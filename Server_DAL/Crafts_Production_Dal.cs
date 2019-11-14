using Server_Modle.DBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DAL
{
    public class Crafts_Production_Dal
    {

        /// <summary>
        /// the sql of select all data from table
        /// </summary>
        /// <returns></returns>
        public string Select_All_Production_Table()
        {
            string _select_all_production = "SELECT [ProductionID]" 
                + ",[ProductionName],[ProductionNo],[ProductionDescripe],[ProductionRule]"
                + "FROM [AMS].[dbo].[Crafts_Production]";
            return _select_all_production;
        }

        /// <summary>
        /// the sql of insert one data to table
        /// </summary>
        /// <param name="crafts_Production_Modle"></param>
        /// <returns></returns>
        public string Insert_One_Production_Table(Crafts_Production_Modle crafts_Production_Modle)
        {
            string _insert_one_production = "INSERT INTO [AMS].[dbo].[Crafts_Production]" 
                + "([ProductionName],[ProductionNo],[ProductionDescripe],[ProductionRule]) VALUES "
                + "('" + crafts_Production_Modle.ProductionName + "','" 
                + crafts_Production_Modle.ProductionNo + "','" 
                + crafts_Production_Modle.ProductionDescripe + "','" + crafts_Production_Modle.ProductionRule + "')";
            return _insert_one_production;
        }

        /// <summary>
        /// the sql of update one data to table
        /// </summary>
        /// <param name="crafts_Production_Modle"></param>
        /// <param name="oldProductionName"></param>
        /// <returns></returns>
        public string Update_One_Production_Table(Crafts_Production_Modle crafts_Production_Modle,string oldProductionName)
        {
            string _update_one_production = "UPDATE [AMS].[dbo].[Crafts_Production]" 
                + "SET [ProductionName] = '" + crafts_Production_Modle.ProductionName 
                + "',[ProductionNo] = '" + crafts_Production_Modle.ProductionNo 
                + "',[ProductionDescripe] = '" + crafts_Production_Modle.ProductionDescripe 
                + "',[ProductionRule] = '" + crafts_Production_Modle.ProductionRule
                + "' WHERE ProductionName = '" + oldProductionName + "'";
            return _update_one_production;
        }

        /// <summary>
        /// the sql of delete one data from table
        /// </summary>
        /// <param name="productionName"></param>
        /// <returns></returns>
        public string Delete_One_Production_Table(string productionName)
        {
            string _delete_one_production = "DELETE FROM [AMS].[dbo].[Crafts_Production]" 
                + " WHERE ProductionName = '" + productionName + "'";
            return _delete_one_production;
        }
    }
}
