using DevComponents.DotNetBar;
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
using static Server_Modle.XML.Xml_DbConfig;

namespace AMS_Server.FormSetting
{
    public partial class SystemSettingForm : Office2007Form
    {
        public delegate void recodeSettingLog(string name, string message, int b, bool showFlag);
        public static event recodeSettingLog recodeSettingMessage;

        string log_page_exception = string.Empty;
        string log_save_success = string.Empty;
        string log_save_exception = string.Empty;

        public SystemSettingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemSettingForm_Load(object sender, EventArgs e)
        {
            try
            {
                #region combobox added
                dbType_comboBox.Items.Add("MySql");
                dbType_comboBox.Items.Add("SqlServer");
                dbType_comboBox.Items.Add("Oracle");

                parity_comboBox.Items.Add("Even");
                parity_comboBox.Items.Add("Mark");
                parity_comboBox.Items.Add("None");
                parity_comboBox.Items.Add("Odd");
                parity_comboBox.Items.Add("Space");

                stopBits_comboBox.Items.Add("None");
                stopBits_comboBox.Items.Add("One");
                stopBits_comboBox.Items.Add("OnePointFive");
                stopBits_comboBox.Items.Add("Two");

                isChinese_comboBox.Items.Add("true");
                isChinese_comboBox.Items.Add("false");

                isClient_comboBox.Items.Add("true");
                isClient_comboBox.Items.Add("false");

                startWithLogin_comboBox.Items.Add("true");
                startWithLogin_comboBox.Items.Add("false");

                endWithLogin_comboBox.Items.Add("true");
                endWithLogin_comboBox.Items.Add("false");
                #endregion

                #region page frush
                PageFrush();
                Language_translation();
                #endregion
            }
            catch (Exception ex)
            {
                #region write log
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    recodeSettingMessage(string.Empty,"加载配置出现异常：" + ex.Message,1,true);
                    MessageBoxEx.Show("加载配置出现异常：" + ex.Message);
                }
                else
                {
                    recodeSettingMessage(string.Empty, "load config occers exception：" + ex.Message, 1, true);
                    MessageBoxEx.Show("load config occers exception：" + ex.Message);
                }
                #endregion
            }
        }

        /// <summary>
        /// save event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                #region DB
                XML_Tool.xml.DataBase.DataSource = serviceName__Textbox.Text;
                XML_Tool.xml.DataBase.InitialCatalog = dbName_textBox.Text;
                XML_Tool.xml.DataBase.UserID = userName__textBox.Text;
                XML_Tool.xml.DataBase.pwd = userPassword_textBox.Text;
                XML_Tool.xml.DataBase.BackupPath = backupPath_textBox.Text;
                if (dbType_comboBox.Text == "MySql")
                {
                    XML_Tool.xml.DataBase.DatabaseType = DbProviderType.MySql;
                }
                else if (dbType_comboBox.Text == "SqlServer")
                {
                    XML_Tool.xml.DataBase.DatabaseType = DbProviderType.SqlServer;
                }
                else
                {
                    XML_Tool.xml.DataBase.DatabaseType = DbProviderType.Oracle;
                }
                #endregion

                #region serialPort
                XML_Tool.xml.SerialPortConfig.Name = serialPortName_textBox.Text;
                switch (parity_comboBox.Text)
                {
                    case "Even":
                        XML_Tool.xml.SerialPortConfig.Parity = System.IO.Ports.Parity.Even;
                        break;
                    case "Mark":
                        XML_Tool.xml.SerialPortConfig.Parity = System.IO.Ports.Parity.Mark;
                        break;
                    case "None":
                        XML_Tool.xml.SerialPortConfig.Parity = System.IO.Ports.Parity.None;
                        break;
                    case "Odd":
                        XML_Tool.xml.SerialPortConfig.Parity = System.IO.Ports.Parity.Odd;
                        break;
                    case "Space":
                        XML_Tool.xml.SerialPortConfig.Parity = System.IO.Ports.Parity.Space;
                        break;
                    default:
                        break;
                }
                XML_Tool.xml.SerialPortConfig.BaudRate = int.Parse(baudRate_textBox.Text);
                XML_Tool.xml.SerialPortConfig.DataBits = int.Parse(dataBits_textBox.Text);
                switch (stopBits_comboBox.Text)
                {
                    case "None":
                        XML_Tool.xml.SerialPortConfig.StopBits = System.IO.Ports.StopBits.None;
                        break;
                    case "One":
                        XML_Tool.xml.SerialPortConfig.StopBits = System.IO.Ports.StopBits.One;
                        break;
                    case "OnePointFive":
                        XML_Tool.xml.SerialPortConfig.StopBits = System.IO.Ports.StopBits.OnePointFive;
                        break;
                    case "Two":
                        XML_Tool.xml.SerialPortConfig.StopBits = System.IO.Ports.StopBits.Two;
                        break;
                    default:
                        break;
                }
                #endregion

