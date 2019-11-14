using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Line_StationOPDetail_Modle
    {
        private int iD;
        private string station;
        private string operationType;
        private string operationName;
        private string address;

        public int ID { get => iD; set => iD = value; }
        public string Station { get => station; set => station = value; }
        public string OperationType { get => operationType; set => operationType = value; }
        public string OperationName { get => operationName; set => operationName = value; }
        public string Address { get => address; set => address = value; }
    }
}
