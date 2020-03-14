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
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (rolesText.Text == "") { rolesErrorLabel.Visible = true; } else { rolesErrorLabel.Visible = false; }
            if (statusDropdown.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            if (rolesErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory.","Error","Error");
            }
            else
            {
               if(edit == 0)   //code for save
                {
                    
                    role r = new role();
                    r.r_name = rolesText.Text;
                    if (statusDropdown.SelectedIndex == 0)
                    {
                       r.r_status=1;
                    }
                    else
                    {
                        r.r_status=0;
                    }

                    //obj.roles.InsertOnSubmit(r);
                    obj.st_InsertRoles(rolesText.Text,r.r_status);
                    obj.SubmitChanges();
                    MainClass.showMSG(rolesText.Text+" added successfully","Success.","Success");
                    MainClass.disable_reset(panel6);
                }
               else if(edit==1)   //code for update //lecture 5 18:10 min
                {

                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Roles_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
        }
    }
}
