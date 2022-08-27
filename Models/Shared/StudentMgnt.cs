using StudentMgntSystem.Models.Admin;
using StudentMgntSystem.Models.Students;
using StudentMgntSystem.Models.Teachers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
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
        //string loginName = LoginDetails.LoginName;
        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginDetails.LoginName = usernameTextBox.Text;
            if (usernameTextBox.Text == "ADMIN" && passwordTextBox.Text == "ADMIN")
            {
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
            }
            else if (IsTeacher())
            {
                this.Hide();
                Home1 home1 = new Home1();
                home1.ShowDialog();
            }

            else if (IsStudent())
            {
                this.Hide();
                Home2 home2 = new Home2();
                home2.ShowDialog();
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

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpHome signUpHome = new SignUpHome();
            signUpHome.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit ? ";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes )
            {
                Application.Exit();
            }
        }
    }
}
