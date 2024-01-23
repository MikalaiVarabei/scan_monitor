using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scm
{
    class ScanResponseMonitor
    {
        private int CheckResponse(byte[] data, int size)
        {
            //check CRC 
            //TODO
            return 0;
        }

        public int DataReseived(byte[] data, int size)
        {
            int err = CheckResponse(data, size);
            if (err != 0) return err;

            if(data[2] == 0x03)         //пришли параметры по маске
            {
                MaskParametersDisplay(data);
            }
            else if(data[2] == 0x42)    //пришел пробег из ипром
            {
                WayDataToDisplay(data);
            }
            else if(data[2] == 0x4B)    //пришли настройки
            {
                SettingsDataToDisplay(data);
            }

            return err;
        }

        private void MaskParametersDisplay(byte[] data)
        {
            int count = 0;
            int size = (int)data[3];
            uint mask = (uint)(data[4] << 8) | data[5];
            count = 6;

            Program.form.allParamTextBox.Clear();
            if ((mask & 0x0001) == 0x0001)
            {
                int locks = data[count];
                count++;
                //замок зажигания
                Program.form.allParamTextBox.AppendText("" + ((locks & 0x01) == 0x01 ? "\r\n Ключ в замке" : "Ключ извлечен"));
                Program.form.allParamTextBox.AppendText("" + ((locks & 0x02) == 0x02 ? "\r\n Зажигаиние вкл." : ""));
                Program.form.allParamTextBox.AppendText("" + ((locks & 0x04) == 0x04 ? "\r\n Аксессуары вкл." : ""));
                Program.form.allParamTextBox.AppendText("" + ((locks & 0x08) == 0x08 ? "\r\n Двигатель запущен" : "Двигатель остановлен"));
                Program.form.allParamTextBox.AppendText("\r\n");
            }
            if ((mask & 0x0002) == 0x0002)
            {
                int light = data[count];
                count++;
                //свет
                Program.form.allParamTextBox.AppendText("Свет:     ");
                if (light == 0) Program.form.allParamTextBox.AppendText("выкл.\r\n");
                else
                {
                    Program.form.allParamTextBox.AppendText("" + ((light & 0x01) == 0x01 ? "\r\n  габариты" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((light & 0x02) == 0x02 ? "\r\n  ближний" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((light & 0x04) == 0x04 ? "\r\n  дальний" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((light & 0x08) == 0x08 ? "\r\n  левый габарит" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((light & 0x10) == 0x10 ? "\r\n  правый габарит" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((light & 0x80) == 0x80 ? "\r\n Нажата педаль тормоза" : ""));
                    Program.form.allParamTextBox.AppendText("\r\n");
                }
            }
            if ((mask & 0x0004) == 0x0004)
            {
                int door = data[count];
                count++;
                //двери
                Program.form.allParamTextBox.AppendText("Двери:    ");
                if (door == 0) Program.form.allParamTextBox.AppendText("закрыто\r\n");
                else
                {
                    Program.form.allParamTextBox.AppendText("" + ((door & 0x01) == 0x01 ? "\r\n  левая-1" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((door & 0x02) == 0x02 ? "\r\n  правая-1" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((door & 0x04) == 0x04 ? "\r\n  левая-2" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((door & 0x08) == 0x08 ? "\r\n  правая-2" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((door & 0x10) == 0x10 ? "\r\n  багажник" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((door & 0x20) == 0x20 ? "\r\n  капот" : ""));
                    Program.form.allParamTextBox.AppendText("\r\n");
                }

            }
            if ((mask & 0x0008) == 0x0008)
            {
                int selector = data[count];
                count++;
                //передачи
                Program.form.allParamTextBox.AppendText("Селектор передач: ");
                if (selector == 0) Program.form.allParamTextBox.AppendText("неопределено\r\n");
                else
                {
                    Program.form.allParamTextBox.AppendText("" + ((selector & 0x01) == 0x01 ? "P" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((selector & 0x02) == 0x02 ? "R" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((selector & 0x04) == 0x04 ? "N" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((selector & 0x08) == 0x08 ? "D" : ""));
                    Program.form.allParamTextBox.AppendText("" + ((selector & 0x10) == 0x10 ? "S" : ""));
                    Program.form.allParamTextBox.AppendText("\r\n");
                    Program.form.allParamTextBox.AppendText("" + ((selector & 0x80) == 0x80 ? "АКПП" : "МКПП"));
                    Program.form.allParamTextBox.AppendText("\r\n");
                }
            }
            if ((mask & 0x0010) == 0x0010)
            {
                int rpm = (data[count++] << 8) | data[count++];
                Program.form.allParamTextBox.AppendText("Обороты:  " + rpm + " об/мин\r\n");
            }
            if ((mask & 0x0020) == 0x0020)
            {
                int tEngine = (sbyte)data[count++];
                //Температура
                Program.form.allParamTextBox.AppendText("Температура двиг:  " + tEngine + " °C\r\n");
            }
            if ((mask & 0x0040) == 0x0040)
            {
                float voltage = (float)(data[count++]) / 10;
                //Напряжениe
                Program.form.allParamTextBox.AppendText("Напряжениe:  " + voltage + " В\r\n");
            }
            if ((mask & 0x0080) == 0x0080)
            {
                int speed = data[count++];
                Program.form.allParamTextBox.AppendText("Скорость: " + speed + " км/ч\r\n");
            }
            if ((mask & 0x0100) == 0x0100)
            {
                int miles = (data[count++] << 16) | (data[count++] << 8) | data[count++];
                Program.form.allParamTextBox.AppendText("Пробег:   " + miles + " км\r\n");
            }
            if ((mask & 0x0200) == 0x0200)
            {
                int fuel = data[count++];
                Program.form.allParamTextBox.AppendText("Топливо:  " + fuel + " л\r\n");
            }
            if ((mask & 0x0400) == 0x0400)
            {
                int warnings = data[count++];
                //warning
                Program.form.allParamTextBox.AppendText("" + ((warnings & 0x01) == 0x01 ? "\r\n Низкий уровень топлива" : ""));
                Program.form.allParamTextBox.AppendText("" + ((warnings & 0x02) == 0x02 ? "\r\n Низкий уровень омывайки" : ""));
                Program.form.allParamTextBox.AppendText("" + ((warnings & 0x04) == 0x04 ? "\r\n Низкий уровень антифриза" : ""));
                Program.form.allParamTextBox.AppendText("" + ((warnings & 0x08) == 0x08 ? "\r\n Ручник затянут" : "\r\n Ручник - не определено"));//на vw polo при выключенном зажигании бит всегда 0
                Program.form.allParamTextBox.AppendText("" + ((warnings & 0x10) == 0x10 ? "\r\n Пристегнут ремень безопасности водителя" : ""));
                Program.form.allParamTextBox.AppendText("\r\n");
            }
            if ((mask & 0x0800) == 0x0800)
            {
                int timeout = (int)data[count++] * 10;
                Program.form.allParamTextBox.AppendText("Осталось:  " + timeout + " сек.\r\n");
            }
            if ((mask & 0x1000) == 0x1000)
            {
                count++;
            }
            if ((mask & 0x2000) == 0x2000)
            {
                count++;
            }
            if ((mask & 0x4000) == 0x4000)
            {
                count++;
            }
            if ((mask & 0x8000) == 0x8000)
            {
                count++;
            }
        }

        /*******************************************************************/
        // вывод настроек 4Bh
        /*******************************************************************/
        private void SettingsDataToDisplay(byte[] data)
        {
            Program.form.numericUpDownByte0.Text = ((Int16)data[4] * 10).ToString();         //время работы двигателя
            Program.form.numericUpDownByte1.Text = ((sbyte)data[5]).ToString();            //температура прогрева двигателя
            Program.form.numericUpDownByte2.Text = data[6].ToString();                     //Световые приборы
            Program.form.numericUpDownByte3.Text = ((double)data[7] / 10).ToString("F1");    //Время прокрутки стартера
            Program.form.numericUpDownByte4.Text = ((Int16)data[8] * 10).ToString();         //Порог оборотов двигателя для отсечки
            Program.form.numericUpDownByte5.Text = (data[9]).ToString();                   //IWD Counter Event
        }
        /*******************************************************************/
        // вывод настроек 42h
        /*******************************************************************/
        private void WayDataToDisplay(byte[] data)
        {
            Program.form.numericUpDownWay.Text = (((Int32)data[4] << 24) | ((Int32)data[5] << 16) | ((Int32)data[6] << 8) | ((Int32)data[7])).ToString();//пробег, км
        }
    }
}
