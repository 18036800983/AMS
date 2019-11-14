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
    [XmlRoot("Tag"),
        CollectionFormInfo("控制字数值配置", 500, 500)]
    public class Xml_InfoConfig_Tags
    {
        [XmlAttribute("name")]
        public string Name { get; set; } = "Tag";

        [XmlAttribute("Tag")]
        public int Tag { get; set; }

        [XmlAttribute("TableName"),
        Category("数据库设置"),
        DisplayName("表名"),
        Description("表名")]
        public string TableName { get; set; }

        [XmlElement("dataitem"),
        TypeConverter(typeof(ListConverter)),
        Editor(typeof(CustomEditor), typeof(UITypeEditor)),
        Category("工艺设置"),
        DisplayName("数据"),
        Description("数据")]
        public List<Xml_InfoConfig_Dataitem> Dataitem { get; set; } = new List<Xml_InfoConfig_Dataitem>();
    }
}
