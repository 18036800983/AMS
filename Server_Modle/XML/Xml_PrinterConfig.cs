using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Server_Modle.XML
{
    [XmlRoot("PrinterConfig")]
    public class Xml_PrinterConfig
    {
        [XmlElement("IP")]
        public string IP { get; set; }

        [XmlElement("PORT")]
        public string PORT { get; set; }

        [XmlElement("ZPLCODE"), TypeConverter(typeof(ArrayConverter)),
         DisplayName("ZPLCODE"),
         Description("ZPLCODE"),
         Browsable(true),
         ReadOnly(false)]
        public string ZPLCODE { get; set; }

        [XmlElement("Enable")]
        public bool Enable { get; set; }
    }
}
