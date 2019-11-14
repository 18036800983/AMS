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
    public class Trace_StationStatus_Bll : DB_Tool
    {
        Trace_StationStatus_Dal trace_StationStatus_Dal = new Trace_StationStatus_Dal();
        public string Select_State__CurStationInfo_Table(string station, string sn)
        {
            try
            {
                using (var con = GetOpenConnection())
                {
                    return con.ExecuteScalar(trace_StationStatus_Dal.Select_State__CurStationInfo_Table(station, sn)).ToString();
                }
            }
            catch (Exception)
            {
                return "";
            }
        }
        public string Select_Count__CurStationInfo_Table(string station, string sn)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteScalar(trace_StationStatus_Dal.Select_Count__CurStationInfo_Table(station,sn)).ToString();
            }
        }

        public int Delete_Con_CurStationInfo_Table(string station, string sn)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(trace_StationStatus_Dal.Delete_Con_CurStationInfo_Table(station, sn));
            }
        }

        public int Insert_Condition_CurStationInfo_Table(Trace_StationStatus_Modle trace_StationStatus_Modle,bool historyFlag)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(trace_StationStatus_Dal.Insert_Condition_CurStationInfo_Table(trace_StationStatus_Modle, historyFlag));
            }
        }

        public static void TraceData_Transfer(string station, string sn)
        {
            Dictionary<string,string> dic = Trace_StationStatus_Dal.TraceData_Transfer(station,sn);
            using (var con = GetOpenConnection())
            {
                foreach (var dc in dic)
                {
                    if (dc.Key == "bolt")
                    {
                        con.Execute(dc.Value);
                        string sql = "delete from Trace_Bolt where Station = '" + station + "' and SN = '" + sn + "'";
                        con.Execute(sql);
                    }
                    if (dc.Key == "keypart")
                    {
                        con.Execute(dc.Value);
                        string sql = "delete from Trace_Keypart where Station = '" + station + "' and SN = '" + sn + "'";
                        con.Execute(sql);
                    }
                    if (dc.Key == "measure")
                    {
                        con.Execute(dc.Value);
                        string sql = "delete from Trace_Measure where Station = '" + station + "' and SN = '" + sn + "'";
                        con.Execute(sql);
                    }
                    if (dc.Key == "stationStatus")
                    {
                        con.Execute(dc.Value);
                        string sql = "delete from Trace_StationStatus where SN = '" + sn + "'";
                        con.Execute(sql);
                    }
                }
            }
        }
    }
}
