using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Server_Modle.XML
{
    [XmlRoot("column"), CollectionFormInfo("报表配置", 600, 500)]
    public class Xml_ReportConfig_Column
    {
        [XmlAttribute("Name"),
         DisplayName("名称"),
         Description("名称"),
         Browsable(true),
         ReadOnly(false)]
        public string Name { get; set; } = "Column";

        [XmlAttribute("DisplayIndex"),
         DisplayName("索引"),
         Description("索引"),
         Browsable(true),
         ReadOnly(false)]
        public int DisplayIndex { get; set; }

        [XmlAttribute("DataName"),
         DisplayName("数据库字段"),
         Description("数据库字段"),
         Browsable(true),
         ReadOnly(false)]
        public string dataName { get; set; }

        [XmlAttribute("Width"),
         DisplayName("宽度"),
         Description("宽度"),
         Browsable(true),
         ReadOnly(false)]
        public int width { get; set; }

        [XmlAttribute("autoFilter"),
         DisplayName("显示筛选"),
         Description("显示筛选"),
         Browsable(true),
         ReadOnly(false)]
        public bool autoFilter { get; set; }

        [XmlAttribute("enableSearch"),
         DisplayName("显示搜索"),
         Description("显示搜索"),
         Browsable(true),
         ReadOnly(false)]
        public bool enableSearch { get; set; }

        [XmlAttribute("isDatetime"),
         DisplayName("显示为日期格式"),
         Description("显示为日期格式"),
         Browsable(true),
         ReadOnly(false)]
        public bool isDatetime { get; set; }
    }
}
