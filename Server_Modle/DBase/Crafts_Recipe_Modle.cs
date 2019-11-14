using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Crafts_Recipe_Modle
    {
        private int recipeID;
        private string productionName;
        private string station;
        private int step;
        private string operationType;
        private string programNo;
        private string checkRule;
        private string blotNo;
        private string componentName;
        private int blotNumber;
        private int componentNNumber;
        private int barcodeLength;
        private int istrace;
        private string imagePath;
        private int sleeveNo;
        private string stepDesc;

        public int RecipeID { get => recipeID; set => recipeID = value; }
        public string ProductionName { get => productionName; set => productionName = value; }
        public string Station { get => station; set => station = value; }
        public int Step { get => step; set => step = value; }
        public string OperationType { get => operationType; set => operationType = value; }
        public string ProgramNo { get => programNo; set => programNo = value; }
        public string CheckRule { get => checkRule; set => checkRule = value; }
        public string BlotNo { get => blotNo; set => blotNo = value; }
        public string ComponentName { get => componentName; set => componentName = value; }
        public int BlotNumber { get => blotNumber; set => blotNumber = value; }
        public int ComponentNNumber { get => componentNNumber; set => componentNNumber = value; }
        public int BarcodeLength { get => barcodeLength; set => barcodeLength = value; }
        public int Istrace { get => istrace; set => istrace = value; }
        public int IsCheck { get; set; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public int SleeveNo { get => sleeveNo; set => sleeveNo = value; }
        public string StepDesc { get => stepDesc; set => stepDesc = value; }
    }
}
