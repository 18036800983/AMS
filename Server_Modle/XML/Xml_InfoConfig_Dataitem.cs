using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Server_Modle.XML
{
    [XmlRoot("dataitem"),
        CollectionFormInfo("数据配置", 500, 500)]
    public class Xml_InfoConfig_Dataitem
    {

        [XmlAttribute("name")]
        public string Name { get; set; } = "Dataitem";

        [XmlAttribute("addr"),
         OPCAddress("", true)]
        public string Addr { get; set; }

        [XmlAttribute("ColmnName"),
        Category("数据库设置"),
        DisplayName("列名"),
        Description("列名")]
        public string ColmnName { get; set; }

        [XmlAttribute("AddrType")]
        public string AddrType { get; set; }

        [XmlAttribute("AddrLength")]
        public string AddrLength { get; set; }
    }
}
