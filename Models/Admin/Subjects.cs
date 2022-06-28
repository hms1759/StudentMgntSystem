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

namespace StudentMgntSystem.Models.Admin
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            BindGrid();
        }
        string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SchoolMgnDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Subject", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);

                            subjectData.DataSource = ds.Tables[0];
                            subjectData.Columns[0].Visible = false;

                        }
                    }
                }
            }
        }
        private void subjectRegisterBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
