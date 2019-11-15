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

namespace AMS_Server.FormRecipe
{
    public partial class ProductionManagerForm : Office2007Form
    {
        Crafts_Production_Bll crafts_Production_Bll = new Crafts_Production_Bll();
        Crafts_Production_Modle crafts_Production_Modle = new Crafts_Production_Modle();
        Crafts_Recipe_Bll crafts_Recipe_Bll = new Crafts_Recipe_Bll();
        DataTable productionDt = new DataTable();
        string productionName = string.Empty;
        string log_page_exception = string.Empty;
        string log_save_proc = string.Empty;
        string log_save_success = string.Empty;
        string log_save_exception = string.Empty;
        string log_delete_success = string.Empty;
        string log_delete_fail = string.Empty;
        string log_delete_exception = string.Empty;

        public ProductionManagerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductionManagerForm_Load(object sender, EventArgs e)
        {
            try
            {
                PageFrush();
                Language_translation();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(log_page_exception + ex.Message);
            }
        }

        /// <summary>
        /// save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void production_save_button_Click(object sender, EventArgs e)
        {
            try
            {
                #region check
                if (string.IsNullOrEmpty(production_Name_textBox.Text) || string.IsNullOrEmpty(production_No_textBox.Text)
                    || string.IsNullOrEmpty(production_Rule_textBox.Text))
                {
                    MessageBoxEx.Show(log_save_proc);
                    return;
                }
                #endregion

                #region Assignment
                crafts_Production_Modle.ProductionName = production_Name_textBox.Text;
                crafts_Production_Modle.ProductionNo = production_No_textBox.Text;
                crafts_Production_Modle.ProductionDescripe = production_Descripe_textBox.Text;
                crafts_Production_Modle.ProductionRule = production_Rule_textBox.Text;
                #endregion

                #region save or add
                if (string.IsNullOrEmpty(productionName))
                {
                    if (productionDt.Rows.Count > 0)
                    {
                        for (int i = 0; i < productionDt.Rows.Count; i++)
                        {
                            if (productionDt.Rows[i]["ProductionName"].ToString() == production_Name_textBox.Text)
                            {
                                crafts_Production_Bll.Update_One_Production_Table(crafts_Production_Modle, production_Name_textBox.Text);
                                MessageBoxEx.Show(log_save_success);
                                PageFrush();
                                return;
                            }
                        }
                    }
                    crafts_Production_Bll.Insert_One_Production_Table(crafts_Production_Modle);
                }
                else
                {
                    crafts_Production_Bll.Update_One_Production_Table(crafts_Production_Modle, productionName);
                }
                MessageBoxEx.Show(log_save_success);
                PageFrush();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(log_save_exception + ex.Message);
            }
        }

        /// <summary>
        /// delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void production_delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(production_Name_textBox.Text))
                {
                    int result = crafts_Production_Bll.Delete_One_Production_Table(production_Name_textBox.Text);
                    crafts_Recipe_Bll.Delete_Condition_Recipe_Table(production_Name_textBox.Text,string.Empty,0,0);
                    if (result > 0)
                    {
                        MessageBoxEx.Show(log_delete_success);
                    }
                    else
                    {
                        MessageBoxEx.Show(log_delete_fail);
                    }
                    PageFrush();
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(log_delete_exception + ex.Message);
            }
        }

        /// <summary>
        /// cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void production_cancel_button_Click(object sender, EventArgs e)
        {
            production_Name_textBox.Text = string.Empty;
            production_No_textBox.Text = string.Empty;
            production_Descripe_textBox.Text = string.Empty;
            production_Rule_textBox.Text = string.Empty;
            productionName = string.Empty;
        }

