﻿using Server_Modle.DBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DAL
{
    public class System_User_Dal
    {

        /// <summary>
        /// select by employee id
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public string Select_LoginInfo_Table(string employeeID)
        {
            string _selectSql = "select * from [AMS].[dbo].[Sys_User] Where [UserEmployeeID] = '" + employeeID + "'";
            return _selectSql;
        }

        /// <summary>
        /// select all data from database (when data large prevent using the type of select *)
        /// </summary>
        /// <returns></returns>
        public string Select_ALL_User_Table()
        {
            string _select_all_sql = "select * from [AMS].[dbo].[Sys_User]";
            return _select_all_sql;
        }

        /// <summary>
        /// select all user beside super manager
        /// </summary>
        /// <returns></returns>
        public string Select_All_OPUser_Table()
        {
            string _select_all_sql = "select * from [AMS].[dbo].[Sys_User] where UserLevel not in('超级管理员')";
            return _select_all_sql;
        }

        /// <summary>
        /// select password by username
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public string Select_ONE_User_Table(System_User_Modle sum)
        {
            string _select_one_sql = "select Password from [AMS].[dbo].[Sys_User]" 
                + " WHERE UserName = '" + sum.UserName + "'";
            return _select_one_sql;
        }

        /// <summary>
        /// select UserLevel by username
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public string Select_Level_User_Table(string name)
        {
            string _select_one_sql = "select UserLevel from [AMS].[dbo].[Sys_User]"
                + " WHERE UserName = '" + name + "'";
            return _select_one_sql;
        }

        /// <summary>
        /// insert user into table
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public string Insert_ONE_User_Table(System_User_Modle sum)
        {
            string _insertSql = "INSERT INTO [AMS].[dbo].[Sys_User]" 
                + "([UserName],[Password],[UserLevel],[UserOperator]" 
                + ",[UserEmployeeID],[UserGroup]) VALUES('" + sum.UserName 
                + "','" + sum.Password + "','" + sum.UserLevel 
                + "','" + sum.UserOperator + "','" + sum.UserEmployeeID 
                + "','" + sum.UserGroup + "')";
            return _insertSql;
        }

        /// <summary>
        /// update user infomation
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public string Update_ONE_User_Table(System_User_Modle sum)
        {
            string _updateSql = "UPDATE [AMS].[dbo].[Sys_User]" 
                + "SET [UserName] = '" + sum.UserName 
                + "',[Password] = '" + sum.Password 
                + "',[UserLevel] = '" + sum.UserLevel 
                + "',[UserOperator] = '" + sum.UserOperator 
                + "',[UserEmployeeID] = '" + sum.UserEmployeeID 
                + "',[UserGroup] = '" + sum.UserGroup
                + "' WHERE ID = " + sum.ID;
            return _updateSql;
        }

        /// <summary>
        /// delete the user appointed
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public string Delete_ONE_User_Table(System_User_Modle sum)
        {
            string _delete_one_sql = "DELETE FROM [AMS].[dbo].[Sys_User]" 
                + " WHERE ID = " + sum.ID;
            return _delete_one_sql;
        }
    }
}
