using DevComponents.DotNetBar;
using MyExcel;
using Server_BLL;
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
    public partial class RecipeInputForm : Office2007Form
    {
        Crafts_Recipe_Bll crafts_Recipe_Bll = new Crafts_Recipe_Bll();
        Crafts_Production_Bll crafts_Production_Bll = new Crafts_Production_Bll();
        DataTable dataGirlDt;
        string log_page_exception = string.Empty;
        string log_select_proc = string.Empty;
        string log_select_exception = string.Empty;
        string log_input_tip = string.Empty;
        string log_input_success = string.Empty;
        string log_input_fail = string.Empty;
        string log_input_exception = string.Empty;
        string log_output_title = string.Empty;
        string log_output_success = string.Empty;
        string log_output_fail = string.Empty;
        string log_output_exception = string.Empty;
        string log_save_success = string.Empty;
        string log_save_exception = string.Empty;
        public RecipeInputForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecipeInputForm_Load(object sender, EventArgs e)
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
        /// select button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recipeInput_select_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(recipeInput_production_comboBox.Text))
                {
                    dataGirlDt = crafts_Recipe_Bll.Select_Condition_Recipe_Table(recipeInput_production_comboBox.Text, "");
                    if (dataGirlDt.Rows[0]["操作类型"].ToString() != "扫描")
                    {
                        dataGirlDt = crafts_Recipe_Bll.Select_Condition_Recipe_English(recipeInput_production_comboBox.Text, "");
                    }
                    //if (XML_Tool.xml.SysConfig.IsChinese)
                    //{
                    //    dataGirlDt = crafts_Recipe_Bll.Select_Condition_Recipe_Table(recipeInput_production_comboBox.Text, "");
                    //}
                    //else
                    //{
                    //    dataGirlDt = crafts_Recipe_Bll.Select_Condition_Recipe_English(recipeInput_production_comboBox.Text, "");
                    //}
                    recipeInput_view_dataGridView.DataSource = dataGirlDt;
                }
                else
                {
                    MessageBox.Show(log_select_proc);
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(log_select_exception + ex.Message);
            }
        }

        /// <summary>
        /// input button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recipeInput_input_button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Title = log_input_tip;
                open.Filter = "excel07文件(*.xlsx)|*.xlsx";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string fileName = open.FileName;
                    ExcelHelper execl = new ExcelHelper(fileName);
                    if (dataGirlDt == null)
                    {
                        dataGirlDt = new DataTable();
                    }
                    dataGirlDt = execl.ExcelToDataTable("Sheet1", true);
                    if (dataGirlDt.Rows.Count > 0)
                    {
                        if (recipeInput_view_dataGridView.Rows.Count > 0)
                        {
                            recipeInput_view_dataGridView.DataSource = dataGirlDt;
                            recipeInput_view_dataGridView.Refresh();
                            this.recipeInput_view_dataGridView.ClearSelection();
                        }
                        else
                        {
                            recipeInput_view_dataGridView.DataSource = dataGirlDt;
                            this.recipeInput_view_dataGridView.ClearSelection();
                        }

                        MessageBox.Show(log_input_success);
                    }
                    else
                    {
                        MessageBox.Show(log_input_fail);
                    }
                    execl.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(log_input_exception + ex.Message);
            }
        }

        /// <summary>
        /// out put button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recipeInput_ouyput_button_Click(object sender, EventArgs e)
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
                    if (execl.DataGridViewToExcel(recipeInput_view_dataGridView, log_output_title, true) > 0)
                    {
                        MessageBox.Show(log_output_success);
                    }
                    else
                    {
                        MessageBox.Show(log_output_fail);
                    }
                    execl.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(log_output_exception + ex.Message);
            }
        }

        /// <summary>
        /// save button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recipeInput_save_button_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMes = string.Empty;
                if (!CheckRecipe(out errorMes))
                {
                    MessageBoxEx.Show(errorMes);
                    return;
                }
                crafts_Recipe_Bll.SqlBulkCopyInsert("Crafts_Recipe", dataGirlDt);
                MessageBoxEx.Show(log_save_success);
                PageFrush();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(log_save_exception + ex.Message);
            }
        }

        /// <summary>
        /// page frush
        /// </summary>
        public void PageFrush()
        {
            recipeInput_production_comboBox.Items.Clear();
            DataTable dt = new DataTable();
            dt = crafts_Recipe_Bll.Select_All_Recipe_Table(1);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    recipeInput_production_comboBox.Items.Add(dt.Rows[i]["ProductionName"].ToString());
                }
            }
        }

        /// <summary>
        /// check recipe true or false
        /// </summary>
        /// <returns></returns>
        public bool CheckRecipe(out string errorMessage)
        {
            try
            {
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    #region empty
                    errorMessage = string.Empty;
                    if (dataGirlDt.Rows.Count <= 0)
                    {
                        errorMessage = "请先导入配方，再点击保存！";
                        return false;
                    }
                    #endregion

                    #region Delete the corresponding formula 
                    DataTable productionDt = crafts_Production_Bll.Select_All_Production_Table();
                    if (productionDt.Rows.Count < 0)
                    {
                        errorMessage = "当前无产品，请先添加要导入的产品！";
                        return false;
                    }
                    List<string> productList = new List<string>();
                    for (int j = 0; j < productionDt.Rows.Count; j++)
                    {
                        if (!productList.Contains(productionDt.Rows[j]["ProductionName"].ToString()))
                        {
                            productList.Add(productionDt.Rows[j]["ProductionName"].ToString());
                        }
                    }
                    if (productList.Contains(dataGirlDt.Rows[0]["产品名称"].ToString()))
                    {
                        crafts_Recipe_Bll.Delete_Condition_Recipe_Table(dataGirlDt.Rows[0]["产品名称"].ToString(), string.Empty, 0, 0);
                    }
                    else
                    {
                        errorMessage = "请先添加要导入的产品！";
                        return false;
                    }
                    #endregion

                    #region get station list
                    List<string> stationList = new List<string>();
                    for (int i = 0; i < dataGirlDt.Rows.Count; i++)
                    {
                        if (!stationList.Contains(dataGirlDt.Rows[i]["工位"].ToString()))
                        {
                            stationList.Add(dataGirlDt.Rows[i]["工位"].ToString());
                        }
                    }
                    #endregion

                    #region check station recipe
                    foreach (var st in stationList)
                    {
                        DataTable dt = new DataTable();
                        dt = GetNewDataTable(dataGirlDt, "工位 = '" + st + "'");
                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                if (dt.Rows[i]["步序"].ToString() != (i + 1).ToString())
                                {
                                    errorMessage = "产品：" + dataGirlDt.Rows[0]["产品名称"].ToString() + ",工位：" + st + ",步序不连续，请检查！";
                                    return false;
                                }
                            }
                            if (dt.Rows[dt.Rows.Count - 1]["操作类型"].ToString() != "结束")
                            {
                                errorMessage = "产品：" + dataGirlDt.Rows[0]["产品名称"].ToString() + ",工位：" + st + ",没有以操作类型结束为最后一步，请检查！";
                                return false;
                            }
                            if (dt.Rows[0]["操作类型"].ToString() != "扫描")
                            {
                                errorMessage = "产品：" + dataGirlDt.Rows[0]["产品名称"].ToString() + ",工位：" + st + ",没有以操作类型扫描为第一步，请检查！";
                                return false;
                            }
                        }
                    }
                    #endregion
                    return true;
                }
                else
                {
                    #region empty
                    errorMessage = string.Empty;
                    if (dataGirlDt.Rows.Count <= 0)
                    {
                        errorMessage = "Please import the recipe first, then click save！";
                        return false;
                    }
                    #endregion

                    #region Delete the corresponding formula 
                    DataTable productionDt = crafts_Production_Bll.Select_All_Production_Table();
                    if (productionDt.Rows.Count < 0)
                    {
                        errorMessage = "There is currently no product, please add the product to be imported first.！";
                        return false;
                    }
                    List<string> productList = new List<string>();
                    for (int j = 0; j < productionDt.Rows.Count; j++)
                    {
                        if (!productList.Contains(productionDt.Rows[j]["ProductionName"].ToString()))
                        {
                            productList.Add(productionDt.Rows[j]["ProductionName"].ToString());
                        }
                    }
                    if (productList.Contains(dataGirlDt.Rows[0]["ProductionName"].ToString()))
                    {
                        crafts_Recipe_Bll.Delete_Condition_Recipe_Table(dataGirlDt.Rows[0]["ProductionName"].ToString(), string.Empty, 0, 0);
                    }
                    else
                    {
                        errorMessage = "Please add the product you want to import first.！";
                        return false;
                    }
                    #endregion

                    #region get station list
                    List<string> stationList = new List<string>();
                    for (int i = 0; i < dataGirlDt.Rows.Count; i++)
                    {
                        if (!stationList.Contains(dataGirlDt.Rows[i]["Station"].ToString()))
                        {
                            stationList.Add(dataGirlDt.Rows[i]["Station"].ToString());
                        }
                    }
                    #endregion

                    #region check station recipe
                    foreach (var st in stationList)
                    {
                        if (string.IsNullOrEmpty(st))
                        {
                            dataGirlDt.Rows.RemoveAt(dataGirlDt.Rows.Count - 1);
                            break;
                        }
                        DataTable dt = new DataTable();
                        dt = GetNewDataTable(dataGirlDt, "Station = '" + st + "'");
                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                if (dt.Rows[i]["Step"].ToString() != (i + 1).ToString())
                                {
                                    errorMessage = "Prodction：" + dataGirlDt.Rows[0]["ProductionName"].ToString() + ",Station：" + st + ",Steps are not continuous, please check！";
                                    return false;
                                }
                            }
                            if (dt.Rows[dt.Rows.Count - 1]["OperationType"].ToString() != "End")
                            {
                                errorMessage = "Prodction：" + dataGirlDt.Rows[0]["ProductionName"].ToString() + ",Station：" + st + ",Did not end with the operation type as the last step, please check！";
                                return false;
                            }
                            if (dt.Rows[0]["OperationType"].ToString() != "Scanning")
                            {
                                errorMessage = "Prodction：" + dataGirlDt.Rows[0]["ProductionName"].ToString() + ",Station：" + st + ",No operation type scan is the first step, please check！";
                                return false;
                            }
                        }
                    }
                    #endregion
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }


        /// <summary>
        /// 执行DataTable中的查询返回新的DataTable
        /// </summary>
        /// <param name="dt">源数据DataTable</param>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        private DataTable GetNewDataTable(DataTable dt, string condition)
        {
            DataTable newdt = new DataTable();
            newdt = dt.Clone();
            DataRow[] dr = dt.Select(condition);
            for (int i = 0; i < dr.Length; i++)
            {
                newdt.ImportRow((DataRow)dr[i]);
            }
            return newdt;//返回的查询结果
        }

        /// <summary>
        /// translation
        /// </summary>
        public void Language_translation()
        {
            if (XML_Tool.xml.SysConfig.IsChinese)
            {
                #region Text
                this.Text = Chinese.RecipeInputForm_Top_title;
                recipeInput_production_label.Text = Chinese.RecipeInputForm_label_ProductionName;
                recipeInput_select_button.Text = Chinese.RecipeInputForm_Button_select;
                recipeInput_input_button.Text = Chinese.RecipeInputForm_Button_input;
                recipeInput_ouyput_button.Text = Chinese.RecipeInputForm_Button_exput;
                recipeInput_save_button.Text = Chinese.RecipeInputForm_Button_save;
                #endregion

                #region log
                log_page_exception = Chinese.RecipeInputForm_log_page_exception;
                log_select_proc = Chinese.RecipeInputForm_log_select_proc;
                log_select_exception = Chinese.RecipeInputForm_log_select_exception;
                log_input_tip = Chinese.RecipeInputForm_log_input_tip;
                log_input_success = Chinese.RecipeInputForm_log_input_success;
                log_input_fail = Chinese.RecipeInputForm_log_input_fail;
                log_input_exception = Chinese.RecipeInputForm_log_input_exception;
                log_output_title = Chinese.RecipeInputForm_log_output_title;
                log_output_success = Chinese.RecipeInputForm_log_output_success;
                log_output_fail = Chinese.RecipeInputForm_log_output_fail;
                log_output_exception = Chinese.RecipeInputForm_log_output_exception;
                log_save_success = Chinese.RecipeInputForm_log_save_success;
                log_save_exception = Chinese.RecipeInputForm_log_save_exception;
                #endregion
            }
            else
            {
                #region Text
                this.Text = English.RecipeInputForm_Top_title;
                recipeInput_production_label.Text = English.RecipeInputForm_label_ProductionName;
                recipeInput_select_button.Text = English.RecipeInputForm_Button_select;
                recipeInput_input_button.Text = English.RecipeInputForm_Button_input;
                recipeInput_ouyput_button.Text = English.RecipeInputForm_Button_exput;
                recipeInput_save_button.Text = English.RecipeInputForm_Button_save;
                #endregion

                #region log
                log_page_exception = English.RecipeInputForm_log_page_exception;
                log_select_proc = English.RecipeInputForm_log_select_proc;
                log_select_exception = English.RecipeInputForm_log_select_exception;
                log_input_tip = English.RecipeInputForm_log_input_tip;
                log_input_success = English.RecipeInputForm_log_input_success;
                log_input_fail = English.RecipeInputForm_log_input_fail;
                log_input_exception = English.RecipeInputForm_log_input_exception;
                log_output_title = English.RecipeInputForm_log_output_title;
                log_output_success = English.RecipeInputForm_log_output_success;
                log_output_fail = English.RecipeInputForm_log_output_fail;
                log_output_exception = English.RecipeInputForm_log_output_exception;
                log_save_success = English.RecipeInputForm_log_save_success;
                log_save_exception = English.RecipeInputForm_log_save_exception;
                #endregion
            }
        }
    }
}
