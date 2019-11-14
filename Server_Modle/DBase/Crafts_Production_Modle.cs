using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Crafts_Production_Modle
    {
        private int productionID;
        private string productionName;
        private string productionNo;
        private string productionDescripe;
        private string productionRule;

        public int ProductionID { get => productionID; set => productionID = value; }
        public string ProductionName { get => productionName; set => productionName = value; }
        public string ProductionNo { get => productionNo; set => productionNo = value; }
        public string ProductionDescripe { get => productionDescripe; set => productionDescripe = value; }
        public string ProductionRule { get => productionRule; set => productionRule = value; }
    }
}
