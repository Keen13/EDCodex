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
            this.SuspendLayout();
            // 
            // textBox_logMsgs
            // 
            this.textBox_logMsgs.Location = new System.Drawing.Point(3, 373);
            this.textBox_logMsgs.Name = "textBox_logMsgs";
            this.textBox_logMsgs.Size = new System.Drawing.Size(880, 224);
            this.textBox_logMsgs.TabIndex = 0;
            this.textBox_logMsgs.Text = "";
            // 
            // PanelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_logMsgs);
            this.Name = "PanelUserControl";
            this.Size = new System.Drawing.Size(886, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox_logMsgs;
    }
}
