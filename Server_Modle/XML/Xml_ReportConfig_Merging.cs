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
    [XmlRoot("merging"),
       CollectionFormInfo("报表配置", 600, 500)]
    public class Xml_ReportConfig_Merging
    {
        [XmlAttribute("Name"),
                 //Category(""),
                 DisplayName("名称"),
                 Description("名称"),
                 //DefaultValue(""),
                 Browsable(true),
                 ReadOnly(false)]
        public string Name { get; set; } = "Merging";

        [XmlAttribute("StartDisplayIndex"),
         //Category(""),
         DisplayName("开始索引"),
         Description("开始索引"),
         //DefaultValue(""),
         Browsable(true),
         ReadOnly(false)]
        public int StartDisplayIndex { get; set; }

        [XmlAttribute("EndDisplayIndex"),
         //Category(""),
         DisplayName("结束索引"),
         Description("结束索引"),
         //DefaultValue(""),
         Browsable(true),
         ReadOnly(false)]
        public int EndDisplayIndex { get; set; }

        [XmlElement("merging"), TypeConverter(typeof(ListConverter)),
        //Category(""),
        DisplayName("子合并列"),
        Description("子合并列"),
        Editor(typeof(CustomEditor), typeof(UITypeEditor))]
        public List<Xml_ReportConfig_Merging> merging { get; set; } = new List<Xml_ReportConfig_Merging>();
    }
}
