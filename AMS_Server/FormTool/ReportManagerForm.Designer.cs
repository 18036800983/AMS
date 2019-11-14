namespace AMS_Server.FormTool
{
    partial class ReportManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportManagerForm));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.iptCount = new DevComponents.Editors.IntegerInput();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ckStation = new System.Windows.Forms.CheckBox();
            this.txtCode = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtStation = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.count_label = new System.Windows.Forms.Label();
            this.chkCode = new System.Windows.Forms.CheckBox();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.select_count_label = new DevComponents.DotNetBar.LabelX();
            this.select_button = new DevComponents.DotNetBar.ButtonX();
            this.export_button = new DevComponents.DotNetBar.ButtonX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.end_day_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.start_day_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end_time_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.start_time_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsQueryList = new DevComponents.DotNetBar.SuperTabStrip();
            this.queryTab = new DevComponents.DotNetBar.SuperTabItem();
            this.show_superGridControl = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbStart = new System.Windows.Forms.ToolStripButton();
            this.tsbPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.tslTotalPages = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbEnd = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iptCount)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbsQueryList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.iptCount);
            this.groupPanel1.Controls.Add(this.tableLayoutPanel2);
            this.groupPanel1.Controls.Add(this.count_label);
            this.groupPanel1.Controls.Add(this.chkCode);
            this.groupPanel1.Controls.Add(this.chkTime);
            this.groupPanel1.Controls.Add(this.select_count_label);
            this.groupPanel1.Controls.Add(this.select_button);
            this.groupPanel1.Controls.Add(this.export_button);
            this.groupPanel1.Controls.Add(this.tableLayoutPanel1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1409, 96);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 2;
            // 
            // iptCount
            // 
            // 
            // 
            // 
            this.iptCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iptCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iptCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iptCount.Increment = 100;
            this.iptCount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.iptCount.Location = new System.Drawing.Point(156, 19);
            this.iptCount.Margin = new System.Windows.Forms.Padding(4);
            this.iptCount.MinValue = 0;
            this.iptCount.Name = "iptCount";
            this.iptCount.ShowUpDown = true;
            this.iptCount.Size = new System.Drawing.Size(109, 25);
            this.iptCount.TabIndex = 17;
            this.iptCount.Value = 100;
            this.iptCount.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.iptCount.WatermarkColor = System.Drawing.Color.Gray;
            this.iptCount.WatermarkFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.0131F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.13537F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.06987F));
            this.tableLayoutPanel2.Controls.Add(this.ckStation, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtStation, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(409, 52);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(664, 41);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // ckStation
            // 
            this.ckStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckStation.AutoSize = true;
            this.ckStation.Location = new System.Drawing.Point(311, 12);
            this.ckStation.Margin = new System.Windows.Forms.Padding(4);
            this.ckStation.Name = "ckStation";
            this.ckStation.Size = new System.Drawing.Size(18, 17);
            this.ckStation.TabIndex = 20;
            this.ckStation.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtCode.BackgroundStyle.Class = "TextBoxBorder";
            this.txtCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCode.ButtonClear.Visible = true;
            this.txtCode.Location = new System.Drawing.Point(4, 7);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(276, 26);
            this.txtCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtCode.TabIndex = 19;
            this.txtCode.Text = "";
            this.txtCode.WatermarkText = "请输入序列号";
            // 
            // txtStation
            // 
            this.txtStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtStation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStation.ButtonClear.Visible = true;
            this.txtStation.Location = new System.Drawing.Point(361, 7);
            this.txtStation.Margin = new System.Windows.Forms.Padding(4);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(299, 26);
            this.txtStation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtStation.TabIndex = 8;
            this.txtStation.Text = "";
            this.txtStation.WatermarkText = "输入工位";
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(4, 74);
            this.count_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(0, 15);
            this.count_label.TabIndex = 6;
            // 
            // chkCode
            // 
            this.chkCode.AutoSize = true;
            this.chkCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.chkCode.Location = new System.Drawing.Point(285, 63);
            this.chkCode.Margin = new System.Windows.Forms.Padding(4);
            this.chkCode.Name = "chkCode";
            this.chkCode.Size = new System.Drawing.Size(18, 17);
            this.chkCode.TabIndex = 16;
            this.chkCode.UseVisualStyleBackColor = false;
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.chkTime.Location = new System.Drawing.Point(285, 25);
            this.chkTime.Margin = new System.Windows.Forms.Padding(4);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(18, 17);
            this.chkTime.TabIndex = 15;
            this.chkTime.UseVisualStyleBackColor = false;
            // 
            // select_count_label
            // 
            this.select_count_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            // 
            // 
            // 
            this.select_count_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.select_count_label.Location = new System.Drawing.Point(17, 19);
            this.select_count_label.Margin = new System.Windows.Forms.Padding(4);
            this.select_count_label.Name = "select_count_label";
            this.select_count_label.Size = new System.Drawing.Size(139, 29);
            this.select_count_label.TabIndex = 13;
            // 
            // select_button
            // 
            this.select_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.select_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.select_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.select_button.Image = ((System.Drawing.Image)(resources.GetObject("select_button.Image")));
            this.select_button.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.select_button.Location = new System.Drawing.Point(1104, 11);
            this.select_button.Margin = new System.Windows.Forms.Padding(4);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(105, 68);
            this.select_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.select_button.TabIndex = 5;
            this.select_button.Text = "开始查询";
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // export_button
            // 
            this.export_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.export_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.export_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.export_button.Image = ((System.Drawing.Image)(resources.GetObject("export_button.Image")));
            this.export_button.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.export_button.Location = new System.Drawing.Point(1253, 11);
            this.export_button.Margin = new System.Windows.Forms.Padding(4);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(101, 68);
            this.export_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.export_button.TabIndex = 4;
            this.export_button.Text = "导出数据";
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.43623F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.43623F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.0935F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.4057F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.43623F));
            this.tableLayoutPanel1.Controls.Add(this.end_day_dateTimePicker, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.start_day_dateTimePicker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.end_time_dateTimePicker, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.start_time_dateTimePicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(409, 11);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 42);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // end_day_dateTimePicker
            // 
            this.end_day_dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.end_day_dateTimePicker.CustomFormat = "yy-MM-dd";
            this.end_day_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_day_dateTimePicker.Location = new System.Drawing.Point(361, 8);
            this.end_day_dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.end_day_dateTimePicker.Name = "end_day_dateTimePicker";
            this.end_day_dateTimePicker.Size = new System.Drawing.Size(154, 25);
            this.end_day_dateTimePicker.TabIndex = 9;
            // 
            // start_day_dateTimePicker
            // 
            this.start_day_dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.start_day_dateTimePicker.CustomFormat = "yy-MM-dd";
            this.start_day_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_day_dateTimePicker.Location = new System.Drawing.Point(4, 8);
            this.start_day_dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.start_day_dateTimePicker.Name = "start_day_dateTimePicker";
            this.start_day_dateTimePicker.Size = new System.Drawing.Size(134, 25);
            this.start_day_dateTimePicker.TabIndex = 7;
            // 
            // end_time_dateTimePicker
            // 
            this.end_time_dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.end_time_dateTimePicker.CustomFormat = "HH:mm:ss";
            this.end_time_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_time_dateTimePicker.Location = new System.Drawing.Point(523, 8);
            this.end_time_dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.end_time_dateTimePicker.Name = "end_time_dateTimePicker";
            this.end_time_dateTimePicker.ShowUpDown = true;
            this.end_time_dateTimePicker.Size = new System.Drawing.Size(137, 25);
            this.end_time_dateTimePicker.TabIndex = 12;
            // 
            // start_time_dateTimePicker
            // 
            this.start_time_dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.start_time_dateTimePicker.CustomFormat = "HH:mm:ss";
            this.start_time_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_time_dateTimePicker.Location = new System.Drawing.Point(146, 8);
            this.start_time_dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.start_time_dateTimePicker.Name = "start_time_dateTimePicker";
            this.start_time_dateTimePicker.ShowUpDown = true;
            this.start_time_dateTimePicker.Size = new System.Drawing.Size(134, 25);
            this.start_time_dateTimePicker.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "----";
            // 
            // tbsQueryList
            // 
            this.tbsQueryList.AutoSelectAttachedControl = false;
            // 
            // 
            // 
            this.tbsQueryList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbsQueryList.ContainerControlProcessDialogKey = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tbsQueryList.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tbsQueryList.ControlBox.MenuBox.Name = "";
            this.tbsQueryList.ControlBox.Name = "";
            this.tbsQueryList.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tbsQueryList.ControlBox.MenuBox,
            this.tbsQueryList.ControlBox.CloseBox});
            this.tbsQueryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbsQueryList.Location = new System.Drawing.Point(0, 96);
            this.tbsQueryList.Margin = new System.Windows.Forms.Padding(4);
            this.tbsQueryList.Name = "tbsQueryList";
            this.tbsQueryList.ReorderTabsEnabled = true;
            this.tbsQueryList.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tbsQueryList.SelectedTabIndex = 0;
            this.tbsQueryList.Size = new System.Drawing.Size(1409, 27);
            this.tbsQueryList.TabCloseButtonHot = null;
            this.tbsQueryList.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbsQueryList.TabIndex = 9;
            this.tbsQueryList.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.queryTab});
            this.tbsQueryList.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.tbsQueryList.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.tbsQueryList_SelectedTabChanged);
            // 
            // queryTab
            // 
            this.queryTab.GlobalItem = false;
            this.queryTab.Name = "queryTab";
            this.queryTab.Text = "QueryTab";
            // 
            // show_superGridControl
            // 
            this.show_superGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.show_superGridControl.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.show_superGridControl.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.show_superGridControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.show_superGridControl.Location = new System.Drawing.Point(0, 122);
            this.show_superGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.show_superGridControl.Name = "show_superGridControl";
            // 
            // 
            // 
            this.show_superGridControl.PrimaryGrid.AllowRowHeaderResize = true;
            this.show_superGridControl.PrimaryGrid.AllowRowResize = true;
            // 
            // 
            // 
            this.show_superGridControl.PrimaryGrid.ColumnHeader.RowHeight = 20;
            this.show_superGridControl.PrimaryGrid.DataMember = "";
            this.show_superGridControl.PrimaryGrid.EnableColumnFiltering = true;
            this.show_superGridControl.PrimaryGrid.EnableFiltering = true;
            // 
            // 
            // 
            this.show_superGridControl.PrimaryGrid.GroupByRow.RowHeight = 20;
            this.show_superGridControl.PrimaryGrid.GroupByRow.Visible = true;
            this.show_superGridControl.PrimaryGrid.GroupByRow.WatermarkText = "拖拽一列到这里可以进行分组";
            this.show_superGridControl.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.show_superGridControl.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.show_superGridControl.PrimaryGrid.MultiSelect = false;
            this.show_superGridControl.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.show_superGridControl.Size = new System.Drawing.Size(1409, 630);
            this.show_superGridControl.TabIndex = 10;
            this.show_superGridControl.Text = "superGridControl1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsbStart,
            this.tsbPreview,
            this.toolStripSeparator1,
            this.tstCurrentPage,
            this.tslTotalPages,
            this.toolStripSeparator2,
            this.tsbNext,
            this.tsbEnd,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 756);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1409, 27);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(501, 21);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // tsbStart
            // 
            this.tsbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStart.Image = ((System.Drawing.Image)(resources.GetObject("tsbStart.Image")));
            this.tsbStart.Name = "tsbStart";
            this.tsbStart.RightToLeftAutoMirrorImage = true;
            this.tsbStart.Size = new System.Drawing.Size(29, 25);
            this.tsbStart.Text = "移到第一条记录";
            this.tsbStart.Click += new System.EventHandler(this.tsbStart_Click);
            // 
            // tsbPreview
            // 
            this.tsbPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsbPreview.Image")));
            this.tsbPreview.Name = "tsbPreview";
            this.tsbPreview.RightToLeftAutoMirrorImage = true;
            this.tsbPreview.Size = new System.Drawing.Size(29, 25);
            this.tsbPreview.Text = "移到上一条记录";
            this.tsbPreview.Click += new System.EventHandler(this.tsbPreview_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tstCurrentPage
            // 
            this.tstCurrentPage.AccessibleName = "位置";
            this.tstCurrentPage.AutoSize = false;
            this.tstCurrentPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstCurrentPage.Name = "tstCurrentPage";
            this.tstCurrentPage.Size = new System.Drawing.Size(65, 27);
            this.tstCurrentPage.Text = "0";
            this.tstCurrentPage.ToolTipText = "当前位置";
            this.tstCurrentPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstCurrentPage_KeyPress);
            // 
            // tslTotalPages
            // 
            this.tslTotalPages.Name = "tslTotalPages";
            this.tslTotalPages.Size = new System.Drawing.Size(24, 25);
            this.tslTotalPages.Text = "/0";
            this.tslTotalPages.ToolTipText = "总项数";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbNext
            // 
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.RightToLeftAutoMirrorImage = true;
            this.tsbNext.Size = new System.Drawing.Size(29, 25);
            this.tsbNext.Text = "移到下一条记录";
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // tsbEnd
            // 
            this.tsbEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEnd.Image = ((System.Drawing.Image)(resources.GetObject("tsbEnd.Image")));
            this.tsbEnd.Name = "tsbEnd";
            this.tsbEnd.RightToLeftAutoMirrorImage = true;
            this.tsbEnd.Size = new System.Drawing.Size(29, 25);
            this.tsbEnd.Text = "移到最后一条记录";
            this.tsbEnd.Click += new System.EventHandler(this.tsbEnd_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(501, 21);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(167, 21);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // ReportManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 783);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.show_superGridControl);
            this.Controls.Add(this.tbsQueryList);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportManagerForm";
            this.Text = "报表查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportManagerForm_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iptCount)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbsQueryList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Editors.IntegerInput iptCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtStation;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.CheckBox chkCode;
        private System.Windows.Forms.CheckBox chkTime;
        private DevComponents.DotNetBar.LabelX select_count_label;
        private DevComponents.DotNetBar.ButtonX select_button;
        private DevComponents.DotNetBar.ButtonX export_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker end_day_dateTimePicker;
        private System.Windows.Forms.DateTimePicker start_day_dateTimePicker;
        private System.Windows.Forms.DateTimePicker end_time_dateTimePicker;
        private System.Windows.Forms.DateTimePicker start_time_dateTimePicker;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.SuperTabStrip tbsQueryList;
        private DevComponents.DotNetBar.SuperTabItem queryTab;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl show_superGridControl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton tsbStart;
        private System.Windows.Forms.ToolStripButton tsbPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tstCurrentPage;
        private System.Windows.Forms.ToolStripLabel tslTotalPages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbEnd;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.CheckBox ckStation;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtCode;
    }
}