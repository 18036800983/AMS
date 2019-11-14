namespace AMS_Server.FormRecipe
{
    partial class RecipeManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeManageForm));
            this.recipe_tree_advTree = new DevComponents.AdvTree.AdvTree();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.配方检查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.recipe_edit_panel = new DevComponents.DotNetBar.PanelEx();
            this.StepDesc_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.StepDesc_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_barcodeLength_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.recipe_sleeve_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_imagePath_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.recipe_imagePath_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_ProductionName_comboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.recipe_sleeve_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.recipe_componentNNumber_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.recipe_cancel_button = new DevComponents.DotNetBar.ButtonX();
            this.recipe_delete_button = new DevComponents.DotNetBar.ButtonX();
            this.repice_save_button = new DevComponents.DotNetBar.ButtonX();
            this.recipe_boltNumber_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.recipe_isCheck_checkBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.recipe_isTrace_checkBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.recipe_barcodeLength_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_componentNNumber_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_boltNumber_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_componentName_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.recipe_componentName_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_boltNo_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.recipe_boltNo_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_programNo_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.recipe_programNo_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_operationType_comboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.recipe_operationType_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_step_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_station_comboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.recipe_checkRule_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_checkRule_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.recipe_step_textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.recipe_station_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_ProductionName_label = new DevComponents.DotNetBar.LabelX();
            this.recipe_show_dataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.left_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.recipe_tree_advTree)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.recipe_edit_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipe_show_dataGridView)).BeginInit();
            this.left_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipe_tree_advTree
            // 
            this.recipe_tree_advTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.recipe_tree_advTree.AllowDrop = true;
            this.recipe_tree_advTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.recipe_tree_advTree.BackgroundStyle.Class = "TreeBorderKey";
            this.recipe_tree_advTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_tree_advTree.ContextMenuStrip = this.contextMenuStrip1;
            this.recipe_tree_advTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.recipe_tree_advTree.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipe_tree_advTree.Location = new System.Drawing.Point(0, 0);
            this.recipe_tree_advTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_tree_advTree.Name = "recipe_tree_advTree";
            this.recipe_tree_advTree.NodesConnector = this.nodeConnector1;
            this.recipe_tree_advTree.NodeStyle = this.elementStyle1;
            this.recipe_tree_advTree.PathSeparator = ";";
            this.recipe_tree_advTree.Size = new System.Drawing.Size(156, 760);
            this.recipe_tree_advTree.Styles.Add(this.elementStyle1);
            this.recipe_tree_advTree.TabIndex = 12;
            this.recipe_tree_advTree.Text = "advTree1";
            this.recipe_tree_advTree.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.recipe_tree_advTree_AfterNodeSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配方检查ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 28);
            // 
            // 配方检查ToolStripMenuItem
            // 
            this.配方检查ToolStripMenuItem.Name = "配方检查ToolStripMenuItem";
            this.配方检查ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.配方检查ToolStripMenuItem.Text = "配方检查";
            this.配方检查ToolStripMenuItem.Click += new System.EventHandler(this.配方检查ToolStripMenuItem_Click);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // recipe_edit_panel
            // 
            this.recipe_edit_panel.CanvasColor = System.Drawing.Color.Transparent;
            this.recipe_edit_panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipe_edit_panel.Controls.Add(this.StepDesc_textBox);
            this.recipe_edit_panel.Controls.Add(this.StepDesc_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_barcodeLength_textBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_sleeve_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_imagePath_textBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_imagePath_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_ProductionName_comboBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_sleeve_textBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_componentNNumber_textBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_cancel_button);
            this.recipe_edit_panel.Controls.Add(this.recipe_delete_button);
            this.recipe_edit_panel.Controls.Add(this.repice_save_button);
            this.recipe_edit_panel.Controls.Add(this.recipe_boltNumber_textBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_isCheck_checkBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_isTrace_checkBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_barcodeLength_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_componentNNumber_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_boltNumber_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_componentName_textBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_componentName_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_boltNo_textBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_boltNo_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_programNo_textBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_programNo_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_operationType_comboBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_operationType_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_step_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_station_comboBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_checkRule_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_checkRule_textBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_step_textBox);
            this.recipe_edit_panel.Controls.Add(this.recipe_station_label);
            this.recipe_edit_panel.Controls.Add(this.recipe_ProductionName_label);
            this.recipe_edit_panel.DisabledBackColor = System.Drawing.Color.Empty;
            this.recipe_edit_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.recipe_edit_panel.Location = new System.Drawing.Point(782, 0);
            this.recipe_edit_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_edit_panel.Name = "recipe_edit_panel";
            this.recipe_edit_panel.Size = new System.Drawing.Size(544, 760);
            this.recipe_edit_panel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.recipe_edit_panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.recipe_edit_panel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.recipe_edit_panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.recipe_edit_panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.recipe_edit_panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.recipe_edit_panel.Style.GradientAngle = 90;
            this.recipe_edit_panel.TabIndex = 11;
            // 
            // StepDesc_textBox
            // 
            this.StepDesc_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.StepDesc_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.StepDesc_textBox.Location = new System.Drawing.Point(166, 579);
            this.StepDesc_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StepDesc_textBox.Name = "StepDesc_textBox";
            this.StepDesc_textBox.PreventEnterBeep = true;
            this.StepDesc_textBox.Size = new System.Drawing.Size(359, 19);
            this.StepDesc_textBox.TabIndex = 34;
            this.StepDesc_textBox.WatermarkText = "都需配置";
            // 
            // StepDesc_label
            // 
            this.StepDesc_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.StepDesc_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.StepDesc_label.Location = new System.Drawing.Point(34, 568);
            this.StepDesc_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StepDesc_label.Name = "StepDesc_label";
            this.StepDesc_label.Size = new System.Drawing.Size(126, 45);
            this.StepDesc_label.TabIndex = 33;
            this.StepDesc_label.Text = "操作描述";
            // 
            // recipe_barcodeLength_textBox
            // 
            this.recipe_barcodeLength_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_barcodeLength_textBox.Border.Class = "TextBoxBorder";
            this.recipe_barcodeLength_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_barcodeLength_textBox.Location = new System.Drawing.Point(167, 500);
            this.recipe_barcodeLength_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_barcodeLength_textBox.Name = "recipe_barcodeLength_textBox";
            this.recipe_barcodeLength_textBox.PreventEnterBeep = true;
            this.recipe_barcodeLength_textBox.Size = new System.Drawing.Size(360, 25);
            this.recipe_barcodeLength_textBox.TabIndex = 32;
            this.recipe_barcodeLength_textBox.WatermarkText = "扫描类型需配置";
            // 
            // recipe_sleeve_label
            // 
            this.recipe_sleeve_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_sleeve_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_sleeve_label.Location = new System.Drawing.Point(35, 530);
            this.recipe_sleeve_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_sleeve_label.Name = "recipe_sleeve_label";
            this.recipe_sleeve_label.Size = new System.Drawing.Size(126, 45);
            this.recipe_sleeve_label.TabIndex = 31;
            this.recipe_sleeve_label.Text = "套 筒 号";
            // 
            // recipe_imagePath_textBox
            // 
            this.recipe_imagePath_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_imagePath_textBox.Border.Class = "TextBoxBorder";
            this.recipe_imagePath_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_imagePath_textBox.Location = new System.Drawing.Point(167, 119);
            this.recipe_imagePath_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_imagePath_textBox.Name = "recipe_imagePath_textBox";
            this.recipe_imagePath_textBox.PreventEnterBeep = true;
            this.recipe_imagePath_textBox.Size = new System.Drawing.Size(360, 25);
            this.recipe_imagePath_textBox.TabIndex = 30;
            this.recipe_imagePath_textBox.WatermarkText = "都需配置";
            // 
            // recipe_imagePath_label
            // 
            this.recipe_imagePath_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_imagePath_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_imagePath_label.Location = new System.Drawing.Point(35, 113);
            this.recipe_imagePath_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_imagePath_label.Name = "recipe_imagePath_label";
            this.recipe_imagePath_label.Size = new System.Drawing.Size(122, 45);
            this.recipe_imagePath_label.TabIndex = 29;
            this.recipe_imagePath_label.Text = "图片路径";
            // 
            // recipe_ProductionName_comboBox
            // 
            this.recipe_ProductionName_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recipe_ProductionName_comboBox.DisplayMember = "Text";
            this.recipe_ProductionName_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.recipe_ProductionName_comboBox.FormattingEnabled = true;
            this.recipe_ProductionName_comboBox.ItemHeight = 23;
            this.recipe_ProductionName_comboBox.Location = new System.Drawing.Point(167, 41);
            this.recipe_ProductionName_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_ProductionName_comboBox.Name = "recipe_ProductionName_comboBox";
            this.recipe_ProductionName_comboBox.Size = new System.Drawing.Size(359, 29);
            this.recipe_ProductionName_comboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipe_ProductionName_comboBox.TabIndex = 28;
            // 
            // recipe_sleeve_textBox
            // 
            this.recipe_sleeve_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_sleeve_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_sleeve_textBox.Location = new System.Drawing.Point(167, 543);
            this.recipe_sleeve_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_sleeve_textBox.Name = "recipe_sleeve_textBox";
            this.recipe_sleeve_textBox.PreventEnterBeep = true;
            this.recipe_sleeve_textBox.Size = new System.Drawing.Size(359, 19);
            this.recipe_sleeve_textBox.TabIndex = 27;
            this.recipe_sleeve_textBox.WatermarkText = "拧紧类型需配置";
            // 
            // recipe_componentNNumber_textBox
            // 
            this.recipe_componentNNumber_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_componentNNumber_textBox.Border.Class = "TextBoxBorder";
            this.recipe_componentNNumber_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_componentNNumber_textBox.Location = new System.Drawing.Point(167, 459);
            this.recipe_componentNNumber_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_componentNNumber_textBox.Name = "recipe_componentNNumber_textBox";
            this.recipe_componentNNumber_textBox.PreventEnterBeep = true;
            this.recipe_componentNNumber_textBox.Size = new System.Drawing.Size(360, 25);
            this.recipe_componentNNumber_textBox.TabIndex = 26;
            this.recipe_componentNNumber_textBox.WatermarkText = "扫描类型需配置";
            // 
            // recipe_cancel_button
            // 
            this.recipe_cancel_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.recipe_cancel_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recipe_cancel_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.recipe_cancel_button.Location = new System.Drawing.Point(417, 689);
            this.recipe_cancel_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_cancel_button.Name = "recipe_cancel_button";
            this.recipe_cancel_button.Size = new System.Drawing.Size(108, 45);
            this.recipe_cancel_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipe_cancel_button.TabIndex = 8;
            this.recipe_cancel_button.Text = "取消";
            this.recipe_cancel_button.Click += new System.EventHandler(this.recipe_cancel_button_Click);
            // 
            // recipe_delete_button
            // 
            this.recipe_delete_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.recipe_delete_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recipe_delete_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.recipe_delete_button.Location = new System.Drawing.Point(238, 689);
            this.recipe_delete_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_delete_button.Name = "recipe_delete_button";
            this.recipe_delete_button.Size = new System.Drawing.Size(108, 45);
            this.recipe_delete_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipe_delete_button.TabIndex = 7;
            this.recipe_delete_button.Text = "删除";
            this.recipe_delete_button.Click += new System.EventHandler(this.recipe_delete_button_Click);
            // 
            // repice_save_button
            // 
            this.repice_save_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.repice_save_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.repice_save_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.repice_save_button.Location = new System.Drawing.Point(39, 689);
            this.repice_save_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repice_save_button.Name = "repice_save_button";
            this.repice_save_button.Size = new System.Drawing.Size(108, 45);
            this.repice_save_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.repice_save_button.TabIndex = 6;
            this.repice_save_button.Text = "保存";
            this.repice_save_button.Click += new System.EventHandler(this.repice_save_button_Click);
            // 
            // recipe_boltNumber_textBox
            // 
            this.recipe_boltNumber_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_boltNumber_textBox.Border.Class = "TextBoxBorder";
            this.recipe_boltNumber_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_boltNumber_textBox.Location = new System.Drawing.Point(167, 417);
            this.recipe_boltNumber_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_boltNumber_textBox.Name = "recipe_boltNumber_textBox";
            this.recipe_boltNumber_textBox.PreventEnterBeep = true;
            this.recipe_boltNumber_textBox.Size = new System.Drawing.Size(359, 25);
            this.recipe_boltNumber_textBox.TabIndex = 25;
            this.recipe_boltNumber_textBox.WatermarkText = "拧紧类型需配置";
            // 
            // recipe_isCheck_checkBox
            // 
            this.recipe_isCheck_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_isCheck_checkBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_isCheck_checkBox.Location = new System.Drawing.Point(334, 633);
            this.recipe_isCheck_checkBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_isCheck_checkBox.Name = "recipe_isCheck_checkBox";
            this.recipe_isCheck_checkBox.Size = new System.Drawing.Size(192, 31);
            this.recipe_isCheck_checkBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipe_isCheck_checkBox.TabIndex = 24;
            this.recipe_isCheck_checkBox.Text = "    是否校验";
            // 
            // recipe_isTrace_checkBox
            // 
            this.recipe_isTrace_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_isTrace_checkBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_isTrace_checkBox.Location = new System.Drawing.Point(39, 633);
            this.recipe_isTrace_checkBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_isTrace_checkBox.Name = "recipe_isTrace_checkBox";
            this.recipe_isTrace_checkBox.Size = new System.Drawing.Size(192, 31);
            this.recipe_isTrace_checkBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipe_isTrace_checkBox.TabIndex = 23;
            this.recipe_isTrace_checkBox.Text = "    是否追溯";
            // 
            // recipe_barcodeLength_label
            // 
            this.recipe_barcodeLength_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_barcodeLength_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_barcodeLength_label.Location = new System.Drawing.Point(34, 490);
            this.recipe_barcodeLength_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_barcodeLength_label.Name = "recipe_barcodeLength_label";
            this.recipe_barcodeLength_label.Size = new System.Drawing.Size(122, 45);
            this.recipe_barcodeLength_label.TabIndex = 21;
            this.recipe_barcodeLength_label.Text = "条码长度";
            // 
            // recipe_componentNNumber_label
            // 
            this.recipe_componentNNumber_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_componentNNumber_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_componentNNumber_label.Location = new System.Drawing.Point(35, 451);
            this.recipe_componentNNumber_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_componentNNumber_label.Name = "recipe_componentNNumber_label";
            this.recipe_componentNNumber_label.Size = new System.Drawing.Size(134, 45);
            this.recipe_componentNNumber_label.TabIndex = 20;
            this.recipe_componentNNumber_label.Text = "部件数量";
            // 
            // recipe_boltNumber_label
            // 
            this.recipe_boltNumber_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_boltNumber_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_boltNumber_label.Location = new System.Drawing.Point(36, 407);
            this.recipe_boltNumber_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_boltNumber_label.Name = "recipe_boltNumber_label";
            this.recipe_boltNumber_label.Size = new System.Drawing.Size(133, 45);
            this.recipe_boltNumber_label.TabIndex = 19;
            this.recipe_boltNumber_label.Text = "螺栓数量";
            // 
            // recipe_componentName_textBox
            // 
            this.recipe_componentName_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_componentName_textBox.Border.Class = "TextBoxBorder";
            this.recipe_componentName_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_componentName_textBox.Location = new System.Drawing.Point(167, 373);
            this.recipe_componentName_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_componentName_textBox.Name = "recipe_componentName_textBox";
            this.recipe_componentName_textBox.PreventEnterBeep = true;
            this.recipe_componentName_textBox.Size = new System.Drawing.Size(359, 25);
            this.recipe_componentName_textBox.TabIndex = 18;
            this.recipe_componentName_textBox.WatermarkText = "除开始结束以外其他操作类型都需要配置";
            // 
            // recipe_componentName_label
            // 
            this.recipe_componentName_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_componentName_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_componentName_label.Location = new System.Drawing.Point(35, 365);
            this.recipe_componentName_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_componentName_label.Name = "recipe_componentName_label";
            this.recipe_componentName_label.Size = new System.Drawing.Size(134, 45);
            this.recipe_componentName_label.TabIndex = 17;
            this.recipe_componentName_label.Text = "部件名称";
            // 
            // recipe_boltNo_textBox
            // 
            this.recipe_boltNo_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_boltNo_textBox.Border.Class = "TextBoxBorder";
            this.recipe_boltNo_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_boltNo_textBox.Location = new System.Drawing.Point(167, 329);
            this.recipe_boltNo_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_boltNo_textBox.Name = "recipe_boltNo_textBox";
            this.recipe_boltNo_textBox.PreventEnterBeep = true;
            this.recipe_boltNo_textBox.Size = new System.Drawing.Size(359, 25);
            this.recipe_boltNo_textBox.TabIndex = 16;
            this.recipe_boltNo_textBox.WatermarkText = "拧紧类型需配置";
            // 
            // recipe_boltNo_label
            // 
            this.recipe_boltNo_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_boltNo_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_boltNo_label.Location = new System.Drawing.Point(35, 321);
            this.recipe_boltNo_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_boltNo_label.Name = "recipe_boltNo_label";
            this.recipe_boltNo_label.Size = new System.Drawing.Size(122, 45);
            this.recipe_boltNo_label.TabIndex = 15;
            this.recipe_boltNo_label.Text = "螺栓编号";
            // 
            // recipe_programNo_textBox
            // 
            this.recipe_programNo_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_programNo_textBox.Border.Class = "TextBoxBorder";
            this.recipe_programNo_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_programNo_textBox.Location = new System.Drawing.Point(167, 240);
            this.recipe_programNo_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_programNo_textBox.Name = "recipe_programNo_textBox";
            this.recipe_programNo_textBox.PreventEnterBeep = true;
            this.recipe_programNo_textBox.Size = new System.Drawing.Size(359, 25);
            this.recipe_programNo_textBox.TabIndex = 14;
            this.recipe_programNo_textBox.WatermarkText = "拧紧类型需配置";
            // 
            // recipe_programNo_label
            // 
            this.recipe_programNo_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_programNo_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_programNo_label.Location = new System.Drawing.Point(35, 232);
            this.recipe_programNo_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_programNo_label.Name = "recipe_programNo_label";
            this.recipe_programNo_label.Size = new System.Drawing.Size(122, 45);
            this.recipe_programNo_label.TabIndex = 13;
            this.recipe_programNo_label.Text = "程 序 号";
            // 
            // recipe_operationType_comboBox
            // 
            this.recipe_operationType_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recipe_operationType_comboBox.DisplayMember = "Text";
            this.recipe_operationType_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.recipe_operationType_comboBox.FormattingEnabled = true;
            this.recipe_operationType_comboBox.ItemHeight = 23;
            this.recipe_operationType_comboBox.Location = new System.Drawing.Point(167, 197);
            this.recipe_operationType_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_operationType_comboBox.Name = "recipe_operationType_comboBox";
            this.recipe_operationType_comboBox.Size = new System.Drawing.Size(358, 29);
            this.recipe_operationType_comboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipe_operationType_comboBox.TabIndex = 12;
            // 
            // recipe_operationType_label
            // 
            this.recipe_operationType_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_operationType_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_operationType_label.Location = new System.Drawing.Point(35, 191);
            this.recipe_operationType_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_operationType_label.Name = "recipe_operationType_label";
            this.recipe_operationType_label.Size = new System.Drawing.Size(122, 45);
            this.recipe_operationType_label.TabIndex = 11;
            this.recipe_operationType_label.Text = "操作类型";
            // 
            // recipe_step_label
            // 
            this.recipe_step_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_step_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_step_label.Location = new System.Drawing.Point(35, 150);
            this.recipe_step_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_step_label.Name = "recipe_step_label";
            this.recipe_step_label.Size = new System.Drawing.Size(122, 45);
            this.recipe_step_label.TabIndex = 10;
            this.recipe_step_label.Text = "步    序";
            // 
            // recipe_station_comboBox
            // 
            this.recipe_station_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recipe_station_comboBox.DisplayMember = "Text";
            this.recipe_station_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.recipe_station_comboBox.FormattingEnabled = true;
            this.recipe_station_comboBox.ItemHeight = 23;
            this.recipe_station_comboBox.Location = new System.Drawing.Point(167, 76);
            this.recipe_station_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_station_comboBox.Name = "recipe_station_comboBox";
            this.recipe_station_comboBox.Size = new System.Drawing.Size(358, 29);
            this.recipe_station_comboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recipe_station_comboBox.TabIndex = 9;
            // 
            // recipe_checkRule_label
            // 
            this.recipe_checkRule_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_checkRule_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_checkRule_label.Location = new System.Drawing.Point(35, 276);
            this.recipe_checkRule_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_checkRule_label.Name = "recipe_checkRule_label";
            this.recipe_checkRule_label.Size = new System.Drawing.Size(122, 45);
            this.recipe_checkRule_label.TabIndex = 5;
            this.recipe_checkRule_label.Text = "校验规则";
            // 
            // recipe_checkRule_textBox
            // 
            this.recipe_checkRule_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_checkRule_textBox.Border.Class = "TextBoxBorder";
            this.recipe_checkRule_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_checkRule_textBox.Location = new System.Drawing.Point(167, 284);
            this.recipe_checkRule_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_checkRule_textBox.Name = "recipe_checkRule_textBox";
            this.recipe_checkRule_textBox.PreventEnterBeep = true;
            this.recipe_checkRule_textBox.Size = new System.Drawing.Size(359, 25);
            this.recipe_checkRule_textBox.TabIndex = 4;
            this.recipe_checkRule_textBox.WatermarkText = "扫描类型需配置";
            // 
            // recipe_step_textBox
            // 
            this.recipe_step_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_step_textBox.Border.Class = "TextBoxBorder";
            this.recipe_step_textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_step_textBox.Location = new System.Drawing.Point(167, 158);
            this.recipe_step_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_step_textBox.Name = "recipe_step_textBox";
            this.recipe_step_textBox.PreventEnterBeep = true;
            this.recipe_step_textBox.Size = new System.Drawing.Size(359, 25);
            this.recipe_step_textBox.TabIndex = 3;
            this.recipe_step_textBox.WatermarkText = "都需配置，每个工位必须填连续的数字";
            // 
            // recipe_station_label
            // 
            this.recipe_station_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_station_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_station_label.Location = new System.Drawing.Point(35, 70);
            this.recipe_station_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_station_label.Name = "recipe_station_label";
            this.recipe_station_label.Size = new System.Drawing.Size(122, 45);
            this.recipe_station_label.TabIndex = 2;
            this.recipe_station_label.Text = "工    位";
            // 
            // recipe_ProductionName_label
            // 
            this.recipe_ProductionName_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.recipe_ProductionName_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recipe_ProductionName_label.Location = new System.Drawing.Point(35, 36);
            this.recipe_ProductionName_label.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_ProductionName_label.Name = "recipe_ProductionName_label";
            this.recipe_ProductionName_label.Size = new System.Drawing.Size(122, 45);
            this.recipe_ProductionName_label.TabIndex = 0;
            this.recipe_ProductionName_label.Text = "产品名称";
            // 
            // recipe_show_dataGridView
            // 
            this.recipe_show_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.recipe_show_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recipe_show_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recipe_show_dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.recipe_show_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipe_show_dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.recipe_show_dataGridView.Location = new System.Drawing.Point(156, 0);
            this.recipe_show_dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipe_show_dataGridView.Name = "recipe_show_dataGridView";
            this.recipe_show_dataGridView.RowHeadersWidth = 51;
            this.recipe_show_dataGridView.RowTemplate.Height = 27;
            this.recipe_show_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recipe_show_dataGridView.Size = new System.Drawing.Size(626, 760);
            this.recipe_show_dataGridView.TabIndex = 10;
            this.recipe_show_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recipe_show_dataGridView_CellClick);
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.recipe_show_dataGridView);
            this.left_panel.Controls.Add(this.recipe_tree_advTree);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(782, 760);
            this.left_panel.TabIndex = 17;
            // 
            // RecipeManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 760);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.recipe_edit_panel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecipeManageForm";
            this.Text = "配方管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RecipeManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipe_tree_advTree)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.recipe_edit_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipe_show_dataGridView)).EndInit();
            this.left_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree recipe_tree_advTree;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.PanelEx recipe_edit_panel;
        private DevComponents.DotNetBar.Controls.TextBoxX recipe_sleeve_textBox;
        private DevComponents.DotNetBar.Controls.TextBoxX recipe_componentNNumber_textBox;
        private DevComponents.DotNetBar.Controls.TextBoxX recipe_boltNumber_textBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX recipe_isCheck_checkBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX recipe_isTrace_checkBox;
        private DevComponents.DotNetBar.LabelX recipe_barcodeLength_label;
        private DevComponents.DotNetBar.LabelX recipe_componentNNumber_label;
        private DevComponents.DotNetBar.LabelX recipe_boltNumber_label;
        private DevComponents.DotNetBar.Controls.TextBoxX recipe_componentName_textBox;
        private DevComponents.DotNetBar.LabelX recipe_componentName_label;
        private DevComponents.DotNetBar.Controls.TextBoxX recipe_boltNo_textBox;
        private DevComponents.DotNetBar.LabelX recipe_boltNo_label;
        private DevComponents.DotNetBar.Controls.TextBoxX recipe_programNo_textBox;
        private DevComponents.DotNetBar.LabelX recipe_programNo_label;
        private DevComponents.DotNetBar.Controls.ComboBoxEx recipe_operationType_comboBox;
        private DevComponents.DotNetBar.LabelX recipe_operationType_label;
        private DevComponents.DotNetBar.LabelX recipe_step_label;
        private DevComponents.DotNetBar.Controls.ComboBoxEx recipe_station_comboBox;
        private DevComponents.DotNetBar.ButtonX recipe_cancel_button;
        private DevComponents.DotNetBar.ButtonX recipe_delete_button;
        private DevComponents.DotNetBar.ButtonX repice_save_button;
        private DevComponents.DotNetBar.LabelX recipe_checkRule_label;
        private DevComponents.DotNetBar.Controls.TextBoxX recipe_checkRule_textBox;
        private DevComponents.DotNetBar.Controls.TextBoxX recipe_step_textBox;
        private DevComponents.DotNetBar.LabelX recipe_station_label;
        private DevComponents.DotNetBar.LabelX recipe_ProductionName_label;
        private DevComponents.DotNetBar.Controls.DataGridViewX recipe_show_dataGridView;
        private DevComponents.DotNetBar.Controls.ComboBoxEx recipe_ProductionName_comboBox;
        private DevComponents.DotNetBar.LabelX recipe_imagePath_label;
        private DevComponents.DotNetBar.Controls.TextBoxX recipe_imagePath_textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 配方检查ToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.TextBoxX recipe_barcodeLength_textBox;
        private DevComponents.DotNetBar.LabelX recipe_sleeve_label;
        private System.Windows.Forms.Panel left_panel;
        private DevComponents.DotNetBar.LabelX StepDesc_label;
        private DevComponents.DotNetBar.Controls.TextBoxX StepDesc_textBox;
    }
}