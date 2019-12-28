using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Server_Modle.XML
{
    [XmlRoot("column"), CollectionFormInfo("测试数据表配置", 600, 500)]
    public class Xml_TestDBConfig_Column
    {
        [XmlAttribute("Name"),
         DisplayName("名称"),
         Description("名称"),
         Browsable(true),
         ReadOnly(false)]
        public string Name { get; set; } = "Column";

        [XmlAttribute("dataType"),
         DisplayName("字段数据类型"),
         Description("字段数据类型"),
         Browsable(true),
         ReadOnly(false)]
        public string DataType { get; set; }

        [XmlAttribute("desc"),
         DisplayName("字段描述"),
         Description("字段描述"),
         Browsable(true),
         ReadOnly(false)]
        public string Desc { get; set; }

        [XmlAttribute("myColumnName"),
         DisplayName("字段描述"),
         Description("字段描述"),
         Browsable(true),
         ReadOnly(false)]
        public string MyColumnName { get; set; }
    }
}
