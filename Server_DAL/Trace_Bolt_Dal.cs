using Server_Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DAL
{
    public class Trace_Bolt_Dal 
    {
        public string Select_Count__Bolt_Table(string station,string sn,int boltNo)
        {
            string _select_count_bolt = "select count(*) from Trace_Bolt where Station = '"
                    + station + "' and SN = '" + sn + "' and BoltNo = '" + boltNo + "'";
            return _select_count_bolt;
        }

        public string Delete_Con_Bolt_Table(string station, string sn, int boltNo)
        {
            string _delete_con_bolt = "delete from Trace_Bolt where Station = '"
                    + station + "' and SN = '" + sn + "' and BoltNo = '" + boltNo + "'";
            return _delete_con_bolt;
        }

        public string Insert_Condition_Bolt_Table(string tableName,string columnName,string value,string station)
        {
            string _insert_sql = "insert " + tableName + "(" + columnName + "RecordTime,Station"
                   + ") values('"
                   + value
                   + DateTime.Now + "','" + station + "')";
            return _insert_sql;
        }

        public string Select_Result_Bolt_Table(string station, string sn)
        {
            string _select_result_bolt = "select Result from Trace_Bolt where Station = '"
                                         + station + "' and SN = '" + sn + "'";
            return _select_result_bolt;
        }
    }
}
