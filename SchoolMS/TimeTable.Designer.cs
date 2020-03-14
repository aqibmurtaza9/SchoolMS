namespace SchoolMS
{
    partial class TimeTable
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
            this.LeftPanel.Size = new System.Drawing.Size(240, 653);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(240, 604);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(1167, 653);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1167, 604);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1167, 49);
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 653);
            this.Name = "TimeTable";
            this.Text = "TimeTable";
            this.Load += new System.EventHandler(this.TimeTable_Load);
            this.LeftPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}