using MySql;
using Server_DAL;
using Server_Modle.Chart;
using Server_Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_BLL
{
    public class Line_StationAlarm_Bll : DB_Tool
    {
        public static void Insert(long DT_INT, string DT, string RecipeID, string DBAddress, string Station, string Type, string Describtion)
        {
            using (var con = GetOpenConnection())
            {
                var count = con.Execute(Line_StationAlarm_Dal.Insert(DT_INT, DT, RecipeID, DBAddress, Station, Type, Describtion));
                if (count != 1)
                {
                    throw new Exception("添加报警结果信息错误");
                }
            }
        }

        public static List<Line_StationAlarm_Model> Get(string condition = "", string showColumn = "*")
        {
            using (var con = GetOpenConnection())
            {
                var entity = con.Query<Line_StationAlarm_Model>(Line_StationAlarm_Dal.Get(condition));
                if (entity == null)
                {
                    throw new Exception("获取报警结果信息错误");
                }
                return entity.ToList();
            }
        }

        public static DataTable GetTable(string condition = "", string showColumn = "*")
        {
            using (var con = GetOpenConnection())
            {
                using (var command = new SQLiteCommand(Line_StationAlarm_Dal.GetTable(), (SQLiteConnection)con))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable data = new DataTable();
                        adapter.Fill(data);
                        return data;
                    }
                }
            }
        }

        public static void Update(Line_StationAlarm_Model entity)
        {
            using (var con = GetOpenConnection())
            {
                var res = con.Update(entity);
                if (res != 1)
                {
                    throw new Exception("更新报警结果信息错误");
                }
            }
        }
    }
}
