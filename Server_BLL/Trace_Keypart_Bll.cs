using MySql;
using Server_DAL;
using Server_Modle.DBase;
using Server_Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_BLL
{
    public class Trace_Keypart_Bll : DB_Tool
    {
        Trace_Keypart_Dal trace_Keypart_Dal = new Trace_Keypart_Dal();
        public string Select_Count__Material_Table(string station, string sn, string barcode)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteScalar(trace_Keypart_Dal.Select_Count__Material_Table(station, sn,barcode)).ToString();
            }
        }

        public int Delete_Con_Material_Table(string station, string sn, string barcode)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(trace_Keypart_Dal.Delete_Con_Material_Table(station, sn, barcode));
            }
        }

        public int Insert_Condition_Material_Table(Trace_Keypart_Modle trace_Keypart_Modle)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(trace_Keypart_Dal.Insert_Condition_Material_Table(trace_Keypart_Modle));
            }
        }
    }
}
