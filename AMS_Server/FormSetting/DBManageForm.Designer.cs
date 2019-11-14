namespace AMS_Server.FormSetting
{
    partial class DBManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBManageForm));
            this.db_total_panel = new DevComponents.DotNetBar.PanelEx();
            this.db_groupPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.db_backup_button = new DevComponents.DotNetBar.ButtonX();
            this.db_recover_button = new DevComponents.DotNetBar.ButtonX();
            this.db_total_panel.SuspendLayout();
            this.db_groupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // db_total_panel
            // 
            this.db_total_panel.CanvasColor = System.Drawing.SystemColors.Control;
            this.db_total_panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.db_total_panel.Controls.Add(this.db_groupPanel);
            this.db_total_panel.DisabledBackColor = System.Drawing.Color.Empty;
            this.db_total_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_total_panel.Location = new System.Drawing.Point(0, 0);
            this.db_total_panel.Margin = new System.Windows.Forms.Padding(4);
            this.db_total_panel.Name = "db_total_panel";
            this.db_total_panel.Size = new System.Drawing.Size(742, 441);
            this.db_total_panel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.db_total_panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.db_total_panel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.db_total_panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.db_total_panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.db_total_panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.db_total_panel.Style.GradientAngle = 90;
            this.db_total_panel.TabIndex = 6;
            // 
            // db_groupPanel
            // 
            this.db_groupPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.db_groupPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.db_groupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.db_groupPanel.Controls.Add(this.db_backup_button);
            this.db_groupPanel.Controls.Add(this.db_recover_button);
            this.db_groupPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.db_groupPanel.Location = new System.Drawing.Point(125, 84);
            this.db_groupPanel.Margin = new System.Windows.Forms.Padding(4);
            this.db_groupPanel.Name = "db_groupPanel";
            this.db_groupPanel.Size = new System.Drawing.Size(489, 238);
            // 
            // 
            // 
            this.db_groupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.db_groupPanel.Style.BackColorGradientAngle = 90;
            this.db_groupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.db_groupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.db_groupPanel.Style.BorderBottomWidth = 1;
            this.db_groupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.db_groupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.db_groupPanel.Style.BorderLeftWidth = 1;
            this.db_groupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.db_groupPanel.Style.BorderRightWidth = 1;
            this.db_groupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.db_groupPanel.Style.BorderTopWidth = 1;
            this.db_groupPanel.Style.CornerDiameter = 4;
            this.db_groupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.db_groupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.db_groupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.db_groupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.db_groupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.db_groupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.db_groupPanel.TabIndex = 2;
            this.db_groupPanel.Text = "数据库备份为bak文件";
            // 
            // db_backup_button
            // 
            this.db_backup_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.db_backup_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.db_backup_button.Location = new System.Drawing.Point(165, 48);
            this.db_backup_button.Margin = new System.Windows.Forms.Padding(4);
            this.db_backup_button.Name = "db_backup_button";
            this.db_backup_button.Size = new System.Drawing.Size(151, 35);
            this.db_backup_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.db_backup_button.TabIndex = 0;
            this.db_backup_button.Text = "备份数据库";
            this.db_backup_button.Click += new System.EventHandler(this.db_backup_button_Click);
            // 
            // db_recover_button
            // 
            this.db_recover_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.db_recover_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.db_recover_button.Location = new System.Drawing.Point(165, 130);
            this.db_recover_button.Margin = new System.Windows.Forms.Padding(4);
            this.db_recover_button.Name = "db_recover_button";
            this.db_recover_button.Size = new System.Drawing.Size(151, 35);
            this.db_recover_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.db_recover_button.TabIndex = 1;
            this.db_recover_button.Text = "还原数据库";
            this.db_recover_button.Click += new System.EventHandler(this.db_recover_button_Click);
            // 
            // DBManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 441);
            this.Controls.Add(this.db_total_panel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库备份还原";
            this.Load += new System.EventHandler(this.DBManageForm_Load);
            this.db_total_panel.ResumeLayout(false);
            this.db_groupPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx db_total_panel;
        private DevComponents.DotNetBar.Controls.GroupPanel db_groupPanel;
        private DevComponents.DotNetBar.ButtonX db_backup_button;
        private DevComponents.DotNetBar.ButtonX db_recover_button;
    }
}