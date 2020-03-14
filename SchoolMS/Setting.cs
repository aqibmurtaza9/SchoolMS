using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS
{
    public partial class Setting : Sample
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void datasourcetxt_TextChanged(object sender, EventArgs e)
        {
            if (datasourcetxt.Text == "") { dserrorLabel.Visible= true; } else { dserrorLabel.Visible = false; }
        }

        private void databasetxt_TextChanged(object sender, EventArgs e)
        {
            if (databasetxt.Text == "") { dberrorLabel.Visible = true; } else { dberrorLabel.Visible = false; }
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            if (usernametxt.Text == "") { unerrorLabel.Visible = true; } else { unerrorLabel.Visible = false; }
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            if (passtxt.Text == "") { pwerrorLabel.Visible = true; } else { pwerrorLabel.Visible = false; }
        }
      
        private void savebutton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (CB.Checked)
            {
                if (datasourcetxt.Text == "") { dserrorLabel.Visible = true; } else { dserrorLabel.Visible = false; }
                if (databasetxt.Text == "") { dberrorLabel.Visible = true; } else { dberrorLabel.Visible = false; }
                if (dserrorLabel.Visible || dberrorLabel.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory!");
                }
                else
                { 
                    sb.Append("Data Source" + datasourcetxt.Text + ";Initial catalog= " + databasetxt + ";Security = true; MultipleActiveResultSets=ture");
                    File.WriteAllText(MainClass.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Setting Save Successfully,","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log,this,MDI.ActiveForm);
                    }
                }

            }
            else
            {
                if (datasourcetxt.Text == "") { dserrorLabel.Visible = true; } else { dserrorLabel.Visible = false; }
                if (databasetxt.Text == "") { dberrorLabel.Visible = true; } else { dberrorLabel.Visible = false; }
                if (usernametxt.Text == "") { unerrorLabel.Visible = true; } else { unerrorLabel.Visible = false; }
                if (passtxt.Text == "") { pwerrorLabel.Visible = true; } else { pwerrorLabel.Visible = false; }
                if (dserrorLabel.Visible || dberrorLabel.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory!");
                }
                else
                {
                    sb.Append("Data Source" + datasourcetxt.Text + ";Initial catalog= " + databasetxt + ";User ID ="+usernametxt.Text+"Password="+passtxt.Text+ "MultipleActiveResultSets=ture");
                    File.WriteAllText(MainClass.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Setting Save Successfully,", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
            }


        }

        private void CB_CheckedChanged(object sender, EventArgs e)
        {
            if (CB.Checked)
            {
                usernametxt.Text = "";
                usernametxt.Enabled = false;
                unerrorLabel.Visible = false;
                passtxt.Text = "";
                passtxt.Enabled = false;
                pwerrorLabel.Visible = false;

            }
            else
            {
                usernametxt.Enabled = true;
                passtxt.Enabled = true;
            }
        }
    }
}
