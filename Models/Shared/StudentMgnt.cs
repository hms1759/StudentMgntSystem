using StudentMgntSystem.Models;
using StudentMgntSystem.Models.Admin;
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
    public partial class StudentMgnt : Form
    {
        public StudentMgnt()
        {
            LoadingPage loading = new LoadingPage();
            loading.ShowDialog();
            InitializeComponent();
        }

       
           
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
