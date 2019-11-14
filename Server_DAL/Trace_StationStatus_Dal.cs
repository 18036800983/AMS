using Server_Modle.DBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DAL
{
    public class Trace_StationStatus_Dal
    {
        public string Select_State__CurStationInfo_Table(string station, string sn)
        {
            string _select_state_curStationInfo = "select StationStatue from Trace_StationStatus where Station = '"
                    + station + "' and SN = '" + sn + "'";
            return _select_state_curStationInfo;
        }
        public string Select_Count__CurStationInfo_Table(string station, string sn)
        {
            string _select_count_curStationInfo = "select count(*) from Trace_StationStatus where Station = '"
                    + station + "' and SN = '" + sn +  "'";
            return _select_count_curStationInfo;
        }

        public string Delete_Con_CurStationInfo_Table(string station, string sn)
        {
            string _delete_con_curStationInfo = "delete from Trace_StationStatus where Station = '"
                    + station + "' and SN = '" + sn + "'";
            return _delete_con_curStationInfo;
        }

        public string Insert_Condition_CurStationInfo_Table(Trace_StationStatus_Modle trace_StationStatus_Modle, bool histroyFlag)
        {
            if (histroyFlag)
            {
                string _insert_sql = "INSERT INTO [AMS].[dbo].[Trace_StationStatus_transfer] ([SN]"
                                     + ",[Station],[TrayCode],[StationStatue],[RecordTime],[WorkOrder],[StationBeat]) VALUES('"
                                     + trace_StationStatus_Modle.SN + "','" + trace_StationStatus_Modle.Station
                                     + "','" + trace_StationStatus_Modle.TrayCode + "',"
                                     + trace_StationStatus_Modle.StationStatue + ",'" + trace_StationStatus_Modle.RecordTime
                                     + "','" + trace_StationStatus_Modle.WorkOrder + "','" + trace_StationStatus_Modle.StationBeat + "')";
                return _insert_sql;
            }
            else
            {
                string _insert_sql = "INSERT INTO [AMS].[dbo].[Trace_StationStatus] ([SN]"
                                     + ",[Station],[TrayCode],[StationStatue],[RecordTime],[WorkOrder],[StationBeat]) VALUES('"
                                     + trace_StationStatus_Modle.SN + "','" + trace_StationStatus_Modle.Station
                                     + "','" + trace_StationStatus_Modle.TrayCode + "',"
                                     + trace_StationStatus_Modle.StationStatue + ",'" + trace_StationStatus_Modle.RecordTime
                                     + "','" + trace_StationStatus_Modle.WorkOrder + "','" + trace_StationStatus_Modle.StationBeat + "')";
                return _insert_sql;
            }
        }

        public static Dictionary<string,string> TraceData_Transfer(string station,string sn)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            string _bolt_sql = "INSERT INTO [AMS].[dbo].[Trace_Bolt_Transfer] " 
                + "([BoltName],[BoltNo],[ProgramNo],[Torque],[MaxTorque],[MinTorque]" 
                + ",[Angle],[MaxAngle],[MinAngle],[Result],[SN],[Station],[RecordTime])" 
                + "(SELECT [BoltName],[BoltNo],[ProgramNo],[Torque],[MaxTorque]" 
                + ",[MinTorque],[Angle],[MaxAngle],[MinAngle],[Result],[SN]" 
                + ",[Station],[RecordTime] FROM [AMS].[dbo].[Trace_Bolt] " 
                + " where Station = '" + station + "' and SN = '+ sn + ')";
            dic.Add("bolt",_bolt_sql);
            string _keypart_sql = "INSERT INTO [AMS].[dbo].[Trace_Keypart_Transfer] " 
                + "([ComponentName],[ComponentBarcode],[SN],[Station] ,[RecordTime])" 
                + "(SELECT [ComponentName],[ComponentBarcode],[SN],[Station]" 
                + ",[RecordTime] FROM [AMS].[dbo].[Trace_Keypart] where Station = '" 
                + station + "' and SN = '" + sn + "')";
            dic.Add("keypart",_keypart_sql);
            string _measure_sql = "INSERT INTO [AMS].[dbo].[Trace_Measure_Transfer]" 
                + "([SN],[Station],[MeasureName],[MeasureValue1],[MeasureValue2]" 
                + ",[MeasureValue3],[MeasureValue4],[MeasureValue5],[MeasureValue6]" 
                + ",[RecordTime]) (SELECT [SN],[Station],[MeasureName],[MeasureValue1]" 
                + ",[MeasureValue2],[MeasureValue3],[MeasureValue4],[MeasureValue5]" 
                + ",[MeasureValue6],[RecordTime],[MeasureResult] FROM [AMS].[dbo].[Trace_Measure] " 
                + " where Station = '" + station + "' and SN = '" + sn + "')";
            dic.Add("measure",_measure_sql);
            string _stationStatus_sql = "INSERT INTO [AMS].[dbo].[Trace_StationStatus_transfer]" 
                + "([SN],[Station],[TrayCode],[StationStatue],[RecordTime],[WorkOrder],[StationBeat])( SELECT [SN]"
                + ",[Station],[TrayCode],[StationStatue],[RecordTime],[WorkOrder],[StationBeat] FROM [AMS].[dbo].[Trace_StationStatus] "
                + " where SN = '" + sn + "')";
            dic.Add("stationStatus",_stationStatus_sql);
            return dic;
        }
    }
}
