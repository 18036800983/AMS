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
    [XmlRoot("station"),
        CollectionFormInfo("站配置", 550, 550)]
    public class Xml_InfoConfig_Station
    {
        [XmlAttribute("name"),
        Category("Station设置"),
        DisplayName("名称"),
        Description("名称")]
        public string Name { get; set; } = "StationNull";

        [XmlAttribute("desc"),
         Category("Station设置"),
         DisplayName("工位描述"),
         Description("工位描述")]
        public string Desc { get; set; }

        [XmlAttribute("planTime"),
         Category("Station设置"),
         DisplayName("工位描述"),
         Description("工位描述")]
        public string PlanTime { get; set; }

        [XmlAttribute("AlarmAddr"),
         Category("报警地址"),
         DisplayName("报警地址"),
         Description("报警地址")]
        public string AlarmAddr { get; set; }

        [XmlAttribute("AddrType"),
         Category("地址类型"),
         DisplayName("地址类型"),
         Description("地址类型")]
        public string AddrType { get; set; }

        [XmlArray("DataRecord"), XmlArrayItem("opcitem"),
        TypeConverter(typeof(ListConverter)),
        Editor(typeof(CustomEditor), typeof(UITypeEditor)),
        Category("工艺设置"),
        DisplayName("控制字"),
        Description("控制字")]
        public List<Xml_InfoConfig_Opcitem> Opcitem { get; set; } = new List<Xml_InfoConfig_Opcitem>();

        [XmlArray("Alarm"), XmlArrayItem("opcitem"),
         TypeConverter(typeof(ListConverter)),
         Editor(typeof(CustomEditor), typeof(UITypeEditor)),
         Category("报警设置"),
         DisplayName("报警"),
         Description("报警")]
        public List<Xml_InfoConfig_Alarm> Alarms { get; set; } = new List<Xml_InfoConfig_Alarm>();
    }
}