                #region printer
                XML_Tool.xml.Printer.IP = printIP_textBox.Text;
                XML_Tool.xml.Printer.PORT = port_textBox.Text;
                XML_Tool.xml.Printer.ZPLCODE = zplCode_textBox.Text;
                #endregion

                #region system
                XML_Tool.xml.SysConfig.IsChinese = bool.Parse(isChinese_comboBox.Text);
                XML_Tool.xml.SysConfig.IsHaveClient = bool.Parse(isClient_comboBox.Text);
                XML_Tool.xml.SysConfig.startWithReport = bool.Parse(startWithLogin_comboBox.Text);
                XML_Tool.xml.SysConfig.QuitWithLogin = bool.Parse(endWithLogin_comboBox.Text);
                #endregion

                #region save
                XML_Tool.Save();
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    recodeSettingMessage(string.Empty, "保存配置成功！", 0, true);
                    MessageBoxEx.Show("保存配置成功");
                }
                else
                {
                    recodeSettingMessage(string.Empty, "save config success！" , 0, true);
                    MessageBoxEx.Show("save config success！");
                }
                PageFrush();
                #endregion
            }
            catch (Exception ex)
            {
                #region write log
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    recodeSettingMessage(string.Empty, "保存配置出现异常：" + ex.Message, 1, true);
                    MessageBoxEx.Show("保存配置出现异常：" + ex.Message);
                }
                else
                {
                    recodeSettingMessage(string.Empty, "save config occers exception：" + ex.Message, 1, true);
                    MessageBoxEx.Show("save config occers exception：" + ex.Message);
                }
                #endregion            
            }
        }

        /// <summary>
        /// page frush
        /// </summary>
        public void PageFrush()
        {
            #region DB
            serviceName__Textbox.Text = XML_Tool.xml.DataBase.DataSource;
            dbName_textBox.Text = XML_Tool.xml.DataBase.InitialCatalog;
            userName__textBox.Text = XML_Tool.xml.DataBase.UserID;
            userPassword_textBox.Text = XML_Tool.xml.DataBase.pwd;
            backupPath_textBox.Text = XML_Tool.xml.DataBase.BackupPath;
            dbType_comboBox.Text = XML_Tool.xml.DataBase.DatabaseType.ToString();
            #endregion

            #region serialPort
            serialPortName_textBox.Text = XML_Tool.xml.SerialPortConfig.Name;
            parity_comboBox.Text = XML_Tool.xml.SerialPortConfig.Parity.ToString();
            baudRate_textBox.Text = XML_Tool.xml.SerialPortConfig.BaudRate.ToString();
            dataBits_textBox.Text = XML_Tool.xml.SerialPortConfig.DataBits.ToString();
            stopBits_comboBox.Text = XML_Tool.xml.SerialPortConfig.StopBits.ToString();
            #endregion

            #region printer
            printIP_textBox.Text = XML_Tool.xml.Printer.IP;
            port_textBox.Text = XML_Tool.xml.Printer.PORT;
            zplCode_textBox.Text = XML_Tool.xml.Printer.ZPLCODE;
            #endregion

            #region system
            isChinese_comboBox.Text = XML_Tool.xml.SysConfig.IsChinese.ToString();
            isClient_comboBox.Text = XML_Tool.xml.SysConfig.IsHaveClient.ToString();
            startWithLogin_comboBox.Text = XML_Tool.xml.SysConfig.startWithReport.ToString();
            endWithLogin_comboBox.Text = XML_Tool.xml.SysConfig.QuitWithLogin.ToString();
            #endregion
        }

        /// <summary>
        /// translation
        /// </summary>
        public void Language_translation()
        {
            if (XML_Tool.xml.SysConfig.IsChinese)
            {
                #region Text
                this.Text = Chinese.SystemSettingForm_Top_title;
                db_groupPanel.Text = Chinese.SystemSettingForm_Db_tip;
                serviceName_label.Text = Chinese.SystemSettingForm_Db_serviceName;
                dbName_label.Text = Chinese.SystemSettingForm_Db_dbName;
                userName_label.Text = Chinese.SystemSettingForm_Db_loginName;
                userPassword_label.Text = Chinese.SystemSettingForm_Db_pwd;
                backupPath_label.Text = Chinese.SystemSettingForm_Db_backupPath;
                dbType_label.Text = Chinese.SystemSettingForm_Db_dbType;
                serialPort_groupPanel.Text = Chinese.SystemSettingForm_SerialPort_tip;
                serialPortName_label.Text = Chinese.SystemSettingForm_SerialPort_name;
                parity_label.Text = Chinese.SystemSettingForm_SerialPort_parity;
                baudRate_label.Text = Chinese.SystemSettingForm_SerialPort_bandRate;
                dataBits_label.Text = Chinese.SystemSettingForm_SerialPort_dataBits;
                stopBits_label.Text = Chinese.SystemSettingForm_SerialPort_stopBits;
                printer_groupPanel.Text = Chinese.SystemSettingForm_Print_tip;
                printIP_label.Text = Chinese.SystemSettingForm_Print_IP;
                port_label.Text = Chinese.SystemSettingForm_Print_port;
                zplCode_label.Text = Chinese.SystemSettingForm_Print_code;
                sys_groupPanel.Text = Chinese.SystemSettingForm_sys_tip;
                isChinese_label.Text = Chinese.SystemSettingForm_sys_isChinese;
                isClient_label.Text = Chinese.SystemSettingForm_sys_isClient;
                startWithLogin_label.Text = Chinese.SystemSettingForm_sys_startWithLogin;
                endWithLogin_label.Text = Chinese.SystemSettingForm_sys_endWithLogin;
                save_toolStripMenuItem.Text = Chinese.SystemSettingForm_Button_save;
                #endregion

                #region log
                log_page_exception = Chinese.SystemSettingForm_log_page_exception;
                log_save_success = Chinese.SystemSettingForm_log_save_success;
                log_save_exception = Chinese.SystemSettingForm_log_save_exception;
                #endregion
            }
            else
            {
                #region text
                this.Text = English.SystemSettingForm_Top_title;
                db_groupPanel.Text = English.SystemSettingForm_Db_tip;
                serviceName_label.Text = English.SystemSettingForm_Db_serviceName;
                dbName_label.Text = English.SystemSettingForm_Db_dbName;
                userName_label.Text = English.SystemSettingForm_Db_loginName;
                userPassword_label.Text = English.SystemSettingForm_Db_pwd;
                backupPath_label.Text = English.SystemSettingForm_Db_backupPath;
                dbType_label.Text = English.SystemSettingForm_Db_dbType;
                serialPort_groupPanel.Text = English.SystemSettingForm_SerialPort_tip;
                serialPortName_label.Text = English.SystemSettingForm_SerialPort_name;
                parity_label.Text = English.SystemSettingForm_SerialPort_parity;
                baudRate_label.Text = English.SystemSettingForm_SerialPort_bandRate;
                dataBits_label.Text = English.SystemSettingForm_SerialPort_dataBits;
                stopBits_label.Text = English.SystemSettingForm_SerialPort_stopBits;
                printer_groupPanel.Text = English.SystemSettingForm_Print_tip;
                printIP_label.Text = English.SystemSettingForm_Print_IP;
                port_label.Text = English.SystemSettingForm_Print_port;
                zplCode_label.Text = English.SystemSettingForm_Print_code;
                sys_groupPanel.Text = English.SystemSettingForm_sys_tip;
                isChinese_label.Text = English.SystemSettingForm_sys_isChinese;
                isClient_label.Text = English.SystemSettingForm_sys_isClient;
                startWithLogin_label.Text = English.SystemSettingForm_sys_startWithLogin;
                endWithLogin_label.Text = English.SystemSettingForm_sys_endWithLogin;
                save_toolStripMenuItem.Text = English.SystemSettingForm_Button_save;
                #endregion

                #region log
                log_page_exception = English.SystemSettingForm_log_page_exception;
                log_save_success = English.SystemSettingForm_log_save_success;
                log_save_exception = English.SystemSettingForm_log_save_exception;
                #endregion
            }
        }
    }
}
