using DevComponents.DotNetBar;
using MyBackup;
using Server_Tools;
using Server_Tools.Language;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_Server.FormSetting
{
    public partial class DBManageForm : Office2007Form
    {
        public delegate void recodeDBBackRecoverLog(string name, string message, int b ,bool showFlag);
        public static event recodeDBBackRecoverLog recodeDBBackRecoverMessage;
        string connectionString;

        string log_backup_success = string.Empty;
        string log_backup_exception = string.Empty;
        string log_recover_success = string.Empty;
        string log_recover_exception = string.Empty;

        public DBManageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DBManageForm_Load(object sender, EventArgs e)
        {
            Language_translation();
        }

        /// <summary>
        /// 备份按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void db_backup_button_Click(object sender, EventArgs e)
        {
            try
            {
                #region copy
                connectionString = DB_Tool.GetConnectionString();
                CopyDatabase();
                #endregion

                #region write log
                recodeDBBackRecoverMessage(string.Empty, log_backup_success, 0 ,true);
                MessageBoxEx.Show(log_backup_success);
                #endregion
            }
            catch (Exception ex)
            {
                #region write log
                recodeDBBackRecoverMessage(string.Empty, log_backup_exception + ex.Message,1 , true);
                #endregion
            }
        }

        /// <summary>
        /// 还原按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void db_recover_button_Click(object sender, EventArgs e)
        {
            #region restore
            Restoredb();
            #endregion

            #region write log
            recodeDBBackRecoverMessage(string.Empty, log_recover_success, 0 ,true);
            MessageBoxEx.Show(log_recover_success);
            #endregion
        }

        /// <summary>
        /// 数据库备份
        /// </summary>
        public void CopyDatabase()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("use master;backup database @name to disk=@path;", connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@name", XML_Tool.xml.DataBase.InitialCatalog);
                command.Parameters.AddWithValue("@path", XML_Tool.xml.DataBase.BackupPath + XML_Tool.xml.DataBase.InitialCatalog + ".bak");
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                recodeDBBackRecoverMessage(string.Empty, log_backup_exception + ex.Message, 1 ,true);
            }
            finally
            {
                connection.Close();
            }
        }

        
        /// <summary>
        /// 数据库还原
        /// </summary>
        public void Restoredb()
        {
            string pathFile = XML_Tool.xml.DataBase.BackupPath + XML_Tool.xml.DataBase.InitialCatalog + ".bak";//bak文件路径
            string dbName = XML_Tool.xml.DataBase.InitialCatalog;//数据库名称
            string connectionString = DB_Tool.GetConnectionString();//数据库连接字符串
            if (!File.Exists(pathFile)) return;
            SqlConnection conn = new SqlConnection(connectionString);
            string cmdStr = string.Format("use master restore database {0} from disk='{1}' with replace", dbName, pathFile);//添加“use master ”解决问题一
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            try
            {
                conn.Open();
                cmd.CommandTimeout = 100;//解决问题二
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                recodeDBBackRecoverMessage(string.Empty, log_recover_exception + ex.Message, 1 ,true);
            }
            finally
            {
                conn.Close();
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
                this.Text = Chinese.DBManageForm_Top_title;
                db_groupPanel.Text = Chinese.DBManageForm_Group_tip;
                db_backup_button.Text = Chinese.DBManageForm_Button_backup;
                db_recover_button.Text = Chinese.DBManageForm_Btton_recover;
                #endregion

                #region log
                log_backup_success = Chinese.DBManageForm_log_backup_success;
                log_backup_exception = Chinese.DBManageForm_log_backup_exception;
                log_recover_success = Chinese.DBManageForm_log_recover_success;
                log_recover_exception = Chinese.DBManageForm_log_recover_exception;
                #endregion
            }
            else
            {
                #region Text
                this.Text = English.DBManageForm_Top_title;
                db_groupPanel.Text = English.DBManageForm_Group_tip;
                db_backup_button.Text = English.DBManageForm_Button_backup;
                db_recover_button.Text = English.DBManageForm_Btton_recover;
                #endregion

                #region log
                log_backup_success = English.DBManageForm_log_backup_success;
                log_backup_exception = English.DBManageForm_log_backup_exception;
                log_recover_success = English.DBManageForm_log_recover_success;
                log_recover_exception = English.DBManageForm_log_recover_exception;
                #endregion
            }
        }
    }
}