        /// <summary>
        /// tree selecte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void production_tree_advTree_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            try
            {
                for (int i = 0; i < productionDt.Rows.Count; i++)
                {
                    if (productionDt.Rows[i]["ProductionName"].ToString() == e.Node.Text)
                    {
                        production_Name_textBox.Text = productionDt.Rows[i]["ProductionName"].ToString();
                        production_No_textBox.Text = productionDt.Rows[i]["ProductionNo"].ToString();
                        production_Descripe_textBox.Text = productionDt.Rows[i]["ProductionDescripe"].ToString();
                        production_Rule_textBox.Text = productionDt.Rows[i]["ProductionRule"].ToString();
                        productionName = productionDt.Rows[i]["ProductionName"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                //MessageBoxEx.Show("出现异常：" + ex.Message);
            }
        }

        /// <summary>
        /// page frush
        /// </summary>
        public void PageFrush()
        {
            productionDt.Clear();
            production_tree_advTree.Nodes[0].Nodes.Clear();
            productionDt = crafts_Production_Bll.Select_All_Production_Table();
            if (productionDt.Rows.Count > 0)
            {
                for (int i = 0; i < productionDt.Rows.Count; i++)
                {
                    production_tree_advTree.Nodes[0].Nodes.Add(new DevComponents.AdvTree.Node(productionDt.Rows[i]["ProductionName"].ToString()));
                }
            }
        }

        /// <summary>
        /// translation
        /// </summary>
        public void Language_translation()
        {
            if (XML_Tool.xml.SysConfig.IsChinese)
            {
                #region text
                this.Text = Chinese.ProductionManagerForm_Top_title;
                production_node.Text = Chinese.ProductionManagerForm_Production_node;
                production_Name_label.Text = Chinese.ProductionManagerForm_Production_name;
                production_No_label.Text = Chinese.ProductionManagerForm__Production_no;
                production_Descripe_label.Text = Chinese.ProductionManagerForm_Production_describe;
                production_Rule_label.Text = Chinese.ProductionManagerForm_Production_rule;
                production_save_button.Text = Chinese.ProductionManagerForm_Button_save;
                production_delete_button.Text = Chinese.ProductionManagerForm_Button_delete;
                production_cancel_button.Text = Chinese.ProductionManagerForm_Button_cancel;
                #endregion

                #region log
                log_page_exception = Chinese.ProductionManagerForm_log_page_exception;
                log_save_proc = Chinese.ProductionManagerForm_log_save_proc;
                log_save_success = Chinese.ProductionManagerForm_log_save_success;
                log_save_exception = Chinese.ProductionManagerForm_log_save_exception;
                log_delete_success = Chinese.ProductionManagerForm_log_delete_success;
                log_delete_fail = Chinese.ProductionManagerForm_log_delete_fail;
                log_delete_exception = Chinese.ProductionManagerForm_log_delete_exception;
                #endregion
            }
            else
            {
                #region text
                this.Text = English.ProductionManagerForm_Top_title;
                production_node.Text = English.ProductionManagerForm_Production_node;
                production_Name_label.Text = English.ProductionManagerForm_Production_name;
                production_No_label.Text = English.ProductionManagerForm__Production_no;
                production_Descripe_label.Text = English.ProductionManagerForm_Production_describe;
                production_Rule_label.Text = English.ProductionManagerForm_Production_rule;
                production_save_button.Text = English.ProductionManagerForm_Button_save;
                production_delete_button.Text = English.ProductionManagerForm_Button_delete;
                production_cancel_button.Text = English.ProductionManagerForm_Button_cancel;
                #endregion

                #region log
                log_page_exception = English.ProductionManagerForm_log_page_exception;
                log_save_proc = English.ProductionManagerForm_log_save_proc;
                log_save_success = English.ProductionManagerForm_log_save_success;
                log_save_exception = English.ProductionManagerForm_log_save_exception;
                log_delete_success = English.ProductionManagerForm_log_delete_success;
                log_delete_fail = English.ProductionManagerForm_log_delete_fail;
                log_delete_exception = English.ProductionManagerForm_log_delete_exception;
                #endregion
            }
        }
    }
}
