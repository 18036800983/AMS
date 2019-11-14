using MySql;
using Server_DAL;
using Server_Modle.DBase;
using Server_Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_BLL
{
    public class Crafts_Production_Bll : DB_Tool
    {
        Crafts_Production_Dal crafts_Production_Dal = new Crafts_Production_Dal();
        /// <summary>
        /// Execute the sql of select all data from table
        /// </summary>
        /// <returns></returns>
        public DataTable Select_All_Production_Table()
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteDataTable(crafts_Production_Dal.Select_All_Production_Table());
            }
        }

        /// <summary>
        /// Execute the sql of insert one data to table
        /// </summary>
        /// <param name="crafts_Production_Modle"></param>
        /// <returns></returns>
        public int Insert_One_Production_Table(Crafts_Production_Modle crafts_Production_Modle)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(crafts_Production_Dal.Insert_One_Production_Table(crafts_Production_Modle));
            }
        }

        /// <summary>
        /// Execute the sql of update one data to table
        /// </summary>
        /// <param name="crafts_Production_Modle"></param>
        /// <param name="oldProductionName"></param>
        /// <returns></returns>
        public int Update_One_Production_Table(Crafts_Production_Modle crafts_Production_Modle, string oldProductionName)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(crafts_Production_Dal.Update_One_Production_Table(crafts_Production_Modle,oldProductionName));
            }
        }

        /// <summary>
        /// Execute the sql of delete one data from table
        /// </summary>
        /// <param name="productionName"></param>
        /// <returns></returns>
        public int Delete_One_Production_Table(string productionName)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(crafts_Production_Dal.Delete_One_Production_Table(productionName));
            }
        }
    }
}
