namespace AMS_Server.FormStation
{
    partial class StationManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationManageForm));
            this.station_name_label = new DevComponents.DotNetBar.LabelX();
            this.station_index_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.station_name_comboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.station_index_label = new DevComponents.DotNetBar.LabelX();
            this.station_save_button = new DevComponents.DotNetBar.ButtonX();
            this.station_delete_button = new DevComponents.DotNetBar.ButtonX();
            this.station_cancel_button = new DevComponents.DotNetBar.ButtonX();
            this.station_isShield_checkBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.station_isOutLine_checkBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.station_isEnd_checkBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.station_top_panel = new DevComponents.DotNetBar.PanelEx();
            this.station_show_dataGridView = new System.Windows.Forms.DataGridView();
            this.station_top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.station_show_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // station_name_label
            // 
            this.station_name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.station_name_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.station_name_label.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.station_name_label.Location = new System.Drawing.Point(123, 34);
            this.station_name_label.Name = "station_name_label";
            this.station_name_label.Size = new System.Drawing.Size(126, 23);
            this.station_name_label.TabIndex = 1;
            this.station_name_label.Text = "工位名称";
            // 
            // station_index_textBox
            // 
            this.station_index_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.station_index_textBox.Border.Class = "TextBoxBorder";
            this.station_index_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.station_index_textBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.station_index_textBox.Location = new System.Drawing.Point(251, 91);
            this.station_index_textBox.Name = "station_index_textBox";
            this.station_index_textBox.PreventEnterBeep = true;
            this.station_index_textBox.Size = new System.Drawing.Size(168, 28);
            this.station_index_textBox.TabIndex = 2;
            // 
            // station_name_comboBox
            // 
            this.station_name_comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.station_name_comboBox.DisplayMember = "Text";
            this.station_name_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.station_name_comboBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.station_name_comboBox.FormattingEnabled = true;
            this.station_name_comboBox.ItemHeight = 23;
            this.station_name_comboBox.Location = new System.Drawing.Point(251, 28);
            this.station_name_comboBox.Name = "station_name_comboBox";
            this.station_name_comboBox.Size = new System.Drawing.Size(168, 29);
            this.station_name_comboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.station_name_comboBox.TabIndex = 3;
            // 
            // station_index_label
            // 
            this.station_index_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.station_index_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.station_index_label.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.station_index_label.Location = new System.Drawing.Point(123, 96);
            this.station_index_label.Name = "station_index_label";
            this.station_index_label.Size = new System.Drawing.Size(126, 23);
            this.station_index_label.TabIndex = 4;
            this.station_index_label.Text = "工位顺序";
            // 
            // station_save_button
            // 
            this.station_save_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.station_save_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.station_save_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.station_save_button.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.station_save_button.Location = new System.Drawing.Point(122, 157);
            this.station_save_button.Name = "station_save_button";
            this.station_save_button.Size = new System.Drawing.Size(102, 40);
            this.station_save_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.station_save_button.TabIndex = 11;
            this.station_save_button.Text = "保存";
            this.station_save_button.Click += new System.EventHandler(this.station_save_button_Click);
            // 
            // station_delete_button
            // 
            this.station_delete_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.station_delete_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.station_delete_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.station_delete_button.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.station_delete_button.Location = new System.Drawing.Point(399, 157);
            this.station_delete_button.Name = "station_delete_button";
            this.station_delete_button.Size = new System.Drawing.Size(102, 40);
            this.station_delete_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.station_delete_button.TabIndex = 12;
            this.station_delete_button.Text = "删除";
            this.station_delete_button.Click += new System.EventHandler(this.station_delete_button_Click);
            // 
            // station_cancel_button
            // 
            this.station_cancel_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.station_cancel_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.station_cancel_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.station_cancel_button.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.station_cancel_button.Location = new System.Drawing.Point(641, 157);
            this.station_cancel_button.Name = "station_cancel_button";
            this.station_cancel_button.Size = new System.Drawing.Size(102, 40);
            this.station_cancel_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.station_cancel_button.TabIndex = 13;
            this.station_cancel_button.Text = "取消";
            this.station_cancel_button.Click += new System.EventHandler(this.station_cancel_button_Click);
            // 
            // station_isShield_checkBox
            // 
            this.station_isShield_checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.station_isShield_checkBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.station_isShield_checkBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.station_isShield_checkBox.Location = new System.Drawing.Point(488, 34);
            this.station_isShield_checkBox.Name = "station_isShield_checkBox";
            this.station_isShield_checkBox.Size = new System.Drawing.Size(118, 23);
            this.station_isShield_checkBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.station_isShield_checkBox.TabIndex = 14;
            this.station_isShield_checkBox.Text = " 是否屏蔽";
            // 
            // station_isOutLine_checkBox
            // 
            this.station_isOutLine_checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.station_isOutLine_checkBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.station_isOutLine_checkBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.station_isOutLine_checkBox.Location = new System.Drawing.Point(488, 91);
            this.station_isOutLine_checkBox.Name = "station_isOutLine_checkBox";
            this.station_isOutLine_checkBox.Size = new System.Drawing.Size(128, 23);
            this.station_isOutLine_checkBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.station_isOutLine_checkBox.TabIndex = 15;
            this.station_isOutLine_checkBox.Text = " 是否线外站";
            // 
            // station_isEnd_checkBox
            // 
            this.station_isEnd_checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.station_isEnd_checkBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.station_isEnd_checkBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.station_isEnd_checkBox.Location = new System.Drawing.Point(641, 34);
            this.station_isEnd_checkBox.Name = "station_isEnd_checkBox";
            this.station_isEnd_checkBox.Size = new System.Drawing.Size(118, 23);
            this.station_isEnd_checkBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.station_isEnd_checkBox.TabIndex = 16;
            this.station_isEnd_checkBox.Text = " 是否尾站";
            // 
            // station_top_panel
            // 
            this.station_top_panel.CanvasColor = System.Drawing.SystemColors.Control;
            this.station_top_panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.station_top_panel.Controls.Add(this.station_save_button);
            this.station_top_panel.Controls.Add(this.station_isEnd_checkBox);
            this.station_top_panel.Controls.Add(this.station_name_label);
            this.station_top_panel.Controls.Add(this.station_isOutLine_checkBox);
            this.station_top_panel.Controls.Add(this.station_name_comboBox);
            this.station_top_panel.Controls.Add(this.station_isShield_checkBox);
            this.station_top_panel.Controls.Add(this.station_index_label);
            this.station_top_panel.Controls.Add(this.station_cancel_button);
            this.station_top_panel.Controls.Add(this.station_index_textBox);
            this.station_top_panel.Controls.Add(this.station_delete_button);
            this.station_top_panel.DisabledBackColor = System.Drawing.Color.Empty;
            this.station_top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.station_top_panel.Location = new System.Drawing.Point(0, 0);
            this.station_top_panel.Name = "station_top_panel";
            this.station_top_panel.Size = new System.Drawing.Size(910, 229);
            this.station_top_panel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.station_top_panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.station_top_panel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.station_top_panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.station_top_panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.station_top_panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.station_top_panel.Style.GradientAngle = 90;
            this.station_top_panel.TabIndex = 17;
            // 
            // station_show_dataGridView
            // 
            this.station_show_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.station_show_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.station_show_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.station_show_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.station_show_dataGridView.Location = new System.Drawing.Point(0, 229);
            this.station_show_dataGridView.Name = "station_show_dataGridView";
            this.station_show_dataGridView.RowHeadersWidth = 51;
            this.station_show_dataGridView.RowTemplate.Height = 27;
            this.station_show_dataGridView.Size = new System.Drawing.Size(910, 333);
            this.station_show_dataGridView.TabIndex = 21;
            this.station_show_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.station_show_dataGridView_CellClick);
            // 
            // StationManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(910, 562);
            this.Controls.Add(this.station_show_dataGridView);
            this.Controls.Add(this.station_top_panel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StationManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工位管理";
            this.Load += new System.EventHandler(this.StationManageForm_Load);
            this.station_top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.station_show_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX station_name_label;
        private DevComponents.DotNetBar.Controls.TextBoxX station_index_textBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx station_name_comboBox;
        private DevComponents.DotNetBar.LabelX station_index_label;
        private DevComponents.DotNetBar.ButtonX station_save_button;
        private DevComponents.DotNetBar.ButtonX station_delete_button;
        private DevComponents.DotNetBar.ButtonX station_cancel_button;
        private DevComponents.DotNetBar.Controls.CheckBoxX station_isShield_checkBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX station_isOutLine_checkBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX station_isEnd_checkBox;
        private DevComponents.DotNetBar.PanelEx station_top_panel;
        private System.Windows.Forms.DataGridView station_show_dataGridView;
    }
}