namespace AMS_Server.FormRecipe
{
    partial class RecipeInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeInputForm));
            this.recipeInput_top_panel = new DevComponents.DotNetBar.PanelEx();
            this.recipeInput_production_label = new DevComponents.DotNetBar.LabelX();
            this.recipeInput_save_button = new DevComponents.DotNetBar.ButtonX();
            this.recipeInput_production_comboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.recipeInput_ouyput_button = new DevComponents.DotNetBar.ButtonX();
            this.recipeInput_select_button = new DevComponents.DotNetBar.ButtonX();
            this.recipeInput_input_button = new DevComponents.DotNetBar.ButtonX();
            this.recipeInput_view_dataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.recipeInput_top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeInput_view_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeInput_top_panel
            // 
            this.recipeInput_top_panel.CanvasColor = System.Drawing.SystemColors.Control;
            this.recipeInput_top_panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipeInput_top_panel.Controls.Add(this.recipeInput_production_label);
            this.recipeInput_top_panel.Controls.Add(this.recipeInput_save_button);
            this.recipeInput_top_panel.Controls.Add(this.recipeInput_production_comboBox);
            this.recipeInput_top_panel.Controls.Add(this.recipeInput_ouyput_button);
            this.recipeInput_top_panel.Controls.Add(this.recipeInput_select_button);
            this.recipeInput_top_panel.Controls.Add(this.recipeInput_input_button);
            this.recipeInput_top_panel.DisabledBackColor = System.Drawing.Color.Empty;
            this.recipeInput_top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.recipeInput_top_panel.Location = new System.Drawing.Point(0, 0);
            this.recipeInput_top_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipeInput_top_panel.Name = "recipeInput_top_panel";
            this.recipeInput_top_panel.Size = new System.Drawing.Size(1374, 144);
            this.recipeInput_top_panel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.recipeInput_top_panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.recipeInput_top_panel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.recipeInput_top_panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.recipeInput_top_panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.recipeInput_top_panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.recipeInput_top_panel.Style.GradientAngle = 90;
            this.recipeInput_top_panel.TabIndex = 11;
            // 
            // recipeInput_production_label
            // 
            this.recipeInput_production_label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.recipeInput_production_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipeInput_production_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeInput_production_label.Location = new System.Drawing.Point(22, 42);
            this.recipeInput_production_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipeInput_production_label.Name = "recipeInput_production_label";
            this.recipeInput_production_label.Size = new System.Drawing.Size(153, 47);
            this.recipeInput_production_label.TabIndex = 1;
            this.recipeInput_production_label.Text = "产品名称";
            // 
            // recipeInput_save_button
            // 
            this.recipeInput_save_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.recipeInput_save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recipeInput_save_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.recipeInput_save_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeInput_save_button.Location = new System.Drawing.Point(1220, 35);
            this.recipeInput_save_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipeInput_save_button.Name = "recipeInput_save_button";
            this.recipeInput_save_button.Size = new System.Drawing.Size(132, 69);
            this.recipeInput_save_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipeInput_save_button.TabIndex = 6;
            this.recipeInput_save_button.Text = "保存";
            this.recipeInput_save_button.Click += new System.EventHandler(this.recipeInput_save_button_Click);
            // 
            // recipeInput_production_comboBox
            // 
            this.recipeInput_production_comboBox.DisplayMember = "Text";
            this.recipeInput_production_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.recipeInput_production_comboBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeInput_production_comboBox.FormattingEnabled = true;
            this.recipeInput_production_comboBox.ItemHeight = 25;
            this.recipeInput_production_comboBox.Location = new System.Drawing.Point(174, 49);
            this.recipeInput_production_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipeInput_production_comboBox.Name = "recipeInput_production_comboBox";
            this.recipeInput_production_comboBox.Size = new System.Drawing.Size(385, 31);
            this.recipeInput_production_comboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipeInput_production_comboBox.TabIndex = 2;
            // 
            // recipeInput_ouyput_button
            // 
            this.recipeInput_ouyput_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.recipeInput_ouyput_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recipeInput_ouyput_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.recipeInput_ouyput_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeInput_ouyput_button.Location = new System.Drawing.Point(1032, 35);
            this.recipeInput_ouyput_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipeInput_ouyput_button.Name = "recipeInput_ouyput_button";
            this.recipeInput_ouyput_button.Size = new System.Drawing.Size(132, 69);
            this.recipeInput_ouyput_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipeInput_ouyput_button.TabIndex = 5;
            this.recipeInput_ouyput_button.Text = "导出";
            this.recipeInput_ouyput_button.Click += new System.EventHandler(this.recipeInput_ouyput_button_Click);
            // 
            // recipeInput_select_button
            // 
            this.recipeInput_select_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.recipeInput_select_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recipeInput_select_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.recipeInput_select_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeInput_select_button.Location = new System.Drawing.Point(616, 35);
            this.recipeInput_select_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipeInput_select_button.Name = "recipeInput_select_button";
            this.recipeInput_select_button.Size = new System.Drawing.Size(132, 69);
            this.recipeInput_select_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipeInput_select_button.TabIndex = 3;
            this.recipeInput_select_button.Text = "查询";
            this.recipeInput_select_button.Click += new System.EventHandler(this.recipeInput_select_button_Click);
            // 
            // recipeInput_input_button
            // 
            this.recipeInput_input_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.recipeInput_input_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recipeInput_input_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.recipeInput_input_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeInput_input_button.Location = new System.Drawing.Point(830, 35);
            this.recipeInput_input_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipeInput_input_button.Name = "recipeInput_input_button";
            this.recipeInput_input_button.Size = new System.Drawing.Size(132, 69);
            this.recipeInput_input_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipeInput_input_button.TabIndex = 4;
            this.recipeInput_input_button.Text = "导入";
            this.recipeInput_input_button.Click += new System.EventHandler(this.recipeInput_input_button_Click);
            // 
            // recipeInput_view_dataGridView
            // 
            this.recipeInput_view_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recipeInput_view_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recipeInput_view_dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.recipeInput_view_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeInput_view_dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.recipeInput_view_dataGridView.Location = new System.Drawing.Point(0, 144);
            this.recipeInput_view_dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipeInput_view_dataGridView.Name = "recipeInput_view_dataGridView";
            this.recipeInput_view_dataGridView.RowTemplate.Height = 27;
            this.recipeInput_view_dataGridView.Size = new System.Drawing.Size(1374, 597);
            this.recipeInput_view_dataGridView.TabIndex = 12;
            // 
            // RecipeInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 741);
            this.Controls.Add(this.recipeInput_view_dataGridView);
            this.Controls.Add(this.recipeInput_top_panel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecipeInputForm";
            this.Text = "配方导入";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RecipeInputForm_Load);
            this.recipeInput_top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipeInput_view_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx recipeInput_top_panel;
        private DevComponents.DotNetBar.LabelX recipeInput_production_label;
        private DevComponents.DotNetBar.ButtonX recipeInput_save_button;
        private DevComponents.DotNetBar.Controls.ComboBoxEx recipeInput_production_comboBox;
        private DevComponents.DotNetBar.ButtonX recipeInput_ouyput_button;
        private DevComponents.DotNetBar.ButtonX recipeInput_select_button;
        private DevComponents.DotNetBar.ButtonX recipeInput_input_button;
        private DevComponents.DotNetBar.Controls.DataGridViewX recipeInput_view_dataGridView;
    }
}