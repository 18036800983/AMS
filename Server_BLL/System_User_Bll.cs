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
    public class System_User_Bll : DB_Tool
    {
        System_User_Dal system_User_Dal = new System_User_Dal();

        /// <summary>
        /// select by employee id
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public DataTable Select_LoginInfo_Table(string employeeID)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteDataTable(system_User_Dal.Select_LoginInfo_Table(employeeID));
            }
        }

        /// <summary>
        /// Execute select all data from database (when data large prevent using the type of select *)
        /// </summary>
        /// <returns></returns>
        public DataTable Select_ALL_User_Table()
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteDataTable(system_User_Dal.Select_ALL_User_Table());
            }
        }

        /// <summary>
        /// Execute select all data from database (when data large prevent using the type of select *)
        /// </summary>
        /// <returns></returns>
        public DataTable Select_ALL_OPUser_Table()
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteDataTable(system_User_Dal.Select_All_OPUser_Table());
            }
        }

        /// <summary>
        /// Execute select password by username
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public string Select_ONE_User_Table(System_User_Modle sum)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteScalar(system_User_Dal.Select_ONE_User_Table(sum)).ToString();
            }
        }

        /// <summary>
        /// select UserLevel by username
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public string Select_Level_User_Table(string name)
        {
            try
            {
                using (var con = GetOpenConnection())
                {
                    return con.ExecuteScalar(system_User_Dal.Select_Level_User_Table(name)).ToString();
                }
            }
            catch (Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// Execute insert user into table
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public int Insert_ONE_User_Table(System_User_Modle sum)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(system_User_Dal.Insert_ONE_User_Table(sum));
            }
        }

        /// <summary>
        /// Execute update user infomation
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public int Update_ONE_User_Table(System_User_Modle sum)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(system_User_Dal.Update_ONE_User_Table(sum));
            }
        }

        /// <summary>
        /// Execute delete the user appointed
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public int Delete_ONE_User_Table(System_User_Modle sum)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(system_User_Dal.Delete_ONE_User_Table(sum));
            }
        }
    }
}
