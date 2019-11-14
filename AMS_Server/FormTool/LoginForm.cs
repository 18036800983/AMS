using DevComponents.DotNetBar;
using Server_BLL;
using Server_Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server_Tools.Language;

namespace AMS_Server.FormTool
{
    public partial class LoginForm : Office2007Form
    {
        System_User_Bll system_User_Bll = new System_User_Bll();
        Dictionary<string, string> KeyValues = new Dictionary<string, string>();
        public static string userName = string.Empty;
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            Language_translation();
            PageFrush();
        }

        /// <summary>
        /// login button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(login_name_comboBox.Text) || string.IsNullOrEmpty(login_pwd_textBox.Text))
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                        MessageBoxEx.Show("用户名或密码为空！");
                    else
                        MessageBoxEx.Show("User Name Or Password Can not Null！");
                    return;
                }
                foreach (var dic in KeyValues)
                {
                    if (dic.Key == login_name_comboBox.Text)
                    {
                        if (dic.Value == login_pwd_textBox.Text)
                        {
                            userName = dic.Key;
                            this.Close();
                        }
                        else
                        {
                            if (XML_Tool.xml.SysConfig.IsChinese)
                                MessageBoxEx.Show("用户名或密码错误！");
                            else
                                MessageBoxEx.Show("User Name Or Password is error！");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (XML_Tool.xml.SysConfig.IsChinese)
                    MessageBoxEx.Show("登录异常：" + ex.Message);
                else
                    MessageBoxEx.Show("Login Exception：" + ex.Message);
            }
        }

        /// <summary>
        /// cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// page frush
        /// </summary>
        public void PageFrush()
        {
            KeyValues.Clear();
            DataTable dataTable = system_User_Bll.Select_ALL_User_Table();
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (!KeyValues.ContainsKey(dataTable.Rows[i]["UserName"].ToString()))
                    {
                        KeyValues.Add(dataTable.Rows[i]["UserName"].ToString(), dataTable.Rows[i]["Password"].ToString());
                        if(dataTable.Rows[i]["UserLevel"].ToString() != "超级管理员")
                            login_name_comboBox.Items.Add(dataTable.Rows[i]["UserName"].ToString());
                    }
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
                #region Text
                login_name_label.Text = Chinese.LoginForm_UserName;
                login_pwd_label.Text = Chinese.LoginForm_Password;
                login_button.Text = Chinese.LoginForm_Sure;
                cancel_button.Text = Chinese.LoginForm_Cancle;
                #endregion
            }
            else
            {
                #region text
                login_name_label.Text = English.LoginForm_UserName;
                login_pwd_label.Text = English.LoginForm_Password;
                login_button.Text = English.LoginForm_Sure;
                cancel_button.Text = English.LoginForm_Cancle;
                #endregion
            }
        }
    }
}
