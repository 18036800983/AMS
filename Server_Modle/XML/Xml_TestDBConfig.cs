using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Server_Modle.XML
{
    [XmlRoot("DB"), CollectionFormInfo("测试设备数据库配置", 500, 500)]
    public class Xml_TestDBConfig
    {
        [XmlAttribute("Name"),
         DisplayName("名称"),
         Description("名称"),
         Browsable(true),
         ReadOnly(false)]
        public string Name { get; set; }

        [XmlAttribute("DataSource"),
         DisplayName("服务器"),
         Description("服务器"),
         Browsable(true),
         ReadOnly(false)]
        public string DataSource { get; set; }

        [XmlAttribute("InitialCatalog"),
         DisplayName("数据库名称"),
         Description("数据库名称"),
         Browsable(true),
         ReadOnly(false)]
        public string InitialCatalog { get; set; }

        [XmlAttribute("UserID"),
         DisplayName("登录名"),
         Description("登录名"),
         Browsable(true),
         ReadOnly(false)]
        public string UserID { get; set; }

        [XmlAttribute("pwd"),
         DisplayName("密码"),
         Description("密码"),
         Browsable(true),
         ReadOnly(false)]
        public string Password { get; set; }

        [XmlAttribute("DatabaseType"),
         DisplayName("数据库类型"),
         Description("数据库类型"),
         Browsable(true),
         ReadOnly(false)]
        public string DatabaseType { get; set; }

        [XmlAttribute("TableName"),
         DisplayName("表名"),
         Description("表名"),
         Browsable(true),
         ReadOnly(false)]
        public string TableName { get; set; }

        [XmlAttribute("MyTableName"),
         DisplayName("表名"),
         Description("表名"),
         Browsable(true),
         ReadOnly(false)]
        public string MyTableName { get; set; }

        [XmlAttribute("Count"),
         DisplayName("数据数量"),
         Description("数据数量"),
         Browsable(true),
         ReadOnly(false)]
        public string Count { get; set; }

        [XmlElement("column"), TypeConverter(typeof(ListConverter)),
        DisplayName("列"),
        Description("列"),
        Editor(typeof(CustomEditor), typeof(UITypeEditor))]
        public List<Xml_TestDBConfig_Column> column { get; set; } = new List<Xml_TestDBConfig_Column>();
    }
}
