using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Line_PLCSetting_Modle
    {
        private int iD;
        private string station;
        private string plcIP;
        private int plcThreaCount;
        private int plcUpdateRate;
        private string plcHeartBeatAddr;
        private int plcCpuSlot;

        public int ID { get => iD; set => iD = value; }
        public string Station { get => station; set => station = value; }
        public string PlcIP { get => plcIP; set => plcIP = value; }
        public int PlcThreaCount { get => plcThreaCount; set => plcThreaCount = value; }
        public int PlcUpdateRate { get => plcUpdateRate; set => plcUpdateRate = value; }
        public string PlcHeartBeatAddr { get => plcHeartBeatAddr; set => plcHeartBeatAddr = value; }
        public int PlcCpuSlot { get => plcCpuSlot; set => plcCpuSlot = value; }
    }
}
