namespace AMS_Server.FormPlan
{
    partial class PlanManagerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanManagerForm));
            this.plan_show_dataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.plan_Edit_panel = new DevComponents.DotNetBar.PanelEx();
            this.plan_describe_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.plan_describe_label = new DevComponents.DotNetBar.LabelX();
            this.plan_number_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.plan_productionNo_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.plan_productionNo_label = new DevComponents.DotNetBar.LabelX();
            this.plan_number_label = new DevComponents.DotNetBar.LabelX();
            this.plan_No_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.plan_No_label = new DevComponents.DotNetBar.LabelX();
            this.plan_cancel_button = new DevComponents.DotNetBar.ButtonX();
            this.plan_save_button = new DevComponents.DotNetBar.ButtonX();
            this.plan_delete_button = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.plan_show_dataGridView)).BeginInit();
            this.plan_Edit_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plan_show_dataGridView
            // 
            this.plan_show_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.plan_show_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plan_show_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.plan_show_dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.plan_show_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plan_show_dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.plan_show_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.plan_show_dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_show_dataGridView.Name = "plan_show_dataGridView";
            this.plan_show_dataGridView.RowTemplate.Height = 27;
            this.plan_show_dataGridView.Size = new System.Drawing.Size(920, 651);
            this.plan_show_dataGridView.TabIndex = 2;
            this.plan_show_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.plan_show_dataGridView_CellClick);
            // 
            // plan_Edit_panel
            // 
            this.plan_Edit_panel.CanvasColor = System.Drawing.Color.Transparent;
            this.plan_Edit_panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.plan_Edit_panel.Controls.Add(this.plan_describe_textBox);
            this.plan_Edit_panel.Controls.Add(this.plan_describe_label);
            this.plan_Edit_panel.Controls.Add(this.plan_number_textBox);
            this.plan_Edit_panel.Controls.Add(this.plan_productionNo_textBox);
            this.plan_Edit_panel.Controls.Add(this.plan_productionNo_label);
            this.plan_Edit_panel.Controls.Add(this.plan_number_label);
            this.plan_Edit_panel.Controls.Add(this.plan_No_textBox);
            this.plan_Edit_panel.Controls.Add(this.plan_No_label);
            this.plan_Edit_panel.Controls.Add(this.plan_cancel_button);
            this.plan_Edit_panel.Controls.Add(this.plan_save_button);
            this.plan_Edit_panel.Controls.Add(this.plan_delete_button);
            this.plan_Edit_panel.DisabledBackColor = System.Drawing.Color.Empty;
            this.plan_Edit_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.plan_Edit_panel.Location = new System.Drawing.Point(920, 0);
            this.plan_Edit_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_Edit_panel.Name = "plan_Edit_panel";
            this.plan_Edit_panel.Size = new System.Drawing.Size(829, 651);
            this.plan_Edit_panel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.plan_Edit_panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.plan_Edit_panel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.plan_Edit_panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.plan_Edit_panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.plan_Edit_panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.plan_Edit_panel.Style.GradientAngle = 90;
            this.plan_Edit_panel.TabIndex = 12;
            // 
            // plan_describe_textBox
            // 
            this.plan_describe_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.plan_describe_textBox.Border.Class = "TextBoxBorder";
            this.plan_describe_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.plan_describe_textBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_describe_textBox.Location = new System.Drawing.Point(243, 306);
            this.plan_describe_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_describe_textBox.Name = "plan_describe_textBox";
            this.plan_describe_textBox.PreventEnterBeep = true;
            this.plan_describe_textBox.Size = new System.Drawing.Size(542, 30);
            this.plan_describe_textBox.TabIndex = 17;
            // 
            // plan_describe_label
            // 
            this.plan_describe_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.plan_describe_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.plan_describe_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_describe_label.Location = new System.Drawing.Point(45, 299);
            this.plan_describe_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_describe_label.Name = "plan_describe_label";
            this.plan_describe_label.Size = new System.Drawing.Size(200, 45);
            this.plan_describe_label.TabIndex = 16;
            this.plan_describe_label.Text = "工单描述";
            // 
            // plan_number_textBox
            // 
            this.plan_number_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.plan_number_textBox.Border.Class = "TextBoxBorder";
            this.plan_number_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.plan_number_textBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_number_textBox.Location = new System.Drawing.Point(243, 408);
            this.plan_number_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_number_textBox.Name = "plan_number_textBox";
            this.plan_number_textBox.PreventEnterBeep = true;
            this.plan_number_textBox.Size = new System.Drawing.Size(542, 30);
            this.plan_number_textBox.TabIndex = 15;
            // 
            // plan_productionNo_textBox
            // 
            this.plan_productionNo_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.plan_productionNo_textBox.Border.Class = "TextBoxBorder";
            this.plan_productionNo_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.plan_productionNo_textBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_productionNo_textBox.Location = new System.Drawing.Point(243, 202);
            this.plan_productionNo_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_productionNo_textBox.Name = "plan_productionNo_textBox";
            this.plan_productionNo_textBox.PreventEnterBeep = true;
            this.plan_productionNo_textBox.Size = new System.Drawing.Size(542, 30);
            this.plan_productionNo_textBox.TabIndex = 14;
            // 
            // plan_productionNo_label
            // 
            this.plan_productionNo_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.plan_productionNo_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.plan_productionNo_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_productionNo_label.Location = new System.Drawing.Point(45, 196);
            this.plan_productionNo_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_productionNo_label.Name = "plan_productionNo_label";
            this.plan_productionNo_label.Size = new System.Drawing.Size(192, 45);
            this.plan_productionNo_label.TabIndex = 13;
            this.plan_productionNo_label.Text = "产品编号";
            // 
            // plan_number_label
            // 
            this.plan_number_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.plan_number_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.plan_number_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_number_label.Location = new System.Drawing.Point(45, 401);
            this.plan_number_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_number_label.Name = "plan_number_label";
            this.plan_number_label.Size = new System.Drawing.Size(192, 45);
            this.plan_number_label.TabIndex = 11;
            this.plan_number_label.Text = "计划量";
            // 
            // plan_No_textBox
            // 
            this.plan_No_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.plan_No_textBox.Border.Class = "TextBoxBorder";
            this.plan_No_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.plan_No_textBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_No_textBox.Location = new System.Drawing.Point(243, 97);
            this.plan_No_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_No_textBox.Name = "plan_No_textBox";
            this.plan_No_textBox.PreventEnterBeep = true;
            this.plan_No_textBox.Size = new System.Drawing.Size(542, 30);
            this.plan_No_textBox.TabIndex = 10;
            // 
            // plan_No_label
            // 
            this.plan_No_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.plan_No_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.plan_No_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_No_label.Location = new System.Drawing.Point(45, 95);
            this.plan_No_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_No_label.Name = "plan_No_label";
            this.plan_No_label.Size = new System.Drawing.Size(192, 45);
            this.plan_No_label.TabIndex = 9;
            this.plan_No_label.Text = "工单编号";
            // 
            // plan_cancel_button
            // 
            this.plan_cancel_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.plan_cancel_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plan_cancel_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.plan_cancel_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_cancel_button.Location = new System.Drawing.Point(618, 535);
            this.plan_cancel_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_cancel_button.Name = "plan_cancel_button";
            this.plan_cancel_button.Size = new System.Drawing.Size(138, 45);
            this.plan_cancel_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.plan_cancel_button.TabIndex = 8;
            this.plan_cancel_button.Text = "取消";
            this.plan_cancel_button.Click += new System.EventHandler(this.plan_cancel_button_Click);
            // 
            // plan_save_button
            // 
            this.plan_save_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.plan_save_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plan_save_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.plan_save_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_save_button.Location = new System.Drawing.Point(63, 535);
            this.plan_save_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_save_button.Name = "plan_save_button";
            this.plan_save_button.Size = new System.Drawing.Size(138, 45);
            this.plan_save_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.plan_save_button.TabIndex = 6;
            this.plan_save_button.Text = "保存";
            this.plan_save_button.Click += new System.EventHandler(this.plan_save_button_Click);
            // 
            // plan_delete_button
            // 
            this.plan_delete_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.plan_delete_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plan_delete_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.plan_delete_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_delete_button.Location = new System.Drawing.Point(353, 535);
            this.plan_delete_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plan_delete_button.Name = "plan_delete_button";
            this.plan_delete_button.Size = new System.Drawing.Size(138, 45);
            this.plan_delete_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.plan_delete_button.TabIndex = 7;
            this.plan_delete_button.Text = "删除";
            this.plan_delete_button.Click += new System.EventHandler(this.plan_delete_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.plan_show_dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 651);
            this.panel1.TabIndex = 16;
            // 
            // PlanManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1749, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plan_Edit_panel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工单管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlanManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plan_show_dataGridView)).EndInit();
            this.plan_Edit_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX plan_show_dataGridView;
        private DevComponents.DotNetBar.PanelEx plan_Edit_panel;
        private DevComponents.DotNetBar.ButtonX plan_cancel_button;
        private DevComponents.DotNetBar.ButtonX plan_save_button;
        private DevComponents.DotNetBar.ButtonX plan_delete_button;
        private DevComponents.DotNetBar.LabelX plan_No_label;
        private DevComponents.DotNetBar.LabelX plan_number_label;
        private DevComponents.DotNetBar.Controls.TextBoxX plan_No_textBox;
        private DevComponents.DotNetBar.LabelX plan_productionNo_label;
        private DevComponents.DotNetBar.Controls.TextBoxX plan_number_textBox;
        private DevComponents.DotNetBar.Controls.TextBoxX plan_productionNo_textBox;
        private DevComponents.DotNetBar.Controls.TextBoxX plan_describe_textBox;
        private DevComponents.DotNetBar.LabelX plan_describe_label;
        private System.Windows.Forms.Panel panel1;
    }
}