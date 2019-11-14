using DevComponents.DotNetBar;
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

namespace AMS_Server.FormStation
{
    public partial class StationManageForm : Office2007Form
    {
        public StationManageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StationManageForm_Load(object sender, EventArgs e)
        {
            try
            {
                PageFrush();
                Language_translation();
            }
            catch (Exception ex)
            {
                if (XML_Tool.xml.SysConfig.IsChinese)
                    MessageBoxEx.Show("工位管理界面加载出现异常：" + ex.Message);
                else
                    MessageBoxEx.Show("Station management interface loading exception：" + ex.Message);
            }
        }

        /// <summary>
        /// save button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void station_save_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(station_name_comboBox.Text) && !string.IsNullOrEmpty(station_index_textBox.Text))
            {
                if (station_name_comboBox.Items.Contains(station_name_comboBox.Text))
                {
                    #region modify
                    foreach (var st in XML_Tool.xml.StationConfig)
                    {
                        if (st.Name == station_name_comboBox.Text)
                        {
                            st.Index = int.Parse(station_index_textBox.Text);
                            if (station_isShield_checkBox.CheckState == CheckState.Checked)
                            {
                                st.IsShield = "1";
                            }
                            else
                            {
                                st.IsShield = "0";
                            }
                            if (station_isEnd_checkBox.CheckState == CheckState.Checked)
                            {
                                st.IsEnd = "1";
                            }
                            else
                            {
                                st.IsEnd = "0";
                            }
                            if (station_isOutLine_checkBox.CheckState == CheckState.Checked)
                            {
                                st.IsOutLine = "1";
                            }
                            else
                            {
                                st.IsOutLine = "0";
                            }
                            XML_Tool.Save();
                            if (XML_Tool.xml.SysConfig.IsChinese)
                                MessageBoxEx.Show("工位配置修改成功！");
                            else
                                MessageBoxEx.Show("Station configuration modified successfully！");
                            PageFrush();
                        }
                    }
                    #endregion
                }
                else
                {
                    Xml_StationConfig stationCon = new Xml_StationConfig
                    {
                        Name = station_name_comboBox.Text,
                        Index = int.Parse(station_index_textBox.Text)
                    };
                    if (station_isShield_checkBox.CheckState == CheckState.Checked)
                    {
                        stationCon.IsShield = "1";
                    }
                    else
                    {
                        stationCon.IsShield = "0";
                    }
                    if (station_isEnd_checkBox.CheckState == CheckState.Checked)
                    {
                        stationCon.IsEnd = "1";
                    }
                    else
                    {
                        stationCon.IsEnd = "0";
                    }
                    if (station_isOutLine_checkBox.CheckState == CheckState.Checked)
                    {
                        stationCon.IsOutLine = "1";
                    }
                    else
                    {
                        stationCon.IsOutLine = "0";
                    }
                    XML_Tool.xml.StationConfig.Add(stationCon);
                    XML_Tool.Save();
                    if (XML_Tool.xml.SysConfig.IsChinese)
                        MessageBoxEx.Show("工位配置添加成功！");
                    else
                        MessageBoxEx.Show("Station configuration added successfully！");
                    PageFrush();
                }
            }
                    
        }

