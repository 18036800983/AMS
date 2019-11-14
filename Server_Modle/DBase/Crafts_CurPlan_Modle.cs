using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Crafts_CurPlan_Modle
    {
        private int iD;
        private string workOrderNo;
        private string workOrderName;
        private string workOrderDescripe;
        private int planNumber;
        private int doneNumber;
        private string passRate;

        public int ID { get => iD; set => iD = value; }
        public string WorkOrderNo { get => workOrderNo; set => workOrderNo = value; }
        public string WorkOrderName { get => workOrderName; set => workOrderName = value; }
        public string WorkOrderDescripe { get => workOrderDescripe; set => workOrderDescripe = value; }
        public int PlanNumber { get => planNumber; set => planNumber = value; }
        public int DoneNumber { get => doneNumber; set => doneNumber = value; }
        public string PassRate { get => passRate; set => passRate = value; }
    }
}
