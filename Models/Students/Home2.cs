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

namespace StudentMgntSystem.Models.Students
{
    public partial class Home2 : Form
    {
        public Home2()
        {
            InitializeComponent();
        }
        string constring = DBconnect.DbConnectstring;
        private void Home2_Load(object sender, EventArgs e)
        {
            GetName();
        }
        public void GetName()
        {
            string name = string.Empty;
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT Name from Student where Email=@Email and IsDeleted IS NULL", conn))
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
                nameLabel.Text = name;
            }
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            StudentMgnt studentMgnt = new StudentMgnt();
            studentMgnt.ShowDialog();
        }
    }
}
