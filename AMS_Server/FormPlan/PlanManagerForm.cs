using DevComponents.DotNetBar;
using Server_BLL;
using Server_Modle.DBase;
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

namespace AMS_Server.FormPlan
{
    public partial class PlanManagerForm : Office2007Form
    {
        Crafts_CurPlan_Bll crafts_CurPlan_Bll = new Crafts_CurPlan_Bll();
        Crafts_CurPlan_Modle crafts_CurPlan_Modle = new Crafts_CurPlan_Modle();
        DataTable dt = new DataTable();
        int id = 0;
        string log_save_proc = string.Empty;
        string log_modify_success = string.Empty;
        string log_add_success = string.Empty;
        string log_save_exception = string.Empty;
        string log_delete_proc = string.Empty;
        string log_delete_success = string.Empty;
        string log_delete_exception = string.Empty;
        string log_cancel_exception = string.Empty;
        public PlanManagerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlanManagerForm_Load(object sender, EventArgs e)
        {
            PageFrush();
            Language_translation();
        }

        /// <summary>
        /// save button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plan_save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(plan_No_textBox.Text)
                    || string.IsNullOrEmpty(plan_productionNo_textBox.Text)
                    || string.IsNullOrEmpty(plan_number_textBox.Text))
                {
                    MessageBoxEx.Show(log_save_proc);
                    return;
                }

                crafts_CurPlan_Modle.ID = id;
                crafts_CurPlan_Modle.WorkOrderNo = plan_No_textBox.Text;
                crafts_CurPlan_Modle.WorkOrderName = plan_productionNo_textBox.Text;
                crafts_CurPlan_Modle.WorkOrderDescripe =  plan_describe_textBox.Text;
                crafts_CurPlan_Modle.PlanNumber = int.Parse(plan_number_textBox.Text);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["WorkOrderNo"].ToString() == plan_No_textBox.Text)
                    {
                        crafts_CurPlan_Bll.Update_One_Plan_Table(crafts_CurPlan_Modle);
                        MessageBoxEx.Show(log_modify_success);
                        PageFrush();
                        return;
                    }
                }

                crafts_CurPlan_Bll.Insert_One_Plan__Table(crafts_CurPlan_Modle);
                MessageBoxEx.Show(log_add_success);
                PageFrush();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(log_save_exception + ex.Message);
            }
        }

        /// <summary>
        /// delete button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plan_delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(plan_No_textBox.Text))
                {
                    MessageBoxEx.Show(log_delete_proc);
                    return;
                }
                crafts_CurPlan_Bll.Delete_One_Plan_Table(plan_No_textBox.Text);
                MessageBoxEx.Show(log_delete_success);
                PageFrush();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(log_delete_exception + ex.Message);
            }
        }

        /// <summary>
        /// cancel button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plan_cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                plan_No_textBox.Text = "";
                plan_productionNo_textBox.Text = "";
                plan_number_textBox.Text = "";
                plan_describe_textBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(log_cancel_exception + ex.Message);
            }
        }

        /// <summary>
        /// datagirl view event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plan_show_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    id = int.Parse(plan_show_dataGridView.CurrentRow.Cells["编号"].Value.ToString());
                    plan_No_textBox.Text = plan_show_dataGridView.CurrentRow.Cells["工单号"].Value.ToString();
                    plan_productionNo_textBox.Text = plan_show_dataGridView.CurrentRow.Cells["工单名称"].Value.ToString();
                    plan_describe_textBox.Text = plan_show_dataGridView.CurrentRow.Cells["工单描述"].Value.ToString();
                    plan_number_textBox.Text = plan_show_dataGridView.CurrentRow.Cells["计划量"].Value.ToString();
                }
                else
                {
                    id = int.Parse(plan_show_dataGridView.CurrentRow.Cells["NO"].Value.ToString());
                    plan_No_textBox.Text = plan_show_dataGridView.CurrentRow.Cells["Work order number"].Value.ToString();
                    plan_productionNo_textBox.Text = plan_show_dataGridView.CurrentRow.Cells["Work order name"].Value.ToString();
                    plan_describe_textBox.Text = plan_show_dataGridView.CurrentRow.Cells["Work order describe"].Value.ToString();
                    plan_number_textBox.Text = plan_show_dataGridView.CurrentRow.Cells["Plan Number"].Value.ToString();
                }
            }
            catch (Exception)
            {
                //MessageBoxEx.Show("订单点击出现异常：" + ex.Message);
            }
        }

        /// <summary>
        /// page frush
        /// </summary>
        public void PageFrush()
        {
            dt = crafts_CurPlan_Bll.Select_All_Plan_Table(XML_Tool.xml.SysConfig.IsChinese);
            plan_show_dataGridView.DataSource = dt;
        }

        /// <summary>
        /// translation
        /// </summary>
        public void Language_translation()
        {
            if (XML_Tool.xml.SysConfig.IsChinese)
            {
                #region Text
                this.Text = Chinese.PlanManagerForm_Top_title;
                plan_No_label.Text = Chinese.PlanManagerForm_Plan_NO;
                plan_productionNo_label.Text = Chinese.PlanManagerForm_Production_NO;
                plan_describe_label.Text = Chinese.PlanManagerForm_Plan_Describe;
                plan_number_label.Text = Chinese.PlanManagerForm_Plan_number;
                plan_save_button.Text = Chinese.PlanManagerForm_Button_save;
                plan_delete_button.Text = Chinese.PlanManagerForm_Button_delete;
                plan_cancel_button.Text = Chinese.PlanManagerForm_Button_cancel;
                #endregion

                #region log
                log_save_proc = Chinese.PlanManagerForm_log_save_proc;
                log_modify_success = Chinese.PlanManagerForm_log_modify_success;
                log_add_success = Chinese.PlanManagerForm_log_add_success;
                log_save_exception = Chinese.PlanManagerForm_log_save_exception;
                log_delete_proc = Chinese.PlanManagerForm_log_delete_proc;
                log_delete_success = Chinese.PlanManagerForm_log_delete_success;
                log_delete_exception = Chinese.PlanManagerForm_log_delete_exception;
                log_cancel_exception = Chinese.PlanManagerForm_log_cancel_exception;
                #endregion
            }
            else
            {
                #region Text
                this.Text = English.PlanManagerForm_Top_title;
                plan_No_label.Text = English.PlanManagerForm_Plan_NO;
                plan_productionNo_label.Text = English.PlanManagerForm_Production_NO;
                plan_describe_label.Text = English.PlanManagerForm_Plan_Describe;
                plan_number_label.Text = English.PlanManagerForm_Plan_number;
                plan_save_button.Text = English.PlanManagerForm_Button_save;
                plan_delete_button.Text = English.PlanManagerForm_Button_delete;
                plan_cancel_button.Text = English.PlanManagerForm_Button_cancel;
                #endregion

                #region log
                log_save_proc = English.PlanManagerForm_log_save_proc;
                log_modify_success = English.PlanManagerForm_log_modify_success;
                log_add_success = English.PlanManagerForm_log_add_success;
                log_save_exception = English.PlanManagerForm_log_save_exception;
                log_delete_proc = English.PlanManagerForm_log_delete_proc;
                log_delete_success = English.PlanManagerForm_log_delete_success;
                log_delete_exception = English.PlanManagerForm_log_delete_exception;
                log_cancel_exception = English.PlanManagerForm_log_cancel_exception;
                #endregion
            }
        }
    }
}
