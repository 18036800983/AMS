using MySql;
using Server_DAL;
using Server_Modle.DBase;
using Server_Modle.XML;
using Server_Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Server_Modle.XML.Xml_DbConfig;

namespace Server_BLL
{
    public class Report_Bll : DB_Tool
    {
        Report_Dal report_Dal = new Report_Dal(); 
        /// <summary>
        /// Execute get table by condition
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="condition"></param>
        /// <returns></returns>
        public IEnumerable<T> GetTableByCondition<T>(string condition)
        {
            using (var con = GetOpenConnection())
            {
                return con.Query<T>(report_Dal.GetTableByCondition<T>(condition));
            }
        }

        /// <summary>
        /// Execute get table count
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public int GetTableCount(string tableName)
        {
            using (var con = GetOpenConnection())
            {
                var para = new DynamicParameters();
                para.Add("@RowCount", 0, DbType.Int32, ParameterDirection.Output, 4);
                para.Add("@TableName", tableName, DbType.String, ParameterDirection.Input, 30);
                var res = con.Query<int>("GetRowCount", para, commandType: CommandType.StoredProcedure);
                return para.Get<int>("@RowCount");
            }
        }

        public DataTable Get(int page, int sizePage, string showColumn, string tabName, string strCondition, string ascColumn, int bitOrderType, string pkColumn)
        {
            using (var con = GetOpenConnection())
            {
                List<DbParameter> parameters = new List<DbParameter>();
                parameters.Add(DbUtility.CreateDbParameter("@currPage", page, ParameterDirection.Input));
                parameters.Add(DbUtility.CreateDbParameter("@showColumn", showColumn, ParameterDirection.Input));
                parameters.Add(DbUtility.CreateDbParameter("@tabName", tabName, ParameterDirection.Input));
                parameters.Add(DbUtility.CreateDbParameter("@strCondition", strCondition, ParameterDirection.Input));
                parameters.Add(DbUtility.CreateDbParameter("@ascColumn", ascColumn, ParameterDirection.Input));
                parameters.Add(DbUtility.CreateDbParameter("@bitOrderType", bitOrderType, ParameterDirection.Input));
                parameters.Add(DbUtility.CreateDbParameter("@pkColumn ", pkColumn, ParameterDirection.Input));
                parameters.Add(DbUtility.CreateDbParameter("@pageSize ", sizePage, ParameterDirection.Input));

                return con.ExecuteDataTable("prcPage", parameters, CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// 获取报表名称
        /// </summary>
        /// <typeparam name="T">数据库表</typeparam>
        /// <returns>报表名称信息</returns>
        public Tuple<string, int, string>[] GetReportName<T>()
        {
            if (XML_Tool.xml.DataBase.ReportNameShowType == ReportNameShow.数据库说明)
                return GetReportNameBySQLDescription<T>();
            else if (XML_Tool.xml.DataBase.ReportNameShowType == ReportNameShow.特性)
                return GetReportNameByAttribute<T>();
            else
                return null;
        }

        /// <summary>
        /// 通过数据库属性的特性获取报表名称
        /// </summary>
        /// <typeparam name="T">数据库表</typeparam>
        /// <returns>报表名称信息</returns>
        private Tuple<string, int, string>[] GetReportNameByAttribute<T>()
        {
            var type = typeof(T);
            return type.GetProperties()
                .Select(n =>
                {
                    var attrs = n.GetCustomAttributes(typeof(ReportName), true);
                    if (attrs.Count() > 0)
                    {
                        var attr = attrs.First() as ReportName;
                        return new Tuple<string, int, string>(attr.name, attr.width, n.Name);
                    }
                    else
                    {
                        return null;
                    }
                }).Where(n => n != null)
                .ToArray();
        }

        /// <summary>
        /// 通过sqlserver的字段说明获取报表名称
        /// </summary>
        /// <typeparam name="T">数据库表</typeparam>
        /// <returns>报表名称信息</returns>
        private Tuple<string, int, string>[] GetReportNameBySQLDescription<T>()
        {
            var sql = string.Format(@"SELECT
                                        a.name AS 列名,
                                        isnull(g.[value],a.name) AS 说明
                                    FROM
                                        sys.columns a left join sys.extended_properties g
                                        on (a.object_id = g.major_id AND g.minor_id = a.column_id)
                                    WHERE
                                        object_id =
                                    (SELECT object_id FROM sys.tables WHERE name = '{0}')", typeof(T).Name);
            using (var con = GetOpenConnection())
            {
                var res = con.Query<Tb_Description_Modle>(sql);
                if (res == null)
                {
                    throw new Exception("获取列名信息错误");
                }
                else
                {
                    return res
                         .Where(n => n.说明 != "ignore")
                         .Select(n =>
                         {
                             var splitDes = n.说明.Split(':');
                             if (splitDes.Count() == 1)
                                 return new Tuple<string, int, string>(n.说明, 100, n.列名);
                             else
                                 return new Tuple<string, int, string>(splitDes[0], int.Parse(splitDes[1]), n.列名);
                         }).Where(n => n != null)
                         .ToArray();
                }
            }
        }
    }
}
