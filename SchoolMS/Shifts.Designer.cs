namespace SchoolMS
{
    partial class Shifts
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
            this.label4 = new System.Windows.Forms.Label();
            this.shiftnameTexbox = new System.Windows.Forms.TextBox();
            this.shiftnumCombo = new System.Windows.Forms.ComboBox();
            this.LeftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(240, 764);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.shiftnumCombo);
            this.panel6.Controls.Add(this.shiftnameTexbox);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Size = new System.Drawing.Size(240, 715);
            this.panel6.Controls.SetChildIndex(this.label3, 0);
            this.panel6.Controls.SetChildIndex(this.label4, 0);
            this.panel6.Controls.SetChildIndex(this.shiftnameTexbox, 0);
            this.panel6.Controls.SetChildIndex(this.shiftnumCombo, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(1170, 764);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1170, 715);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1170, 49);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Shift Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Shift Number";
            // 
            // shiftnameTexbox
            // 
            this.shiftnameTexbox.Location = new System.Drawing.Point(3, 158);
            this.shiftnameTexbox.Name = "shiftnameTexbox";
            this.shiftnameTexbox.Size = new System.Drawing.Size(213, 26);
            this.shiftnameTexbox.TabIndex = 2;
            // 
            // shiftnumCombo
            // 
            this.shiftnumCombo.FormattingEnabled = true;
            this.shiftnumCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.shiftnumCombo.Location = new System.Drawing.Point(4, 234);
            this.shiftnumCombo.Name = "shiftnumCombo";
            this.shiftnumCombo.Size = new System.Drawing.Size(212, 26);
            this.shiftnumCombo.TabIndex = 3;
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 764);
            this.Controls.Add(this.label2);
            this.Name = "Shifts";
            this.Text = "Shifts";
            this.Load += new System.EventHandler(this.Shifts_Load);
            this.Controls.SetChildIndex(this.LeftPanel, 0);
            this.Controls.SetChildIndex(this.RightPanel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.LeftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox shiftnumCombo;
        private System.Windows.Forms.TextBox shiftnameTexbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}