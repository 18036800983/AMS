namespace AMS_Server.FromMain
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.top_bar = new DevComponents.DotNetBar.Bar();
            this.setting_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.sys_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.db_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.user_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.tool_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.log_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.report_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.analysis_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.station_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.stationMange_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.plcAddressManage_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.receipe_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.productionM_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.recipeM_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.receipeInput_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.plan_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.planM_buttonItem = new DevComponents.DotNetBar.ButtonItem();
            this.statue_tabControl = new DevComponents.DotNetBar.TabControl();
            this.sysLog_tabControlPanel = new DevComponents.DotNetBar.TabControlPanel();
            this.systemLog_richTextBoxEx = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.sysLog_tabItem = new DevComponents.DotNetBar.TabItem(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.title_label = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.top_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statue_tabControl)).BeginInit();
            this.statue_tabControl.SuspendLayout();
            this.sysLog_tabControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // top_bar
            // 
            this.top_bar.AntiAlias = true;
            this.top_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.top_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_bar.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.top_bar.IsMaximized = false;
            this.top_bar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.setting_buttonItem,
            this.tool_buttonItem,
            this.station_buttonItem,
            this.receipe_buttonItem,
            this.plan_buttonItem});
            this.top_bar.Location = new System.Drawing.Point(0, 0);
            this.top_bar.Name = "top_bar";
            this.top_bar.Size = new System.Drawing.Size(1330, 36);
            this.top_bar.Stretch = true;
            this.top_bar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.top_bar.TabIndex = 4;
            this.top_bar.TabStop = false;
            this.top_bar.Text = "bar1";
            // 
            // setting_buttonItem
            // 
            this.setting_buttonItem.Name = "setting_buttonItem";
            this.setting_buttonItem.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sys_buttonItem,
            this.db_buttonItem,
            this.user_buttonItem});
            this.setting_buttonItem.Text = "设置 ";
            // 
            // sys_buttonItem
            // 
            this.sys_buttonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("sys_buttonItem.Icon")));
            this.sys_buttonItem.Name = "sys_buttonItem";
            this.sys_buttonItem.Text = "系统设置";
            this.sys_buttonItem.Click += new System.EventHandler(this.sys_buttonItem_Click);
            // 
            // db_buttonItem
            // 
            this.db_buttonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("db_buttonItem.Icon")));
            this.db_buttonItem.Name = "db_buttonItem";
            this.db_buttonItem.Text = "数据库设置";
            this.db_buttonItem.Click += new System.EventHandler(this.db_buttonItem_Click);
            // 
            // user_buttonItem
            // 
            this.user_buttonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("user_buttonItem.Icon")));
            this.user_buttonItem.Name = "user_buttonItem";
            this.user_buttonItem.Text = "用户设置";
            this.user_buttonItem.Click += new System.EventHandler(this.user_buttonItem_Click);
            // 
            // tool_buttonItem
            // 
            this.tool_buttonItem.Name = "tool_buttonItem";
            this.tool_buttonItem.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.log_buttonItem,
            this.report_buttonItem,
            this.analysis_buttonItem});
            this.tool_buttonItem.Text = " 工具 ";
            // 
            // log_buttonItem
            // 
            this.log_buttonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("log_buttonItem.Icon")));
            this.log_buttonItem.Name = "log_buttonItem";
            this.log_buttonItem.Text = "日志查询";
            this.log_buttonItem.Click += new System.EventHandler(this.log_buttonItem_Click);
            // 
            // report_buttonItem
            // 
            this.report_buttonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("report_buttonItem.Icon")));
            this.report_buttonItem.Name = "report_buttonItem";
            this.report_buttonItem.Text = "报表查询";
            this.report_buttonItem.Click += new System.EventHandler(this.report_buttonItem_Click);
            // 
            // analysis_buttonItem
            // 
            this.analysis_buttonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("analysis_buttonItem.Icon")));
            this.analysis_buttonItem.Name = "analysis_buttonItem";
            this.analysis_buttonItem.Text = "报警分析";
            this.analysis_buttonItem.Click += new System.EventHandler(this.analysis_buttonItem_Click);
            // 
            // station_buttonItem
            // 
            this.station_buttonItem.Name = "station_buttonItem";
            this.station_buttonItem.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stationMange_buttonItem,
            this.plcAddressManage_buttonItem});
            this.station_buttonItem.Text = "工位";
            // 
            // stationMange_buttonItem
            // 
            this.stationMange_buttonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("stationMange_buttonItem.Icon")));
            this.stationMange_buttonItem.Name = "stationMange_buttonItem";
            this.stationMange_buttonItem.Text = "工位管理";
            this.stationMange_buttonItem.Click += new System.EventHandler(this.stationMange_buttonItem_Click);
            // 
            // plcAddressManage_buttonItem
            // 
            this.plcAddressManage_buttonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("plcAddressManage_buttonItem.Icon")));
            this.plcAddressManage_buttonItem.Name = "plcAddressManage_buttonItem";
            this.plcAddressManage_buttonItem.Text = "产线管理";
            this.plcAddressManage_buttonItem.Click += new System.EventHandler(this.plcAddressManage_buttonItem_Click);
            // 
            // receipe_buttonItem
            // 
            this.receipe_buttonItem.Name = "receipe_buttonItem";
            this.receipe_buttonItem.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.productionM_buttonItem,
            this.recipeM_buttonItem,
            this.receipeInput_buttonItem});
            this.receipe_buttonItem.Text = "配方";
            // 
            // productionM_buttonItem
            // 
            this.productionM_buttonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("productionM_buttonItem.Icon")));
            this.productionM_buttonItem.Name = "productionM_buttonItem";
            this.productionM_buttonItem.Text = "产品管理";
            this.productionM_buttonItem.Click += new System.EventHandler(this.productionM_buttonItem_Click);
            // 
            // recipeM_buttonItem
            // 
            this.recipeM_buttonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("recipeM_buttonItem.Icon")));
            this.recipeM_buttonItem.Name = "recipeM_buttonItem";
            this.recipeM_buttonItem.Text = "配方管理";
            this.recipeM_buttonItem.Click += new System.EventHandler(this.recipeM_buttonItem_Click);
            // 
            // receipeInput_buttonItem
            // 
            this.receipeInput_buttonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("receipeInput_buttonItem.Icon")));
            this.receipeInput_buttonItem.Name = "receipeInput_buttonItem";
            this.receipeInput_buttonItem.Text = "配方导入";
            this.receipeInput_buttonItem.Click += new System.EventHandler(this.receipeInput_buttonItem_Click);
            // 
            // plan_buttonItem
            // 
            this.plan_buttonItem.Name = "plan_buttonItem";
            this.plan_buttonItem.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.planM_buttonItem});
            this.plan_buttonItem.Text = "计划";
            // 
            // planM_buttonItem
            // 
            this.planM_buttonItem.Icon = ((System.Drawing.Icon)(resources.GetObject("planM_buttonItem.Icon")));
            this.planM_buttonItem.Name = "planM_buttonItem";
            this.planM_buttonItem.Text = "工单管理";
            this.planM_buttonItem.Click += new System.EventHandler(this.planM_buttonItem_Click);
            // 
            // statue_tabControl
            // 
            this.statue_tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.statue_tabControl.CanReorderTabs = true;
            this.statue_tabControl.Controls.Add(this.sysLog_tabControlPanel);
            this.statue_tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statue_tabControl.ImageList = this.imageList;
            this.statue_tabControl.Location = new System.Drawing.Point(0, 355);
            this.statue_tabControl.Name = "statue_tabControl";
            this.statue_tabControl.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.statue_tabControl.SelectedTabIndex = 0;
            this.statue_tabControl.Size = new System.Drawing.Size(1330, 352);
            this.statue_tabControl.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.statue_tabControl.TabIndex = 5;
            this.statue_tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.statue_tabControl.Tabs.Add(this.sysLog_tabItem);
            this.statue_tabControl.Text = "tabControl2";
            // 
            // sysLog_tabControlPanel
            // 
            this.sysLog_tabControlPanel.Controls.Add(this.systemLog_richTextBoxEx);
            this.sysLog_tabControlPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.sysLog_tabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sysLog_tabControlPanel.Location = new System.Drawing.Point(0, 29);
            this.sysLog_tabControlPanel.Name = "sysLog_tabControlPanel";
            this.sysLog_tabControlPanel.Padding = new System.Windows.Forms.Padding(1);
            this.sysLog_tabControlPanel.Size = new System.Drawing.Size(1330, 323);
            this.sysLog_tabControlPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.sysLog_tabControlPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.sysLog_tabControlPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.sysLog_tabControlPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.sysLog_tabControlPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.sysLog_tabControlPanel.Style.GradientAngle = 90;
            this.sysLog_tabControlPanel.TabIndex = 1;
            this.sysLog_tabControlPanel.TabItem = this.sysLog_tabItem;
            // 
            // systemLog_richTextBoxEx
            // 
            // 
            // 
            // 
            this.systemLog_richTextBoxEx.BackgroundStyle.Class = "RichTextBoxBorder";
            this.systemLog_richTextBoxEx.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.systemLog_richTextBoxEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemLog_richTextBoxEx.Location = new System.Drawing.Point(1, 1);
            this.systemLog_richTextBoxEx.Margin = new System.Windows.Forms.Padding(4);
            this.systemLog_richTextBoxEx.Name = "systemLog_richTextBoxEx";
            this.systemLog_richTextBoxEx.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\nouicompat\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fn" +
    "il\\fcharset134 \\\'cb\\\'ce\\\'cc\\\'e5;}}\r\n{\\*\\generator Riched20 10.0.17763}\\viewkind4" +
    "\\uc1 \r\n\\pard\\f0\\fs24\\lang2052\\par\r\n}\r\n";
            this.systemLog_richTextBoxEx.Size = new System.Drawing.Size(1328, 321);
            this.systemLog_richTextBoxEx.TabIndex = 1;
            // 
            // sysLog_tabItem
            // 
            this.sysLog_tabItem.AttachedControl = this.sysLog_tabControlPanel;
            this.sysLog_tabItem.Name = "sysLog_tabItem";
            this.sysLog_tabItem.Text = "系统";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "blue2.png");
            this.imageList.Images.SetKeyName(1, "yuan.png");
            this.imageList.Images.SetKeyName(2, "green.png");
            // 
            // title_label
            // 
            this.title_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.title_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.title_label.Font = new System.Drawing.Font("隶书", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title_label.Location = new System.Drawing.Point(212, 226);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(1781, 94);
            this.title_label.TabIndex = 6;
            this.title_label.Text = "   AMS智能制造装配系统";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::AMS_Server.Properties.Resources.anwha;
            this.pictureBox1.Location = new System.Drawing.Point(551, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 94);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1330, 707);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.statue_tabControl);
            this.Controls.Add(this.top_bar);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "昂华自动化工程股份有限公司";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.top_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statue_tabControl)).EndInit();
            this.statue_tabControl.ResumeLayout(false);
            this.sysLog_tabControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar top_bar;
        private DevComponents.DotNetBar.ButtonItem setting_buttonItem;
        private DevComponents.DotNetBar.ButtonItem sys_buttonItem;
        private DevComponents.DotNetBar.ButtonItem db_buttonItem;
        private DevComponents.DotNetBar.ButtonItem user_buttonItem;
        private DevComponents.DotNetBar.ButtonItem tool_buttonItem;
        private DevComponents.DotNetBar.ButtonItem station_buttonItem;
        private DevComponents.DotNetBar.ButtonItem stationMange_buttonItem;
        private DevComponents.DotNetBar.TabControl statue_tabControl;
        private DevComponents.DotNetBar.TabControlPanel sysLog_tabControlPanel;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx systemLog_richTextBoxEx;
        private DevComponents.DotNetBar.TabItem sysLog_tabItem;
        private DevComponents.DotNetBar.LabelX title_label;
        private DevComponents.DotNetBar.ButtonItem receipe_buttonItem;
        private DevComponents.DotNetBar.ButtonItem productionM_buttonItem;
        private DevComponents.DotNetBar.ButtonItem recipeM_buttonItem;
        private DevComponents.DotNetBar.ButtonItem receipeInput_buttonItem;
        private DevComponents.DotNetBar.ButtonItem plan_buttonItem;
        private DevComponents.DotNetBar.ButtonItem planM_buttonItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonItem log_buttonItem;
        private DevComponents.DotNetBar.ButtonItem report_buttonItem;
        private DevComponents.DotNetBar.ButtonItem analysis_buttonItem;
        private DevComponents.DotNetBar.ButtonItem plcAddressManage_buttonItem;
        private System.Windows.Forms.ImageList imageList;
    }
}