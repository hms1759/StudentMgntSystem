using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMgntSystem.Models.Admin
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void classRegisterBtn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Class cl = new Class();
            cl.TopLevel = false;
            panelContent.Controls.Add(cl);
            cl.Show();
        }
        private void subjectsRegisterBtn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Subjects subjects = new Subjects();
            subjects.TopLevel = false;
            panelContent.Controls.Add(subjects);
            subjects.Show();
        }
        private void teacherBtn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Teacher teacher = new Teacher();
            teacher.TopLevel = false;
            panelContent.Controls.Add(teacher);
            teacher.Show();
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Students student = new Students();
            student.TopLevel = false;
            panelContent.Controls.Add(student);
            student.Show();
        }

        private void feesBtn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            FeesForm fees = new FeesForm();
            fees.TopLevel = false;
            panelContent.Controls.Add(fees);
            fees.Show();
        }
    }
}