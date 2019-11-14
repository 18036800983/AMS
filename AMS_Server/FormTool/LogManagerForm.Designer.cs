namespace AMS_Server.FormTool
{
    partial class LogManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogManagerForm));
            this.log_top_panel = new DevComponents.DotNetBar.PanelEx();
            this.log_outPut_button = new DevComponents.DotNetBar.ButtonX();
            this.log_select_button = new DevComponents.DotNetBar.ButtonX();
            this.log_condition_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.log_horizontal_label = new DevComponents.DotNetBar.LabelX();
            this.log_endTime_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.log_beginTime_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.log_condition_checkBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.log_timer_checkBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.log_date_advTree = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector3 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle3 = new DevComponents.DotNetBar.ElementStyle();
            this.log_detail_superGridControl = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.node1 = new DevComponents.AdvTree.Node();
            this.log_top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_date_advTree)).BeginInit();
            this.SuspendLayout();
            // 
            // log_top_panel
            // 
            this.log_top_panel.CanvasColor = System.Drawing.SystemColors.Control;
            this.log_top_panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.log_top_panel.Controls.Add(this.log_outPut_button);
            this.log_top_panel.Controls.Add(this.log_select_button);
            this.log_top_panel.Controls.Add(this.log_condition_textBox);
            this.log_top_panel.Controls.Add(this.log_horizontal_label);
            this.log_top_panel.Controls.Add(this.log_endTime_dateTimePicker);
            this.log_top_panel.Controls.Add(this.log_beginTime_dateTimePicker);
            this.log_top_panel.Controls.Add(this.log_condition_checkBox);
            this.log_top_panel.Controls.Add(this.log_timer_checkBox);
            this.log_top_panel.DisabledBackColor = System.Drawing.Color.Empty;
            this.log_top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_top_panel.Location = new System.Drawing.Point(0, 0);
            this.log_top_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_top_panel.Name = "log_top_panel";
            this.log_top_panel.Size = new System.Drawing.Size(1383, 133);
            this.log_top_panel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.log_top_panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.log_top_panel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.log_top_panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.log_top_panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.log_top_panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.log_top_panel.Style.GradientAngle = 90;
            this.log_top_panel.TabIndex = 4;
            // 
            // log_outPut_button
            // 
            this.log_outPut_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.log_outPut_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.log_outPut_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.log_outPut_button.Location = new System.Drawing.Point(1096, 16);
            this.log_outPut_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_outPut_button.Name = "log_outPut_button";
            this.log_outPut_button.Size = new System.Drawing.Size(119, 95);
            this.log_outPut_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.log_outPut_button.TabIndex = 14;
            this.log_outPut_button.Text = "导出";
            this.log_outPut_button.Click += new System.EventHandler(this.log_outPut_button_Click);
            // 
            // log_select_button
            // 
            this.log_select_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.log_select_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.log_select_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.log_select_button.Location = new System.Drawing.Point(935, 17);
            this.log_select_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_select_button.Name = "log_select_button";
            this.log_select_button.Size = new System.Drawing.Size(119, 95);
            this.log_select_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.log_select_button.TabIndex = 13;
            this.log_select_button.Text = "查询";
            this.log_select_button.Click += new System.EventHandler(this.log_select_button_Click);
            // 
            // log_condition_textBox
            // 
            this.log_condition_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.log_condition_textBox.Border.Class = "TextBoxBorder";
            this.log_condition_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.log_condition_textBox.Location = new System.Drawing.Point(281, 76);
            this.log_condition_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_condition_textBox.Name = "log_condition_textBox";
            this.log_condition_textBox.PreventEnterBeep = true;
            this.log_condition_textBox.Size = new System.Drawing.Size(588, 25);
            this.log_condition_textBox.TabIndex = 12;
            // 
            // log_horizontal_label
            // 
            this.log_horizontal_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.log_horizontal_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.log_horizontal_label.Location = new System.Drawing.Point(526, 24);
            this.log_horizontal_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_horizontal_label.Name = "log_horizontal_label";
            this.log_horizontal_label.Size = new System.Drawing.Size(102, 31);
            this.log_horizontal_label.TabIndex = 11;
            this.log_horizontal_label.Text = "-------";
            // 
            // log_endTime_dateTimePicker
            // 
            this.log_endTime_dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.log_endTime_dateTimePicker.CustomFormat = "HH:mm:ss";
            this.log_endTime_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.log_endTime_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.log_endTime_dateTimePicker.Location = new System.Drawing.Point(659, 16);
            this.log_endTime_dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.log_endTime_dateTimePicker.Name = "log_endTime_dateTimePicker";
            this.log_endTime_dateTimePicker.ShowUpDown = true;
            this.log_endTime_dateTimePicker.Size = new System.Drawing.Size(210, 25);
            this.log_endTime_dateTimePicker.TabIndex = 10;
            // 
            // log_beginTime_dateTimePicker
            // 
            this.log_beginTime_dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.log_beginTime_dateTimePicker.CustomFormat = "HH:mm:ss";
            this.log_beginTime_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.log_beginTime_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.log_beginTime_dateTimePicker.Location = new System.Drawing.Point(281, 17);
            this.log_beginTime_dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.log_beginTime_dateTimePicker.Name = "log_beginTime_dateTimePicker";
            this.log_beginTime_dateTimePicker.ShowUpDown = true;
            this.log_beginTime_dateTimePicker.Size = new System.Drawing.Size(210, 25);
            this.log_beginTime_dateTimePicker.TabIndex = 9;
            // 
            // log_condition_checkBox
            // 
            this.log_condition_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.log_condition_checkBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.log_condition_checkBox.Location = new System.Drawing.Point(153, 81);
            this.log_condition_checkBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_condition_checkBox.Name = "log_condition_checkBox";
            this.log_condition_checkBox.Size = new System.Drawing.Size(112, 31);
            this.log_condition_checkBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.log_condition_checkBox.TabIndex = 1;
            this.log_condition_checkBox.Text = " 条件";
            // 
            // log_timer_checkBox
            // 
            this.log_timer_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.log_timer_checkBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.log_timer_checkBox.Location = new System.Drawing.Point(153, 23);
            this.log_timer_checkBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_timer_checkBox.Name = "log_timer_checkBox";
            this.log_timer_checkBox.Size = new System.Drawing.Size(112, 31);
            this.log_timer_checkBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.log_timer_checkBox.TabIndex = 0;
            this.log_timer_checkBox.Text = " 时间";
            // 
            // log_date_advTree
            // 
            this.log_date_advTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.log_date_advTree.AllowDrop = true;
            this.log_date_advTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.log_date_advTree.BackgroundStyle.Class = "TreeBorderKey";
            this.log_date_advTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.log_date_advTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.log_date_advTree.Location = new System.Drawing.Point(0, 133);
            this.log_date_advTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_date_advTree.Name = "log_date_advTree";
            this.log_date_advTree.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1});
            this.log_date_advTree.NodesConnector = this.nodeConnector3;
            this.log_date_advTree.NodeStyle = this.elementStyle3;
            this.log_date_advTree.PathSeparator = ";";
            this.log_date_advTree.Size = new System.Drawing.Size(302, 494);
            this.log_date_advTree.Styles.Add(this.elementStyle3);
            this.log_date_advTree.TabIndex = 5;
            this.log_date_advTree.Text = "advTree1";
            this.log_date_advTree.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.log_date_advTree_AfterNodeSelect);
            // 
            // nodeConnector3
            // 
            this.nodeConnector3.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle3
            // 
            this.elementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle3.Name = "elementStyle3";
            this.elementStyle3.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // log_detail_superGridControl
            // 
            this.log_detail_superGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_detail_superGridControl.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.log_detail_superGridControl.Location = new System.Drawing.Point(302, 133);
            this.log_detail_superGridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_detail_superGridControl.Name = "log_detail_superGridControl";
            // 
            // 
            // 
            this.log_detail_superGridControl.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            this.log_detail_superGridControl.Size = new System.Drawing.Size(1081, 494);
            this.log_detail_superGridControl.TabIndex = 6;
            this.log_detail_superGridControl.Text = "superGridControl1";
            // 
            // node1
            // 
            this.node1.Name = "node1";
            this.node1.Text = "日志";
            // 
            // LogManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 627);
            this.Controls.Add(this.log_detail_superGridControl);
            this.Controls.Add(this.log_date_advTree);
            this.Controls.Add(this.log_top_panel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogManagerForm";
            this.Text = "日志管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LogManagerForm_Load);
            this.log_top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.log_date_advTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx log_top_panel;
        private DevComponents.DotNetBar.ButtonX log_outPut_button;
        private DevComponents.DotNetBar.ButtonX log_select_button;
        private DevComponents.DotNetBar.Controls.TextBoxX log_condition_textBox;
        private DevComponents.DotNetBar.LabelX log_horizontal_label;
        private System.Windows.Forms.DateTimePicker log_endTime_dateTimePicker;
        private System.Windows.Forms.DateTimePicker log_beginTime_dateTimePicker;
        private DevComponents.DotNetBar.Controls.CheckBoxX log_condition_checkBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX log_timer_checkBox;
        private DevComponents.AdvTree.AdvTree log_date_advTree;
        private DevComponents.AdvTree.NodeConnector nodeConnector3;
        private DevComponents.DotNetBar.ElementStyle elementStyle3;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl log_detail_superGridControl;
        private DevComponents.AdvTree.Node node1;
    }
}