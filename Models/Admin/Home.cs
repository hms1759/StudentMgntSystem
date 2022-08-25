using StudentMgntSystem.Models.Teachers;
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

        private void ExpenseBtn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Expense expense = new Expense();
            expense.TopLevel = false;
            panelContent.Controls.Add(expense);
            expense.Show();
        }

        private void examBtn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Exam exam = new Exam();
            exam.TopLevel = false;
            panelContent.Controls.Add(exam);
            exam.Show();
        }

        private void AttendanceBtn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            StudentAttendance studentAttendance = new StudentAttendance();
            studentAttendance.TopLevel = false;
            panelContent.Controls.Add(studentAttendance);
            studentAttendance.Show();
        }
    }
}