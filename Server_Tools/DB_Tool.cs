using MySql;
using Server_Modle.XML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Tools
{
    public class DB_Tool
    {
        static string connectionString;
        public static string GetConnectionString()
        {
            string connectionString;
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
            return connectionString;
        }

        public static DbProviderFactory GetDbProviderFactory()
        {
            return Server_Modle.XML.ProviderFactory.GetDbProviderFactory(XML_Tool.xml.DataBase.DatabaseType);
        }
        /// <summary>
        /// 创建数据库连接
        /// </summary>
        /// <returns></returns>
        public static DbConnection GetOpenConnection()
        {
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
            var con = GetDbProviderFactory().CreateConnection();
            con.ConnectionString = connectionString;

            //指定SimpleCRUD中的数据库类型
            SimpleCRUD.Dialect _Dialect;
            switch (XML_Tool.xml.DataBase.DatabaseType)
            {
                case Server_Modle.XML.Xml_DbConfig.DbProviderType.SqlServer:
                    _Dialect = SimpleCRUD.Dialect.SQLServer;
                    break;
                case Server_Modle.XML.Xml_DbConfig.DbProviderType.MySql:
                    _Dialect = SimpleCRUD.Dialect.MySQL;
                    break;
                case Server_Modle.XML.Xml_DbConfig.DbProviderType.SQLite:
                    _Dialect = SimpleCRUD.Dialect.SQLite;
                    break;
                default:
                    _Dialect = SimpleCRUD.Dialect.PostgreSQL;
                    break;
            }
            SimpleCRUD.SetDialect(_Dialect);

            if (con == null)
            {
                throw new Exception("数据库连接配置不正确。");
            }
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("数据库打开失败。" + ex.Message);
            }
            return con;
        }
    }
}
