namespace AMS_Server.FormTool
{
    partial class ReportAnalysisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportAnalysisForm));
            this.Buttom_superTabStrip = new DevComponents.DotNetBar.SuperTabStrip();
            this.PieChart_superTabItem = new DevComponents.DotNetBar.SuperTabItem();
            this.Histogram_superTabItem = new DevComponents.DotNetBar.SuperTabItem();
            this.LineChart_superTabItem = new DevComponents.DotNetBar.SuperTabItem();
            this.Export_button = new DevComponents.DotNetBar.ButtonX();
            this.Top_groupPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Sinton__comboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Sinton_label = new System.Windows.Forms.Label();
            this.Start_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTime_label = new System.Windows.Forms.Label();
            this.Type_comboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Type_label = new System.Windows.Forms.Label();
            this.End_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTime_label = new System.Windows.Forms.Label();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)(this.Buttom_superTabStrip)).BeginInit();
            this.Top_groupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Buttom_superTabStrip
            // 
            this.Buttom_superTabStrip.AutoSelectAttachedControl = false;
            this.Buttom_superTabStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.Buttom_superTabStrip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Buttom_superTabStrip.ContainerControlProcessDialogKey = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Buttom_superTabStrip.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.Buttom_superTabStrip.ControlBox.MenuBox.Name = "";
            this.Buttom_superTabStrip.ControlBox.MenuBox.Visible = false;
            this.Buttom_superTabStrip.ControlBox.Name = "";
            this.Buttom_superTabStrip.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Buttom_superTabStrip.ControlBox.MenuBox,
            this.Buttom_superTabStrip.ControlBox.CloseBox});
            this.Buttom_superTabStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Buttom_superTabStrip.ForeColor = System.Drawing.Color.Black;
            this.Buttom_superTabStrip.Location = new System.Drawing.Point(0, 654);
            this.Buttom_superTabStrip.Margin = new System.Windows.Forms.Padding(0);
            this.Buttom_superTabStrip.Name = "Buttom_superTabStrip";
            this.Buttom_superTabStrip.ReorderTabsEnabled = true;
            this.Buttom_superTabStrip.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.Buttom_superTabStrip.SelectedTabIndex = 0;
            this.Buttom_superTabStrip.Size = new System.Drawing.Size(1437, 29);
            this.Buttom_superTabStrip.TabCloseButtonHot = null;
            this.Buttom_superTabStrip.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Buttom_superTabStrip.TabIndex = 1;
            this.Buttom_superTabStrip.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.PieChart_superTabItem,
            this.Histogram_superTabItem,
            this.LineChart_superTabItem});
            this.Buttom_superTabStrip.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.Buttom_superTabStrip.Text = "superTabStrip1";
            this.Buttom_superTabStrip.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.Buttom_superTabStrip_SelectedTabChanged);
            // 
            // PieChart_superTabItem
            // 
            this.PieChart_superTabItem.GlobalItem = false;
            this.PieChart_superTabItem.Name = "PieChart_superTabItem";
            this.PieChart_superTabItem.Text = "饼状图";
            // 
            // Histogram_superTabItem
            // 
            this.Histogram_superTabItem.GlobalItem = false;
            this.Histogram_superTabItem.Name = "Histogram_superTabItem";
            this.Histogram_superTabItem.Text = "柱形图";
            // 
            // LineChart_superTabItem
            // 
            this.LineChart_superTabItem.GlobalItem = false;
            this.LineChart_superTabItem.Name = "LineChart_superTabItem";
            this.LineChart_superTabItem.Text = "折线图";
            // 
            // Export_button
            // 
            this.Export_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Export_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Export_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Export_button.Image = ((System.Drawing.Image)(resources.GetObject("Export_button.Image")));
            this.Export_button.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.Export_button.Location = new System.Drawing.Point(1279, 4);
            this.Export_button.Margin = new System.Windows.Forms.Padding(4);
            this.Export_button.Name = "Export_button";
            this.Export_button.Size = new System.Drawing.Size(131, 68);
            this.Export_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Export_button.TabIndex = 17;
            this.Export_button.Text = "导出图片";
            this.Export_button.Click += new System.EventHandler(this.Export_button_Click);
            // 
            // Top_groupPanel
            // 
            this.Top_groupPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.Top_groupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.Top_groupPanel.Controls.Add(this.Sinton__comboBoxEx);
            this.Top_groupPanel.Controls.Add(this.Sinton_label);
            this.Top_groupPanel.Controls.Add(this.Start_dateTimePicker);
            this.Top_groupPanel.Controls.Add(this.StartTime_label);
            this.Top_groupPanel.Controls.Add(this.Type_comboBoxEx);
            this.Top_groupPanel.Controls.Add(this.Type_label);
            this.Top_groupPanel.Controls.Add(this.End_dateTimePicker);
            this.Top_groupPanel.Controls.Add(this.EndTime_label);
            this.Top_groupPanel.Controls.Add(this.Export_button);
            this.Top_groupPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.Top_groupPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_groupPanel.Location = new System.Drawing.Point(0, 0);
            this.Top_groupPanel.Margin = new System.Windows.Forms.Padding(4);
            this.Top_groupPanel.Name = "Top_groupPanel";
            this.Top_groupPanel.Size = new System.Drawing.Size(1437, 83);
            // 
            // 
            // 
            this.Top_groupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Top_groupPanel.Style.BackColorGradientAngle = 90;
            this.Top_groupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Top_groupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Top_groupPanel.Style.BorderBottomWidth = 1;
            this.Top_groupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Top_groupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Top_groupPanel.Style.BorderLeftWidth = 1;
            this.Top_groupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Top_groupPanel.Style.BorderRightWidth = 1;
            this.Top_groupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Top_groupPanel.Style.BorderTopWidth = 1;
            this.Top_groupPanel.Style.CornerDiameter = 4;
            this.Top_groupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.Top_groupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Top_groupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Top_groupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.Top_groupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.Top_groupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Top_groupPanel.TabIndex = 26;
            // 
            // Sinton__comboBoxEx
            // 
            this.Sinton__comboBoxEx.DisplayMember = "Text";
            this.Sinton__comboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Sinton__comboBoxEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sinton__comboBoxEx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sinton__comboBoxEx.ForeColor = System.Drawing.Color.Black;
            this.Sinton__comboBoxEx.FormattingEnabled = true;
            this.Sinton__comboBoxEx.ItemHeight = 24;
            this.Sinton__comboBoxEx.Location = new System.Drawing.Point(1098, 23);
            this.Sinton__comboBoxEx.Margin = new System.Windows.Forms.Padding(0);
            this.Sinton__comboBoxEx.Name = "Sinton__comboBoxEx";
            this.Sinton__comboBoxEx.Size = new System.Drawing.Size(177, 30);
            this.Sinton__comboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Sinton__comboBoxEx.TabIndex = 25;
            this.Sinton__comboBoxEx.SelectedIndexChanged += new System.EventHandler(this.Sinton__comboBoxEx_SelectedIndexChanged);
            // 
            // Sinton_label
            // 
            this.Sinton_label.AutoSize = true;
            this.Sinton_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.Sinton_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sinton_label.Location = new System.Drawing.Point(964, 28);
            this.Sinton_label.Name = "Sinton_label";
            this.Sinton_label.Size = new System.Drawing.Size(59, 20);
            this.Sinton_label.TabIndex = 24;
            this.Sinton_label.Text = "单项:";
            // 
            // Start_dateTimePicker
            // 
            this.Start_dateTimePicker.CalendarFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start_dateTimePicker.CustomFormat = "yy-MM-dd";
            this.Start_dateTimePicker.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Start_dateTimePicker.Location = new System.Drawing.Point(155, 23);
            this.Start_dateTimePicker.Margin = new System.Windows.Forms.Padding(0);
            this.Start_dateTimePicker.Name = "Start_dateTimePicker";
            this.Start_dateTimePicker.Size = new System.Drawing.Size(160, 30);
            this.Start_dateTimePicker.TabIndex = 19;
            this.Start_dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // StartTime_label
            // 
            this.StartTime_label.AutoSize = true;
            this.StartTime_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.StartTime_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartTime_label.Location = new System.Drawing.Point(9, 30);
            this.StartTime_label.Name = "StartTime_label";
            this.StartTime_label.Size = new System.Drawing.Size(0, 20);
            this.StartTime_label.TabIndex = 18;
            // 
            // Type_comboBoxEx
            // 
            this.Type_comboBoxEx.DisplayMember = "Text";
            this.Type_comboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Type_comboBoxEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_comboBoxEx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Type_comboBoxEx.ForeColor = System.Drawing.Color.Black;
            this.Type_comboBoxEx.FormattingEnabled = true;
            this.Type_comboBoxEx.ItemHeight = 24;
            this.Type_comboBoxEx.Location = new System.Drawing.Point(765, 23);
            this.Type_comboBoxEx.Margin = new System.Windows.Forms.Padding(0);
            this.Type_comboBoxEx.Name = "Type_comboBoxEx";
            this.Type_comboBoxEx.Size = new System.Drawing.Size(177, 30);
            this.Type_comboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Type_comboBoxEx.TabIndex = 23;
            this.Type_comboBoxEx.SelectedIndexChanged += new System.EventHandler(this.Type_comboBoxEx_SelectedIndexChanged);
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.Type_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Type_label.Location = new System.Drawing.Point(667, 28);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(59, 20);
            this.Type_label.TabIndex = 22;
            this.Type_label.Text = "类别:";
            // 
            // End_dateTimePicker
            // 
            this.End_dateTimePicker.CalendarFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.End_dateTimePicker.CustomFormat = "yy-MM-dd";
            this.End_dateTimePicker.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.End_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.End_dateTimePicker.Location = new System.Drawing.Point(474, 23);
            this.End_dateTimePicker.Margin = new System.Windows.Forms.Padding(0);
            this.End_dateTimePicker.Name = "End_dateTimePicker";
            this.End_dateTimePicker.Size = new System.Drawing.Size(157, 30);
            this.End_dateTimePicker.TabIndex = 21;
            this.End_dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // EndTime_label
            // 
            this.EndTime_label.AutoSize = true;
            this.EndTime_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.EndTime_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndTime_label.Location = new System.Drawing.Point(330, 30);
            this.EndTime_label.Name = "EndTime_label";
            this.EndTime_label.Size = new System.Drawing.Size(0, 20);
            this.EndTime_label.TabIndex = 20;
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.plotView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotView1.Location = new System.Drawing.Point(0, 83);
            this.plotView1.Margin = new System.Windows.Forms.Padding(4);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(1437, 571);
            this.plotView1.TabIndex = 9;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // ReportAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 683);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.Top_groupPanel);
            this.Controls.Add(this.Buttom_superTabStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportAnalysisForm";
            this.Text = "数据分析";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportAnalysisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Buttom_superTabStrip)).EndInit();
            this.Top_groupPanel.ResumeLayout(false);
            this.Top_groupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabStrip Buttom_superTabStrip;
        private DevComponents.DotNetBar.SuperTabItem PieChart_superTabItem;
        private DevComponents.DotNetBar.SuperTabItem Histogram_superTabItem;
        private DevComponents.DotNetBar.SuperTabItem LineChart_superTabItem;
        private DevComponents.DotNetBar.ButtonX Export_button;
        private DevComponents.DotNetBar.Controls.GroupPanel Top_groupPanel;
        private System.Windows.Forms.Label StartTime_label;
        private System.Windows.Forms.DateTimePicker Start_dateTimePicker;
        private System.Windows.Forms.DateTimePicker End_dateTimePicker;
        private System.Windows.Forms.Label EndTime_label;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Type_comboBoxEx;
        private System.Windows.Forms.Label Type_label;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Sinton__comboBoxEx;
        private System.Windows.Forms.Label Sinton_label;
    }
}