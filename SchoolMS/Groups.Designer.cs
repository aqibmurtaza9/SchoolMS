namespace SchoolMS
{
    partial class Groups
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupTexbox = new System.Windows.Forms.TextBox();
            this.statusTexbox = new System.Windows.Forms.ComboBox();
            this.LeftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(240, 656);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.statusTexbox);
            this.panel6.Controls.Add(this.groupTexbox);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Size = new System.Drawing.Size(240, 607);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.label3, 0);
            this.panel6.Controls.SetChildIndex(this.groupTexbox, 0);
            this.panel6.Controls.SetChildIndex(this.statusTexbox, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(1174, 656);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1174, 607);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1174, 49);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // groupTexbox
            // 
            this.groupTexbox.Location = new System.Drawing.Point(7, 140);
            this.groupTexbox.Name = "groupTexbox";
            this.groupTexbox.Size = new System.Drawing.Size(212, 26);
            this.groupTexbox.TabIndex = 3;
            // 
            // statusTexbox
            // 
            this.statusTexbox.FormattingEnabled = true;
            this.statusTexbox.Items.AddRange(new object[] {
            "Active",
            "In acive"});
            this.statusTexbox.Location = new System.Drawing.Point(7, 213);
            this.statusTexbox.Name = "statusTexbox";
            this.statusTexbox.Size = new System.Drawing.Size(212, 26);
            this.statusTexbox.TabIndex = 4;
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 656);
            this.Name = "Groups";
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.Groups_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox statusTexbox;
        private System.Windows.Forms.TextBox groupTexbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}