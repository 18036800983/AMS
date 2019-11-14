using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using TabItem = DevComponents.DotNetBar.TabItem;

namespace AMS_Server.FormCustomize
{
    public partial class RecordBox : UserControl
    {
        Dictionary<string, TabItem> lineTabItem = new Dictionary<string, TabItem>();
        public RecordBox()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void SetStatusEvent(string name, int index)
        {
            ((TabItem)lineTabItem[name]).ImageIndex = index;
        }
    }
}
