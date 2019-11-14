using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Line_StationStatus_Modle
    {
        private int iD;
        private string productionName;
        private string station;
        private int step;
        private string operationType;
        private string programNo;
        private string checkRule;
        private string blotNo;
        private string componentNName;
        private int blotNumber;
        private int componentNNumber;
        private int barcodeLength;
        private int istrace;
        private int isCheck;
        private string sN;
        private string recordTime;

        public int ID { get => iD; set => iD = value; }
        public string ProductionName { get => productionName; set => productionName = value; }
        public string Station { get => station; set => station = value; }
        public int Step { get => step; set => step = value; }
        public string OperationType { get => operationType; set => operationType = value; }
        public string ProgramNo { get => programNo; set => programNo = value; }
        public string CheckRule { get => checkRule; set => checkRule = value; }
        public string BlotNo { get => blotNo; set => blotNo = value; }
        public string ComponentNName { get => componentNName; set => componentNName = value; }
        public int BlotNumber { get => blotNumber; set => blotNumber = value; }
        public int ComponentNNumber { get => componentNNumber; set => componentNNumber = value; }
        public int BarcodeLength { get => barcodeLength; set => barcodeLength = value; }
        public int Istrace { get => istrace; set => istrace = value; }
        public int IsCheck { get => isCheck; set => isCheck = value; }
        public string SN { get => sN; set => sN = value; }
        public string RecordTime { get => recordTime; set => recordTime = value; }
    }
}
