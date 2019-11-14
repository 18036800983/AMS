using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Line_Rework_Modle
    {
        private int iD;
        private string sN;
        private string reworkStation;
        private string productionName;
        private string recordTime;

        public int ID { get => iD; set => iD = value; }
        public string SN { get => sN; set => sN = value; }
        public string ReworkStation { get => reworkStation; set => reworkStation = value; }
        public string ProductionName { get => productionName; set => productionName = value; }
        public string RecordTime { get => recordTime; set => recordTime = value; }
    }
}
