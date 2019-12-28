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
            string _measure_sql = "INSERT INTO [dbo].[Trace_Measure_Transfer]"
                + "([SN],[Station],[MeasureName],[MeasureValue1],[MeasureValue2],[MeasureValue3]"
                + ",[MeasureValue4],[MeasureValue5],[MeasureValue6],[MeasureValue7],[MeasureValue8]"
                + ",[MeasureValue9],[MeasureValue10],[MeasureValue11],[MeasureValue12],[MeasureValue13]"
                + ",[MeasureValue14],[MeasureValue15],[MeasureValue16],[MeasureValue17],[MeasureValue18]"
                + ",[MeasureValue19],[MeasureValue20],[MeasureValue21],[MeasureValue22],[MeasureValue23]"
                + ",[MeasureValue24],[MeasureValue25],[MeasureValue26],[MeasureValue27],[MeasureValue28]"
                + ",[MeasureValue29],[MeasureValue30],[MeasureValue31],[MeasureValue32],[MeasureValue33]"
                + ",[MeasureValue34],[MeasureValue35],[MeasureValue36],[MeasureValue37],[MeasureValue38]"
                + ",[MeasureValue39],[MeasureValue40],[MeasureValue41],[MeasureValue42],[MeasureValue43]"
                + ",[MeasureValue44],[MeasureValue45],[MeasureValue46],[MeasureValue47],[MeasureValue48]"
                + ",[MeasureValue49],[MeasureValue50],[MeasureValue51],[MeasureValue52],[MeasureValue53]"
                + ",[MeasureValue54],[MeasureValue55],[MeasureValue56],[MeasureValue57],[MeasureValue58]"
                + ",[MeasureValue59],[MeasureValue60],[TestTime],[RecordTime],[MeasureResult])"
                + "(SELECT [Trace_Measure].[SN],[Trace_Measure].[Station],[Trace_Measure].[MeasureName]"
                + ",[Trace_Measure].[MeasureValue1],[Trace_Measure].[MeasureValue2],[Trace_Measure].[MeasureValue3]"
                + ",[Trace_Measure].[MeasureValue4],[Trace_Measure].[MeasureValue5],[Trace_Measure].[MeasureValue6]"
                + ",[Trace_Measure].[MeasureValue7],[Trace_Measure].[MeasureValue8]"
                + ",[Trace_Measure].[MeasureValue9],[Trace_Measure].[MeasureValue10],[Trace_Measure].[MeasureValue11]"
                + ",[Trace_Measure].[MeasureValue12],[MeasureValue13]"
                + ",[Trace_Measure].[MeasureValue14],[Trace_Measure].[MeasureValue15],[Trace_Measure].[MeasureValue16]"
                + ",[Trace_Measure].[MeasureValue17],[Trace_Measure].[MeasureValue18]"
                + ",[Trace_Measure].[MeasureValue19],[Trace_Measure].[MeasureValue20],[Trace_Measure].[MeasureValue21]"
                + ",[Trace_Measure].[MeasureValue22],[Trace_Measure].[MeasureValue23]"
                + ",[Trace_Measure].[MeasureValue24],[Trace_Measure].[MeasureValue25],[Trace_Measure].[MeasureValue26]"
                + ",[Trace_Measure].[MeasureValue27],[Trace_Measure].[MeasureValue28]"
                + ",[Trace_Measure].[MeasureValue29],[Trace_Measure].[MeasureValue30],[Trace_Measure].[MeasureValue31]"
                + ",[Trace_Measure].[MeasureValue32],[Trace_Measure].[MeasureValue33]"
                + ",[Trace_Measure].[MeasureValue34],[Trace_Measure].[MeasureValue35],[Trace_Measure].[MeasureValue36]"
                + ",[Trace_Measure].[MeasureValue37],[Trace_Measure].[MeasureValue38]"
                + ",[Trace_Measure].[MeasureValue39],[Trace_Measure].[MeasureValue40],[Trace_Measure].[MeasureValue41]"
                + ",[Trace_Measure].[MeasureValue42],[Trace_Measure].[MeasureValue43]"
                + ",[Trace_Measure].[MeasureValue44],[Trace_Measure].[MeasureValue45],[Trace_Measure].[MeasureValue46]"
                + ",[Trace_Measure].[MeasureValue47],[Trace_Measure].[MeasureValue48]"
                + ",[Trace_Measure].[MeasureValue49],[Trace_Measure].[MeasureValue50],[Trace_Measure].[MeasureValue51]"
                + ",[Trace_Measure].[MeasureValue52],[Trace_Measure].[MeasureValue53]"
                + ",[Trace_Measure].[MeasureValue54],[Trace_Measure].[MeasureValue55],[Trace_Measure].[MeasureValue56]"
                + ",[Trace_Measure].[MeasureValue57],[Trace_Measure].[MeasureValue58]"
                + ",[Trace_Measure].[MeasureValue59],[Trace_Measure].[MeasureValue60],[Trace_Measure].[TestTime]"
                + ",[Trace_Measure].[RecordTime],[Trace_Measure].[MeasureResult]"
                + "FROM [dbo].[Trace_Measure],[dbo].[Trace_Keypart_Transfer]"
                + " WHERE Trace_Measure.SN = Trace_Keypart_Transfer.ComponentBarcode"
                + " and Trace_Keypart_Transfer.SN = '" + sn + "' and Trace_Measure.Station like '%" + station + "')";
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
