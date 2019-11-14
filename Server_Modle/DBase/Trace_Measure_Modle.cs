using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Trace_Measure_Modle
    {
        private int iD;
        private string sN;
        private string station;
        private string measureName;
        private string measureValue1;
        private string measureValue2;
        private string measureValue3;
        private string measureValue4;
        private string measureValue5;
        private string measureValue6;
        private string recordTime;
        private string measureResult;

        public int ID { get => iD; set => iD = value; }
        public string SN { get => sN; set => sN = value; }
        public string Station { get => station; set => station = value; }
        public string MeasureName { get => measureName; set => measureName = value; }
        public string MeasureValue1 { get => measureValue1; set => measureValue1 = value; }
        public string MeasureValue2 { get => measureValue2; set => measureValue2 = value; }
        public string MeasureValue3 { get => measureValue3; set => measureValue3 = value; }
        public string MeasureValue4 { get => measureValue4; set => measureValue4 = value; }
        public string MeasureValue5 { get => measureValue5; set => measureValue5 = value; }
        public string MeasureValue6 { get => measureValue6; set => measureValue6 = value; }
        public string RecordTime { get => recordTime; set => recordTime = value; }
        public string MeasureResult { get => measureResult; set => measureResult = value; }
    }
}
