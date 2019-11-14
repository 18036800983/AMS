using Server_Modle.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DAL
{
    public class Line_StationAlarm_Dal
    {
        public static string Insert(long DT_INT, string DT, string RecipeID, string DBAddress, string Station, string Type, string Describtion)
        {
            var sql = $"insert into Line_StationAlarm_Model(DT_INT,DT,RecipeID,DBAddress,Station,Type,Describtion) "
                + $"values({DT_INT},'{DT}','{RecipeID}','{DBAddress}','{Station}','{Type}','{Describtion}')";
            return sql;
        }

        public static string Get(string condition = "", string showColumn = "*")
        {
            var sql = $"select {showColumn} from Line_StationAlarm_Model";
            if (condition != string.Empty)
                sql += $" where {condition}";
            return sql;
        }

        public static string GetTable(string condition = "", string showColumn = "*")
        {
                var sql = $"select {showColumn} from Line_StationAlarm_Model";
                if (condition != string.Empty)
                    sql += $" where {condition}";
            return sql;
        }
    }
}
