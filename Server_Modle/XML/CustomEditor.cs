using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Modle.XML
{
    public class CustomEditor : CollectionEditor
    {
        public CustomEditor(Type type)
            : base(type)
        {
        }
    }
}
