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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void staffBtn_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
          MainClass.showWindow(s,this,MDI.ActiveForm);
        }

       
        private void classesBtn_Click(object sender, EventArgs e)
        {
            Classes cls = new Classes();
           MainClass.showWindow(cls,this,MDI.ActiveForm);
        }

        private void roleBtn_Click(object sender, EventArgs e)
        {
            Roles rls = new Roles();
           MainClass.showWindow(rls, this, MDI.ActiveForm);
        }

        private void sectionBtn_Click(object sender, EventArgs e)
        {
            Sections sec = new Sections();
            MainClass.showWindow(sec, this, MDI.ActiveForm);
        }

        private void subjectsBtn_Click(object sender, EventArgs e)
        {
            Subjects sb = new Subjects();
            MainClass.showWindow(sb,this,MDI.ActiveForm);
        }

        private void feevoucherBtn_Click(object sender, EventArgs e)
        {
            FeeVoucher fv = new FeeVoucher();
            MainClass.showWindow(fv, this, MDI.ActiveForm);
        }

        private void groupBtn_Click(object sender, EventArgs e)
        {
            Groups g = new Groups();
            MainClass.showWindow(g,this,MDI.ActiveForm);
        }

        private void timetableBtn_Click(object sender, EventArgs e)
        {
            TimeTable tt = new TimeTable();
            MainClass.showWindow(tt,this,MDI.ActiveForm);
        }

        private void notificationBtn_Click(object sender, EventArgs e)
        {
            Notifications n = new Notifications();
            MainClass.showWindow(n,this,MDI.ActiveForm);
        }

        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            MainClass.showWindow(at,this,MDI.ActiveForm);
        }

        private void classtimeBtn_Click(object sender, EventArgs e)
        {
            ClassTimings ct = new ClassTimings();
            MainClass.showWindow(ct,this,ActiveForm);
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            Students st = new Students();
            MainClass.showWindow(st,this,MDI.ActiveForm);
        }
    }
}
