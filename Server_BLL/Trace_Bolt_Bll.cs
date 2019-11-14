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
    public class Trace_Bolt_Bll : DB_Tool
    {
        Trace_Bolt_Dal trace_Bolt_Dal = new Trace_Bolt_Dal();
        public string Select_Count__Bolt_Table(string station, string sn, int boltNo)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteScalar(trace_Bolt_Dal.Select_Count__Bolt_Table(station,sn,boltNo)).ToString();
            }
        }

        public int Delete_Con_Bolt_Table(string station, string sn, int boltNo)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(trace_Bolt_Dal.Delete_Con_Bolt_Table(station,sn,boltNo));
            }
        }

        public int Insert_Condition_Bolt_Table(string tableName, string columnName, string value, string station)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(trace_Bolt_Dal.Insert_Condition_Bolt_Table(tableName, columnName, value, station));
            }
        }

        public DataTable Select_Result_Bolt_Table(string station, string sn)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteDataTable(trace_Bolt_Dal.Select_Result_Bolt_Table(station, sn));
            }
        }
    }
}
