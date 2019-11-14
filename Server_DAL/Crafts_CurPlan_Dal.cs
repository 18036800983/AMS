using Server_Modle.DBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DAL
{
    public class Crafts_CurPlan_Dal
    {

        /// <summary>
        /// the sql of select
        /// </summary>
        /// <returns></returns>
        public string Select_All_Plan_Table(bool flag)
        {
            if (flag)
            {
                string _select_all_sql = "SELECT [ID] as '编号',[WorkOrderNo] as '工单号',[WorkOrderName] as '工单名称'" 
                    + ",[WorkOrderDescripe] as '工单描述',[PlanNumber] as '计划量',[DoneNumber] as '完成量',[PassRate] as '通过率'"
                    + "FROM [AMS].[dbo].[Crafts_CurPlan]";
                return _select_all_sql;
            }
            else
            {
                string _select_all_sql = "SELECT [ID] as 'NO',[WorkOrderNo] as 'Work order number',[WorkOrderName] as 'Work order name'"
                    + ",[WorkOrderDescripe] as 'Work order describe',[PlanNumber] as 'Plan Number',[DoneNumber] as 'Amount completed',[PassRate] as 'Passing rate'"
                    + "FROM [AMS].[dbo].[Crafts_CurPlan]";
                return _select_all_sql;
            }
        }

        /// <summary>
        /// the sql of insert
        /// </summary>
        /// <param name="crafts_CurPlan_Modle"></param>
        /// <returns></returns>
        public string Insert_One_Plan__Table(Crafts_CurPlan_Modle crafts_CurPlan_Modle)
        {
            string _insert_one_sql = "INSERT INTO [AMS].[dbo].[Crafts_CurPlan]" 
                + "([WorkOrderNo],[WorkOrderName],[WorkOrderDescripe],[PlanNumber]" 
                + ",[DoneNumber],[PassRate]) VALUES('" + crafts_CurPlan_Modle.WorkOrderNo 
                + "','" + crafts_CurPlan_Modle.WorkOrderName + "','" 
                + crafts_CurPlan_Modle.WorkOrderDescripe + "'," 
                + crafts_CurPlan_Modle.PlanNumber + "," + crafts_CurPlan_Modle.DoneNumber 
                + ",'" + crafts_CurPlan_Modle.PassRate + "')";
            return _insert_one_sql;
        }

        /// <summary>
        /// the sql of update
        /// </summary>
        /// <param name="crafts_CurPlan_Modle"></param>
        /// <returns></returns>
        public string Update_One_Plan_Table(Crafts_CurPlan_Modle crafts_CurPlan_Modle)
        {
            string _update_one_sql = "UPDATE [AMS].[dbo].[Crafts_CurPlan]" 
                + "SET [WorkOrderNo] = '" + crafts_CurPlan_Modle.WorkOrderNo 
                + "',[WorkOrderName] = '" + crafts_CurPlan_Modle.WorkOrderName + "',[WorkOrderDescripe] = '" 
                + crafts_CurPlan_Modle.WorkOrderDescripe + "',[PlanNumber] = " 
                + crafts_CurPlan_Modle.PlanNumber + ",[DoneNumber] = " 
                + crafts_CurPlan_Modle.DoneNumber + ",[PassRate] = '" 
                + crafts_CurPlan_Modle.PassRate + "' WHERE ID = " 
                + crafts_CurPlan_Modle.ID;
            return _update_one_sql;
        }

        /// <summary>
        /// the sql of delete
        /// </summary>
        /// <param name="workOrderNo"></param>
        /// <returns></returns>
        public string Delete_One_Plan_Table(string workOrderNo)
        {
            string _delete_one_sql = "DELETE FROM [AMS].[dbo].[Crafts_CurPlan]" 
                + " WHERE WorkOrderNo = '" + workOrderNo + "'";
            return _delete_one_sql;
        }

        public static string Select_workOrder_Table()
        {
            string select_sql = "select WorkOrderNo from Crafts_CurPlan where Id = 1";
            return select_sql;
        }
    }
}
