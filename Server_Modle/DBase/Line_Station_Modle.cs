using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.DBase
{
    public class Line_Station_Modle
    {
        private int stationID;
        private string stationName;
        private int stationIndex;
        private int stationIsShield;
        private int stationIsOutLine;
        private int stationIsEnd;

        public int StationID { get => stationID; set => stationID = value; }
        public string StationName { get => stationName; set => stationName = value; }
        public int StationIndex { get => stationIndex; set => stationIndex = value; }
        public int StationIsShield { get => stationIsShield; set => stationIsShield = value; }
        public int StationIsOutLine { get => stationIsOutLine; set => stationIsOutLine = value; }
        public int StationIsEnd { get => stationIsEnd; set => stationIsEnd = value; }
    }
}
