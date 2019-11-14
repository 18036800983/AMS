using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Trace_StationStatus_transfer_Modle
    {
        private int iD;
        private string sN;
        private string station;
        private string trayCode;
        private int stationStatue;
        private string stationBeat;
        private string recordTime;

        public int ID { get => iD; set => iD = value; }
        public string SN { get => sN; set => sN = value; }
        public string Station { get => station; set => station = value; }
        public string TrayCode { get => trayCode; set => trayCode = value; }
        public int StationStatue { get => stationStatue; set => stationStatue = value; }
        public string StationBeat { get => stationBeat; set => stationBeat = value; }
        public string RecordTime { get => recordTime; set => recordTime = value; }
    }
}
