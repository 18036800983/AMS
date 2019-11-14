using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.Chart
{
    public class Line_StationAlarm_Model
    {
        public long ID { get; set; }
        public long DT_INT { get; set; }
        public DateTime DT { get; set; }
        public long RecipeID { get; set; }
        public string DBAddress { get; set; }
        public string Station { get; set; }
        public string Type { get; set; }
        public string Describtion { get; set; }
    }
}
