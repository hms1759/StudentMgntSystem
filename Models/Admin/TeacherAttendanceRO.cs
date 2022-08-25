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
    public partial class TeacherAttendanceRO : Form
    {
        public TeacherAttendanceRO()
        {
            InitializeComponent();
        }
        string constring = DBconnect.DbConnectstring;
        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TeacherAttendance.Id, Teacher.Name, TeacherAttendance.Status , TeacherAttendance.Date FROM TeacherAttendance INNER JOIN Teacher on TeacherAttendance.TeacherId=Teacher.TeacherId  Where TeacherAttendance.IsDeleted IS NULL and Teacher.IsDeleted IS NULL", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            attendanceData.DataSource = ds.Tables[0];
                            attendanceData.Columns[0].Visible = false;
                        }
                    }
                }
            }
        }

        private void TeacherAttendanceRO_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
