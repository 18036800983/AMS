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
    [XmlRoot("opcitem"),
    CollectionFormInfo("控制字配置", 550, 550)]
    public class Xml_InfoConfig_Opcitem
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("addr"), OPCAddress("", true)]
        public string Addr { get; set; }

        [XmlAttribute("backaddr"), OPCAddress("", true)]
        public string BackAddr { get; set; }

        [XmlAttribute("AddrType")]
        public string AddrType { get; set; }

        [XmlAttribute("OperationDesc")]
        public string OperationDesc { get; set; }

        [XmlElement("Tag"),
        TypeConverter(typeof(ListConverter)),
        Editor(typeof(CustomEditor), typeof(UITypeEditor)),
        Category("工艺设置"),
        DisplayName("数据"),
        Description("数据")]
        public List<Xml_InfoConfig_Tags> Tag { get; set; } = new List<Xml_InfoConfig_Tags>();
    }
}
