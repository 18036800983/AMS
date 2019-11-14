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
    [XmlRoot("table"), CollectionFormInfo("报表配置", 500, 500)]
    public class Xml_ReportConfig
    {
        [XmlElement("column"), TypeConverter(typeof(ListConverter)),
        DisplayName("列"),
        Description("列"),
        Editor(typeof(CustomEditor), typeof(UITypeEditor))]
        public List<Xml_ReportConfig_Column> column { get; set; } = new List<Xml_ReportConfig_Column>();

        [XmlAttribute("Name"),
         DisplayName("名称"),
         Description("名称"),
         Browsable(true),
         ReadOnly(false)]
        public string Name { get; set; } = "Table";

        [XmlAttribute("DataName"),
         DisplayName("数据库表名称"),
         Description("数据库表名称"),
         //DefaultValue(""),
         Browsable(true),
         ReadOnly(false)]
        public string DataName { get; set; }

        [XmlAttribute("ColumnAutoSizeMode"),
         DisplayName("列宽调整"),
         Description("列宽调整"),
         Browsable(true),
         ReadOnly(false)]
        public ColumnAutoSizeModeEnum ColumnAutoSizeMode { get; set; }

        [XmlElement("merging"), TypeConverter(typeof(ListConverter)),
        //Category(""),
        DisplayName("合并列"),
        Description("合并列"),
        Editor(typeof(CustomEditor), typeof(UITypeEditor))]
        public List<Xml_ReportConfig_Merging> merging { get; set; } = new List<Xml_ReportConfig_Merging>();

        public enum ColumnAutoSizeModeEnum
        {
            默认 = 1,
            填充 = 2,
            除标题外屏幕显示区域自动调整 = 3,
            屏幕显示区域自动调整 = 4,
            适合标题单元格 = 5,
            除标题外自动调整 = 6,
            自动调整 = 7
        }
    }
}
