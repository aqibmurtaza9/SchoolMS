namespace SchoolMS
{
    partial class Roles
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
            this.roleBtn = new System.Windows.Forms.Label();
            this.statusBtn = new System.Windows.Forms.Label();
            this.rolesText = new System.Windows.Forms.TextBox();
            this.statusDropdown = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rolesdataGridView = new System.Windows.Forms.DataGridView();
            this.rolesDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolesErrorLabel = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
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
            this.LeftPanel.Size = new System.Drawing.Size(240, 673);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.statusDropdown);
            this.panel6.Controls.Add(this.rolesText);
            this.panel6.Controls.Add(this.roleBtn);
            this.panel6.Controls.Add(this.statusBtn);
            this.panel6.Controls.Add(this.rolesErrorLabel);
            this.panel6.Controls.Add(this.statusErrorLabel);
            this.panel6.Size = new System.Drawing.Size(240, 624);
            this.panel6.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.rolesErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.statusBtn, 0);
            this.panel6.Controls.SetChildIndex(this.roleBtn, 0);
            this.panel6.Controls.SetChildIndex(this.rolesText, 0);
            this.panel6.Controls.SetChildIndex(this.statusDropdown, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(1293, 673);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Size = new System.Drawing.Size(1293, 624);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1293, 49);
            // 
            // roleBtn
            // 
            this.roleBtn.AutoSize = true;
            this.roleBtn.Location = new System.Drawing.Point(12, 74);
            this.roleBtn.Name = "roleBtn";
            this.roleBtn.Size = new System.Drawing.Size(42, 18);
            this.roleBtn.TabIndex = 1;
            this.roleBtn.Text = "Roles";
            // 
            // statusBtn
            // 
            this.statusBtn.AutoSize = true;
            this.statusBtn.Location = new System.Drawing.Point(12, 127);
            this.statusBtn.Name = "statusBtn";
            this.statusBtn.Size = new System.Drawing.Size(49, 18);
            this.statusBtn.TabIndex = 1;
            this.statusBtn.Text = "Status";
            // 
            // rolesText
            // 
            this.rolesText.Location = new System.Drawing.Point(15, 93);
            this.rolesText.Name = "rolesText";
            this.rolesText.Size = new System.Drawing.Size(204, 26);
            this.rolesText.TabIndex = 2;
            this.rolesText.TextChanged += new System.EventHandler(this.rolesText_TextChanged);
            // 
            // statusDropdown
            // 
            this.statusDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDropdown.FormattingEnabled = true;
            this.statusDropdown.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDropdown.Location = new System.Drawing.Point(17, 146);
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.Size = new System.Drawing.Size(202, 26);
            this.statusDropdown.TabIndex = 3;
            this.statusDropdown.SelectedIndexChanged += new System.EventHandler(this.statusDropdown_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rolesdataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1293, 568);
            this.groupBox2.TabIndex = 1;
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
            this.rolesDGV,
            this.snoGV,
            this.roleGV,
            this.statusGV});
            this.rolesdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesdataGridView.Location = new System.Drawing.Point(3, 22);
            this.rolesdataGridView.Name = "rolesdataGridView";
            this.rolesdataGridView.ReadOnly = true;
            this.rolesdataGridView.RowHeadersVisible = false;
            this.rolesdataGridView.RowHeadersWidth = 51;
            this.rolesdataGridView.Size = new System.Drawing.Size(1287, 543);
            this.rolesdataGridView.TabIndex = 0;
            // 
            // rolesDGV
            // 
            this.rolesDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rolesDGV.HeaderText = "Roles Id";
            this.rolesDGV.MinimumWidth = 6;
            this.rolesDGV.Name = "rolesDGV";
            this.rolesDGV.ReadOnly = true;
            this.rolesDGV.Visible = false;
            this.rolesDGV.Width = 125;
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
            // roleGV
            // 
            this.roleGV.HeaderText = "Role";
            this.roleGV.MinimumWidth = 6;
            this.roleGV.Name = "roleGV";
            this.roleGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 6;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // rolesErrorLabel
            // 
            this.rolesErrorLabel.AutoSize = true;
            this.rolesErrorLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolesErrorLabel.Location = new System.Drawing.Point(194, 73);
            this.rolesErrorLabel.Name = "rolesErrorLabel";
            this.rolesErrorLabel.Size = new System.Drawing.Size(27, 30);
            this.rolesErrorLabel.TabIndex = 4;
            this.rolesErrorLabel.Text = "*";
            this.rolesErrorLabel.Visible = false;
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.Location = new System.Drawing.Point(198, 125);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(27, 30);
            this.statusErrorLabel.TabIndex = 4;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 673);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
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

        private System.Windows.Forms.ComboBox statusDropdown;
        private System.Windows.Forms.TextBox rolesText;
        private System.Windows.Forms.Label roleBtn;
        private System.Windows.Forms.Label statusBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView rolesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.Label rolesErrorLabel;
        private System.Windows.Forms.Label statusErrorLabel;
    }
}