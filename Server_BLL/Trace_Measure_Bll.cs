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
    public class Trace_Measure_Bll : DB_Tool
    {
        public static DataTable Select_Condition_Measure_Table(string condition)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteDataTable(Trace_Measure_Dal.Select_Condition_Measure_Table(condition));
            }
        }

        public static int Insert_Condition_Measure_Table(string tableName, string columnName, string value, string station, string sn, string measureName)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(Trace_Measure_Dal.Insert_Condition_Measure_Table(tableName, columnName, value, station, sn, measureName));
            }
        }

        public static string Select_Count_Measure_Table(string station, string sn, string measureName)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteScalar(Trace_Measure_Dal.Select_Count_Measure_Table(station, sn, measureName)).ToString();
            }
        }

        public static int Delete_Con_Measure_Table(string station, string sn, string measureName)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(Trace_Measure_Dal.Delete_Con_Measure_Table(station, sn, measureName));
            }
        }
    }
}
