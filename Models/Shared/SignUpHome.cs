using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMgntSystem.Models.Shared
{
    public partial class SignUpHome : Form
    {
        public SignUpHome()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMgnt studentMgnt = new StudentMgnt();
            studentMgnt.ShowDialog();
        }

        private void TeacherLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelContent.Controls.Clear();
            TeacherRegistration teacherRegistration = new TeacherRegistration();
            teacherRegistration.TopLevel = false;
            panelContent.Controls.Add(teacherRegistration);
            teacherRegistration.Show();
        }

        private void StudentLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelContent.Controls.Clear();
            StudentRegistration studentRegistration = new StudentRegistration();
            studentRegistration.TopLevel = false;
            panelContent.Controls.Add(studentRegistration);
            studentRegistration.Show();
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            StudentMgnt studentMgnt = new StudentMgnt();
            studentMgnt.ShowDialog();
        }
    }
}
