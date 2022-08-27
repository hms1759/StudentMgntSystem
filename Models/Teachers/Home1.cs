using StudentMgntSystem.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMgntSystem.Models.Teachers
{
    public partial class Home1 : Form
    {
        public Home1()
        {
            InitializeComponent();
        }

        string constring = DBconnect.DbConnectstring;
        private void StudentAttendanceBtn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            StudentAttendanceRO studentAttendanceRO = new StudentAttendanceRO();
            studentAttendanceRO.TopLevel = false;
            panelContent.Controls.Add(studentAttendanceRO);
            studentAttendanceRO.Show();
        }

        private void ExamMarkBtn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ExamReadOnly exam = new ExamReadOnly();
            exam.TopLevel = false;
            panelContent.Controls.Add(exam);
            exam.Show();
        }

        private void StudentRegisterationBtn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            StudentAttendance studentAttendance = new StudentAttendance();
            studentAttendance.TopLevel = false;
            panelContent.Controls.Add(studentAttendance);
            studentAttendance.Show();
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Visible = false;
            //StudentMgnt sm = new StudentMgnt();
            //sm.Visible = true;
            this.Hide();
            StudentMgnt studentMgnt = new StudentMgnt();
            studentMgnt.ShowDialog();
        }

        private void Home1_Load(object sender, EventArgs e)
        {
            GetName();
        }
        public void GetName()
        {
            string name = string.Empty;
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT Name from Teacher where Email=@Email and IsDeleted IS NULL", conn))
                {
                    cmr.Parameters.AddWithValue("@Email", LoginDetails.LoginName);
                    using (SqlDataReader reader = cmr.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name = (string)reader["Name"];
                        }
                    }
                    cmr.ExecuteNonQuery();
                }
                conn.Close();
                introLabel.Text = $"{introLabel.Text} {name}";
            }
        }
    }
}
