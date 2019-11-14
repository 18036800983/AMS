using MySql;
using Server_DAL;
using Server_Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_BLL
{
    public class Line_Station_Bll:DB_Tool
    {
        Line_Station_Dal line_Station_Dal = new Line_Station_Dal();
        /// <summary>
        /// Execute the sql of select all station
        /// </summary>
        /// <returns></returns>
        public DataTable Select_All_Station_Table()
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteDataTable(line_Station_Dal.Select_All_Station_Table());
            }
        }
    }
}
