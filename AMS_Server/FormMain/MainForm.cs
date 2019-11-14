using AMS_Server.FormPlan;
using AMS_Server.FormRecipe;
using AMS_Server.FormSetting;
using AMS_Server.FormStation;
using AMS_Server.FormTool;
using DevComponents.DotNetBar;
using Server_BLL;
using Server_Tools;
using Server_Tools.Language;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_Server.FromMain
{
    public partial class MainForm : Office2007Form
    {
        Hashtable recordBox;
        Hashtable stationTabItem;
        Hashtable lineTabItem;
        PLC_Bll plc_bll = new PLC_Bll();
        Thread plcThread;
        System_User_Bll system_User_Bll = new System_User_Bll();
        string log_sys_start = string.Empty;
        Thread realTimeThread;
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            #region user level setting
            if (system_User_Bll.Select_Level_User_Table(LoginForm.userName) == "超级管理员")
            {
                station_buttonItem.Visible = true;
                setting_buttonItem.Enabled = true;
                tool_buttonItem.Enabled = true;
                receipe_buttonItem.Enabled = true;
                plan_buttonItem.Enabled = true;
            }
            else if (system_User_Bll.Select_Level_User_Table(LoginForm.userName) == "管理员" || system_User_Bll.Select_Level_User_Table(LoginForm.userName) == "manager")
            {
                station_buttonItem.Visible = true;
                plcAddressManage_buttonItem.Visible = false;
                setting_buttonItem.Enabled = true;
                tool_buttonItem.Enabled = true;
                receipe_buttonItem.Enabled = true;
                plan_buttonItem.Enabled = true;
            }
            else
            {
                station_buttonItem.Visible = false;
                setting_buttonItem.Enabled = false;
                tool_buttonItem.Enabled = false;
                receipe_buttonItem.Enabled = false;
                plan_buttonItem.Enabled = false;
            }
            #endregion

            #region start every page log
            PLC_Bll.recodePLCStationMessage += new PLC_Bll.recodeStationLog(recordMessage);
           
            DBManageForm.recodeDBBackRecoverMessage += new DBManageForm.recodeDBBackRecoverLog(recordMessage);

            UserManageForm.recodeUserMessage += new UserManageForm.recodeUserLog(recordMessage);

            SystemSettingForm.recodeSettingMessage += new SystemSettingForm.recodeSettingLog(recordMessage);

            Recipe_Bll.recodeRecipeMessage += new Recipe_Bll.recodeRecipeLog(recordMessage);
            #endregion

            #region add log page and plc init
            if (XML_Tool.xml.SysConfig.IsHaveClient)
            {
                foreach (var line in XML_Tool.xml.LINE)
                {
                    List<string> list = new List<string>();
                    foreach (var stattion in line.STATION)
                    {
                        list.Add(stattion.Name);
                    }
                    addTabpages(line.Name, list);
                }

                #region plc init
                plc_bll = new PLC_Bll();
                plc_bll.setStatusEvent += new PLC_Bll.setStatusDg(SetStatusEvent);
                plcThread = new Thread(plc_bll.Init);
                plcThread.IsBackground = true;
                plcThread.Start();
                #endregion
            }
            #endregion

            #region timer init
            Recipe_Bll.Init();
            realTimeThread = new Thread(PLC_Bll.Timer);
            realTimeThread.Start();
            #endregion

            #region write system log
            Language_translation();
            recordMessage(string.Empty, log_sys_start, 0 , true);
            #endregion
        }

        /// <summary>
        /// system setting button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sys_buttonItem_Click(object sender, EventArgs e)
        {
            SystemSettingForm systemSettingForm = new SystemSettingForm();
            systemSettingForm.Show();
        }

        /// <summary>
        /// db setting button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void db_buttonItem_Click(object sender, EventArgs e)
        {
            DBManageForm dBManageForm = new DBManageForm();
            dBManageForm.Show();
        }

        /// <summary>
        /// user setting button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void user_buttonItem_Click(object sender, EventArgs e)
        {
            UserManageForm userManageForm = new UserManageForm();
            userManageForm.Show();
        }

        /// <summary>
        /// log select button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void log_buttonItem_Click(object sender, EventArgs e)
        {
            LogManagerForm logManagerForm = new LogManagerForm();
            logManagerForm.Show();
        }

        /// <summary>
        /// report select button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void report_buttonItem_Click(object sender, EventArgs e)
        {
            ReportManagerForm reportManagerForm = new ReportManagerForm();
            reportManagerForm.Show();
        }

        /// <summary>
        /// report anasys select button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void analysis_buttonItem_Click(object sender, EventArgs e)
        {
            ReportAnalysisForm reportAnalysisForm = new ReportAnalysisForm();
            reportAnalysisForm.Show();
        }

        /// <summary>
        /// station manage button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stationMange_buttonItem_Click(object sender, EventArgs e)
        {
            StationManageForm stationManageForm = new StationManageForm();
            stationManageForm.Show();
        }

        /// <summary>
        /// station plc address manage button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plcAddressManage_buttonItem_Click(object sender, EventArgs e)
        {
            LineManageForm lineManageForm = new LineManageForm();
            lineManageForm.Show();
        }

        /// <summary>
        /// product manage button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productionM_buttonItem_Click(object sender, EventArgs e)
        {
            ProductionManagerForm productionManagerForm = new ProductionManagerForm();
            productionManagerForm.Show();
        }

        /// <summary>
        /// recipe manage button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recipeM_buttonItem_Click(object sender, EventArgs e)
        {
            RecipeManageForm recipeManageForm = new RecipeManageForm();
            recipeManageForm.Show();
        }

        /// <summary>
        /// recipe input button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void receipeInput_buttonItem_Click(object sender, EventArgs e)
        {
            RecipeInputForm recipeInputForm = new RecipeInputForm();
            recipeInputForm.Show();
        }

        /// <summary>
        /// plan manage button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void planM_buttonItem_Click(object sender, EventArgs e)
        {
            PlanManagerForm planManagerForm = new PlanManagerForm();
            planManagerForm.Show();
        }

        /// <summary>
        /// log show
        /// </summary>
        /// <param name="name"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        private void recordMessage(string name, string message, int type ,bool showFlag)
        {
            DevComponents.DotNetBar.Controls.RichTextBoxEx rtb;
            TabItem ti;
            if (name != string.Empty)
            {
                rtb = (DevComponents.DotNetBar.Controls.RichTextBoxEx)recordBox[name];
                ti = (TabItem)stationTabItem[name];
                if (rtb == null)
                {
                    rtb = systemLog_richTextBoxEx;
                    ti = sysLog_tabItem;
                }
            }
            else
            {
                rtb = systemLog_richTextBoxEx;
                ti = sysLog_tabItem;
            }

            LOG_Tool.WriteLogToTxt(name, message, type);

            if (showFlag)
            {
                BeginInvoke((MethodInvoker)delegate () { rtb.Text = rtb.Text.Insert(0, DateTime.Now.ToString("yy/MM/dd-HH:mm:ss") + "  ：  " + message + Environment.NewLine); });

                switch (type)
                {
                    case 0:
                        break;
                    case 1:

                        BeginInvoke((MethodInvoker)delegate () { ti.Image = Properties.Resources.stop; });
                        break;
                    case 2:

                        BeginInvoke((MethodInvoker)delegate () { ti.Image = Properties.Resources.stop3; });
                        break;
                    case 3:

                        BeginInvoke((MethodInvoker)delegate () { ti.Image = Properties.Resources.run4; });
                        break;
                    case 4:

                        BeginInvoke((MethodInvoker)delegate () { ti.Image = Properties.Resources.parts2; });
                        break;
                    case 5:

                        BeginInvoke((MethodInvoker)delegate () { ti.Image = Properties.Resources.run4; });
                        break;
                    case 6:

                        BeginInvoke((MethodInvoker)delegate () { ti.Image = Properties.Resources.bolt2; });
                        break;
                }
            }
        }

        /// <summary>
        /// add tab page
        /// </summary>
        /// <param name="name"></param>
        /// <param name="stationList"></param>
        private void addTabpages(string name, List<string> stationList)
        {
            recordBox = new Hashtable();
            stationTabItem = new Hashtable();
            lineTabItem = new Hashtable();

            DevComponents.DotNetBar.TabControl tabControl = new DevComponents.DotNetBar.TabControl();
            TabControlPanel tabControlPanel = new TabControlPanel();
            TabItem tabItem = new TabItem();

            tabControl.Dock = DockStyle.Fill;
            tabControl.TabAlignment = eTabStripAlignment.Bottom;
            tabControl.Style = eTabStripStyle.Office2007Document;
            tabControlPanel.Controls.Add(tabControl);
            tabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tabItem.AttachedControl = tabControlPanel;
            tabItem.Text = name;
            tabItem.ImageIndex = 1;
            statue_tabControl.Controls.Add(tabControlPanel);
            statue_tabControl.Tabs.Add(tabItem);
            lineTabItem.Add(name, tabItem);

            foreach (string name_ in stationList)
            {
                TabItem tabItem_ = new TabItem();
                TabControlPanel tabControlPanel_ = new TabControlPanel();
                DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
                richTextBox.Dock = DockStyle.Fill;
                richTextBox.BorderStyle = BorderStyle.None;
                tabControlPanel_.Controls.Add(richTextBox);
                tabControlPanel_.Dock = DockStyle.Fill;
                tabItem_.AttachedControl = tabControlPanel_;
                tabItem_.Text = name_;
                tabItem_.Image = Properties.Resources.stop3;
                tabControl.Controls.Add(tabControlPanel_);
                tabControl.Tabs.Add(tabItem_);
                stationTabItem.Add(name + name_, tabItem_);
                recordBox.Add(name + name_, richTextBox);
            }
        }

        /// <summary>
        /// set status
        /// </summary>
        /// <param name="name"></param>
        /// <param name="index"></param>
        private void SetStatusEvent(string name, int index)
        {
            if (!this.IsHandleCreated) return;
            this.Invoke((MethodInvoker)delegate
            {
                foreach (System.Collections.DictionaryEntry de in lineTabItem)
                {
                    if (de.Key.ToString() == name)
                    {
                        ((TabItem)de.Value).Image = imageList.Images[index];
                    }
                }
            });
        }

        /// <summary>
        /// translation
        /// </summary>
        public void Language_translation()
        {
            if (XML_Tool.xml.SysConfig.IsChinese)
            {
                #region Text
                this.Text = Chinese.MainForm_Top_title;
                title_label.Text = Chinese.MainForm_Middle_title;
                setting_buttonItem.Text = Chinese.MainForm_TopBar_Setting;
                sys_buttonItem.Text = Chinese.MainForm_TopBar_Setting_sys;
                db_buttonItem.Text = Chinese.MainForm_TopBar_Setting_db;
                user_buttonItem.Text = Chinese.MainForm_TopBar_Setting_user;
                tool_buttonItem.Text = Chinese.MainForm_TopBar_Tool;
                log_buttonItem.Text = Chinese.MainForm_TopBar_Tool_log;
                report_buttonItem.Text = Chinese.MainForm_TopBar_Tool_report;
                analysis_buttonItem.Text = Chinese.MainForm_TopBar_Tool_analysis;
                station_buttonItem.Text = Chinese.MainForm_TopBar_Station;
                stationMange_buttonItem.Text = Chinese.MainForm_TopBar_Station_stationM;
                plcAddressManage_buttonItem.Text = Chinese.MainForm_TopBar_Station_plcAddr;
                receipe_buttonItem.Text = Chinese.MainForm_TopBar_Recipe;
                productionM_buttonItem.Text = Chinese.MainForm_TopBar_Recipe_production;
                recipeM_buttonItem.Text = Chinese.MainForm_TopBar_Recipe_recipeM;
                receipeInput_buttonItem.Text = Chinese.MainForm_TopBar_Recipe_recipeInput;
                plan_buttonItem.Text = Chinese.MainForm_TopBar_Plan;
                planM_buttonItem.Text = Chinese.MainForm_TopBar_Plan_planM;
                sysLog_tabItem.Text = Chinese.MainForm_TabControl_Log;
                #endregion

                #region control
                //this.title_label.Location = new System.Drawing.Point(160, 300);
                this.title_label.Font = new System.Drawing.Font("隶书", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                #endregion

                #region log
                log_sys_start = Chinese.MainForm_Log_System_Start;
                #endregion
            }
            else
            {
                #region text
                this.Text = English.MainForm_Top_title;
                title_label.Text = English.MainForm_Middle_title;
                setting_buttonItem.Text = English.MainForm_TopBar_Setting;
                sys_buttonItem.Text = English.MainForm_TopBar_Setting_sys;
                db_buttonItem.Text = English.MainForm_TopBar_Setting_db;
                user_buttonItem.Text = English.MainForm_TopBar_Setting_user;
                tool_buttonItem.Text = English.MainForm_TopBar_Tool;
                log_buttonItem.Text = English.MainForm_TopBar_Tool_log;
                report_buttonItem.Text = English.MainForm_TopBar_Tool_report;
                analysis_buttonItem.Text = English.MainForm_TopBar_Tool_analysis;
                station_buttonItem.Text = English.MainForm_TopBar_Station;
                stationMange_buttonItem.Text = English.MainForm_TopBar_Station_stationM;
                plcAddressManage_buttonItem.Text = English.MainForm_TopBar_Station_plcAddr;
                receipe_buttonItem.Text = English.MainForm_TopBar_Recipe;
                productionM_buttonItem.Text = English.MainForm_TopBar_Recipe_production;
                recipeM_buttonItem.Text = English.MainForm_TopBar_Recipe_recipeM;
                receipeInput_buttonItem.Text = English.MainForm_TopBar_Recipe_recipeInput;
                plan_buttonItem.Text = English.MainForm_TopBar_Plan;
                planM_buttonItem.Text = English.MainForm_TopBar_Plan_planM;
                sysLog_tabItem.Text = English.MainForm_TabControl_Log;
                #endregion

                #region control
                this.title_label.Location = new System.Drawing.Point(160, 300);
                this.title_label.Font = new System.Drawing.Font("隶书", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                #endregion

                #region log
                log_sys_start = English.MainForm_Log_System_Start;
                #endregion
            }
        }

        /// <summary>
        /// 页面关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (plcThread != null)
                    plcThread.Abort();
                if (realTimeThread != null)
                    realTimeThread.Abort();
            }
            catch (Exception) { }
        }
    }
}
