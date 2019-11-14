using MySql;
using Server_DAL;
using Server_Modle.DBase;
using Server_Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_BLL
{
    public class Crafts_Recipe_Bll:DB_Tool
    {
        Crafts_Recipe_Dal crafts_Recipe_Dal = new Crafts_Recipe_Dal();
        /// <summary>
        /// Execute the sql of select all recipe production name and station
        /// </summary>
        /// <returns></returns>
        public DataTable Select_All_Recipe_Table(int flag)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteDataTable(crafts_Recipe_Dal.Select_All_Recipe_Table(flag));
            }
        }

        /// <summary>
        /// Execute the sql of select recipe by condition
        /// </summary>
        /// <param name="productionName"></param>
        /// <param name="station"></param>
        /// <returns></returns>
        public DataTable Select_Condition_Recipe_Table(string productionName, string station)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteDataTable(crafts_Recipe_Dal.Select_Condition_Recipe_Table(productionName, station));
            }
        }

        /// <summary>
        /// Execute the sql of select recipe by condition englidh
        /// </summary>
        /// <param name="productionName"></param>
        /// <param name="station"></param>
        /// <returns></returns>
        public DataTable Select_Condition_Recipe_English(string productionName, string station)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteDataTable(crafts_Recipe_Dal.Select_Condition_Recipe_English(productionName, station));
            }
        }

        /// <summary>
        /// Execute the sql of insert recipe into table
        /// </summary>
        /// <param name="crafts_Recipe_Modle"></param>
        /// <returns></returns>
        public int Insert_One_Recipe_Table(Crafts_Recipe_Modle crafts_Recipe_Modle)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(crafts_Recipe_Dal.Insert_One_Recipe_Table(crafts_Recipe_Modle));
            }
        }

        /// <summary>
        /// Execute the sql of update recipe into table
        /// </summary>
        /// <param name="crafts_Recipe_Modle"></param>
        /// <returns></returns>
        public int Update_One_Recipe_Table(Crafts_Recipe_Modle crafts_Recipe_Modle)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(crafts_Recipe_Dal.Update_One_Recipe_Table(crafts_Recipe_Modle));
            }
        }

        /// <summary>
        /// Execute the sql of delete recipe
        /// </summary>
        /// <param name="productionName"></param>
        /// <param name="station"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public int Delete_Condition_Recipe_Table(string productionName, string station, int step,int id)
        {
            using (var con = GetOpenConnection())
            {
                return con.Execute(crafts_Recipe_Dal.Delete_Condition_Recipe_Table(productionName,station,step,id));
            }
        }

        /// <summary>
        /// Execute the sql of select one step is exist
        /// </summary>
        /// <param name="productionName"></param>
        /// <param name="station"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public string Select_Count_Recipe_Table(string productionName, string station, int step)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteScalar(crafts_Recipe_Dal.Select_Count_Recipe_Table(productionName,station,step)).ToString();
            }
        }

        /// <summary>
        /// get one station recipe
        /// </summary>
        public static DataTable Select_Sation_Recipe_Table(string production, string station)
        {
            using (var con = GetOpenConnection())
            {
                return con.ExecuteDataTable(Crafts_Recipe_Dal.Select_Sation_Recipe_Table(production, station));
            }
        }

        /// <summary>
        /// get station recipe list
        /// </summary>
        /// <param name="production"></param>
        /// <param name="station"></param>
        /// <returns></returns>
        public static List<Crafts_Recipe_Modle> GetRecipesByProductionAndStation(string production, string station)
        {
            List<Crafts_Recipe_Modle> lar = new List<Crafts_Recipe_Modle>();
            DataTable dt = Select_Sation_Recipe_Table(production, station);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Crafts_Recipe_Modle crm = new Crafts_Recipe_Modle();
                    crm.RecipeID = int.Parse(dt.Rows[i]["RecipeID"].ToString());
                    crm.ProductionName = dt.Rows[i]["ProductionName"].ToString();
                    crm.Station = dt.Rows[i]["Station"].ToString();
                    crm.Step = int.Parse(dt.Rows[i]["Step"].ToString());
                    crm.OperationType = dt.Rows[i]["OperationType"].ToString();
                    crm.ProgramNo = dt.Rows[i]["ProgramNo"].ToString();
                    crm.CheckRule = dt.Rows[i]["CheckRule"].ToString();
                    crm.BlotNo = dt.Rows[i]["BlotNo"].ToString();
                    crm.ComponentName = dt.Rows[i]["ComponentName"].ToString();
                    crm.BlotNumber = int.Parse(dt.Rows[i]["BlotNumber"].ToString());
                    crm.ComponentNNumber = int.Parse(dt.Rows[i]["ComponentNNumber"].ToString());
                    crm.BarcodeLength = int.Parse(dt.Rows[i]["BarcodeLength"].ToString());
                    crm.Istrace = int.Parse(dt.Rows[i]["Istrace"].ToString());
                    crm.IsCheck = int.Parse(dt.Rows[i]["IsCheck"].ToString());
                    crm.ImagePath = dt.Rows[i]["ImagePath"].ToString();
                    crm.SleeveNo = int.Parse(dt.Rows[i]["SleeveNo"].ToString());
                    crm.StepDesc = dt.Rows[i]["StepDescription"].ToString();
                    lar.Add(crm);
                }
            }
            return lar;
        }

        #region 使用SqlBulkCopy将DataTable中的数据批量插入数据库中  
        /// <summary>  
        /// 注意：DataTable中的列需要与数据库表中的列完全一致。
        /// 已自测可用。
        /// </summary>  
        /// <param name="conStr">数据库连接串</param>
        /// <param name="strTableName">数据库中对应的表名</param>  
        /// <param name="dtData">数据集</param>  
        public void SqlBulkCopyInsert(string strTableName, DataTable dtData)
        {
            try
            {
                string connectionString = string.Empty;
                if (XML_Tool.xml.DataBase.UserID == string.Empty || XML_Tool.xml.DataBase.pwd == string.Empty)
                {
                    connectionString = "Data Source=" + XML_Tool.xml.DataBase.DataSource +
                            ";Initial Catalog=" + XML_Tool.xml.DataBase.InitialCatalog +
                            ";integrated security=sspi";
                }
                else
                {
                    connectionString = "Data Source=" + XML_Tool.xml.DataBase.DataSource +
                            ";Initial Catalog=" + XML_Tool.xml.DataBase.InitialCatalog +
                            ";User ID=" + XML_Tool.xml.DataBase.UserID +
                            ";pwd=" + XML_Tool.xml.DataBase.pwd;
                }
                using (SqlBulkCopy sqlRevdBulkCopy = new SqlBulkCopy(connectionString))//引用SqlBulkCopy  
                {
                    sqlRevdBulkCopy.DestinationTableName = strTableName;//数据库中对应的表名  
                    sqlRevdBulkCopy.NotifyAfter = dtData.Rows.Count;//有几行数据  
                    sqlRevdBulkCopy.WriteToServer(dtData);//数据导入数据库  
                    sqlRevdBulkCopy.Close();//关闭连接  
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        #endregion
    }
}
