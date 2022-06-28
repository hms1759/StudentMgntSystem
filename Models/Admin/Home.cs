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
    }
}