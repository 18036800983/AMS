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
    public class Crafts_CurPlan_Bll : DB_Tool
    {
        Crafts_CurPlan_Dal crafts_CurPlan_Dal = new Crafts_CurPlan_Dal();
        /// <summary>
        /// Execute the sql of select
        /// </summary>
        /// <returns></returns>
        public DataTable Select_All_Plan_Table(bool flag)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteDataTable(crafts_CurPlan_Dal.Select_All_Plan_Table(flag));
            }
        }

        /// <summary>
        /// Execute the sql of insert
        /// </summary>
        /// <param name="crafts_CurPlan_Modle"></param>
        /// <returns></returns>
        public int Insert_One_Plan__Table(Crafts_CurPlan_Modle crafts_CurPlan_Modle)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(crafts_CurPlan_Dal.Insert_One_Plan__Table(crafts_CurPlan_Modle));
            }
        }

        /// <summary>
        /// Execute the sql of update
        /// </summary>
        /// <param name="crafts_CurPlan_Modle"></param>
        /// <returns></returns>
        public int Update_One_Plan_Table(Crafts_CurPlan_Modle crafts_CurPlan_Modle)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(crafts_CurPlan_Dal.Update_One_Plan_Table(crafts_CurPlan_Modle));
            }
        }

        /// <summary>
        /// Execute the sql of delete
        /// </summary>
        /// <param name="workOrderNo"></param>
        /// <returns></returns>
        public int Delete_One_Plan_Table(string workOrderNo)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(crafts_CurPlan_Dal.Delete_One_Plan_Table(workOrderNo));
            }
        }

        public static string Select_workOrder_Table()
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteScalar(Crafts_CurPlan_Dal.Select_workOrder_Table()).ToString();
            }
        }
    }
}
