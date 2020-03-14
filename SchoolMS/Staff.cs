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
    public partial class Staff : Sample2
    {
        public Staff()
        {
            InitializeComponent();
        }
        int edit = 0;
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel6);
            imgtextbox.Enabled = false;
            edit = 0;
           
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable_reset(panel6);
            imgtextbox.Enabled = false;
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (nametextbox.Text == "") { namerrorlbl.Visible = true; }  else { namerrorlbl.Visible = false; }
            if (usernametextbox.Text == "") { usernameerrorlbl.Visible = true; } else { usernameerrorlbl.Visible = false; }
            if (passwordtextbox.Text == "") { passworderrorlbl.Visible = true; } else { passworderrorlbl.Visible = false; }
            if (conpasswordtextbox.Text == "") { conpasserrorlbl.Visible = true; } else { conpasserrorlbl.Visible = false; }
            if (passwordtextbox.Text != conpasswordtextbox.Text) { missmatchlbl.Visible = true; } else { missmatchlbl.Visible = false; }
            if (phone1textbox.Text == "") { phone1errorlbl.Visible = true; } else { phone1errorlbl.Visible = false; }
            if (phone2textbox.Text == "") { phone2errorlbl.Visible = true; } else {phone2errorlbl.Visible = false; }
            if (rolecombobox.SelectedIndex == -1) { roleerrorlbl.Visible = true; } else { roleerrorlbl.Visible = false; }
            if (statuscombobox.SelectedIndex == -1) { statuserrorlbl.Visible = true; } else { statuserrorlbl.Visible = false; }

            if(namerrorlbl.Visible|| usernameerrorlbl.Visible || passworderrorlbl.Visible|| conpasserrorlbl.Visible || passworderrorlbl.Visible || phone1errorlbl.Visible 
                || phone2errorlbl.Visible || roleerrorlbl.Visible || statuserrorlbl.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory.", "Stop...", "Error");

            }
            else
            {
                if (edit == 0) //code for SAVE operation
                {

                }
                else if (edit == 1) // code for UPDATE operation
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
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void statuscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statuscombobox.SelectedIndex == -1) { statuserrorlbl.Visible = true; } else { statuserrorlbl.Visible = false; }
        }

        private void phone2textbox_TextChanged(object sender, EventArgs e)
        {
            if (phone2textbox.Text == "") { phone2errorlbl.Visible = true; } else { phone2errorlbl.Visible = false; }
        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {
            if (nametextbox.Text == "") { namerrorlbl.Visible = true; } else { namerrorlbl.Visible = false; }
        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {
            if (usernametextbox.Text == "") { usernameerrorlbl.Visible = true; } else { usernameerrorlbl.Visible = false; }
        }

        private void passwordtextbox_TextChanged(object sender, EventArgs e)
        {
            if (passwordtextbox.Text == "") { passworderrorlbl.Visible = true; } else { passworderrorlbl.Visible = false; }
        }

        private void conpasswordtextbox_TextChanged(object sender, EventArgs e)
        {
            if (conpasswordtextbox.Text == "") { conpasserrorlbl.Visible = true; } else { conpasserrorlbl.Visible = false; }
        }

        private void phone1textbox_TextChanged(object sender, EventArgs e)
        {
            if (phone1textbox.Text == "") { phone1errorlbl.Visible = true; } else { phone1errorlbl.Visible = false; }
        }

        private void rolecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolecombobox.SelectedIndex == -1) { roleerrorlbl.Visible = true; } else { roleerrorlbl.Visible = false; }
        }

        private void missmatchlbl_Click(object sender, EventArgs e)
        {
            if (passwordtextbox.Text != conpasswordtextbox.Text) { missmatchlbl.Visible = true; } else { missmatchlbl.Visible = false; }
        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
          DialogResult dr=  openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Image img = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                imgtextbox.Text = openFileDialog1.FileName;
            }
        }

        private void namerrorlbl_Click(object sender, EventArgs e)
        {
           
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
        }
    }
}
