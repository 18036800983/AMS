using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using Server_Tools;
using Server_Tools.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_Server.FormTool
{
    public partial class LogManagerForm : Office2007Form
    {
        string fileName;
        public LogManagerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogManagerForm_Load(object sender, EventArgs e)
        {
            Language_translation();
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath + "//Log");
            FileInfo[] fis = di.GetFiles("*.log", SearchOption.TopDirectoryOnly);
            log_date_advTree.Nodes[0].Nodes.AddRange(fis
                .OrderByDescending(n => n.LastWriteTime)
                .Select(n => new DevComponents.AdvTree.Node(n.Name))
                .ToArray());
            log_date_advTree.SelectedNode = log_date_advTree.Nodes[0].Nodes[0];
        }

        /// <summary>
        /// select button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void log_select_button_Click(object sender, EventArgs e)
        {
            if (log_date_advTree.SelectedNode != null && log_date_advTree.SelectedNode.Level == 1)
            {
                log_date_advTree_AfterNodeSelect(null, new AdvTreeNodeEventArgs(eTreeAction.Mouse, log_date_advTree.SelectedNode));
            }
        }

        /// <summary>
        /// out put button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void log_outPut_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                directoryCopy(Application.StartupPath + "//log", fbd.SelectedPath + "//LogBackup"
                    + DateTime.Now.ToString("yyMMddHHmmss"));
                if (XML_Tool.xml.SysConfig.IsChinese)
                    MessageBox.Show("导出成功!");
                else
                    MessageBox.Show("export success!");
            }
        }

        private void directoryCopy(string sourceDirectory, string targetDirectory)
        {
            if (!Directory.Exists(sourceDirectory))
            {
                return;
            }
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }
            DirectoryInfo sourceInfo = new DirectoryInfo(sourceDirectory);
            FileInfo[] fileInfo = sourceInfo.GetFiles();
            foreach (FileInfo fiTemp in fileInfo)
            {
                File.Copy(sourceDirectory + "\\" + fiTemp.Name, targetDirectory + "\\" + fiTemp.Name, true);
            }
            DirectoryInfo[] diInfo = sourceInfo.GetDirectories();
            foreach (DirectoryInfo diTemp in diInfo)
            {
                string sourcePath = diTemp.FullName;
                string targetPath = diTemp.FullName.Replace(sourceDirectory, targetDirectory);
                Directory.CreateDirectory(targetPath);
                directoryCopy(sourcePath, targetPath);
            }
        }

        private Log analyzeLine(string line)
        {
            Log log_ = new Log();
            string time, level, type,message;
            int timeLocation = line.IndexOf("时间：");
            int levelLocation = line.IndexOf("位置：");
            int typeLocation = line.IndexOf("类型：");
            int messageLocation = line.IndexOf("信息：");
            if (timeLocation == 0)
            {
                time = line.Substring(3, levelLocation - 4).Replace(',', '.');
                level = line.Substring(levelLocation + 3, typeLocation - levelLocation - 3).Trim();
                type = line.Substring(typeLocation + 3, messageLocation - typeLocation - 3).Trim();

                log_.Time = time;
                if (string.IsNullOrEmpty(level))
                    log_.Position = "system";
                else
                    log_.Position = level;
                log_.Type = type;
                message = line.Substring(messageLocation + 3);
                log_.Message = message;
            }
            else
            {
                if (!log_condition_checkBox.Checked && !log_timer_checkBox.Checked)
                {
                    log_.Time = string.Empty;
                    log_.Position = "UNKNOW";
                    log_.Type = string.Empty;
                    log_.Message = line;
                }
                else
                {
                    return null;
                }
            }
            return log_;
        }

        class Log
        {
            public string Time { get; set; }
            public string Position { get; set; }
            public string Type { get; set; }
            public string Message { get; set; }
        }

        private void log_date_advTree_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            try
            {
                if (e.Node.Level == 1)
                {
                    Stopwatch st = new Stopwatch();
                    st.Start();;
                    fileName = e.Node.Text;
                    FileStream fs = new FileStream(Application.StartupPath + "//Log//" + fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    StreamReader sr = new StreamReader(fs, Encoding.Default);
                    String line;
                    TimeSpan beginTime = log_beginTime_dateTimePicker.Value.TimeOfDay;
                    TimeSpan endTime = log_endTime_dateTimePicker.Value.TimeOfDay;

                    DataTable myTable = new DataTable();
                    myTable.Columns.Add("Time");
                    myTable.Columns.Add("Type");
                    myTable.Columns.Add("Message");

                    List<Log> list = new List<Log>();
                    while ((line = sr.ReadLine()) != null)
                    {
                        var log = analyzeLine(line);
                        if (log != null) list.Add(log);
                    }
                    var s = list
                        .Where(n => !log_condition_checkBox.Checked || n.Message.Contains(log_condition_textBox.Text))
                        .Where(n => !log_timer_checkBox.Checked || (Convert.ToDateTime(n.Time).TimeOfDay > beginTime &&
                        Convert.ToDateTime(n.Time).TimeOfDay < endTime)).Reverse().ToList();
                    log_detail_superGridControl.PrimaryGrid.DataSource = s.Count() > 0 ? s : null;
                    st.Stop();
                }
            }
            catch (Exception ex)
            {
                if (XML_Tool.xml.SysConfig.IsChinese)
                    MessageBox.Show("日志显示出现异常：" + ex.Message);
                else
                    MessageBox.Show("log display occur exception:" + ex.Message);
            }
        }

        /// <summary>
        /// translation
        /// </summary>
        public void Language_translation()
        {
            if (XML_Tool.xml.SysConfig.IsChinese)
            {
                #region Text
                this.Text = Chinese.LogManagerForm_Top_title;
                log_timer_checkBox.Text = Chinese.LogManagerForm_Condition_time;
                log_condition_checkBox.Text = Chinese.LogManagerForm_Condition_others;
                log_select_button.Text = Chinese.LogManagerForm_Button_select;
                log_outPut_button.Text = Chinese.LogManagerForm_Button_exput;
                node1.Text = Chinese.LogManagerForm_Tree_node;
                #endregion
            }
            else
            {
                #region text
                this.Text = English.LogManagerForm_Top_title;
                log_timer_checkBox.Text = English.LogManagerForm_Condition_time;
                log_condition_checkBox.Text = English.LogManagerForm_Condition_others;
                log_select_button.Text = English.LogManagerForm_Button_select;
                log_outPut_button.Text = English.LogManagerForm_Button_exput;
                node1.Text = English.LogManagerForm_Tree_node;
                #endregion
            }
        }
    }
}
