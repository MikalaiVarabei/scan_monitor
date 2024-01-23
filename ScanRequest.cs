using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scm
{
    class ScanRequest
    {
        readonly public byte RX_PREFIX = 0xAD;
        readonly public byte TX_PREFIX = 0xAC;
        readonly public byte DEV_ADDRESS = 0x56;

        readonly public int PREFIX_INDEX = 0;
        readonly public int ADDRESS_INDEX = 1;
        readonly public int CMD_INDEX = 2;
        readonly public int NUMBER_INDEX = 3;
        readonly public int MASKH_INDEX = 4;
        readonly public int MASKL_INDEX = 5;

        readonly public byte GET_SYSTEM_INFO = 0x01;
        readonly public byte GET_MASK_PARAMS = 0x03;
        readonly public byte SET_PERIODIC_DATA_SEND = 0x04;
        readonly public byte GET_PERIODIC_DATA_SEND = 0x05;
        readonly public byte GET_AUTOSTART_INFO = 0x06;
        readonly public byte SET_LOCK_PARAMS = 0x11;
        readonly public byte SET_BLOCK_ENGINE = 0x12;
        readonly public byte START_ENGINE_WARM_UP = 0x15;
        readonly public byte START_ENGINE_TIMEOUT = 0x16;
        readonly public byte ON_IGNITION_TIMEOUT = 0x17;
        readonly public byte OFF_IGNITION = 0x18;
        readonly public byte SET_AUTOSTART_PARAMS = 0x4A;
        readonly public byte GET_AUTOSTART_PARAMS = 0x4B;
        readonly public byte ERROR_PARAMS = 0xFE;

        //Запрос информации о системе (команда 01h)
        public int GetDeviceInfo(byte[] buf)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = GET_SYSTEM_INFO; //0x01
            buf[3] = 1;
            buf[4] = 0x0;

            for (int i = 0; i < 4; i++)
            {
                buf[4] = CrcCalc(buf[4], buf[i]);
            }

            return 5;
        }

        //команда на чтение всех параметров 03h
        public int GetAllParameters(byte[] buf)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = GET_MASK_PARAMS;   //0x03
            buf[3] = 3;
            buf[4] = 0xFF; //MASKH
            buf[5] = 0xFF; //MASKL
            buf[6] = 0x0;

            for (int i = 0; i < 6; i++)
            {
                buf[6] = CrcCalc(buf[6], buf[i]);
            }

            return 7;
        }

        //Считывание параметров по биовой маске (команда 0x03)
        public int GetMaskParameters(byte[] buf, uint mask)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = GET_MASK_PARAMS;   //0x03
            buf[3] = 3;
            buf[4] = (byte)(mask >> 8); //MASKH
            buf[5] = (byte)(mask & 0x00FF); //MASKL
            buf[6] = 0x0;

            for (int i = 0; i < 6; i++)
            {
                buf[6] = CrcCalc(buf[6], buf[i]);
            }

            return 7;
        }

        //Включение периодической выдачи текущих данных (команда 04h)
        public int SetPeriodicMaskParameters(byte[] buf, uint mask, uint time)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = SET_PERIODIC_DATA_SEND;   //0x04
            buf[3] = 5;
            buf[4] = (byte)(mask >> 8); //MASKH
            buf[5] = (byte)(mask & 0x00FF); //MASKL
            buf[6] = (byte)(time >> 8); //TIMEH
            buf[7] = (byte)(time & 0x00FF); //TIMEL
            buf[8] = 0x0;

            for (int i = 0; i < 8; i++)
            {
                buf[8] = CrcCalc(buf[8], buf[i]);
            }

            return 9;
        }

        //Запрос состояния периодической выдачи текущих данных (команда 05h)
        public int GetPeriodicMaskParameters(byte[] buf)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = GET_PERIODIC_DATA_SEND;   //0x05
            buf[3] = 1;
            buf[4] = 0x0;

            for (int i = 0; i < 4; i++)
            {
                buf[4] = CrcCalc(buf[4], buf[i]);
            }

            return 5;
        }

        //Запрос состояния периодической выдачи текущих данных (команда 06h)
        public int GetAutostartInfo(byte[] buf)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = GET_AUTOSTART_INFO;   //0x06
            buf[3] = 1;
            buf[4] = 0x0;

            for (int i = 0; i < 4; i++)
            {
                buf[4] = CrcCalc(buf[4], buf[i]);
            }

            return 5;
        }

        //Открытие/Закрытие (команда 11h)
        public int SetDoorLock(byte[] buf, byte cmd)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = SET_LOCK_PARAMS;   //0x11
            buf[3] = 2;
            buf[4] = cmd;
            buf[5] = 0x0;

            for (int i = 0; i < 5; i++)
            {
                buf[5] = CrcCalc(buf[5], buf[i]);
            }

            return 6;
        }

        //Принудительная блокировка двигателя (команда 12h)
        public int SetBlockingEngine(byte[] buf, byte cmd)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = SET_BLOCK_ENGINE;   //0x12
            buf[3] = 2;
            buf[4] = cmd;
            buf[5] = 0x0;

            for (int i = 0; i < 5; i++)
            {
                buf[5] = CrcCalc(buf[5], buf[i]);
            }

            return 6;
        }

        //Запустить двигатель для прогрева (команда 15h)
        public int StartEngineWarmUp(byte[] buf)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = START_ENGINE_WARM_UP;   //0x15
            buf[3] = 1;
            buf[4] = 0x0;

            for (int i = 0; i < 4; i++)
            {
                buf[4] = CrcCalc(buf[4], buf[i]);
            }

            return 5;
        }

        //Запустить двигатель на заданный интервал времени (команда 16h)
        public int StartEngineTimeout(byte[] buf, uint time)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = START_ENGINE_TIMEOUT;   //0x16
            buf[3] = 2;
            buf[4] = (byte)time;
            buf[5] = 0x0;

            for (int i = 0; i < 5; i++)
            {
                buf[5] = CrcCalc(buf[5], buf[i]);
            }

            return 6;
        }

        //Включить зажигание на заданное время (команда 17h)
        public int OnIgnitionTimeout(byte[] buf, uint time)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = ON_IGNITION_TIMEOUT;   //0x17
            buf[3] = 2;
            buf[4] = (byte)time;
            buf[5] = 0x0;

            for (int i = 0; i < 5; i++)
            {
                buf[5] = CrcCalc(buf[5], buf[i]);
            }

            return 6;
        }

        //Остановить двигатель (команда 18h)
        public int OffIgnition(byte[] buf)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = OFF_IGNITION;   //0x18
            buf[3] = 1;
            buf[4] = 0x0;

            for (int i = 0; i < 4; i++)
            {
                buf[4] = CrcCalc(buf[4], buf[i]);
            }

            return 5;
        }

        //Запись пробега, км (команда 41h)
        public int SetMiles(byte[] buf, UInt32 mile)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = 0x41;
            buf[3] = 5;
            buf[4] = (byte)(mile >> 24);
            buf[5] = (byte)(mile >> 16);
            buf[6] = (byte)(mile >> 8);
            buf[7] = (byte)(mile);
            buf[8] = 0x0;

            for (int i = 0; i < 8; i++)
            {
                buf[8] = CrcCalc(buf[8], buf[i]);
            }

            return 9;
        }

        //Чтение пробега (команда 42h)
        public int GetMiles(byte[] buf)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = 0x42;
            buf[3] = 1;
            buf[4] = 0x0;

            for (int i = 0; i < 4; i++)
            {
                buf[4] = CrcCalc(buf[4], buf[i]);
            }

            return 5;
        }

        //Запись параметров запуска двигателя (команда 4Ah)
        public int SetAutostarParameters(byte[] buf, uint time, uint temp, uint ligth, uint starter, uint rpm)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = SET_AUTOSTART_PARAMS;
            buf[3] = 6;
            buf[4] = (byte)time;
            buf[5] = (byte)temp;
            buf[6] = (byte)ligth;
            buf[7] = (byte)starter;
            buf[8] = (byte)rpm;
            buf[9] = 0x0;

            for (int i = 0; i < 9; i++)
            {
                buf[9] = CrcCalc(buf[9], buf[i]);
            }

            return 10;
        }

        //Чтение параметров настроек (команда 4Bh)
        public int GetAutostarParameters(byte[] buf)
        {
            buf[0] = TX_PREFIX;
            buf[1] = DEV_ADDRESS;
            buf[2] = GET_AUTOSTART_PARAMS;
            buf[3] = 1;
            buf[4] = 0x0;

            for (int i = 0; i < 4; i++)
            {
                buf[4] = CrcCalc(buf[4], buf[i]);
            }

            return 5;
        }


        //***************************************************************************
        // CRC lookup function
        //***************************************************************************
        public byte CrcCalc(byte crc, byte b)
        {
            //******************** Полином расчета CRC. табличная реализация ********
            byte[] hash_table = new byte[256]
              {0, 94, 188, 226, 97, 63, 221, 131, 194, 156, 126, 32, 163, 253, 31, 65,
              157, 195, 33, 127, 252, 162, 64, 30, 95, 1, 227, 189, 62, 96, 130, 220,
              35, 125, 159, 193, 66, 28, 254, 160, 225, 191, 93, 3, 128, 222, 60, 98,
              190, 224, 2, 92, 223, 129, 99, 61, 124, 34, 192, 158, 29, 67, 161, 255,
              70, 24, 250, 164, 39, 121, 155, 197, 132, 218, 56, 102, 229, 187, 89, 7,
              219, 133, 103, 57, 186, 228, 6, 88, 25, 71, 165, 251, 120, 38, 196, 154,
              101, 59, 217, 135, 4, 90, 184, 230, 167, 249, 27, 69, 198, 152, 122, 36,
              248, 166, 68, 26, 153, 199, 37, 123, 58, 100, 134, 216, 91, 5, 231, 185,
              140, 210, 48, 110, 237, 179, 81, 15, 78, 16, 242, 172, 47, 113, 147, 205,
              17, 79, 173, 243, 112, 46, 204, 146, 211, 141, 111, 49, 178, 236, 14, 80,
              175, 241, 19, 77, 206, 144, 114, 44, 109, 51, 209, 143, 12, 82, 176, 238,
              50, 108, 142, 208, 83, 13, 239, 177, 240, 174, 76, 18, 145, 207, 45, 115,
              202, 148, 118, 40, 171, 245, 23, 73, 8, 86, 180, 234, 105, 55, 213, 139,
              87, 9, 235, 181, 54, 104, 138, 212, 149, 203, 41, 119, 244, 170, 72, 22,
              233, 183, 85, 11, 136, 214, 52, 106, 43, 117, 151, 201, 74, 20, 246, 168,
              116, 42, 200, 150, 21, 75, 169, 247, 182, 232, 10, 84, 215, 137, 107, 53};

            return hash_table[crc ^ b];
        }
    }
}
