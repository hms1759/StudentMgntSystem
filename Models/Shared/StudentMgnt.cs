using StudentMgntSystem.Models;
using StudentMgntSystem.Models.Admin;
using StudentMgntSystem.Models.Teachers;
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

namespace StudentMgntSystem.Models.Shared
{
    public partial class StudentMgnt : Form
    {
        public StudentMgnt()
        {
            InitializeComponent();
        }
        string constring = DBconnect.DbConnectstring;
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "ADMIN" && passwordTextBox.Text == "ADMIN")
            {
                this.Hide();
               // MessageBox.Show("Login successfully as Admin");
                Home home = new Home();
                home.ShowDialog();
            }
            else if (IsTeacher())
            {
                this.Hide();
                Home1 home = new Home1();
                home.ShowDialog();
            }

            else if (IsStudent())
            {

            }

        }
        private bool IsStudent()
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT * from Student where Email=@Email and Phone=@Phone and IsDeleted IS NULL", conn))
                {
                    cmr.CommandType = CommandType.Text;
                    cmr.Parameters.AddWithValue("@Email", usernameTextBox.Text);
                    cmr.Parameters.AddWithValue("@Phone", passwordTextBox.Text);
                    using (SqlDataReader reader = cmr.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        if (dt.Rows.Count != 0)
                        {
                            result = true;
                        }
                    }
                    cmr.ExecuteNonQuery();
                }
                conn.Close();
            }
            return result;
        }
        private bool IsTeacher()
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT * from Teacher where Email=@Email and Password=@Password and IsDeleted IS NULL", conn))
                {
                    cmr.CommandType = CommandType.Text;
                    cmr.Parameters.AddWithValue("@Email", usernameTextBox.Text);
                    cmr.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                    using (SqlDataReader reader = cmr.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        if (dt.Rows.Count != 0)
                        {
                            result = true;
                        }
                    }
                    cmr.ExecuteNonQuery();
                }
                conn.Close();
            }
            return result;
        }
    }
}
