namespace SchoolMS
{
    partial class Sections
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.secnametextbox = new System.Windows.Forms.TextBox();
            this.statustextbox = new System.Windows.Forms.Label();
            this.sectionerrorlbl = new System.Windows.Forms.Label();
            this.statuserrorlbl = new System.Windows.Forms.Label();
            this.comboboxStatus = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rolesdataGridView = new System.Windows.Forms.DataGridView();
            this.sectionDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(240, 734);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.comboboxStatus);
            this.panel6.Controls.Add(this.statustextbox);
            this.panel6.Controls.Add(this.secnametextbox);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.statuserrorlbl);
            this.panel6.Controls.Add(this.sectionerrorlbl);
            this.panel6.Size = new System.Drawing.Size(240, 685);
            this.panel6.Controls.SetChildIndex(this.sectionerrorlbl, 0);
            this.panel6.Controls.SetChildIndex(this.statuserrorlbl, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.secnametextbox, 0);
            this.panel6.Controls.SetChildIndex(this.statustextbox, 0);
            this.panel6.Controls.SetChildIndex(this.comboboxStatus, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(1044, 734);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Size = new System.Drawing.Size(1044, 685);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1044, 49);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Section Name";
            // 
            // secnametextbox
            // 
            this.secnametextbox.Location = new System.Drawing.Point(16, 151);
            this.secnametextbox.Name = "secnametextbox";
            this.secnametextbox.Size = new System.Drawing.Size(203, 26);
            this.secnametextbox.TabIndex = 2;
            this.secnametextbox.TextChanged += new System.EventHandler(this.secnametextbox_TextChanged);
            // 
            // statustextbox
            // 
            this.statustextbox.AutoSize = true;
            this.statustextbox.Location = new System.Drawing.Point(13, 191);
            this.statustextbox.Name = "statustextbox";
            this.statustextbox.Size = new System.Drawing.Size(49, 18);
            this.statustextbox.TabIndex = 1;
            this.statustextbox.Text = "Status";
            // 
            // sectionerrorlbl
            // 
            this.sectionerrorlbl.AutoSize = true;
            this.sectionerrorlbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionerrorlbl.Location = new System.Drawing.Point(198, 133);
            this.sectionerrorlbl.Name = "sectionerrorlbl";
            this.sectionerrorlbl.Size = new System.Drawing.Size(21, 24);
            this.sectionerrorlbl.TabIndex = 3;
            this.sectionerrorlbl.Text = "*";
            // 
            // statuserrorlbl
            // 
            this.statuserrorlbl.AutoSize = true;
            this.statuserrorlbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuserrorlbl.Location = new System.Drawing.Point(198, 194);
            this.statuserrorlbl.Name = "statuserrorlbl";
            this.statuserrorlbl.Size = new System.Drawing.Size(21, 24);
            this.statuserrorlbl.TabIndex = 3;
            this.statuserrorlbl.Text = "*";
            // 
            // comboboxStatus
            // 
            this.comboboxStatus.FormattingEnabled = true;
            this.comboboxStatus.Items.AddRange(new object[] {
            "Active ",
            "In active"});
            this.comboboxStatus.Location = new System.Drawing.Point(16, 214);
            this.comboboxStatus.Name = "comboboxStatus";
            this.comboboxStatus.Size = new System.Drawing.Size(203, 26);
            this.comboboxStatus.TabIndex = 4;
            this.comboboxStatus.SelectedIndexChanged += new System.EventHandler(this.comboboxStatus_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rolesdataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1044, 629);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // rolesdataGridView
            // 
            this.rolesdataGridView.AllowUserToAddRows = false;
            this.rolesdataGridView.AllowUserToDeleteRows = false;
            this.rolesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rolesdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.rolesdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rolesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sectionDGV,
            this.snoGV,
            this.sectionGV,
            this.statusGV});
            this.rolesdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesdataGridView.Location = new System.Drawing.Point(3, 22);
            this.rolesdataGridView.Name = "rolesdataGridView";
            this.rolesdataGridView.ReadOnly = true;
            this.rolesdataGridView.RowHeadersVisible = false;
            this.rolesdataGridView.RowHeadersWidth = 51;
            this.rolesdataGridView.Size = new System.Drawing.Size(1038, 604);
            this.rolesdataGridView.TabIndex = 0;
            // 
            // sectionDGV
            // 
            this.sectionDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sectionDGV.HeaderText = "Section Id";
            this.sectionDGV.MinimumWidth = 6;
            this.sectionDGV.Name = "sectionDGV";
            this.sectionDGV.ReadOnly = true;
            this.sectionDGV.Visible = false;
            this.sectionDGV.Width = 79;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "S No.";
            this.snoGV.MinimumWidth = 6;
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 73;
            // 
            // sectionGV
            // 
            this.sectionGV.HeaderText = "Section";
            this.sectionGV.MinimumWidth = 6;
            this.sectionGV.Name = "sectionGV";
            this.sectionGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 6;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 734);
            this.Name = "Sections";
            this.Text = "Sections";
            this.Load += new System.EventHandler(this.Sections_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rolesdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label statustextbox;
        private System.Windows.Forms.TextBox secnametextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statuserrorlbl;
        private System.Windows.Forms.Label sectionerrorlbl;
        private System.Windows.Forms.ComboBox comboboxStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView rolesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}