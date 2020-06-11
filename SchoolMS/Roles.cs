using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS
{
    public partial class Roles : Sample2
    {
        int edit = 0;
        MyDBDataContext obj = new MyDBDataContext();
        public Roles()
        {
            InitializeComponent();
        }

        private void rolesText_TextChanged(object sender, EventArgs e)
        {
            if (rolesText.Text == "") { rolesErrorLabel.Visible = true; } else { rolesErrorLabel.Visible = false; }
        }

        private void statusDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDropdown.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(panel6);
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel6);
        }

      

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (rolesText.Text == "") { rolesErrorLabel.Visible = true; } else { rolesErrorLabel.Visible = false; }
            if (statusDropdown.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            if (rolesErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory.", "Error", "Error");
            }
            else
            {
                if (edit == 0)   //code for save
                {

                    role r = new role();
                    r.r_name = rolesText.Text;
                    if (statusDropdown.SelectedIndex == 0)
                    {
                        r.r_status = 1;
                    }
                    else
                    {
                        r.r_status = 0;
                    }

                    //obj.roles.InsertOnSubmit(r);
                    obj.st_InsertRoles(rolesText.Text, r.r_status);
                    obj.SubmitChanges();
                    MainClass.showMSG(rolesText.Text + " added successfully", "Success.", "Success");
                    MainClass.disable_reset(panel6);
                    loaddata();  
                }
                else if (edit == 1)   //code for update 
                {
                    byte stat;
                    if (statusDropdown.SelectedIndex == 0)
                    {
                       stat= 1;
                    }
                    else
                    {
                       stat = 0;
                    }
                    obj.st_UpdateRoles(rolesText.Text,stat,roleID);

                    //var data = obj.roles.Single(x => x.r_id == roleID);    // db roleId = DG 
                    //       data.r_name = rolesText.Text;
                    //    if (statusDropdown.SelectedIndex == 0)
                    //    {
                    //       data.r_status = 1;
                    //    }
                    //    else
                    //    {
                    //        data.r_status = 0;
                    //    }
                    //    obj.SubmitChanges();

                    MainClass.showMSG(rolesText.Text + " update successfully", "Success..", "Success");
                    MainClass.disable_reset(panel6);
                    loaddata();


                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + rolesText.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.sr_deleteRoles(roleID);
                    MainClass.showMSG(rolesText.Text + " Deleted successfully", "Success..", "Success");
                    MainClass.disable_reset(panel6);
                    loaddata();
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        public void search()
        {
            var abc = obj.st_searchRoles(searchtxt.Text);
            roleIDGV.DataPropertyName = "ID";
            roleGV.DataPropertyName = "Role";
            statusGV.DataPropertyName = "Status";
            rolesdataGridView.DataSource = abc;
            MainClass.sno(rolesdataGridView, "snoGV");
        }

        public override void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void loaddata()
        {

            MainClass.disable_reset(panel6);
            var abc = obj.st_getRoles();

            roleIDGV.DataPropertyName = "ID";
            roleGV.DataPropertyName = "Role";
            statusGV.DataPropertyName =  "Status";
            rolesdataGridView.DataSource = abc;
           MainClass.sno(rolesdataGridView,"snoGV");
        }
        private void Roles_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            
        }

        int roleID;
        private void rolesdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;   // for delete method
                DataGridViewRow row = rolesdataGridView.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["roleIDGV"].Value.ToString());
                rolesText.Text = row.Cells["roleGV"].Value.ToString();
                statusDropdown.SelectedItem = row.Cells["statusGV"].Value.ToString();

            }
        }
    }
}
