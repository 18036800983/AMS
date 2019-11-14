using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using MyExcel;
using Server_BLL;
using Server_Modle.XML;
using Server_Tools;
using Server_Tools.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_Server.FormTool
{
    public partial class ReportManagerForm : Office2007Form
    {
        GridPanel dgv;
        DataTable dtt;
        int totalPages;
        int page_;
        int sizePage;           //分页大小
        string showColumn; //需要得到的字段 (即 column1,column2,......)
        string tabName;                                    //需要查看的表名 (即 from table_name)
        string strCondition;                               //查询条件 (即 where condition......) 不用加where关键字
        string ascColumn = "id";                                  //排序的字段名 (即 order by column asc/desc)
        int bitOrderType = 1;                                    //排序的类型 (0为升序,1为降序)
        string pkColumn = "id";                                   //主键名称
        string tablistName = string.Empty;  //当前选定报表名称
        Report_Bll report_Bll = new Report_Bll();
        public ReportManagerForm()
        {
            InitializeComponent();
        }

        int page//当前页页码
        {
            get
            {
                page_ = int.Parse(tstCurrentPage.Text);
                if (page_ == 1)
                {
                    tsbStart.Enabled = false;
                    tsbPreview.Enabled = false;
                    tsbNext.Enabled = true;
                    tsbEnd.Enabled = true;
                }
                else if (page_ == totalPages)
                {
                    tsbNext.Enabled = false;
                    tsbEnd.Enabled = false;
                    tsbStart.Enabled = true;
                    tsbPreview.Enabled = true;
                }
                else
                {
                    tsbStart.Enabled = true;
                    tsbPreview.Enabled = true;
                    tsbNext.Enabled = true;
                    tsbEnd.Enabled = true;
                }
                return page_;
            }
            set
            {
                page_ = value;
                tstCurrentPage.Text = page_.ToString();
            }
        }


        /// <summary>
        /// page load 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportManagerForm_Load(object sender, EventArgs e)
        {
            Language_translation();
            tbsQueryList.Tabs.Clear();
            tbsQueryList.Tabs.AddRange(XML_Tool.xml.Report.Select(n => new SuperTabItem() { Text = n.Name }).ToArray());
            start_day_dateTimePicker.Value = DateTime.Now.AddDays(-1);
            show_superGridControl.PrimaryGrid.UseAlternateRowStyle = true;
            show_superGridControl.PrimaryGrid.UseAlternateColumnStyle = false;
        }

        /// <summary>
        /// move first page button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbStart_Click(object sender, EventArgs e)
        {
            page = 1;
            gettable();
        }

        /// <summary>
        /// move previous record button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbPreview_Click(object sender, EventArgs e)
        {
            if (page != 1)
            {
                page--;
                gettable();
            }
        }

        /// <summary>
        /// move next record button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNext_Click(object sender, EventArgs e)
        {
            if (page != totalPages)
            {
                page++;
                gettable();
            }
        }

        /// <summary>
        /// move last page button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbEnd_Click(object sender, EventArgs e)
        {
            page = totalPages;
            gettable();
        }

        /// <summary>
        /// select button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void select_button_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                page = 1;
                strCondition = getCondition();

                if (strCondition != string.Empty)
                {
                    sizePage = -1;
                    totalPages = 1;
                }
                else
                {
                    sizePage = iptCount.Value;
                    sql = "select count(1) from " + tabName;
                    int a = report_Bll.GetTableCount(tabName);

                    if (a % sizePage != 0)
                    {
                        totalPages = a / sizePage + 1;
                    }
                    else
                    {
                        totalPages = a / sizePage;
                    }
                }
                tslTotalPages.Text = "/" + totalPages.ToString();

                gettable();
            }
            catch (Exception ex)
            {
                if (XML_Tool.xml.SysConfig.IsChinese)
                    MessageBox.Show("报表出现异常：" + ex.Message);
                else
                    MessageBox.Show("report select occur exception:" + ex.Message);
            }
        }

        /// <summary>
        /// export button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void export_button_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog frm = new SaveFileDialog();
                frm.FileName = DateTime.Now.ToString("yyyyMMddHHmm");
                frm.Filter = "excel文件(*.xls)|*.xlsx|所有文件(*.*)|*.*";
                if (DialogResult.OK == frm.ShowDialog())
                {
                    string strFileName = frm.FileName;
                    ExcelHelper execl = new ExcelHelper(strFileName);
                    if (execl.DataTableToExcel(dtt, "Report", true) > 0)
                    {
                        if (XML_Tool.xml.SysConfig.IsChinese)
                            MessageBoxEx.Show("报表EXCEL导出成功！");
                        else
                            MessageBoxEx.Show("report excel export success！");
                    }
                    else
                    {
                        if (XML_Tool.xml.SysConfig.IsChinese)
                            MessageBoxEx.Show("报表EXCEL导出失败！");
                        else
                            MessageBoxEx.Show("report excel export failed！");
                    }
                    execl.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (XML_Tool.xml.SysConfig.IsChinese)
                    MessageBoxEx.Show("报表EXCEL导出出现异常：" + ex.Message);
                else
                    MessageBoxEx.Show("report excel export occur exception:" + ex.Message);
            }
        }

        private void gettable()
        {
            var dt = report_Bll.Get(page, sizePage, showColumn, tabName, strCondition, ascColumn, bitOrderType, pkColumn);
            if (dtt != null) dtt.Clear();
            dtt = dt.Copy();
            BindingSource source = new BindingSource();
            source.DataSource = dt;
            dgv.DataSource = source;
            count_label.Text = dt.Rows.Count.ToString();
        }

        private string getCondition()
        {
            string strCondition = "";
            DateTime beginTime = start_day_dateTimePicker.Value.Date + start_time_dateTimePicker.Value.TimeOfDay;
            DateTime endTime = end_day_dateTimePicker.Value.Date + end_time_dateTimePicker.Value.TimeOfDay;
            if (chkTime.Checked)
            {
                strCondition += " and SaveTime between '" + beginTime + "'" + " and '" + endTime + "'";
            }
            if (chkCode.Checked)
            {
                strCondition += " and SN like '%" + txtStation.Text + "%'";
            }
            if (ckStation.Checked)
            {
                strCondition += " and Station like '" + txtStation.Text + "%'";
            }
            if (strCondition.Length > 4)
            {
                strCondition = strCondition.Substring(4);
            }
            return strCondition;
        }

        /// <summary>
        /// current page event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tstCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                gettable();
            }
        }

        /// <summary>
        /// set column style
        /// </summary>
        /// <param name="chc"></param>
        /// <param name="merging"></param>
        private void SetColumnGroupHeader(ColumnGroupHeaderCollection chc, List<Xml_ReportConfig_Merging> merging)
        {
            if (merging.Count == 0) return;
            foreach (var me in merging)
            {
                DevComponents.DotNetBar.SuperGrid.ColumnGroupHeader cgh = new DevComponents.DotNetBar.SuperGrid.ColumnGroupHeader();
                cgh.Name = me.Name;
                cgh.HeaderText = me.Name;
                cgh.MinRowHeight = 20;
                cgh.StartDisplayIndex = me.StartDisplayIndex;
                cgh.EndDisplayIndex = me.EndDisplayIndex;
                chc.Add(cgh);
                SetColumnGroupHeader(cgh.GroupHeaders, me.merging);
            }
        }

        /// <summary>
        /// select tab changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbsQueryList_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            var table = XML_Tool.xml.Report.Single(n => n.Name == e.NewValue.Text);
            //comboBox1.DataSource = table.column.Where(n => n.enableSearch).Select(n => n.Name).ToList();
            tabName = table.DataName;
            showColumn = string.Empty;
            show_superGridControl.PrimaryGrid.ColumnAutoSizeMode = (ColumnAutoSizeMode)(int)table.ColumnAutoSizeMode;
            show_superGridControl.PrimaryGrid.Columns.Clear();
            show_superGridControl.PrimaryGrid.DetachDataSource(false);
            show_superGridControl.PrimaryGrid.ColumnHeader.GroupHeaders.Clear();

            foreach (var co in table.column.OrderBy(n => n.DisplayIndex))
            {
                GridColumn Column;
                Column = new GridColumn()
                {
                    HeaderText = co.Name,
                    FillWeight = co.width,
                    Width = co.width,
                    DataPropertyName = co.dataName,
                    FilterAutoScan = co.autoFilter,
                    DisplayIndex = co.DisplayIndex,
                    ReadOnly = true
                };
                if (co.isDatetime)
                {
                    Column.EditorType = typeof(GridDateTimeInputEditControl);
                    var createTimeColumnRenderControl = (GridDateTimeInputEditControl)Column.RenderControl;
                    //设置 format 为自定义
                    createTimeColumnRenderControl.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
                    //设置自定义格式            
                    createTimeColumnRenderControl.CustomFormat = "yyyy-MM-dd HH:mm:ss fff";
                }
                show_superGridControl.PrimaryGrid.Columns.Add(Column);
                showColumn += "[" + co.dataName + "]" + ",";
            }
            SetColumnGroupHeader(show_superGridControl.PrimaryGrid.ColumnHeader.GroupHeaders, table.merging);
            showColumn = showColumn.TrimEnd(',');
            dgv = show_superGridControl.PrimaryGrid;
            tablistName = e.NewValue.Text;
            select_button_Click(null, null);
        }

        /// <summary>
        /// translation
        /// </summary>
        public void Language_translation()
        {
            if (XML_Tool.xml.SysConfig.IsChinese)
            {
                #region Text
                this.Text = Chinese.ReportManagerForm_Top_title;
                select_count_label.Text = Chinese.ReportManagerForm_Label_count;
                chkTime.Text = Chinese.ReportManagerForm_Condition_time;
                chkCode.Text = Chinese.ReportManagerForm_Condition_serialN0;
                txtCode.Text = Chinese.ReportManagerForm_serialN0_tip;
                ckStation.Text = Chinese.ReportManagerForm_Condition_station;
                txtStation.Text = Chinese.ReportManagerForm_station_tip;
                select_button.Text = Chinese.ReportManagerForm_Button_select;
                export_button.Text = Chinese.ReportManagerForm_Button_exput;
                show_superGridControl.PrimaryGrid.GroupByRow.WatermarkText = Chinese.ReportManagerForm_Table_tip;
                #endregion
            }
            else
            {
                #region text
                this.Text = English.ReportManagerForm_Top_title;
                select_count_label.Text = English.ReportManagerForm_Label_count;
                chkTime.Text = English.ReportManagerForm_Condition_time;
                chkCode.Text = English.ReportManagerForm_Condition_serialN0;
                txtCode.Text = English.ReportManagerForm_serialN0_tip;
                ckStation.Text = English.ReportManagerForm_Condition_station;
                txtStation.Text = English.ReportManagerForm_station_tip;
                select_button.Text = English.ReportManagerForm_Button_select;
                export_button.Text = English.ReportManagerForm_Button_exput;
                show_superGridControl.PrimaryGrid.GroupByRow.WatermarkText = English.ReportManagerForm_Table_tip;
                #endregion
            }
        }
    }
}
