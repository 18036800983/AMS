namespace AMS_Server.FormSetting
{
    partial class UserManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManageForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.userInfo_groupPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.userOPLevel_textBox = new System.Windows.Forms.TextBox();
            this.userlevel_comboBox = new System.Windows.Forms.ComboBox();
            this.userOPLevel_label = new System.Windows.Forms.Label();
            this.userlevel_label = new System.Windows.Forms.Label();
            this.userPassword_Textbox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.userPassword_label = new System.Windows.Forms.Label();
            this.username_Textbox = new System.Windows.Forms.TextBox();
            this.dataGridView_user = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.toolStrip1.SuspendLayout();
            this.userInfo_groupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAdd,
            this.toolStripEdit,
            this.toolStripDel,
            this.toolStripSeparator1,
            this.toolStripSave,
            this.toolStripExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(727, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAdd.Image")));
            this.toolStripAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.Size = new System.Drawing.Size(63, 24);
            this.toolStripAdd.Text = "新增";
            this.toolStripAdd.Click += new System.EventHandler(this.toolStripAdd_Click);
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEdit.Image")));
            this.toolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(63, 24);
            this.toolStripEdit.Text = "修改";
            this.toolStripEdit.Click += new System.EventHandler(this.toolStripEdit_Click);
            // 
            // toolStripDel
            // 
            this.toolStripDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDel.Image")));
            this.toolStripDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDel.Name = "toolStripDel";
            this.toolStripDel.Size = new System.Drawing.Size(63, 24);
            this.toolStripDel.Text = "删除";
            this.toolStripDel.Click += new System.EventHandler(this.toolStripDel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSave
            // 
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(63, 24);
            this.toolStripSave.Text = "保存";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExit.Image")));
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(63, 24);
            this.toolStripExit.Text = "退出";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // userInfo_groupPanel
            // 
            this.userInfo_groupPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.userInfo_groupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.userInfo_groupPanel.Controls.Add(this.userOPLevel_textBox);
            this.userInfo_groupPanel.Controls.Add(this.userlevel_comboBox);
            this.userInfo_groupPanel.Controls.Add(this.userOPLevel_label);
            this.userInfo_groupPanel.Controls.Add(this.userlevel_label);
            this.userInfo_groupPanel.Controls.Add(this.userPassword_Textbox);
            this.userInfo_groupPanel.Controls.Add(this.username_label);
            this.userInfo_groupPanel.Controls.Add(this.userPassword_label);
            this.userInfo_groupPanel.Controls.Add(this.username_Textbox);
            this.userInfo_groupPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.userInfo_groupPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userInfo_groupPanel.Location = new System.Drawing.Point(0, 27);
            this.userInfo_groupPanel.Margin = new System.Windows.Forms.Padding(4);
            this.userInfo_groupPanel.Name = "userInfo_groupPanel";
            this.userInfo_groupPanel.Size = new System.Drawing.Size(727, 141);
            // 
            // 
            // 
            this.userInfo_groupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.userInfo_groupPanel.Style.BackColorGradientAngle = 90;
            this.userInfo_groupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.userInfo_groupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.userInfo_groupPanel.Style.BorderBottomWidth = 1;
            this.userInfo_groupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.userInfo_groupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.userInfo_groupPanel.Style.BorderLeftWidth = 1;
            this.userInfo_groupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.userInfo_groupPanel.Style.BorderRightWidth = 1;
            this.userInfo_groupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.userInfo_groupPanel.Style.BorderTopWidth = 1;
            this.userInfo_groupPanel.Style.CornerDiameter = 4;
            this.userInfo_groupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.userInfo_groupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.userInfo_groupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.userInfo_groupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.userInfo_groupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.userInfo_groupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.userInfo_groupPanel.TabIndex = 6;
            this.userInfo_groupPanel.Text = "用户信息";
            // 
            // userOPLevel_textBox
            // 
            this.userOPLevel_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userOPLevel_textBox.Location = new System.Drawing.Point(543, 73);
            this.userOPLevel_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.userOPLevel_textBox.Name = "userOPLevel_textBox";
            this.userOPLevel_textBox.Size = new System.Drawing.Size(155, 25);
            this.userOPLevel_textBox.TabIndex = 9;
            // 
            // userlevel_comboBox
            // 
            this.userlevel_comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userlevel_comboBox.FormattingEnabled = true;
            this.userlevel_comboBox.Location = new System.Drawing.Point(143, 75);
            this.userlevel_comboBox.Name = "userlevel_comboBox";
            this.userlevel_comboBox.Size = new System.Drawing.Size(166, 23);
            this.userlevel_comboBox.TabIndex = 8;
            // 
            // userOPLevel_label
            // 
            this.userOPLevel_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userOPLevel_label.AutoSize = true;
            this.userOPLevel_label.Location = new System.Drawing.Point(383, 78);
            this.userOPLevel_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userOPLevel_label.Name = "userOPLevel_label";
            this.userOPLevel_label.Size = new System.Drawing.Size(67, 15);
            this.userOPLevel_label.TabIndex = 5;
            this.userOPLevel_label.Text = "操作权限";
            // 
            // userlevel_label
            // 
            this.userlevel_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userlevel_label.AutoSize = true;
            this.userlevel_label.Location = new System.Drawing.Point(27, 83);
            this.userlevel_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userlevel_label.Name = "userlevel_label";
            this.userlevel_label.Size = new System.Drawing.Size(45, 15);
            this.userlevel_label.TabIndex = 4;
            this.userlevel_label.Text = "权 限";
            // 
            // userPassword_Textbox
            // 
            this.userPassword_Textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userPassword_Textbox.Location = new System.Drawing.Point(543, 18);
            this.userPassword_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.userPassword_Textbox.Name = "userPassword_Textbox";
            this.userPassword_Textbox.PasswordChar = '*';
            this.userPassword_Textbox.Size = new System.Drawing.Size(155, 25);
            this.userPassword_Textbox.TabIndex = 3;
            // 
            // username_label
            // 
            this.username_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(27, 21);
            this.username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(52, 15);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "帐户名";
            // 
            // userPassword_label
            // 
            this.userPassword_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userPassword_label.AutoSize = true;
            this.userPassword_label.Location = new System.Drawing.Point(383, 18);
            this.userPassword_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPassword_label.Name = "userPassword_label";
            this.userPassword_label.Size = new System.Drawing.Size(61, 15);
            this.userPassword_label.TabIndex = 2;
            this.userPassword_label.Text = "密   码";
            // 
            // username_Textbox
            // 
            this.username_Textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_Textbox.Location = new System.Drawing.Point(143, 18);
            this.username_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.username_Textbox.Name = "username_Textbox";
            this.username_Textbox.Size = new System.Drawing.Size(166, 25);
            this.username_Textbox.TabIndex = 1;
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.AllowUserToAddRows = false;
            this.dataGridView_user.AllowUserToDeleteRows = false;
            this.dataGridView_user.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_user.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_user.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView_user.Location = new System.Drawing.Point(0, 168);
            this.dataGridView_user.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_user.MultiSelect = false;
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.ReadOnly = true;
            this.dataGridView_user.RowTemplate.Height = 23;
            this.dataGridView_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_user.Size = new System.Drawing.Size(727, 287);
            this.dataGridView_user.TabIndex = 7;
            this.dataGridView_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellContentClick);
            // 
            // UserManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(727, 455);
            this.Controls.Add(this.dataGridView_user);
            this.Controls.Add(this.userInfo_groupPanel);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.UserManageForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.userInfo_groupPanel.ResumeLayout(false);
            this.userInfo_groupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAdd;
        private System.Windows.Forms.ToolStripButton toolStripEdit;
        private System.Windows.Forms.ToolStripButton toolStripDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private DevComponents.DotNetBar.Controls.GroupPanel userInfo_groupPanel;
        private System.Windows.Forms.TextBox userPassword_Textbox;
        private System.Windows.Forms.Label userPassword_label;
        private System.Windows.Forms.TextBox username_Textbox;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView_user;
        private System.Windows.Forms.Label userOPLevel_label;
        private System.Windows.Forms.Label userlevel_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.ComboBox userlevel_comboBox;
        private System.Windows.Forms.TextBox userOPLevel_textBox;
    }
}