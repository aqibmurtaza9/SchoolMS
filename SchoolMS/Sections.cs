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
    public partial class Sections : Sample2
    {
        public Sections()
        {
            InitializeComponent();
        }

        private void Sections_Load(object sender, EventArgs e)
        {

        }

        private void secnametextbox_TextChanged(object sender, EventArgs e)
        {
            if (secnametextbox.Text == "") { sectionerrorlbl.Visible = true; } else { sectionerrorlbl.Visible = false; }
        }

        private void comboboxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxStatus.SelectedIndex == -1) { statuserrorlbl.Visible=true; } else {statuserrorlbl.Visible=false; }
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

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
    }
}
