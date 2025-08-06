namespace EDCodex.Panel
{
    partial class PanelUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_logMsgs = new System.Windows.Forms.RichTextBox();
            this.comboBox_currentRegion = new System.Windows.Forms.ComboBox();
            this.label_currentRegion = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_codexEntries = new System.Windows.Forms.DataGridView();
            this.panel_topControls = new System.Windows.Forms.Panel();
            this.groupBox_discoveryFilters = new System.Windows.Forms.GroupBox();
            this.radioButton_filterNotFound = new System.Windows.Forms.RadioButton();
            this.radioButton_filterExisting = new System.Windows.Forms.RadioButton();
            this.radioButton_filterAll = new System.Windows.Forms.RadioButton();
            this.comboBox_discoveryType = new System.Windows.Forms.ComboBox();
            this.label_discoveryType = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_codexEntries)).BeginInit();
            this.panel_topControls.SuspendLayout();
            this.groupBox_discoveryFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_logMsgs
            // 
            this.textBox_logMsgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_logMsgs.Location = new System.Drawing.Point(0, 0);
            this.textBox_logMsgs.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_logMsgs.Name = "textBox_logMsgs";
            this.textBox_logMsgs.ReadOnly = true;
            this.textBox_logMsgs.Size = new System.Drawing.Size(793, 120);
            this.textBox_logMsgs.TabIndex = 0;
            this.textBox_logMsgs.Text = "";
            // 
            // comboBox_currentRegion
            // 
            this.comboBox_currentRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_currentRegion.FormattingEnabled = true;
            this.comboBox_currentRegion.Location = new System.Drawing.Point(13, 21);
            this.comboBox_currentRegion.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_currentRegion.Name = "comboBox_currentRegion";
            this.comboBox_currentRegion.Size = new System.Drawing.Size(183, 21);
            this.comboBox_currentRegion.TabIndex = 1;
            this.comboBox_currentRegion.SelectedIndexChanged += new System.EventHandler(this.comboBox_currentRegion_SelectedIndexChanged);
            // 
            // label_currentRegion
            // 
            this.label_currentRegion.AutoSize = true;
            this.label_currentRegion.Location = new System.Drawing.Point(13, 6);
            this.label_currentRegion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_currentRegion.Name = "label_currentRegion";
            this.label_currentRegion.Size = new System.Drawing.Size(73, 13);
            this.label_currentRegion.TabIndex = 2;
            this.label_currentRegion.Text = "Current region";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox_logMsgs);
            this.splitContainer1.Size = new System.Drawing.Size(793, 573);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // dataGridView_codexEntries
            // 
            this.dataGridView_codexEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_codexEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_codexEntries.Location = new System.Drawing.Point(0, 104);
            this.dataGridView_codexEntries.Name = "dataGridView_codexEntries";
            this.dataGridView_codexEntries.Size = new System.Drawing.Size(369, 346);
            this.dataGridView_codexEntries.TabIndex = 0;
            // 
            // panel_topControls
            // 
            this.panel_topControls.Controls.Add(this.groupBox_discoveryFilters);
            this.panel_topControls.Controls.Add(this.comboBox_discoveryType);
            this.panel_topControls.Controls.Add(this.label_discoveryType);
            this.panel_topControls.Controls.Add(this.label_currentRegion);
            this.panel_topControls.Controls.Add(this.comboBox_currentRegion);
            this.panel_topControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topControls.Location = new System.Drawing.Point(0, 0);
            this.panel_topControls.Margin = new System.Windows.Forms.Padding(2);
            this.panel_topControls.Name = "panel_topControls";
            this.panel_topControls.Size = new System.Drawing.Size(369, 104);
            this.panel_topControls.TabIndex = 5;
            // 
            // groupBox_discoveryFilters
            // 
            this.groupBox_discoveryFilters.Controls.Add(this.radioButton_filterNotFound);
            this.groupBox_discoveryFilters.Controls.Add(this.radioButton_filterExisting);
            this.groupBox_discoveryFilters.Controls.Add(this.radioButton_filterAll);
            this.groupBox_discoveryFilters.Location = new System.Drawing.Point(246, 6);
            this.groupBox_discoveryFilters.Name = "groupBox_discoveryFilters";
            this.groupBox_discoveryFilters.Size = new System.Drawing.Size(98, 85);
            this.groupBox_discoveryFilters.TabIndex = 5;
            this.groupBox_discoveryFilters.TabStop = false;
            this.groupBox_discoveryFilters.Text = "Filter by";
            // 
            // radioButton_filterNotFound
            // 
            this.radioButton_filterNotFound.AutoSize = true;
            this.radioButton_filterNotFound.Location = new System.Drawing.Point(6, 62);
            this.radioButton_filterNotFound.Name = "radioButton_filterNotFound";
            this.radioButton_filterNotFound.Size = new System.Drawing.Size(72, 17);
            this.radioButton_filterNotFound.TabIndex = 2;
            this.radioButton_filterNotFound.TabStop = true;
            this.radioButton_filterNotFound.Text = "Not found";
            this.radioButton_filterNotFound.UseVisualStyleBackColor = true;
            // 
            // radioButton_filterExisting
            // 
            this.radioButton_filterExisting.AutoSize = true;
            this.radioButton_filterExisting.Location = new System.Drawing.Point(6, 39);
            this.radioButton_filterExisting.Name = "radioButton_filterExisting";
            this.radioButton_filterExisting.Size = new System.Drawing.Size(61, 17);
            this.radioButton_filterExisting.TabIndex = 1;
            this.radioButton_filterExisting.TabStop = true;
            this.radioButton_filterExisting.Text = "Existing";
            this.radioButton_filterExisting.UseVisualStyleBackColor = true;
            // 
            // radioButton_filterAll
            // 
            this.radioButton_filterAll.AutoSize = true;
            this.radioButton_filterAll.Location = new System.Drawing.Point(6, 16);
            this.radioButton_filterAll.Name = "radioButton_filterAll";
            this.radioButton_filterAll.Size = new System.Drawing.Size(65, 17);
            this.radioButton_filterAll.TabIndex = 0;
            this.radioButton_filterAll.TabStop = true;
            this.radioButton_filterAll.Text = "Show all";
            this.radioButton_filterAll.UseVisualStyleBackColor = true;
            // 
            // comboBox_discoveryType
            // 
            this.comboBox_discoveryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_discoveryType.FormattingEnabled = true;
            this.comboBox_discoveryType.Location = new System.Drawing.Point(13, 70);
            this.comboBox_discoveryType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_discoveryType.Name = "comboBox_discoveryType";
            this.comboBox_discoveryType.Size = new System.Drawing.Size(183, 21);
            this.comboBox_discoveryType.TabIndex = 4;
            this.comboBox_discoveryType.SelectedIndexChanged += new System.EventHandler(this.comboBox_discoveryType_SelectedIndexChanged);
            // 
            // label_discoveryType
            // 
            this.label_discoveryType.AutoSize = true;
            this.label_discoveryType.Location = new System.Drawing.Point(10, 55);
            this.label_discoveryType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_discoveryType.Name = "label_discoveryType";
            this.label_discoveryType.Size = new System.Drawing.Size(77, 13);
            this.label_discoveryType.TabIndex = 3;
            this.label_discoveryType.Text = "Discovery type";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView_codexEntries);
            this.splitContainer2.Panel1.Controls.Add(this.panel_topControls);
            this.splitContainer2.Size = new System.Drawing.Size(793, 450);
            this.splitContainer2.SplitterDistance = 369;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // PanelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelUserControl";
            this.Size = new System.Drawing.Size(793, 573);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_codexEntries)).EndInit();
            this.panel_topControls.ResumeLayout(false);
            this.panel_topControls.PerformLayout();
            this.groupBox_discoveryFilters.ResumeLayout(false);
            this.groupBox_discoveryFilters.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox_logMsgs;
        private System.Windows.Forms.ComboBox comboBox_currentRegion;
        private System.Windows.Forms.Label label_currentRegion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_topControls;
        private System.Windows.Forms.ComboBox comboBox_discoveryType;
        private System.Windows.Forms.Label label_discoveryType;
        private System.Windows.Forms.DataGridView dataGridView_codexEntries;
        private System.Windows.Forms.GroupBox groupBox_discoveryFilters;
        private System.Windows.Forms.RadioButton radioButton_filterNotFound;
        private System.Windows.Forms.RadioButton radioButton_filterExisting;
        private System.Windows.Forms.RadioButton radioButton_filterAll;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}
