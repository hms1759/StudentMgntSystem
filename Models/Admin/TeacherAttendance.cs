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
    public partial class TeacherAttendance : Form
    {
        public TeacherAttendance()
        {
            InitializeComponent();
        }

        string constring = DBconnect.DbConnectstring;
        private void TeacherAttendance_Load(object sender, EventArgs e)
        {
            BindGrid();
            TeacherNameList();
            TeacherStatus();
        }

        private void TeacherStatus()
        {
            statusComboBox.Items.Add("PRESENT");
            statusComboBox.Items.Add("ABSENT");
        }

        private void TeacherNameList()
        {
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT Name from Teacher Where IsDeleted IS NULL", conn))
                {

                    using (SqlDataReader reader = cmr.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        teacherNameComboBox.ValueMember = "Name";
                        teacherNameComboBox.SelectedItem = "";
                        teacherNameComboBox.DataSource = dt;
                        teacherNameComboBox.SelectedItem = null;
                    }
                    cmr.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void BindGrid()
        {
            //throw new NotImplementedException();
        }

        private void TeacherAttendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Hide();
        }
    }
}
