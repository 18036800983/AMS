using DevComponents.DotNetBar;
using OxyPlot.WindowsForms;
using Server_BLL;
using Server_Tools;
using Server_Tools.Chart;
using Server_Tools.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_Server.FormTool
{
    public partial class ReportAnalysisForm : Office2007Form
    {
        public ReportAnalysisForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportAnalysisForm_Load(object sender, EventArgs e)
        {
            Language_translation();
            sideNavItem3_Click(null,null);
            Start_dateTimePicker.Value = DateTime.Now.AddDays(-3);
        }

        /// <summary>
        /// 导出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Export_button_Click(object sender, EventArgs e)
        {
            try
            {
                var path = this.GetFilename(".png files|*.png", ".png");
                if (path != null)
                {
                    PngExporter.Export(plotView1.Model, path, 800, 500, Brushes.White);
                    OpenContainingFolder(path);
                }
            }
            catch (Exception)
            {
            }
        }


        /// <summary>
        /// 绘制图形
        /// </summary>
        /// <param name="addItem"></param>
        private void refreshChart(bool addItem = false)
        {
            try
            {
                if (Type_comboBoxEx.SelectedItem == null) return;

                var beginTime = long.Parse((Start_dateTimePicker.Value.Date).ToString("yyMMdd") + "000000");
                var endTime = long.Parse((End_dateTimePicker.Value.Date).ToString("yyMMdd") + "235959");
                var strCondition = " DT_INT between " + beginTime + " and " + endTime;

                var type = ((ComboBoxItem)Type_comboBoxEx.SelectedItem).Tag.ToString();
                var subtitle = Start_dateTimePicker.Value.ToString("yyyy/MM/dd") + " - " + End_dateTimePicker.Value.ToString("yyyy/MM/dd");
                var dataSouce = Line_StationAlarm_Bll.Get(strCondition);
                List<string> itemSouce = new List<string>();
                if(XML_Tool.xml.SysConfig.IsChinese)
                    itemSouce.Add("全部");
                else
                    itemSouce.Add("ALL");
                switch (type)
                {
                    case "Type":
                        itemSouce.AddRange(dataSouce.Select(n => n.Type).Distinct().ToList());
                        break;
                    case "Station":
                        itemSouce.AddRange(dataSouce.Select(n => n.Station).Distinct().ToList());
                        break;
                    case "Describtion":
                        itemSouce.AddRange(dataSouce.Select(n => n.Describtion).Distinct().ToList());
                        break;
                }
                if (addItem)
                {
                    Sinton__comboBoxEx.DataSource = itemSouce;
                }
                else
                    switch (Buttom_superTabStrip.SelectedTab.Text)
                    {
                        case "饼状图":
                            plotView1.Model = PieChart.CreateModel(dataSouce, subtitle, type);
                            plotView1.Controller = PieChart.CreateController();
                            Sinton__comboBoxEx.Visible = false;
                            Sinton_label.Visible = false;
                            break;
                        case "柱形图":
                            plotView1.Model = ColumnChart.CreateModel(dataSouce, subtitle, type, Sinton__comboBoxEx.Text);
                            plotView1.Controller = PieChart.CreateController();
                            Sinton__comboBoxEx.Visible = true;
                            Sinton_label.Visible = true;
                            break;
                        case "折线图":
                            plotView1.Model = LineChart.CreateModel(dataSouce, subtitle, type, Sinton__comboBoxEx.Text);
                            plotView1.Controller = PieChart.CreateController();
                            Sinton__comboBoxEx.Visible = true;
                            Sinton_label.Visible = true;
                            break;
                        case "pie chart":
                            plotView1.Model = PieChart.CreateModel(dataSouce, subtitle, type);
                            plotView1.Controller = PieChart.CreateController();
                            Sinton__comboBoxEx.Visible = false;
                            Sinton_label.Visible = false;
                            break;
                        case "column chart":
                            plotView1.Model = ColumnChart.CreateModel(dataSouce, subtitle, type, Sinton__comboBoxEx.Text);
                            plotView1.Controller = PieChart.CreateController();
                            Sinton__comboBoxEx.Visible = true;
                            Sinton_label.Visible = true;
                            break;
                        case "line chart":
                            plotView1.Model = LineChart.CreateModel(dataSouce, subtitle, type, Sinton__comboBoxEx.Text);
                            plotView1.Controller = PieChart.CreateController();
                            Sinton__comboBoxEx.Visible = true;
                            Sinton_label.Visible = true;
                            break;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 类型初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideNavItem3_Click(object sender, EventArgs e)
        {
            if (XML_Tool.xml.SysConfig.IsChinese)
            {
                ComboBoxItem[] array3 = new ComboBoxItem[3]
                {
                    new ComboBoxItem() {Text= "类型",Tag="Type" },
                    new ComboBoxItem() {Text= "站名",Tag="Station" },
                    new ComboBoxItem() {Text= "描述",Tag="Describtion" }
                };
                Type_comboBoxEx.DataSource = array3;
            }
            else
            {
                ComboBoxItem[] array3 = new ComboBoxItem[3]
                {
                    new ComboBoxItem() {Text= "Type",Tag="Type" },
                    new ComboBoxItem() {Text= "Station",Tag="Station" },
                    new ComboBoxItem() {Text= "Describtion",Tag="Describtion" }
                };
                Type_comboBoxEx.DataSource = array3;
            }
        }

        /// <summary>
        /// 饼状，柱形，折线图切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Buttom_superTabStrip_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            refreshChart();
        }

        /// <summary>
        /// 开始，结束时间变化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePicker_ValueChanged(Object sender, EventArgs e)
        {
            refreshChart();
        }

        /// <summary>
        /// 类别下拉框切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Type_comboBoxEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshChart(true);
        }

        /// <summary>
        /// 单项下拉框切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sinton__comboBoxEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshChart();
        }

        public string GetFilename(string filter, string defaultExt)
        {
            var dlg = new SaveFileDialog { Filter = filter, DefaultExt = defaultExt };
            return dlg.ShowDialog() == DialogResult.OK ? dlg.FileName : null;
        }

        public void OpenContainingFolder(string fileName)
        {
            // var folder = Path.GetDirectoryName(fileName);
            var psi = new ProcessStartInfo("Explorer.exe", "/select," + fileName);
            Process.Start(psi);
        }

        /// <summary>
        /// translation
        /// </summary>
        public void Language_translation()
        {
            if (XML_Tool.xml.SysConfig.IsChinese)
            {
                #region Text
                this.Text = Chinese.ReportAnalysisForm_Top_title;
                StartTime_label.Text = Chinese.ReportAnalysisForm_Label_starttime;
                EndTime_label.Text = Chinese.ReportAnalysisForm_Label_endtime;
                Type_label.Text = Chinese.ReportAnalysisForm_Label_type;
                Sinton_label.Text = Chinese.ReportAnalysisForm_Label_singleitem;
                Export_button.Text = Chinese.ReportAnalysisForm_Button_export;
                PieChart_superTabItem.Text = Chinese.ReportAnalysisForm_Label_pie;
                Histogram_superTabItem.Text = Chinese.ReportAnalysisForm_Label_Cylindrical;
                LineChart_superTabItem.Text = Chinese.ReportAnalysisForm_Label_line;
                #endregion
            }
            else
            {
                #region text
                this.Text = English.ReportAnalysisForm_Top_title;
                StartTime_label.Text = English.ReportAnalysisForm_Label_starttime;
                EndTime_label.Text = English.ReportAnalysisForm_Label_endtime;
                Type_label.Text = English.ReportAnalysisForm_Label_type;
                Sinton_label.Text = English.ReportAnalysisForm_Label_singleitem;
                Export_button.Text = English.ReportAnalysisForm_Button_export;
                PieChart_superTabItem.Text = English.ReportAnalysisForm_Label_pie;
                Histogram_superTabItem.Text = English.ReportAnalysisForm_Label_Cylindrical;
                LineChart_superTabItem.Text = English.ReportAnalysisForm_Label_line;
                #endregion
            }
        }
    }
}
