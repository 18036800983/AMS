using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DAL
{
    public class Trace_Measure_Dal
    {
        public static string Select_Condition_Measure_Table(string condition)
        {
            string _select_sql = "SELECT [ID],[SN],[Station]"
                + ",[MeasureName],[TestTime],[RecordTime],[MeasureResult]"
                + " FROM [dbo].[Trace_Measure] " + condition;
            return _select_sql;
        }

        public static string Insert_Condition_Measure_Table(string tableName, string columnName, string value, string station, string sn, string measureName)
        {
            string _insert_sql = "insert " + tableName + "(" + columnName + "RecordTime,Station,SN,MeasureName"
                                 + ") values('"
                                 + value
                                 + DateTime.Now + "','" + station + "','" + sn + "','" + measureName + "')";
            return _insert_sql;
        }

        public static string Select_Count_Measure_Table(string station, string sn, string measureName)
        {
            string _select_count_measure = "select count(*) from Trace_Measure where Station = '"
                                        + station + "' and SN = '" + sn + "' and MeasureName like '" + measureName + "%'";
            return _select_count_measure;
        }

        public static string Delete_Con_Measure_Table(string station, string sn, string measureName)
        {
            string _delete_con_measure = "delete from Trace_Measure where Station = '"
                                      + station + "' and SN = '" + sn + "' and MeasureName = '" + measureName + "'";
            return _delete_con_measure;
        }
    }
}
