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

namespace AMS_Server.FormSetting
{
    public partial class UserManageForm : Office2007Form
    {
        public delegate void recodeUserLog(string name, string message, int b , bool showFlag);
        public static event recodeUserLog recodeUserMessage;
        System_User_Bll system_User_Bll = new System_User_Bll();
        System_User_Modle system_User_Modle = new System_User_Modle();
        Dictionary<string, string> userDic = new Dictionary<string, string>();

        public UserManageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserManageForm_Load(object sender, EventArgs e)
        {
            try
            {
                #region comboBox added
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    userlevel_comboBox.Items.Add("管理员");
                    userlevel_comboBox.Items.Add("操作员");
                }
                else
                {
                    userlevel_comboBox.Items.Add("manager");
                    userlevel_comboBox.Items.Add("operator");
                }
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
                    recodeUserMessage(string.Empty, "用户界面加载出现异常：" + ex.Message, 1, true);
                    MessageBoxEx.Show("用户界面加载出现异常：" + ex.Message);
                }
                else
                {
                    recodeUserMessage(string.Empty, "operation of loading user page occur exception：" + ex.Message, 1, true);
                    MessageBoxEx.Show("operation of loading user page occur exception：" + ex.Message);
                }
                #endregion
            }
        }

        /// <summary>
        /// add button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            try
            {
                username_Textbox.Text = string.Empty;
                userPassword_Textbox.Text = string.Empty;
                userlevel_comboBox.Text = string.Empty;
                userOPLevel_textBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                #region write log
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    recodeUserMessage(string.Empty,"添加用户操作出现异常：" + ex.Message,1,true);
                    MessageBoxEx.Show("添加用户操作出现异常：" + ex.Message);
                }
                else
                {
                    recodeUserMessage(string.Empty, "operation of adding user occur exception：" + ex.Message, 1, true);
                    MessageBoxEx.Show("operation of adding user occur exception：：" + ex.Message);
                }
                #endregion
            }
        }

        /// <summary>
        /// modify button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            try
            {
                #region check
                if (string.IsNullOrEmpty(username_Textbox.Text.Trim())
                    || string.IsNullOrEmpty(userPassword_Textbox.Text.Trim())
                    || string.IsNullOrEmpty(userlevel_comboBox.Text.Trim()))
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        MessageBoxEx.Show("账户名，密码，权限不能为空，请检查后再添加！");
                        return;
                    }
                    else
                    {
                        MessageBoxEx.Show("user name or password or Permission is null，plsase added by checking！");
                        return;
                    }
                }
                if ((userlevel_comboBox.Text == "操作员" || userlevel_comboBox.Text == "operator")
                    && string.IsNullOrEmpty(userOPLevel_textBox.Text.Trim()))
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        MessageBoxEx.Show("操作员操作权限不能为空！");
                        return;
                    }
                    else
                    {
                        MessageBoxEx.Show("operator operation Promission can't as null！");
                        return;
                    }
                }
                #endregion

                #region Assignment
                if (userDic.Count > 0)
                {
                    if (userDic.ContainsValue(username_Textbox.Text.Trim()))
                    {
                        foreach (var dic in userDic)
                        {
                            if (dic.Value == username_Textbox.Text.Trim())
                            {
                                system_User_Modle.ID = int.Parse(dic.Key);
                            }
                        }
                    }
                    else
                    {
                        if (XML_Tool.xml.SysConfig.IsChinese)
                        {
                            MessageBoxEx.Show("新加用户请点击保存按钮！");
                            return;
                        }
                        else
                        {
                            MessageBoxEx.Show("add new user plsase click save button！");
                            return;
                        }
                    }
                }
                else
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        MessageBoxEx.Show("新加用户请点击保存按钮！");
                        return;
                    }
                    else
                    {
                        MessageBoxEx.Show("add new user plsase click save button！");
                        return;
                    }
                }
                system_User_Modle.UserName = username_Textbox.Text.Trim();
                system_User_Modle.Password = userPassword_Textbox.Text.Trim();
                system_User_Modle.UserLevel = userlevel_comboBox.Text.Trim();
                system_User_Modle.UserOPLevel = userOPLevel_textBox.Text.Trim();
                #endregion

                #region modify
                if (system_User_Bll.Update_ONE_User_Table(system_User_Modle) > 0)
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        recodeUserMessage(string.Empty, "修改用户操作成功！", 0, true);
                        MessageBoxEx.Show("修改用户操作成功！");
                    }
                    else
                    {
                        recodeUserMessage(string.Empty, "operation of modifying user success！", 1, true);
                        MessageBoxEx.Show("operation of modifying user success！");
                    }
                }
                else
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        recodeUserMessage(string.Empty, "修改用户操作失败！", 0, true);
                        MessageBoxEx.Show("修改用户操作失败！");
                    }
                    else
                    {
                        recodeUserMessage(string.Empty, "operation of modifying user failed！", 1, true);
                        MessageBoxEx.Show("operation of modifying user failed！");
                    }
                }
                #endregion

                #region page refrush
                PageFrush();
                #endregion
            }
            catch (Exception ex)
            {
                #region write log
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    recodeUserMessage(string.Empty, "修改用户操作出现异常：" + ex.Message, 1, true);
                    MessageBoxEx.Show("修改用户操作出现异常：" + ex.Message);
                }
                else
                {
                    recodeUserMessage(string.Empty, "operation of modifying user occur exception：" + ex.Message, 1, true);
                    MessageBoxEx.Show("operation of modifying user occur exception：" + ex.Message);
                }
                #endregion
            }
        }

        /// <summary>
        /// delete button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripDel_Click(object sender, EventArgs e)
        {
            try
            {
                #region Assignment
                if (userDic.Count > 0)
                {
                    if (userDic.ContainsValue(username_Textbox.Text.Trim()))
                    {
                        foreach (var dic in userDic)
                        {
                            if (dic.Value == username_Textbox.Text.Trim())
                            {
                                system_User_Modle.ID = int.Parse(dic.Key);
                            }
                        }
                    }
                    else
                    {
                        if (XML_Tool.xml.SysConfig.IsChinese)
                        {
                            MessageBoxEx.Show("没有用户可删除！");
                            return;
                        }
                        else
                        {
                            MessageBoxEx.Show("no user can delete！");
                            return;
                        }
                    }
                }
                else
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        MessageBoxEx.Show("没有用户可删除！");
                        return;
                    }
                    else
                    {
                        MessageBoxEx.Show("no user can delete！");
                        return;
                    }
                }
                #endregion

                #region delete
                if (system_User_Bll.Delete_ONE_User_Table(system_User_Modle) > 0)
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        recodeUserMessage(string.Empty, "删除用户操作成功！", 0, true);
                        MessageBoxEx.Show("删除用户操作成功！");
                    }
                    else
                    {
                        recodeUserMessage(string.Empty, "operation of delete user success！", 1, true);
                        MessageBoxEx.Show("operation of delete user success！");
                    }
                }
                else
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        recodeUserMessage(string.Empty, "删除用户操作失败！", 0, true);
                        MessageBoxEx.Show("删除用户操作失败！");
                    }
                    else
                    {
                        recodeUserMessage(string.Empty, "operation of delete user failed！", 1, true);
                        MessageBoxEx.Show("operation of delete user failed！");
                    }
                }
                #endregion

                #region page refrush
                PageFrush();
                #endregion
            }
            catch (Exception ex)
            {
                #region write log
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    recodeUserMessage(string.Empty, "删除用户操作出现异常：" + ex.Message, 1, true);
                    MessageBoxEx.Show("删除用户操作出现异常：" + ex.Message);
                }
                else
                {
                    recodeUserMessage(string.Empty, "operation of delete user occur exception：" + ex.Message, 1, true);
                    MessageBoxEx.Show("operation of delete user occur exception：" + ex.Message);
                }
                #endregion
            }
        }

        /// <summary>
        /// save button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            try
            {
                #region check
                if (string.IsNullOrEmpty(username_Textbox.Text.Trim())
                    || string.IsNullOrEmpty(userPassword_Textbox.Text.Trim())
                    || string.IsNullOrEmpty(userlevel_comboBox.Text.Trim()))
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        MessageBoxEx.Show("账户名，密码，权限不能为空，请检查后再添加！");
                        return;
                    }
                    else
                    {
                        MessageBoxEx.Show("user name or password or Permission is null，plsase added by checking！");
                        return;
                    }
                }
                if ((userlevel_comboBox.Text == "操作员" || userlevel_comboBox.Text == "operator")
                    && string.IsNullOrEmpty(userOPLevel_textBox.Text.Trim()))
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        MessageBoxEx.Show("操作员操作权限不能为空！");
                        return;
                    }
                    else
                    {
                        MessageBoxEx.Show("operator operation Promission can't as null！");
                        return;
                    }
                }
                if (userDic.ContainsValue(username_Textbox.Text.Trim()))
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        MessageBoxEx.Show("用户已存在！");
                        return;
                    }
                    else
                    {
                        MessageBoxEx.Show("user having existence！");
                        return;
                    }
                }
                #endregion

                #region Assignment
                system_User_Modle.UserName = username_Textbox.Text.Trim();
                system_User_Modle.Password = userPassword_Textbox.Text.Trim();
                system_User_Modle.UserLevel = userlevel_comboBox.Text.Trim();
                system_User_Modle.UserOPLevel = userOPLevel_textBox.Text.Trim();
                #endregion

                #region save
                if (system_User_Bll.Insert_ONE_User_Table(system_User_Modle) > 0)
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        recodeUserMessage(string.Empty, "保存用户操作成功！", 0, true);
                        MessageBoxEx.Show("保存用户操作成功！");
                    }
                    else
                    {
                        recodeUserMessage(string.Empty, "operation of saving user success！", 1, true);
                        MessageBoxEx.Show("operation of saving user success！");
                    }
                }
                else
                {
                    if (XML_Tool.xml.SysConfig.IsChinese)
                    {
                        recodeUserMessage(string.Empty, "保存用户操作失败！", 0, true);
                        MessageBoxEx.Show("保存用户操作失败！");
                    }
                    else
                    {
                        recodeUserMessage(string.Empty, "operation of saving user failed！", 1, true);
                        MessageBoxEx.Show("operation of saving user failed！");
                    }
                }
                #endregion

                #region page refrush
                PageFrush();
                #endregion
            }
            catch (Exception ex)
            {
                #region write log
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    recodeUserMessage(string.Empty, "保存用户操作出现异常：" + ex.Message, 1, true);
                    MessageBoxEx.Show("保存用户操作出现异常：" + ex.Message);
                }
                else
                {
                    recodeUserMessage(string.Empty, "operation of saving user occur exception：" + ex.Message, 1, true);
                    MessageBoxEx.Show("operation of saving user occur exception：" + ex.Message);
                }
                #endregion
            }
        }

        /// <summary>
        /// exit button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// refrush the page
        /// </summary>
        public void PageFrush()
        {
            #region Assignment
            DataTable userDt = new DataTable();
            userDic.Clear();
            userDt = system_User_Bll.Select_ALL_OPUser_Table();
            if (userDt.Rows.Count > 0)
            {
                for (int i = 0; i < userDt.Rows.Count; i++)
                {
                    userDic.Add(userDt.Rows[i]["ID"].ToString(),userDt.Rows[i]["UserName"].ToString());
                }
            }
            #endregion
            dataGridView_user.DataSource = userDt;
        }

        /// <summary>
        /// datagirlview click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username_Textbox.Text = dataGridView_user.CurrentRow.Cells["UserName"].Value.ToString();
                userPassword_Textbox.Text = dataGridView_user.CurrentRow.Cells["Password"].Value.ToString();
                userlevel_comboBox.Text = dataGridView_user.CurrentRow.Cells["UserLevel"].Value.ToString();
                userOPLevel_textBox.Text = dataGridView_user.CurrentRow.Cells["UserOPLevel"].Value.ToString();
            }
            catch (Exception ex)
            {
                #region write log
                if (XML_Tool.xml.SysConfig.IsChinese)
                {
                    recodeUserMessage(string.Empty, "用户显示出现异常：" + ex.Message, 1, true);
                    MessageBoxEx.Show("用户显示出现异常：" + ex.Message);
                }
                else
                {
                    recodeUserMessage(string.Empty, "user display occur exception：" + ex.Message, 1, true);
                    MessageBoxEx.Show("user display occur exception：" + ex.Message);
                }
                #endregion
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
                this.Text = Chinese.UserManageForm_Top_title;
                toolStripAdd.Text = Chinese.UserManageForm_Top_title;
                toolStripEdit.Text = Chinese.UserManageForm_Button_modify;
                toolStripDel.Text = Chinese.UserManageForm_Button_delete;
                toolStripSave.Text = Chinese.UserManageForm_Button_save;
                toolStripExit.Text = Chinese.UserManageForm_Button_exit;
                userInfo_groupPanel.Text = Chinese.UserManageForm_User_tip;
                username_label.Text = Chinese.UserManageForm_User_name;
                userPassword_label.Text = Chinese.UserManageForm_User_pwd;
                userlevel_label.Text = Chinese.UserManageForm_User_level;
                userOPLevel_label.Text = Chinese.UserManageForm_User_opLevel;
                #endregion
            }
            else
            {
                #region text
                this.Text = English.UserManageForm_Top_title;
                toolStripAdd.Text = English.UserManageForm_Top_title;
                toolStripEdit.Text = English.UserManageForm_Button_modify;
                toolStripDel.Text = English.UserManageForm_Button_delete;
                toolStripSave.Text = English.UserManageForm_Button_save;
                toolStripExit.Text = English.UserManageForm_Button_exit;
                userInfo_groupPanel.Text = English.UserManageForm_User_tip;
                username_label.Text = English.UserManageForm_User_name;
                userPassword_label.Text = English.UserManageForm_User_pwd;
                userlevel_label.Text = English.UserManageForm_User_level;
                userOPLevel_label.Text = English.UserManageForm_User_opLevel;
                #endregion
            }
        }
    }
}
