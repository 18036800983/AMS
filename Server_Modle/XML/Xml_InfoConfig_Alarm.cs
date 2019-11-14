using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Server_Modle.XML
{
    public class Xml_InfoConfig_Alarm
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("addr"), OPCAddress("addr")]
        public string Addr { get; set; }

        [XmlAttribute("backaddr"), OPCAddress("backaddr")]
        public string Backaddr { get; set; }

        [XmlAttribute("AddrType")]
        public string AddrType { get; set; }
    }
}
