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
    public partial class RecipeManageForm : Office2007Form
    {
        Crafts_Recipe_Bll crafts_Recipe_Bll = new Crafts_Recipe_Bll();
        Crafts_Recipe_Modle crafts_Recipe_Modle = new Crafts_Recipe_Modle();
        Crafts_Production_Bll crafts_Production_Bll = new Crafts_Production_Bll();
        Line_Station_Bll line_Station_Bll = new Line_Station_Bll();
        string productionName = string.Empty;
        string stationName = string.Empty;
        int id = 0;

        string log_page_proc = string.Empty;
        string log_page_exception = string.Empty;
        string log_save_success = string.Empty;
        string log_save_exception = string.Empty;
        string log_delete_proc = string.Empty;
        string log_delete_success = string.Empty;
        string log_delete_fail = string.Empty;
        string log_delete_exception = string.Empty;
        string log_cancel_exception = string.Empty;
        string log_check_err1 = string.Empty;
        string log_check_err2 = string.Empty;
        string log_check_err3 = string.Empty;
        string log_check_err4 = string.Empty;

  
        public RecipeManageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecipeManageForm_Load(object sender, EventArgs e)
        {
            try
            {
                #region comboBox added
                DataTable ProductNameDt = crafts_Production_Bll.Select_All_Production_Table();
                if (ProductNameDt.Rows.Count > 0)
                {
                    for (int i = 0; i < ProductNameDt.Rows.Count; i++)
                    {
                        recipe_ProductionName_comboBox.Items.Add(ProductNameDt.Rows[i]["ProductionName"].ToString());
                    }
                }
                else
                {
                    MessageBoxEx.Show(log_page_proc);
                }

                for (int i = 0; i < XML_Tool.xml.StationConfig.Count; i++)
                {
                    recipe_station_comboBox.Items.Add(XML_Tool.xml.StationConfig[i].Name);
                }

                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    recipe_operationType_comboBox.Items.Add("扫描");
                    recipe_operationType_comboBox.Items.Add("拧紧");
                    recipe_operationType_comboBox.Items.Add("测量");
                    recipe_operationType_comboBox.Items.Add("自动站");
                    recipe_operationType_comboBox.Items.Add("安装");
                    recipe_operationType_comboBox.Items.Add("手动拧紧");
                    recipe_operationType_comboBox.Items.Add("结束");
                }
                else
                {
                    recipe_operationType_comboBox.Items.Add("Scanning");
                    recipe_operationType_comboBox.Items.Add("Tighten");
                    recipe_operationType_comboBox.Items.Add("Measuring");
                    recipe_operationType_comboBox.Items.Add("Automatic");
                    recipe_operationType_comboBox.Items.Add("install");
                    recipe_operationType_comboBox.Items.Add("HandTight");
                    recipe_operationType_comboBox.Items.Add("End");
                }
                #endregion

                #region page frush
                PageFrush();
                Language_translation();
                #endregion
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
        private void repice_save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckBeforeSave())
                {
                    #region save
                    if (recipe_operationType_comboBox.Text == "扫描" || recipe_operationType_comboBox.Text == "Scanning")
                    {
                        crafts_Recipe_Modle.ProductionName = recipe_ProductionName_comboBox.Text;
                        crafts_Recipe_Modle.Station = recipe_station_comboBox.Text;
                        crafts_Recipe_Modle.ImagePath = recipe_imagePath_textBox.Text;
                        crafts_Recipe_Modle.Step = int.Parse(NullStringTransfer(recipe_step_textBox.Text));
                        crafts_Recipe_Modle.OperationType = recipe_operationType_comboBox.Text;
                        crafts_Recipe_Modle.ProgramNo = string.Empty;
                        crafts_Recipe_Modle.CheckRule = recipe_checkRule_textBox.Text;
                        crafts_Recipe_Modle.BlotNo = string.Empty;
                        crafts_Recipe_Modle.ComponentName = recipe_componentName_textBox.Text;
                        crafts_Recipe_Modle.BlotNumber = 0;
                        crafts_Recipe_Modle.ComponentNNumber = int.Parse(NullStringTransfer(recipe_componentNNumber_textBox.Text));
                        crafts_Recipe_Modle.BarcodeLength = int.Parse(NullStringTransfer(recipe_barcodeLength_textBox.Text));
                        crafts_Recipe_Modle.SleeveNo = 0;
                        crafts_Recipe_Modle.StepDesc = StepDesc_textBox.Text;
                    }
                    else if (recipe_operationType_comboBox.Text == "拧紧" || recipe_operationType_comboBox.Text == "Tighten")
                    {
                        crafts_Recipe_Modle.ProductionName = recipe_ProductionName_comboBox.Text;
                        crafts_Recipe_Modle.Station = recipe_station_comboBox.Text;
                        crafts_Recipe_Modle.ImagePath = recipe_imagePath_textBox.Text;
                        crafts_Recipe_Modle.Step = int.Parse(NullStringTransfer(recipe_step_textBox.Text));
                        crafts_Recipe_Modle.OperationType = recipe_operationType_comboBox.Text;
                        crafts_Recipe_Modle.ProgramNo = recipe_programNo_textBox.Text;
                        crafts_Recipe_Modle.CheckRule = string.Empty;
                        crafts_Recipe_Modle.BlotNo = recipe_boltNo_textBox.Text;
                        crafts_Recipe_Modle.ComponentName = recipe_componentName_textBox.Text;
                        crafts_Recipe_Modle.BlotNumber = int.Parse(NullStringTransfer(recipe_boltNumber_textBox.Text));
                        crafts_Recipe_Modle.ComponentNNumber = 0;
                        crafts_Recipe_Modle.BarcodeLength = 0;
                        crafts_Recipe_Modle.SleeveNo = int.Parse(recipe_sleeve_textBox.Text);
                        crafts_Recipe_Modle.StepDesc = StepDesc_textBox.Text;
                    }
                    else if (recipe_operationType_comboBox.Text == "测量" || recipe_operationType_comboBox.Text == "自动站" 
                        || recipe_operationType_comboBox.Text == "Measuring" || recipe_operationType_comboBox.Text == "Automatic")
                    {
                        crafts_Recipe_Modle.ProductionName = recipe_ProductionName_comboBox.Text;
                        crafts_Recipe_Modle.Station = recipe_station_comboBox.Text;
                        crafts_Recipe_Modle.ImagePath = recipe_imagePath_textBox.Text;
                        crafts_Recipe_Modle.Step = int.Parse(NullStringTransfer(recipe_step_textBox.Text));
                        crafts_Recipe_Modle.OperationType = recipe_operationType_comboBox.Text;
                        crafts_Recipe_Modle.ProgramNo = recipe_programNo_textBox.Text;
                        crafts_Recipe_Modle.CheckRule = string.Empty;
                        crafts_Recipe_Modle.BlotNo = string.Empty;
                        crafts_Recipe_Modle.ComponentName = recipe_componentName_textBox.Text;
                        crafts_Recipe_Modle.BlotNumber = 0;
                        crafts_Recipe_Modle.ComponentNNumber = 0;
                        crafts_Recipe_Modle.BarcodeLength = 0;
                        crafts_Recipe_Modle.SleeveNo = 0;
                        crafts_Recipe_Modle.StepDesc = StepDesc_textBox.Text;
                    }
                    else
                    {
                        crafts_Recipe_Modle.ProductionName = recipe_ProductionName_comboBox.Text;
                        crafts_Recipe_Modle.Station = recipe_station_comboBox.Text;
                        crafts_Recipe_Modle.ImagePath = recipe_imagePath_textBox.Text;
                        crafts_Recipe_Modle.Step = int.Parse(NullStringTransfer(recipe_step_textBox.Text));
                        crafts_Recipe_Modle.OperationType = recipe_operationType_comboBox.Text;
                        crafts_Recipe_Modle.ProgramNo = string.Empty;
                        crafts_Recipe_Modle.CheckRule = string.Empty;
                        crafts_Recipe_Modle.BlotNo = string.Empty;
                        crafts_Recipe_Modle.ComponentName = string.Empty;
                        crafts_Recipe_Modle.BlotNumber = 0;
                        crafts_Recipe_Modle.ComponentNNumber = 0;
                        crafts_Recipe_Modle.BarcodeLength = 0;
                        crafts_Recipe_Modle.SleeveNo = 0;
                        crafts_Recipe_Modle.StepDesc = StepDesc_textBox.Text;
                    }
                    if (recipe_isTrace_checkBox.CheckState == CheckState.Checked)
                    {
                        crafts_Recipe_Modle.Istrace = 1;
                    }
                    else
                    {
                        crafts_Recipe_Modle.Istrace = 0;
                    }
                    if (recipe_isCheck_checkBox.CheckState == CheckState.Checked)
                    {
                        crafts_Recipe_Modle.IsCheck = 1;
                    }
                    else
                    {
                        crafts_Recipe_Modle.IsCheck = 0;
                    }

                    if (crafts_Recipe_Bll.Select_Count_Recipe_Table(crafts_Recipe_Modle.ProductionName, crafts_Recipe_Modle.Station, crafts_Recipe_Modle.Step) == "0")
                    {
                        crafts_Recipe_Bll.Insert_One_Recipe_Table(crafts_Recipe_Modle);
                    }
                    else
                    {
                        crafts_Recipe_Bll.Update_One_Recipe_Table(crafts_Recipe_Modle);
                    }
                    MessageBoxEx.Show(log_save_success);
                    #endregion
                    #region page frush
                    PageFrush();
                    recipe_show_dataGridView.DataSource = crafts_Recipe_Bll.Select_Condition_Recipe_Table(recipe_ProductionName_comboBox.Text, recipe_station_comboBox.Text); ;
                    #endregion
                }
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
        private void recipe_delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(recipe_ProductionName_comboBox.Text) || string.IsNullOrEmpty(recipe_station_comboBox.Text)
                    || string.IsNullOrEmpty(recipe_step_textBox.Text))
                {
                    MessageBoxEx.Show(log_delete_proc);
                    return;
                }
                if (MessageBoxEx.Show("is sure delete？", "Tip", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (crafts_Recipe_Bll.Delete_Condition_Recipe_Table(recipe_ProductionName_comboBox.Text, recipe_station_comboBox.Text, int.Parse(recipe_step_textBox.Text),id) > 0)
                    {
                        MessageBoxEx.Show(log_delete_success);
                        #region page frush
                        PageFrush();
                        recipe_show_dataGridView.DataSource = crafts_Recipe_Bll.Select_Condition_Recipe_Table(recipe_ProductionName_comboBox.Text, recipe_station_comboBox.Text); ;
                        #endregion
                    }
                    else
                    {
                        MessageBoxEx.Show(log_delete_fail);
                    }
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
        private void recipe_cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                recipe_ProductionName_comboBox.Text = string.Empty;
                recipe_station_comboBox.Text = string.Empty;
                recipe_imagePath_textBox.Text = string.Empty;
                recipe_step_textBox.Text = string.Empty;
                recipe_operationType_comboBox.Text = string.Empty;
                recipe_programNo_textBox.Text = string.Empty;
                recipe_checkRule_textBox.Text = string.Empty;
                recipe_boltNo_textBox.Text = string.Empty;
                recipe_componentName_textBox.Text = string.Empty;
                recipe_boltNumber_textBox.Text = string.Empty;
                recipe_componentNNumber_textBox.Text = string.Empty;
                recipe_barcodeLength_textBox.Text = string.Empty;
                recipe_sleeve_textBox.Text = string.Empty;
                StepDesc_textBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(log_cancel_exception + ex.Message);
            }
        }

        /// <summary>
        /// tree select event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recipe_tree_advTree_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            try
            {
                if (e.Node.Level == 1)
                {
                    productionName = e.Node.Parent.Text;
                    stationName = e.Node.Text;
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        recipe_show_dataGridView.DataSource = crafts_Recipe_Bll.Select_Condition_Recipe_Table(e.Node.Parent.Text, e.Node.Text);
                    }
                    else
                    {
                        recipe_show_dataGridView.DataSource = crafts_Recipe_Bll.Select_Condition_Recipe_English(e.Node.Parent.Text, e.Node.Text);
                    }
                }
                else if (e.Node.Level == 0)
                {
                    productionName = e.Node.Text;
                    if (XML_Tool.xml.SysConfig.IsChinese)
                        recipe_show_dataGridView.DataSource = crafts_Recipe_Bll.Select_Condition_Recipe_Table(e.Node.Text,string.Empty);
                    else
                        recipe_show_dataGridView.DataSource = crafts_Recipe_Bll.Select_Condition_Recipe_English(e.Node.Text, string.Empty);
                }
            }
            catch (Exception)
            {
                //MessageBoxEx.Show("树点击事件出现异常：" + ex.Message);
            }
        }

        /// <summary>
        /// page frush
        /// </summary>
        public void PageFrush()
        {
            #region tree load
            recipe_tree_advTree.Nodes.Clear();
            DataTable productionDt = crafts_Production_Bll.Select_All_Production_Table();
            DataTable recipeDt = crafts_Recipe_Bll.Select_All_Recipe_Table(2);
            if (productionDt.Rows.Count > 0)
            {
                for (int i = 0; i < productionDt.Rows.Count; i++)
                {
                    recipe_tree_advTree.Nodes.Add(new DevComponents.AdvTree.Node(productionDt.Rows[i]["ProductionName"].ToString()));
                    for (int j = 0; j < recipeDt.Rows.Count; j++)
                    {
                        if (productionDt.Rows[i]["ProductionName"].ToString() == recipeDt.Rows[j]["ProductionName"].ToString())
                        {
                            recipe_tree_advTree.Nodes[i].Nodes.Add(new DevComponents.AdvTree.Node(recipeDt.Rows[j]["Station"].ToString()));
                        }
                    }
                }
            }
            #endregion
        }

        /// <summary>
        /// check before save recipe
        /// </summary>
        /// <returns></returns>
        public bool CheckBeforeSave()
        {
            if (string.IsNullOrEmpty(recipe_ProductionName_comboBox.Text) || string.IsNullOrEmpty(recipe_station_comboBox.Text)
                || string.IsNullOrEmpty(recipe_imagePath_textBox.Text) || string.IsNullOrEmpty(recipe_step_textBox.Text)
                || string.IsNullOrEmpty(recipe_operationType_comboBox.Text) || string.IsNullOrEmpty(StepDesc_textBox.Text))
            {
                MessageBoxEx.Show(log_check_err1);
                return false;
            }

            if (recipe_operationType_comboBox.Text == "扫描" || recipe_operationType_comboBox.Text == "Scanning")
            {
                if (string.IsNullOrEmpty(recipe_checkRule_textBox.Text) || string.IsNullOrEmpty(recipe_componentName_textBox.Text)
                    || string.IsNullOrEmpty(recipe_componentNNumber_textBox.Text) || string.IsNullOrEmpty(recipe_barcodeLength_textBox.Text))
                {
                    MessageBoxEx.Show(log_check_err2);
                    return false;
                }
            }
            else if (recipe_operationType_comboBox.Text == "拧紧" || recipe_operationType_comboBox.Text == "Tighten")
            {
                if (string.IsNullOrEmpty(recipe_programNo_textBox.Text) || string.IsNullOrEmpty(recipe_boltNo_textBox.Text)
                    || string.IsNullOrEmpty(recipe_componentName_textBox.Text) || string.IsNullOrEmpty(recipe_boltNumber_textBox.Text)
                    || string.IsNullOrEmpty(recipe_sleeve_textBox.Text))
                {
                    MessageBoxEx.Show(log_check_err3);
                    return false;
                }
            }
            else if (recipe_operationType_comboBox.Text != "结束" && recipe_operationType_comboBox.Text != "End")
            {
                if (string.IsNullOrEmpty(recipe_componentName_textBox.Text))
                {
                    MessageBoxEx.Show(log_check_err4);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// check after save recipe
        /// </summary>
        /// <returns></returns>
        public bool CheckAfterSave(string proditionName, string station)
        {
            if (XML_Tool.xml.SysConfig.IsChinese)
            {
                if (!string.IsNullOrEmpty(station))
                {
                    DataTable stationDt = crafts_Recipe_Bll.Select_Condition_Recipe_Table(proditionName, station);
                    if (stationDt.Rows.Count > 0)
                    {
                        for (int i = 0; i < stationDt.Rows.Count; i++)
                        {
                            if (stationDt.Rows[i]["步序"].ToString() != (i + 1).ToString())
                            {
                                MessageBoxEx.Show("产品：" + proditionName + ", 工位：" + station + ",步序不连续，请检查！");
                                return false;
                            }
                        }
                        if (stationDt.Rows[stationDt.Rows.Count - 1]["操作类型"].ToString() != "结束")
                        {
                            MessageBoxEx.Show("产品：" + proditionName + ", 工位：" + station + ",没有以操作类型结束为最后一步，请检查！");
                            return false;
                        }
                        if (stationDt.Rows[0]["操作类型"].ToString() != "扫描")
                        {
                            MessageBoxEx.Show("产品：" + proditionName + ",工位：" + station + ",没有以操作类型扫描为第一步，请检查！");
                            return false;
                        }
                    }
                }
                else
                {
                    string[] list = new string[recipe_station_comboBox.Items.Count]; ;
                    recipe_station_comboBox.Items.CopyTo(list, 0);
                    foreach (var st in list)
                    {
                        DataTable stationDt = crafts_Recipe_Bll.Select_Condition_Recipe_Table(proditionName, st);
                        if (stationDt.Rows.Count > 0)
                        {
                            for (int i = 0; i < stationDt.Rows.Count; i++)
                            {
                                if (stationDt.Rows[i]["步序"].ToString() != (i + 1).ToString())
                                {
                                    MessageBoxEx.Show("产品：" + proditionName + ",工位：" + st + ",步序不连续，请检查！");
                                    return false;
                                }
                            }
                            if (stationDt.Rows[stationDt.Rows.Count - 1]["操作类型"].ToString() != "结束")
                            {
                                MessageBoxEx.Show("产品：" + proditionName + ",工位：" + st + ",没有以操作类型结束为最后一步，请检查！");
                                return false;
                            }
                            if (stationDt.Rows[0]["操作类型"].ToString() != "扫描")
                            {
                                MessageBoxEx.Show("产品：" + proditionName + ",工位：" + st + ",没有以操作类型扫描为第一步，请检查！");
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            else
            {
                if (!string.IsNullOrEmpty(station))
                {
                    DataTable stationDt = crafts_Recipe_Bll.Select_Condition_Recipe_English(proditionName, station);
                    if (stationDt.Rows.Count > 0)
                    {
                        for (int i = 0; i < stationDt.Rows.Count; i++)
                        {
                            if (stationDt.Rows[i]["Step"].ToString() != (i + 1).ToString())
                            {
                                MessageBoxEx.Show("ProductionName：" + proditionName + ", Station：" + station + ",Steps are not continuous, please check！");
                                return false;
                            }
                        }
                        if (stationDt.Rows[stationDt.Rows.Count - 1]["OperationType"].ToString() != "End")
                        {
                            MessageBoxEx.Show("ProductionName：" + proditionName + ", Station：" + station + ",Did not end with the operation type as the last step, please check！");
                            return false;
                        }
                        if (stationDt.Rows[0]["OperationType"].ToString() != "Scanning")
                        {
                            MessageBoxEx.Show("ProductionName：" + proditionName + ",Station：" + station + ",No operation type scan is the first step, please check！");
                            return false;
                        }
                    }
                }
                else
                {
                    string[] list = new string[recipe_station_comboBox.Items.Count]; ;
                    recipe_station_comboBox.Items.CopyTo(list, 0);
                    foreach (var st in list)
                    {
                        DataTable stationDt = crafts_Recipe_Bll.Select_Condition_Recipe_Table(proditionName, st);
                        if (stationDt.Rows.Count > 0)
                        {
                            for (int i = 0; i < stationDt.Rows.Count; i++)
                            {
                                if (stationDt.Rows[i]["Step"].ToString() != (i + 1).ToString())
                                {
                                    MessageBoxEx.Show("ProductionName：" + proditionName + ",Station：" + st + ",Steps are not continuous, please check！");
                                    return false;
                                }
                            }
                            if (stationDt.Rows[stationDt.Rows.Count - 1]["OperationType"].ToString() != "End")
                            {
                                MessageBoxEx.Show("ProductionName：" + proditionName + ",Station：" + st + ",Did not end with the operation type as the last step, please check！");
                                return false;
                            }
                            if (stationDt.Rows[0]["OperationType"].ToString() != "Scanning")
                            {
                                MessageBoxEx.Show("ProductionName：" + proditionName + ",Station：" + st + ",Scanning by operation type is not the first step, please check！");
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// null transfer 0
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string NullStringTransfer(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "0";
            }
            else
            {
                return input;
            }
        }

        /// <summary>
        /// recipe check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 配方检查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAfterSave(productionName,stationName);
        }

        /// <summary>
        /// data girl view click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recipe_show_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    id = int.Parse(recipe_show_dataGridView.CurrentRow.Cells["编号"].Value.ToString());
                    recipe_ProductionName_comboBox.Text = recipe_show_dataGridView.CurrentRow.Cells["产品名称"].Value.ToString();
                    recipe_station_comboBox.Text = recipe_show_dataGridView.CurrentRow.Cells["工位"].Value.ToString();
                    recipe_imagePath_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["图片路径"].Value.ToString();
                    recipe_step_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["步序"].Value.ToString();
                    recipe_operationType_comboBox.Text = recipe_show_dataGridView.CurrentRow.Cells["操作类型"].Value.ToString();
                    recipe_programNo_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["程序号"].Value.ToString();
                    recipe_checkRule_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["校验规则"].Value.ToString();
                    recipe_boltNo_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["螺栓编号"].Value.ToString();
                    recipe_componentName_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["部件名称"].Value.ToString();
                    recipe_boltNumber_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["螺栓数量"].Value.ToString();
                    recipe_componentNNumber_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["部件数量"].Value.ToString();
                    recipe_barcodeLength_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["条码长度"].Value.ToString();
                    recipe_sleeve_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["套筒号"].Value.ToString();
                    StepDesc_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["操作描述"].Value.ToString();
                    if (recipe_show_dataGridView.CurrentRow.Cells["是否追溯"].Value.ToString() == "1")
                    {
                        recipe_isTrace_checkBox.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        recipe_isTrace_checkBox.CheckState = CheckState.Unchecked;
                    }
                    if (recipe_show_dataGridView.CurrentRow.Cells["是否校验"].Value.ToString() == "1")
                    {
                        recipe_isCheck_checkBox.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        recipe_isCheck_checkBox.CheckState = CheckState.Unchecked;
                    }
                }
                else
                {
                    id = int.Parse(recipe_show_dataGridView.CurrentRow.Cells["RecipeID"].Value.ToString());
                    recipe_ProductionName_comboBox.Text = recipe_show_dataGridView.CurrentRow.Cells["ProductionName"].Value.ToString();
                    recipe_station_comboBox.Text = recipe_show_dataGridView.CurrentRow.Cells["Station"].Value.ToString();
                    recipe_imagePath_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["ImagePath"].Value.ToString();
                    recipe_step_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["Step"].Value.ToString();
                    recipe_operationType_comboBox.Text = recipe_show_dataGridView.CurrentRow.Cells["OperationType"].Value.ToString();
                    recipe_programNo_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["ProgramNo"].Value.ToString();
                    recipe_checkRule_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["CheckRule"].Value.ToString();
                    recipe_boltNo_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["BlotNo"].Value.ToString();
                    recipe_componentName_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["ComponentName"].Value.ToString();
                    recipe_boltNumber_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["BlotNumber"].Value.ToString();
                    recipe_componentNNumber_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["ComponentNNumber"].Value.ToString();
                    recipe_barcodeLength_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["BarcodeLength"].Value.ToString();
                    recipe_sleeve_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["SleeveNo"].Value.ToString();
                    StepDesc_textBox.Text = recipe_show_dataGridView.CurrentRow.Cells["StepDescription"].Value.ToString();
                    if (recipe_show_dataGridView.CurrentRow.Cells["Istrace"].Value.ToString() == "1")
                    {
                        recipe_isTrace_checkBox.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        recipe_isTrace_checkBox.CheckState = CheckState.Unchecked;
                    }
                    if (recipe_show_dataGridView.CurrentRow.Cells["IsCheck"].Value.ToString() == "1")
                    {
                        recipe_isCheck_checkBox.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        recipe_isCheck_checkBox.CheckState = CheckState.Unchecked;
                    }
                }
            }
            catch (Exception)
            {
                //MessageBoxEx.Show("图标点击事件出现异常：" + ex.Message);
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
                this.Text = Chinese.RecipeManageForm_Top_title;
                recipe_ProductionName_label.Text = Chinese.RecipeManageForm_Label_productionName;
                recipe_ProductionName_comboBox.WatermarkText = Chinese.RecipeManageForm_ProductionName_tip;
                recipe_station_label.Text = Chinese.RecipeManageForm_Label_station;
                recipe_station_comboBox.WatermarkText = Chinese.RecipeManageForm_Station_tip;
                recipe_imagePath_label.Text = Chinese.RecipeManageForm_Label_imagePath;
                recipe_imagePath_textBox.WatermarkText = Chinese.RecipeManageForm_ImagePath_tip;
                recipe_step_label.Text = Chinese.RecipeManageForm_Label_step;
                recipe_step_textBox.WatermarkText = Chinese.RecipeManageForm_Step_tip;
                recipe_operationType_label.Text = Chinese.RecipeManageForm_Label_operationType;
                recipe_operationType_comboBox.WatermarkText = Chinese.RecipeManageForm_OperationType_tip;
                recipe_programNo_label.Text = Chinese.RecipeManageForm_Label_programNo;
                recipe_programNo_textBox.WatermarkText = Chinese.RecipeManageForm_ProgramNo_tip;
                recipe_checkRule_label.Text = Chinese.RecipeManageForm_Label_checkRule;
                recipe_checkRule_textBox.WatermarkText = Chinese.RecipeManageForm_CheckRule_tip;
                recipe_boltNo_label.Text = Chinese.RecipeManageForm_Label_boltNo;
                recipe_boltNo_textBox.WatermarkText = Chinese.RecipeManageForm_BoltNo_tip;
                recipe_componentName_label.Text = Chinese.RecipeManageForm_Label_componentName;
                recipe_componentName_textBox.WatermarkText = Chinese.RecipeManageForm_ComponentName_tip;
                recipe_boltNumber_label.Text = Chinese.RecipeManageForm_Label_boltNumber;
                recipe_boltNumber_textBox.WatermarkText = Chinese.RecipeManageForm_BoltNumber_tip;
                recipe_componentNNumber_label.Text = Chinese.RecipeManageForm_Label_componentNumber;
                recipe_componentNNumber_textBox.WatermarkText = Chinese.RecipeManageForm_ComponentNumber_tip;
                recipe_barcodeLength_label.Text = Chinese.RecipeManageForm_Label_barcodeLength;
                recipe_barcodeLength_textBox.WatermarkText = Chinese.RecipeManageForm_BarcodeLength_tip;
                recipe_sleeve_label.Text = Chinese.RecipeManageForm_Label_sleeve;
                StepDesc_label.Text = Chinese.RecipeManageForm_Label_stepDesc;
                recipe_sleeve_textBox.WatermarkText = Chinese.RecipeManageForm_Sleeve_tip;
                StepDesc_textBox.WatermarkText = Chinese.RecipeManageForm_OperationType_tip;
                recipe_isTrace_checkBox.Text = Chinese.RecipeManageForm_Label_isCheck;
                recipe_isCheck_checkBox.Text = Chinese.RecipeManageForm_Label_isTrace;
                repice_save_button.Text = Chinese.RecipeManageForm_Button_save;
                recipe_delete_button.Text = Chinese.RecipeManageForm_Button_delete;
                recipe_cancel_button.Text = Chinese.RecipeManageForm_Button_cancel;
                #endregion

                #region log
                log_page_proc = Chinese.RecipeManageForm_log_page_proc;
                log_page_exception = Chinese.RecipeManageForm_log_page_exception;
                log_save_success = Chinese.RecipeManageForm_log_save_success;
                log_save_exception = Chinese.RecipeManageForm_log_save_exception;
                log_delete_proc = Chinese.RecipeManageForm_log_delete_proc;
                log_delete_success = Chinese.RecipeManageForm_log_delete_success;
                log_delete_fail = Chinese.RecipeManageForm_log_delete_fail;
                log_delete_exception = Chinese.RecipeManageForm_log_delete_exception;
                log_cancel_exception = Chinese.RecipeManageForm_log_cancel_exception ;
                log_check_err1 = Chinese.RecipeManageForm_log_check_err1;
                log_check_err2 = Chinese.RecipeManageForm_log_check_err2;
                log_check_err3 = Chinese.RecipeManageForm_log_check_err3;
                log_check_err4 = Chinese.RecipeManageForm_log_check_err4;
                #endregion
            }
            else
            {
                #region Text
                this.Text = English.RecipeManageForm_Top_title;
                recipe_ProductionName_label.Text = English.RecipeManageForm_Label_productionName;
                recipe_ProductionName_comboBox.WatermarkText = English.RecipeManageForm_ProductionName_tip;
                recipe_station_label.Text = English.RecipeManageForm_Label_station;
                recipe_station_comboBox.WatermarkText = English.RecipeManageForm_Station_tip;
                recipe_imagePath_label.Text = English.RecipeManageForm_Label_imagePath;
                recipe_imagePath_textBox.WatermarkText = English.RecipeManageForm_ImagePath_tip;
                recipe_step_label.Text = English.RecipeManageForm_Label_step;
                recipe_step_textBox.WatermarkText = English.RecipeManageForm_Step_tip;
                recipe_operationType_label.Text = English.RecipeManageForm_Label_operationType;
                recipe_operationType_comboBox.WatermarkText = English.RecipeManageForm_OperationType_tip;
                recipe_programNo_label.Text = English.RecipeManageForm_Label_programNo;
                recipe_programNo_textBox.WatermarkText = English.RecipeManageForm_ProgramNo_tip;
                recipe_checkRule_label.Text = English.RecipeManageForm_Label_checkRule;
                recipe_checkRule_textBox.WatermarkText = English.RecipeManageForm_CheckRule_tip;
                recipe_boltNo_label.Text = English.RecipeManageForm_Label_boltNo;
                recipe_boltNo_textBox.WatermarkText = English.RecipeManageForm_BoltNo_tip;
                recipe_componentName_label.Text = English.RecipeManageForm_Label_componentName;
                recipe_componentName_textBox.WatermarkText = English.RecipeManageForm_ComponentName_tip;
                recipe_boltNumber_label.Text = English.RecipeManageForm_Label_boltNumber;
                recipe_boltNumber_textBox.WatermarkText = English.RecipeManageForm_BoltNumber_tip;
                recipe_componentNNumber_label.Text = English.RecipeManageForm_Label_componentNumber;
                recipe_componentNNumber_textBox.WatermarkText = English.RecipeManageForm_ComponentNumber_tip;
                recipe_barcodeLength_label.Text = English.RecipeManageForm_Label_barcodeLength;
                recipe_barcodeLength_textBox.WatermarkText = English.RecipeManageForm_BarcodeLength_tip;
                recipe_sleeve_label.Text = English.RecipeManageForm_Label_sleeve;
                recipe_sleeve_textBox.WatermarkText = English.RecipeManageForm_Sleeve_tip;
                StepDesc_label.Text = English.RecipeManageForm_Label_stepDesc;
                StepDesc_textBox.WatermarkText = English.RecipeManageForm_OperationType_tip;
                recipe_isTrace_checkBox.Text = English.RecipeManageForm_Label_isCheck;
                recipe_isCheck_checkBox.Text = English.RecipeManageForm_Label_isTrace;
                repice_save_button.Text = English.RecipeManageForm_Button_save;
                recipe_delete_button.Text = English.RecipeManageForm_Button_delete;
                recipe_cancel_button.Text = English.RecipeManageForm_Button_cancel;
                #endregion

                #region log
                log_page_proc = English.RecipeManageForm_log_page_proc;
                log_page_exception = English.RecipeManageForm_log_page_exception;
                log_save_success = English.RecipeManageForm_log_save_success;
                log_save_exception = English.RecipeManageForm_log_save_exception;
                log_delete_proc = English.RecipeManageForm_log_delete_proc;
                log_delete_success = English.RecipeManageForm_log_delete_success;
                log_delete_fail = English.RecipeManageForm_log_delete_fail;
                log_delete_exception = English.RecipeManageForm_log_delete_exception;
                log_cancel_exception = English.RecipeManageForm_log_cancel_exception;
                log_check_err1 = English.RecipeManageForm_log_check_err1;
                log_check_err2 = English.RecipeManageForm_log_check_err2;
                log_check_err3 = English.RecipeManageForm_log_check_err3;
                log_check_err4 = English.RecipeManageForm_log_check_err4;
                #endregion
            }
        }
    }
}
