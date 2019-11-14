using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Trace_Keypart_Modle
    {
        private int iD;
        private string componentName;
        private string componentBarcode;
        private string sN;
        private string station;
        private string recordTime;

        public int ID { get => iD; set => iD = value; }
        public string ComponentName { get => componentName; set => componentName = value; }
        public string ComponentBarcode { get => componentBarcode; set => componentBarcode = value; }
        public string SN { get => sN; set => sN = value; }
        public string Station { get => station; set => station = value; }
        public string RecordTime { get => recordTime; set => recordTime = value; }
    }
}
