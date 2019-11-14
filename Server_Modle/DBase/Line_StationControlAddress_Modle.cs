using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Line_StationControlAddress_Modle
    {
        private int iD;
        private string station;
        private string operationType;
        private string controlAddress;
        private string backAddress;

        public int ID { get => iD; set => iD = value; }
        public string Station { get => station; set => station = value; }
        public string OperationType { get => operationType; set => operationType = value; }
        public string ControlAddress { get => controlAddress; set => controlAddress = value; }
        public string BackAddress { get => backAddress; set => backAddress = value; }
    }
}
