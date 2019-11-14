namespace AMS_Server.FormTool
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_reflectionLabel = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.login_name_label = new System.Windows.Forms.Label();
            this.login_name_comboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.login_pwd_label = new System.Windows.Forms.Label();
            this.login_pwd_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.login_button = new DevComponents.DotNetBar.ButtonX();
            this.cancel_button = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // label_reflectionLabel
            // 
            // 
            // 
            // 
            this.label_reflectionLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_reflectionLabel.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_reflectionLabel.Location = new System.Drawing.Point(75, 30);
            this.label_reflectionLabel.Margin = new System.Windows.Forms.Padding(4);
            this.label_reflectionLabel.Name = "label_reflectionLabel";
            this.label_reflectionLabel.Size = new System.Drawing.Size(382, 93);
            this.label_reflectionLabel.TabIndex = 15;
            this.label_reflectionLabel.Text = "<b><font size=\"+10\"><i>                                                          " +
    "                                                          AMS </i><font color=\"#" +
    "B02B2C\">装配线管理系统</font></font></b>";
            // 
            // login_name_label
            // 
            this.login_name_label.AutoSize = true;
            this.login_name_label.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_name_label.Location = new System.Drawing.Point(93, 147);
            this.login_name_label.Name = "login_name_label";
            this.login_name_label.Size = new System.Drawing.Size(89, 20);
            this.login_name_label.TabIndex = 16;
            this.login_name_label.Text = "登录账号";
            // 
            // login_name_comboBox
            // 
            this.login_name_comboBox.DisplayMember = "Text";
            this.login_name_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.login_name_comboBox.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_name_comboBox.FormattingEnabled = true;
            this.login_name_comboBox.ItemHeight = 24;
            this.login_name_comboBox.Location = new System.Drawing.Point(220, 142);
            this.login_name_comboBox.Name = "login_name_comboBox";
            this.login_name_comboBox.Size = new System.Drawing.Size(185, 30);
            this.login_name_comboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.login_name_comboBox.TabIndex = 17;
            // 
            // login_pwd_label
            // 
            this.login_pwd_label.AutoSize = true;
            this.login_pwd_label.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_pwd_label.Location = new System.Drawing.Point(93, 208);
            this.login_pwd_label.Name = "login_pwd_label";
            this.login_pwd_label.Size = new System.Drawing.Size(89, 20);
            this.login_pwd_label.TabIndex = 18;
            this.login_pwd_label.Text = "登录密码";
            // 
            // login_pwd_textBox
            // 
            // 
            // 
            // 
            this.login_pwd_textBox.Border.Class = "TextBoxBorder";
            this.login_pwd_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.login_pwd_textBox.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_pwd_textBox.Location = new System.Drawing.Point(220, 208);
            this.login_pwd_textBox.Name = "login_pwd_textBox";
            this.login_pwd_textBox.PasswordChar = '*';
            this.login_pwd_textBox.PreventEnterBeep = true;
            this.login_pwd_textBox.Size = new System.Drawing.Size(185, 30);
            this.login_pwd_textBox.TabIndex = 19;
            // 
            // login_button
            // 
            this.login_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.login_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.login_button.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_button.Location = new System.Drawing.Point(97, 268);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(85, 30);
            this.login_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.login_button.TabIndex = 20;
            this.login_button.Text = "登录";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancel_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancel_button.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel_button.Location = new System.Drawing.Point(320, 268);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(85, 30);
            this.cancel_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancel_button.TabIndex = 21;
            this.cancel_button.Text = "取消";
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 343);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_pwd_textBox);
            this.Controls.Add(this.login_pwd_label);
            this.Controls.Add(this.login_name_comboBox);
            this.Controls.Add(this.login_name_label);
            this.Controls.Add(this.label_reflectionLabel);
            this.DoubleBuffered = true;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel label_reflectionLabel;
        private System.Windows.Forms.Label login_name_label;
        private DevComponents.DotNetBar.Controls.ComboBoxEx login_name_comboBox;
        private System.Windows.Forms.Label login_pwd_label;
        private DevComponents.DotNetBar.Controls.TextBoxX login_pwd_textBox;
        private DevComponents.DotNetBar.ButtonX login_button;
        private DevComponents.DotNetBar.ButtonX cancel_button;
    }
}