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
    [XmlRoot("configuration", IsNullable = false)]
    public class Xml_ConfigRoot
    {
        [XmlArray("InfoConfig"), XmlArrayItem("line"), TypeConverter(typeof(ListConverter)),
         Category("产线设置"),
         DisplayName("产线配置"),
         Description("产线配置"),
         Browsable(true),
         ReadOnly(false),
         Editor(typeof(CustomEditor), typeof(UITypeEditor))]
        public List<Xml_InfoConfig> LINE { get; set; }

        [XmlArray("ReportConfig"), XmlArrayItem("table"), TypeConverter(typeof(ListConverter)),
        Category("报表设置"),
        DisplayName("报表配置"),
        Description("报表配置"),
        Browsable(true),
        ReadOnly(false),
        Editor(typeof(CustomEditor), typeof(UITypeEditor))]
        public List<Xml_ReportConfig> Report { get; set; }

        [XmlArray("StationConfig"), XmlArrayItem("station"), TypeConverter(typeof(ListConverter)),
        Category("工位设置"),
        DisplayName("工位配置"),
        Description("工位配置"),
        Browsable(true),
        ReadOnly(false),
        Editor(typeof(CustomEditor), typeof(UITypeEditor))]
        public List<Xml_StationConfig> StationConfig { get; set; }

        [XmlElement("dbConfig"), TypeConverter(typeof(XmlConverter)),
        Category("数据库设置"),
        DisplayName("数据库配置"),
        Description("数据库配置"),
        Browsable(true),
        ReadOnly(false),
        Editor(typeof(CustomEditor), typeof(UITypeEditor))]
        public Xml_DbConfig DataBase { get; set; }

        [XmlElement("serialPortConfig"), TypeConverter(typeof(XmlConverter)),
        Category("串口设置"),
        DisplayName("串口配置"),
        Description("串口配置"),
        Browsable(true),
        ReadOnly(false),
        Editor(typeof(CustomEditor), typeof(UITypeEditor))]
        public Xml_SerialPortConfig SerialPortConfig { get; set; }

        [XmlElement("PrinterConfig"), TypeConverter(typeof(XmlConverter)),
        Category("打印设置"),
        DisplayName("打印配置"),
        Description("打印配置"),
        Browsable(true),
        ReadOnly(false),
        Editor(typeof(CustomEditor), typeof(UITypeEditor))]
        public Xml_PrinterConfig Printer { get; set; }

        [XmlElement("sysConfig"), TypeConverter(typeof(XmlConverter)),
        Category("系统设置"),
        DisplayName("系统配置"),
        Description("系统配置"),
        Browsable(true),
        ReadOnly(false),
        Editor(typeof(CustomEditor), typeof(UITypeEditor))]
        public Xml_SysConfig SysConfig { get; set; }
    }
}
