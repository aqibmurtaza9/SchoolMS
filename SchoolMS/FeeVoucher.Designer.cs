namespace SchoolMS
{
    partial class FeeVoucher
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
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(240, 674);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(240, 625);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(1213, 674);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1213, 625);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1213, 49);
            // 
            // FeeVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 674);
            this.Name = "FeeVoucher";
            this.Text = "FeeVoucher";
            this.Load += new System.EventHandler(this.FeeVoucher_Load);
            this.LeftPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}