using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace scm
{
    public partial class Form1 : Form
    {
        private string portName = "";
        static _serialPort comport = new _serialPort();
        static ScanRequest rq = new ScanRequest();
        static ScanResponseMonitor rm = new ScanResponseMonitor();
        public uint mask = 0xFFFF;

        public Form1()
        {
            InitializeComponent();
            //CallBack.callbackEventHandler = new CallBack.callbackEvent(this.dataToTable);
            //CallBack.callbackEventHandler = new CallBack.callbackEvent(this.getData);
            comport.DataReceived += SerialPort_DataReceived;
            comPortList.Text = Properties.Settings.Default.comPort;
            numericUpDownMask.Value = Properties.Settings.Default.mask;
            numericUpDownMaskWrite.Value = Properties.Settings.Default.maskPeriodic;
            //
        }

        //**********************************************************************
        //кнопка подключения-отключения к COMPORT
        //**********************************************************************
        private bool openClkFlg = false;
        //открываем COM порт
        private void open_Click(object sender, EventArgs e)
        {
            openCloseComPort();
        }
        private void openCloseComPort()
        {
            if (openClkFlg == false)
            {
                portName = comPortList.Text;
                // comport.NamePort(portName);
                if (comport.NamePort(portName) == true)//если имя порта сущесвует
                {
                    openClkFlg = comport.OpenPort();//если порт открыли
                    if (openClkFlg)
                    {                        
                        comPortList.Enabled = false;//деактивируем выподающее меню
                        openBtt.Image = Properties.Resources.cBtt;//меняем картинку на кнопке
                        label1.Text = "Порт открыт";
                        Properties.Settings.Default.comPort = comPortList.Text;
                    }
                }
            }
            else
            {
                closeComPort();
            }
        }

        private void closeComPort()
        {
                comport.Clos();
                comPortList.Enabled = true;//активируем выподающее меню
                openBtt.Image = Properties.Resources.oBtt;//меняем картинку на кнопке
                label1.Text = "Нет соединения";
                openClkFlg = false;
        }
        
        //**********************************************************************
        //кнопка отключения от COMPORT (скрыта)
        //**********************************************************************
        private void close_Click(object sender, EventArgs e)
        {
            comport.Clos();
            comPortList.Enabled = true;
            openClkFlg = false;
        }
        //**********************************************************************
        //выбор COM PORT
        //**********************************************************************
        private void comPortList_DropDown(object sender, EventArgs e)
        {
            //составляем список доступных портов
            string[] ports = SerialPort.GetPortNames();
            comPortList.Items.Clear();
            //заполняем список доступных портов
            foreach (string port in ports)
            {
                comPortList.Items.Add(port);
            }
        }

        //*********************************************************************
        //прием данных comport
        //*********************************************************************
        private const int DataSize = 64;
        volatile private byte[] rxBuffer = new byte[DataSize];
        private int index;
        private int prefixRead;
        private bool dataReadFlg;
        private int rxBufferSize;
        private bool rxDataNotEmpty;
        //  
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            var port = (SerialPort)sender;
            try
            {
                // узнаем сколько байт пришло
                int buferSize = port.BytesToRead;
                for (int i = 0; i < buferSize; ++i)
                {
                    if (countRxTime != 10)  //если буфер не в обработке
                    {
                        rxBuffer[index] = (byte)port.ReadByte(); //  читаем по одному байту
                        index++;
                    }
                }
                countRxTime = 0;//timeout init
            }
            catch{
                Console.Out.Write("DataReceived exp\r\n");
            }
        }

        private byte[] rxData = new byte[64];
        private int indexOffset;
        private int rxDataSize;
        private int countRxTime;
        //***************************************************************************
        // таймер 1ms
        //***************************************************************************
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(countRxTime == 10)//обработка буфера по таймауту
            {
                int i = 0;
                indexOffset = 0;
                prefixRead = 0;
                dataReadFlg = false;
                rxDataNotEmpty = false;

                for (i = 0; i < (index+1); i++)
                {
                    if (dataReadFlg == true)  //дописываем в буфер все остальное
                    {
                        indexOffset++;
                        rxData[indexOffset] = rxBuffer[i];
                        if(rxData[3] == (indexOffset-3))
                        {
                            Console.Out.Write("SIZE OK\r\n");
                            byte crc = 0;
                            //проверяем crc
                            for (int j = 0; j < indexOffset; j++)
                            {
                                crc = rq.CrcCalc(crc, rxData[j]);
                            }
                            if (crc == rxData[indexOffset])
                            {
                                rxBufferSize = indexOffset+1;
                                rxDataNotEmpty = true;
                                i = index;
                                Console.Out.Write("CRC OK\r\n");
                            }
                            else
                            {
                                Console.Out.Write("ERR CRC \r\n");
                            }
                        }
                    }

                    if (prefixRead == 1)
                    {
                        if (rxBuffer[i] == rq.DEV_ADDRESS) // если встретили адрес устройсва
                        {
                            Console.Out.Write("DEV_ADDRESS OK\r\n");
                            indexOffset = 1;
                            rxData[indexOffset] = rxBuffer[i];
                            dataReadFlg = true;
                        }
                        prefixRead = 2;
                    }

                    if ((prefixRead == 2) && (dataReadFlg == false))
                    {
                        prefixRead = 0;
                    }

                    //  если встретили начало кадра
                    if ((prefixRead == 0) && (rxBuffer[i] == rq.RX_PREFIX))
                    {
                        Console.Out.Write("RX_PREFIX OK\r\n");
                        indexOffset = 0;
                        rxData[indexOffset] = rxBuffer[i];
                        prefixRead = 1;
                    }
                }
                index = 0;
            }
            //
            if(countRxTime<11)countRxTime++;
            //
            if (rxDataNotEmpty == true)
            {
                rxDataSize = rxBufferSize;

                int err = rm.DataReseived(rxData, rxDataSize);

                logInfo(rxData, rxDataSize);
                serialText("error: " + err + "\r\n");
                rxDataNotEmpty = false;
            }
            //
        }//timer


        //*********** Вывод данных **************************************
        public void serialText(string txt)//all text
        {
            if (txt == "Scroll") outTextBox.ScrollToCaret();
            else outTextBox.AppendText(txt);
        }

        public void logInfo(byte[] buf, int size)
        {
            for (int i = 0; i < size; i++)
            {
                serialText(buf[i].ToString("X2"));
                serialText(" ");
            }
            serialText("\r\n");
            serialText("Scroll");
        }



        /*******************************************************************/
        //отправка преамбулы
        /*******************************************************************/
        private void preambleSend()
        {
            byte[] preamble = new byte[6];
            preamble[0] = 0xF0;
            preamble[1] = 0xF0;
            preamble[2] = 0xF0;
            preamble[3] = 0xF0;
            preamble[4] = 0xF0;
            preamble[5] = 0xF0;
            comport.Send(preamble, 6);
        }
        //
        private bool paramReadСheckBoxFlg = false;
        /*******************************************************************/
        //таймер 1с
        /*******************************************************************/
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(paramReadСheckBoxFlg) AllParametersRead();  //периодический запрос параметров
        }
        private void paramReadСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            paramReadСheckBoxFlg = paramReadСheckBox.Checked;
        }


        private void ParamReadButton_Click(object sender, EventArgs e)
        {
            AllParametersRead();
        }

        byte[] buf = new byte[32];

        /*******************************************************************/
        //команда на чтение всех параметров
        /*******************************************************************/
        private void AllParametersRead()
        {
            int size = rq.GetAllParameters(buf);
            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void GetSystemInfoButton_Click(object sender, EventArgs e)
        {
            int size = rq.GetDeviceInfo(buf);

            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void MaskParametersReadButton_Click(object sender, EventArgs e)
        {
            mask = System.Convert.ToUInt16(numericUpDownMask.Value);

            int size = rq.GetMaskParameters(buf, mask);

            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void SaveTimeButton_Click(object sender, EventArgs e)
        {
            uint time = System.Convert.ToUInt16(numericUpDownTime.Value);
            uint mask = System.Convert.ToUInt16(numericUpDownMaskWrite.Value);

            int size = rq.SetPeriodicMaskParameters(buf, mask, time);

            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void ReadTimeButton_Click(object sender, EventArgs e)
        {
            int size = rq.GetPeriodicMaskParameters(buf);

            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void GetAutostartInfoButton_Click(object sender, EventArgs e)
        {
            int size = rq.GetAutostartInfo(buf);

            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void OpenDoorButton_Click(object sender, EventArgs e)
        {
            int size = rq.SetDoorLock(buf, 0x01);

            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void CloseDoorButton_Click(object sender, EventArgs e)
        {
            int size = rq.SetDoorLock(buf, 0x04);

            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void OpenTrunkButton_Click(object sender, EventArgs e)
        {
            int size = rq.SetDoorLock(buf, 0x08);

            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void BlockEngineButton_Click(object sender, EventArgs e)
        {
            int size = rq.SetBlockingEngine(buf, 0x02);

            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void UnblockingEngineButton_Click(object sender, EventArgs e)
        {
            int size = rq.SetBlockingEngine(buf, 0x01);

            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void StartEngineButtonButton_Click(object sender, EventArgs e)
        {
            int size = rq.StartEngineWarmUp(buf);
            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void StartEngineTimeButton_Click(object sender, EventArgs e)
        {
            uint time = Convert.ToUInt16(numericUpDownRanTime.Value);
            int size = rq.StartEngineTimeout(buf, time);
            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void OnIgnitionButton_Click(object sender, EventArgs e)
        {
            uint time = Convert.ToUInt16(numericUpDownRanTime.Value);
            int size = rq.OnIgnitionTimeout(buf, time);
            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void OffIgnitionButton_Click(object sender, EventArgs e)
        {
            int size = rq.OffIgnition(buf);
            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void SaveWayButton_Click(object sender, EventArgs e)
        {
            byte[] buf = new byte[9];
            UInt32 way = System.Convert.ToUInt32(numericUpDownWay.Value);
            //way = 4294967295;

            int size = rq.SetMiles(buf, way);
            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void ReadWayButton_Click(object sender, EventArgs e)
        {
            int size = rq.GetMiles(buf);
            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);

            numericUpDownWay.Text = "0";
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            uint time = (uint)(System.Convert.ToInt16(numericUpDownByte0.Text) / 10);     //время работы двигателя
            uint temp = (uint)(System.Convert.ToSByte(numericUpDownByte1.Text));       //температура прогрева двигателя
            uint ligth = (uint)(System.Convert.ToByte(numericUpDownByte2.Text));        //Световые приборы
            uint starterTime = (uint)(System.Convert.ToDouble(numericUpDownByte3.Text) * 10);   //Время прокрутки стартера
            uint rpm = (byte)(System.Convert.ToInt16(numericUpDownByte4.Text) / 10);    //Порог оборотов двигателя для отсечки

            int size = rq.SetAutostarParameters(buf, time, temp, ligth, starterTime, rpm);
            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);
        }

        private void ReadSettingsButton_Click(object sender, EventArgs e)
        {
            int size = rq.GetAutostarParameters(buf);
            preambleSend();
            comport.Send(buf, size);

            logInfo(buf, size);

            numericUpDownByte0.Text = "0";
            numericUpDownByte1.Text = "0";
            numericUpDownByte2.Text = "0";
            numericUpDownByte3.Text = "0";
            numericUpDownByte4.Text = "0";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.mask = Convert.ToUInt16(numericUpDownMask.Value);
            Properties.Settings.Default.maskPeriodic = Convert.ToUInt16(numericUpDownMaskWrite.Value);
            Properties.Settings.Default.Save();
        }
    }
}
