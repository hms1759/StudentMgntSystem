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
    public partial class SuccessMessage : Form
    {
        public SuccessMessage()
        {
            InitializeComponent();
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            StudentMgnt studentMgnt = new StudentMgnt();
            studentMgnt.ShowDialog();
        }
    }
}
