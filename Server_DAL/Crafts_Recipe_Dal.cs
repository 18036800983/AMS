using Server_Modle.DBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DAL
{
    public class Crafts_Recipe_Dal
    {

        /// <summary>
        /// the sql of select all recipe production name and station
        /// </summary>
        /// <returns></returns>
        public string Select_All_Recipe_Table(int flag)
        {
            if (flag == 2)
            {
                string _select_all_recipe = "SELECT distinct [ProductionName]"
                    + ",[Station] FROM [AMS].[dbo].[Crafts_Recipe]";
                return _select_all_recipe;
            }
            else
            {
                string _select_all_recipe = "SELECT distinct [ProductionName]"
                   + " FROM [AMS].[dbo].[Crafts_Recipe]";
                return _select_all_recipe;
            }
        }

        /// <summary>
        /// the sql of select recipe by condition
        /// </summary>
        /// <param name="productionName"></param>
        /// <param name="station"></param>
        /// <returns></returns>
        public string Select_Condition_Recipe_Table(string productionName,string station)
        {
            string _select_condition_recipe = string.Empty;
            if (!string.IsNullOrEmpty(station))
            {
                _select_condition_recipe = "SELECT [RecipeID] as '编号'"
                    + ",[ProductionName] as '产品名称',[Station] as '工位',[Step] as '步序',[OperationType] as '操作类型'"
                    + ",[ProgramNo] as '程序号',[CheckRule] as '校验规则',[BlotNo] as '螺栓编号',[ComponentName] as '部件名称'"
                    + ",[BlotNumber] as '螺栓数量',[ComponentNNumber] as '部件数量',[BarcodeLength] as '条码长度'"
                    + ",[Istrace] as '是否追溯',[IsCheck] as '是否校验',[ImagePath] as '图片路径',[SleeveNo] as '套筒号'" 
                    + ",[StepDescription] as '操作描述' FROM [AMS].[dbo].[Crafts_Recipe] "
                    + " WHERE ProductionName = '" + productionName
                    + "' and Station = '" + station + "' order by Step";
            }
            else
            {
                _select_condition_recipe = "SELECT [RecipeID] as '编号'"
                    + ",[ProductionName] as '产品名称',[Station] as '工位',[Step] as '步序',[OperationType] as '操作类型'"
                    + ",[ProgramNo] as '程序号',[CheckRule] as '校验规则',[BlotNo] as '螺栓编号',[ComponentName] as '部件名称'"
                    + ",[BlotNumber] as '螺栓数量',[ComponentNNumber] as '部件数量',[BarcodeLength] as '条码长度'"
                    + ",[Istrace] as '是否追溯',[IsCheck] as '是否校验',[ImagePath] as '图片路径',[SleeveNo] as '套筒号',[StepDescription] as '操作描述' FROM [AMS].[dbo].[Crafts_Recipe] "
                    + " WHERE ProductionName = '" + productionName + "' order by Station,Step";
            }
            return _select_condition_recipe;
        }

        /// <summary>
        /// the sql of select recipe by condition english
        /// </summary>
        /// <param name="productionName"></param>
        /// <param name="station"></param>
        /// <returns></returns>
        public string Select_Condition_Recipe_English(string productionName, string station)
        {
            string _select_condition_recipe = string.Empty;
            if (!string.IsNullOrEmpty(station))
            {
                _select_condition_recipe = "SELECT * FROM [AMS].[dbo].[Crafts_Recipe] "
                    + " WHERE ProductionName = '" + productionName
                    + "' and Station = '" + station + "' order by Step";
            }
            else
            {
                _select_condition_recipe = "SELECT * FROM [AMS].[dbo].[Crafts_Recipe] "
                    + " WHERE ProductionName = '" + productionName + "' order by Station,Step";
            }
            return _select_condition_recipe;
        }

        /// <summary>
        /// the sql of insert recipe into table
        /// </summary>
        /// <param name="crafts_Recipe_Modle"></param>
        /// <returns></returns>
        public string Insert_One_Recipe_Table(Crafts_Recipe_Modle crafts_Recipe_Modle)
        {
            string _insert_one_recipe = "INSERT INTO [AMS].[dbo].[Crafts_Recipe]" 
                + "([ProductionName],[Station],[Step],[OperationType],[ProgramNo]" 
                + ",[CheckRule],[BlotNo],[ComponentName],[BlotNumber],[ComponentNNumber]" 
                + ",[BarcodeLength],[Istrace],[IsCheck],[ImagePath],[SleeveNo],[StepDescription]) VALUES('"
                + crafts_Recipe_Modle.ProductionName + "','" 
                + crafts_Recipe_Modle.Station + "'," + crafts_Recipe_Modle.Step 
                + ",'" + crafts_Recipe_Modle.OperationType + "','" 
                + crafts_Recipe_Modle.ProgramNo + "','" + crafts_Recipe_Modle.CheckRule 
                + "','" + crafts_Recipe_Modle.BlotNo + "','" 
                + crafts_Recipe_Modle.ComponentName + "'," + crafts_Recipe_Modle.BlotNumber 
                + ",'" + crafts_Recipe_Modle.ComponentNNumber + "'," 
                + crafts_Recipe_Modle.BarcodeLength + "," + crafts_Recipe_Modle.Istrace 
                + "," + crafts_Recipe_Modle.IsCheck + ",'" + crafts_Recipe_Modle.ImagePath 
                + "','" + crafts_Recipe_Modle.SleeveNo + "','" + crafts_Recipe_Modle.StepDesc + "')";
            return _insert_one_recipe;
        }

        /// <summary>
        /// the sql of update recipe into table
        /// </summary>
        /// <param name="crafts_Recipe_Modle"></param>
        /// <returns></returns>
        public string Update_One_Recipe_Table(Crafts_Recipe_Modle crafts_Recipe_Modle)
        {
            string _update_one_recipe = "UPDATE [AMS].[dbo].[Crafts_Recipe]" 
                + "SET [ProductionName] = '" + crafts_Recipe_Modle.ProductionName 
                + "',[Station] = '" + crafts_Recipe_Modle.Station + "',[Step] = " 
                + crafts_Recipe_Modle.Step + ",[OperationType] = '" 
                + crafts_Recipe_Modle.OperationType + "',[ProgramNo] = '" 
                + crafts_Recipe_Modle.ProgramNo + "',[CheckRule] = '" 
                + crafts_Recipe_Modle.CheckRule + "',[BlotNo] = '" 
                + crafts_Recipe_Modle.BlotNo + "',[ComponentName] = '" 
                + crafts_Recipe_Modle.ComponentName + "',[BlotNumber] = " 
                + crafts_Recipe_Modle.BlotNumber + ",[ComponentNNumber] = " 
                + crafts_Recipe_Modle.ComponentNNumber + ",[BarcodeLength] = " 
                + crafts_Recipe_Modle.BarcodeLength + ",[Istrace] = " 
                + crafts_Recipe_Modle.Istrace + ",[IsCheck] = " 
                + crafts_Recipe_Modle.IsCheck + ",[ImagePath] = '" 
                + crafts_Recipe_Modle.ImagePath + "',[SleeveNo] = "
                + crafts_Recipe_Modle.SleeveNo + ",[StepDescription] = '"
                + crafts_Recipe_Modle.StepDesc + "' WHERE ProductionName = '" 
                + crafts_Recipe_Modle.ProductionName + "' and Station = '" 
                + crafts_Recipe_Modle.Station + "' and Step = " + crafts_Recipe_Modle.Step;
            return _update_one_recipe;
        }

        /// <summary>
        /// the sql of delete recipe
        /// </summary>
        /// <param name="productionName"></param>
        /// <param name="station"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public string Delete_Condition_Recipe_Table(string productionName,string station,int step,int id)
        {
            if (step == 0)
            {
                if (string.IsNullOrEmpty(station))
                {
                    string _delete_condition_recipe = "DELETE FROM [AMS].[dbo].[Crafts_Recipe] "
                        + "WHERE  ProductionName = '" + productionName + "'";
                    return _delete_condition_recipe;
                }
                else
                {
                    string _delete_condition_recipe = "DELETE FROM [AMS].[dbo].[Crafts_Recipe] "
                        + "WHERE  ProductionName = '" + productionName + "' and Station = '"
                        + station + "'";
                    return _delete_condition_recipe;
                }
            }
            else
            {
                string _delete_condition_recipe = "DELETE FROM [AMS].[dbo].[Crafts_Recipe] "
                    + "WHERE  ProductionName = '" + productionName + "' and Station = '"
                    + station + "' and Step = " + step + " and RecipeID = " + id;
                return _delete_condition_recipe;
            }
        }

        /// <summary>
        /// the sql of select one step is exist
        /// </summary>
        /// <param name="productionName"></param>
        /// <param name="station"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public string Select_Count_Recipe_Table(string productionName,string station,int step)
        {
            string _select_count_recipe = "select count(*) from [AMS].[dbo].[Crafts_Recipe]"
                +"WHERE  ProductionName = '" + productionName + "' and Station = '"
                + station + "' and Step = " + step;
            return _select_count_recipe;
        }

        /// <summary>
        /// get one station recipe
        /// </summary>
        public static string Select_Sation_Recipe_Table(string production, string station)
        {
            string _select_station_recipe = "SELECT [RecipeID],[ProductionName]"
                + ",[Station],[Step],[OperationType],[ProgramNo],[CheckRule]"
                + ",[BlotNo],[ComponentName],[BlotNumber],[ComponentNNumber]"
                + ",[BarcodeLength],[Istrace],[IsCheck],[ImagePath],[SleeveNo]" 
                + ",[StepDescription] FROM [AMS].[dbo].[Crafts_Recipe]";
            return _select_station_recipe;
        }
    }
}
