using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DAL
{
    public class Line_Station_Dal
    {

        /// <summary>
        /// the sql of select all station
        /// </summary>
        /// <returns></returns>
        public string Select_All_Station_Table()
        {
            string _select_all_station = "SELECT [ID],[StationName]" 
                + ",[StationIndex],[StationIsShield],[StationIsOutLine]" 
                + ",[StationIsEnd] FROM [AMS].[dbo].[Line_Station]";
            return _select_all_station;
        }
    }
}
