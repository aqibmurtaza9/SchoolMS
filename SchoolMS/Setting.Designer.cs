namespace SchoolMS
{
    partial class Setting
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
            this.savebutton = new System.Windows.Forms.Button();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datasourcetxt = new System.Windows.Forms.TextBox();
            this.databasetxt = new System.Windows.Forms.TextBox();
            this.CB = new System.Windows.Forms.CheckBox();
            this.dserrorLabel = new System.Windows.Forms.Label();
            this.dberrorLabel = new System.Windows.Forms.Label();
            this.unerrorLabel = new System.Windows.Forms.Label();
            this.pwerrorLabel = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(240, 648);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.CB);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.datasourcetxt);
            this.panel6.Controls.Add(this.databasetxt);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.savebutton);
            this.panel6.Controls.Add(this.usernametxt);
            this.panel6.Controls.Add(this.passtxt);
            this.panel6.Controls.Add(this.pwerrorLabel);
            this.panel6.Controls.Add(this.unerrorLabel);
            this.panel6.Controls.Add(this.dberrorLabel);
            this.panel6.Controls.Add(this.dserrorLabel);
            this.panel6.Size = new System.Drawing.Size(240, 594);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(911, 648);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Size = new System.Drawing.Size(911, 608);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(911, 40);
            // 
            // savebutton
            // 
            this.savebutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.savebutton.FlatAppearance.BorderSize = 2;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Location = new System.Drawing.Point(52, 463);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(130, 40);
            this.savebutton.TabIndex = 5;
            this.savebutton.Text = "&SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(31, 328);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(187, 26);
            this.usernametxt.TabIndex = 2;
            this.usernametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(31, 382);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(187, 26);
            this.passtxt.TabIndex = 3;
            this.passtxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "DataSource";
            // 
            // datasourcetxt
            // 
            this.datasourcetxt.Location = new System.Drawing.Point(31, 222);
            this.datasourcetxt.Name = "datasourcetxt";
            this.datasourcetxt.Size = new System.Drawing.Size(187, 26);
            this.datasourcetxt.TabIndex = 0;
            this.datasourcetxt.TextChanged += new System.EventHandler(this.datasourcetxt_TextChanged);
            // 
            // databasetxt
            // 
            this.databasetxt.Location = new System.Drawing.Point(31, 276);
            this.databasetxt.Name = "databasetxt";
            this.databasetxt.Size = new System.Drawing.Size(187, 26);
            this.databasetxt.TabIndex = 1;
            this.databasetxt.TextChanged += new System.EventHandler(this.databasetxt_TextChanged);
            // 
            // CB
            // 
            this.CB.AutoSize = true;
            this.CB.Location = new System.Drawing.Point(31, 414);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(155, 22);
            this.CB.TabIndex = 4;
            this.CB.Text = "Integrated Security";
            this.CB.UseVisualStyleBackColor = true;
            this.CB.CheckedChanged += new System.EventHandler(this.CB_CheckedChanged);
            // 
            // dserrorLabel
            // 
            this.dserrorLabel.AutoSize = true;
            this.dserrorLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dserrorLabel.Location = new System.Drawing.Point(191, 201);
            this.dserrorLabel.Name = "dserrorLabel";
            this.dserrorLabel.Size = new System.Drawing.Size(27, 30);
            this.dserrorLabel.TabIndex = 12;
            this.dserrorLabel.Text = "*";
            this.dserrorLabel.Visible = false;
            // 
            // dberrorLabel
            // 
            this.dberrorLabel.AutoSize = true;
            this.dberrorLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dberrorLabel.Location = new System.Drawing.Point(191, 251);
            this.dberrorLabel.Name = "dberrorLabel";
            this.dberrorLabel.Size = new System.Drawing.Size(27, 30);
            this.dberrorLabel.TabIndex = 12;
            this.dberrorLabel.Text = "*";
            this.dberrorLabel.Visible = false;
            // 
            // unerrorLabel
            // 
            this.unerrorLabel.AutoSize = true;
            this.unerrorLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unerrorLabel.Location = new System.Drawing.Point(191, 305);
            this.unerrorLabel.Name = "unerrorLabel";
            this.unerrorLabel.Size = new System.Drawing.Size(27, 30);
            this.unerrorLabel.TabIndex = 12;
            this.unerrorLabel.Text = "*";
            this.unerrorLabel.Visible = false;
            // 
            // pwerrorLabel
            // 
            this.pwerrorLabel.AccessibleDescription = "";
            this.pwerrorLabel.AutoSize = true;
            this.pwerrorLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwerrorLabel.Location = new System.Drawing.Point(191, 361);
            this.pwerrorLabel.Name = "pwerrorLabel";
            this.pwerrorLabel.Size = new System.Drawing.Size(27, 30);
            this.pwerrorLabel.TabIndex = 12;
            this.pwerrorLabel.Text = "*";
            this.pwerrorLabel.Visible = false;
            // 
            // Setting
            // 
            this.AcceptButton = this.savebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 648);
            this.ControlBox = false;
            this.Name = "Setting";
            this.Text = "Setting";
            this.LeftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.CheckBox CB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox datasourcetxt;
        private System.Windows.Forms.TextBox databasetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pwerrorLabel;
        private System.Windows.Forms.Label unerrorLabel;
        private System.Windows.Forms.Label dberrorLabel;
        private System.Windows.Forms.Label dserrorLabel;
    }
}