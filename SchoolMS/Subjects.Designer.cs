namespace SchoolMS
{
    partial class Subjects
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
            this.label2 = new System.Windows.Forms.Label();
            this.subjectstextbox = new System.Windows.Forms.TextBox();
            this.LeftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(240, 653);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.subjectstextbox);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Size = new System.Drawing.Size(240, 604);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.subjectstextbox, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(1227, 653);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1227, 604);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1227, 49);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subjects";
            // 
            // subjectstextbox
            // 
            this.subjectstextbox.Location = new System.Drawing.Point(4, 136);
            this.subjectstextbox.Name = "subjectstextbox";
            this.subjectstextbox.Size = new System.Drawing.Size(215, 26);
            this.subjectstextbox.TabIndex = 2;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 653);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectstextbox;
    }
}