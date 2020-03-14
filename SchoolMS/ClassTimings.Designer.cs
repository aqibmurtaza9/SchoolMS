namespace SchoolMS
{
    partial class ClassTimings
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fromnumUD = new System.Windows.Forms.NumericUpDown();
            this.tonumUD = new System.Windows.Forms.NumericUpDown();
            this.LeftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromnumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(240, 740);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tonumUD);
            this.panel6.Controls.Add(this.fromnumUD);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Size = new System.Drawing.Size(240, 691);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.label3, 0);
            this.panel6.Controls.SetChildIndex(this.label6, 0);
            this.panel6.Controls.SetChildIndex(this.label4, 0);
            this.panel6.Controls.SetChildIndex(this.label5, 0);
            this.panel6.Controls.SetChildIndex(this.textBox1, 0);
            this.panel6.Controls.SetChildIndex(this.textBox2, 0);
            this.panel6.Controls.SetChildIndex(this.comboBox1, 0);
            this.panel6.Controls.SetChildIndex(this.fromnumUD, 0);
            this.panel6.Controls.SetChildIndex(this.tonumUD, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(1199, 740);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1199, 691);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1199, 49);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timing Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "To Timing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "From Timing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Timing Shift";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 26);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 26);
            this.textBox2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Timing Day";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.comboBox1.Location = new System.Drawing.Point(7, 405);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 26);
            this.comboBox1.TabIndex = 6;
            // 
            // fromnumUD
            // 
            this.fromnumUD.Location = new System.Drawing.Point(7, 266);
            this.fromnumUD.Name = "fromnumUD";
            this.fromnumUD.Size = new System.Drawing.Size(215, 26);
            this.fromnumUD.TabIndex = 7;
            // 
            // tonumUD
            // 
            this.tonumUD.Location = new System.Drawing.Point(7, 337);
            this.tonumUD.Name = "tonumUD";
            this.tonumUD.Size = new System.Drawing.Size(215, 26);
            this.tonumUD.TabIndex = 7;
            // 
            // ClassTimings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 740);
            this.Name = "ClassTimings";
            this.Text = "ClassTimings";
            this.Load += new System.EventHandler(this.ClassTimings_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fromnumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonumUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tonumUD;
        private System.Windows.Forms.NumericUpDown fromnumUD;
    }
}