        /// <summary>
        /// delete button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void station_delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(station_name_comboBox.Text) && !string.IsNullOrEmpty(station_index_textBox.Text)
                    && station_name_comboBox.Items.Contains(station_name_comboBox.Text))
                {
                    XML_Tool.xml.StationConfig.RemoveAt(int.Parse(station_index_textBox.Text) - 1);
                    if (XML_Tool.xml.SysConfig.IsChinese)
                        MessageBoxEx.Show("工位删除成功！");
                    else
                        MessageBoxEx.Show("Station deleted successfully！");
                    PageFrush();
                }
                else
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                        MessageBoxEx.Show("删除失败，参数不能为空！");
                    else
                        MessageBoxEx.Show("Delete failed, parameter cannot be empty！");
                }
            }
            catch (Exception ex)
            {
                if (XML_Tool.xml.SysConfig.IsChinese)
                    MessageBoxEx.Show("工位管理删除按钮点击事件出现异常：" + ex.Message);
                else
                    MessageBoxEx.Show("Station management delete button click event exception：" + ex.Message);
            }
        }

        /// <summary>
        /// cancel button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void station_cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                station_name_comboBox.Text = "";
                station_index_textBox.Text = "";
                station_isShield_checkBox.CheckState = CheckState.Unchecked;
                station_isEnd_checkBox.CheckState = CheckState.Unchecked;
                station_isOutLine_checkBox.CheckState = CheckState.Unchecked;
            }
            catch (Exception ex)
            {
                if (XML_Tool.xml.SysConfig.IsChinese)
                    MessageBoxEx.Show("工位管理取消按钮点击事件出现异常：" + ex.Message);
                else
                    MessageBoxEx.Show("Station management cancel button click event exception：" + ex.Message);
            }
        }

        /// <summary>
        /// page frush
        /// </summary>
        public void PageFrush()
        {
            station_name_comboBox.Items.Clear();

            DataTable dt = new DataTable();
            if (XML_Tool.xml.SysConfig.IsChinese)
            {
                dt.Columns.Add("工位名称");
                dt.Columns.Add("工位顺序");
                dt.Columns.Add("是否屏蔽");
                dt.Columns.Add("是否尾站");
                dt.Columns.Add("是否线外站");

                foreach (var st in XML_Tool.xml.StationConfig)
                {
                    station_name_comboBox.Items.Add(st.Name);

                    DataRow drow = dt.NewRow();
                    drow["工位名称"] = st.Name;
                    drow["工位顺序"] = st.Index;
                    drow["是否屏蔽"] = st.IsShield;
                    drow["是否尾站"] = st.IsEnd;
                    drow["是否线外站"] = st.IsOutLine;
                    dt.Rows.Add(drow);
                }
            }
            else
            {
                dt.Columns.Add("Station Name");
                dt.Columns.Add("Station Order");
                dt.Columns.Add("Whether to block");
                dt.Columns.Add("Whether the tail station");
                dt.Columns.Add("Whether the outline station");

                foreach (var st in XML_Tool.xml.StationConfig)
                {
                    station_name_comboBox.Items.Add(st.Name);

                    DataRow drow = dt.NewRow();
                    drow["Station Name"] = st.Name;
                    drow["Station Order"] = st.Index;
                    drow["Whether to block"] = st.IsShield;
                    drow["Whether the tail station"] = st.IsEnd;
                    drow["Whether the outline station"] = st.IsOutLine;
                    dt.Rows.Add(drow);
                }
            }
            station_show_dataGridView.DataSource = dt;
        }

        /// <summary>
        /// data girl view event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void station_show_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    station_name_comboBox.Text = station_show_dataGridView.CurrentRow.Cells["工位名称"].Value.ToString();
                    station_index_textBox.Text = station_show_dataGridView.CurrentRow.Cells["工位顺序"].Value.ToString();
                    if (station_show_dataGridView.CurrentRow.Cells["是否屏蔽"].Value.ToString() == "1")
                        station_isShield_checkBox.CheckState = CheckState.Checked;
                    else
                        station_isShield_checkBox.CheckState = CheckState.Unchecked;
                    if (station_show_dataGridView.CurrentRow.Cells["是否尾站"].Value.ToString() == "1")
                        station_isEnd_checkBox.CheckState = CheckState.Checked;
                    else
                        station_isEnd_checkBox.CheckState = CheckState.Unchecked;
                    if (station_show_dataGridView.CurrentRow.Cells["是否线外站"].Value.ToString() == "1")
                        station_isOutLine_checkBox.CheckState = CheckState.Checked;
                    else
                        station_isOutLine_checkBox.CheckState = CheckState.Unchecked;
                }
                else
                {
                    station_name_comboBox.Text = station_show_dataGridView.CurrentRow.Cells["Station Name"].Value.ToString();
                    station_index_textBox.Text = station_show_dataGridView.CurrentRow.Cells["Station Order"].Value.ToString();
                    if (station_show_dataGridView.CurrentRow.Cells["Whether to block"].Value.ToString() == "1")
                        station_isShield_checkBox.CheckState = CheckState.Checked;
                    else
                        station_isShield_checkBox.CheckState = CheckState.Unchecked;
                    if (station_show_dataGridView.CurrentRow.Cells["Whether the tail station"].Value.ToString() == "1")
                        station_isEnd_checkBox.CheckState = CheckState.Checked;
                    else
                        station_isEnd_checkBox.CheckState = CheckState.Unchecked;
                    if (station_show_dataGridView.CurrentRow.Cells["Whether the outline station"].Value.ToString() == "1")
                        station_isOutLine_checkBox.CheckState = CheckState.Checked;
                    else
                        station_isOutLine_checkBox.CheckState = CheckState.Unchecked;
                }
            }
            catch (Exception ex)
            {
                if (XML_Tool.xml.SysConfig.IsChinese)
                    MessageBoxEx.Show("工位表格点击事件出现异常：" + ex.Message);
                else
                    MessageBoxEx.Show("Station table click event exception：" + ex.Message);
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
                this.Text = Chinese.StationManageForm_Top_title;
                station_name_label.Text = Chinese.StationManageForm_Label_stationName;
                station_index_label.Text = Chinese.StationManageForm_Label_stationOrder;
                station_isShield_checkBox.Text = Chinese.StationManageForm_Label_isPass;
                station_isEnd_checkBox.Text = Chinese.StationManageForm_Label_isEndStation;
                station_isOutLine_checkBox.Text = Chinese.StationManageForm_Label_isOutLineStation;
                station_save_button.Text = Chinese.StationManageForm_Button_save;
                station_delete_button.Text = Chinese.StationManageForm_Button_delete;
                station_cancel_button.Text = Chinese.StationManageForm_Button_cancel;
                #endregion
            }
            else
            {
                #region text
                this.Text = English.StationManageForm_Top_title;
                station_name_label.Text = English.StationManageForm_Label_stationName;
                station_index_label.Text = English.StationManageForm_Label_stationOrder;
                station_isShield_checkBox.Text = English.StationManageForm_Label_isPass;
                station_isEnd_checkBox.Text = English.StationManageForm_Label_isEndStation;
                station_isOutLine_checkBox.Text = English.StationManageForm_Label_isOutLineStation;
                station_save_button.Text = English.StationManageForm_Button_save;
                station_delete_button.Text = English.StationManageForm_Button_delete;
                station_cancel_button.Text = English.StationManageForm_Button_cancel;
                #endregion
            }
        }
    }
}
