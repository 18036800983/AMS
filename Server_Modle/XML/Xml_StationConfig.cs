using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Server_Modle.XML
{
    [XmlRoot("station"), CollectionFormInfo("工位配置", 500, 500)]
    public class Xml_StationConfig
    {
        [XmlAttribute("Name"),
         DisplayName("名称"),
         Description("名称"),
         Browsable(true),
         ReadOnly(false)]
        public string Name { get; set; }

        [XmlAttribute("Index"),
         DisplayName("工位顺序"),
         Description("工位顺序"),
         Browsable(true),
         ReadOnly(false)]
        public int Index { get; set; }

        [XmlAttribute("IsShield"),
         DisplayName("工位是否屏蔽"),
         Description("工位是否屏蔽"),
         Browsable(true),
         ReadOnly(false)]
        public string IsShield { get; set; }

        [XmlAttribute("IsEnd"),
         DisplayName("工位是否尾站"),
         Description("工位是否尾站"),
         Browsable(true),
         ReadOnly(false)]
        public string IsEnd { get; set; }

        [XmlAttribute("IsOutLine"),
         DisplayName("工位是否线外站"),
         Description("工位是否线外站"),
         Browsable(true),
         ReadOnly(false)]
        public string IsOutLine { get; set; }
    }
}
