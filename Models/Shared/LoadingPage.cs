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
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        { 
            InitializeComponent();
        }
        int startpos = 0;
        private void progressTimer_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            progressBar1.Value = startpos;
            if(progressBar1.Value == 100)
            {
                progressTimer.Stop();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressTimer.Start();
        }
    }
}
