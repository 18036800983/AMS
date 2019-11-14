using Server_Modle.DBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DAL
{
    public class Trace_Keypart_Dal
    {
        public string Select_Count__Material_Table(string station, string sn,string barcode)
        {
            string _select_count_material = "select count(*) from Trace_Keypart where Station = '"
                    + station + "' and SN = '" + sn + "' and ComponentBarcode = '" + barcode + "'";
            return _select_count_material;
        }

        public string Delete_Con_Material_Table(string station, string sn,string barcode)
        {
            string _delete_con_material = "delete from Trace_StationStatus where Station = '"
                    + station + "' and SN = '" + sn + "' and ComponentBarcode = '" + barcode + "'";
            return _delete_con_material;
        }

        public string Insert_Condition_Material_Table(Trace_Keypart_Modle trace_Keypart_Modle)
        {
            string _insert_sql = "INSERT INTO [AMS].[dbo].[Trace_Keypart] ([ComponentName]" 
                + ",[ComponentBarcode],[SN],[Station],[RecordTime]) VALUES('" 
                + trace_Keypart_Modle.ComponentName + "','" + trace_Keypart_Modle.ComponentBarcode 
                + "','" + trace_Keypart_Modle.SN + "','" + trace_Keypart_Modle.Station 
                + "','" + trace_Keypart_Modle.RecordTime + "')";
            return _insert_sql;
        }
    }
}
