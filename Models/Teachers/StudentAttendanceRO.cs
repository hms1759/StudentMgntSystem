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
    public partial class StudentAttendanceRO : Form
    {
        public StudentAttendanceRO()
        {
            InitializeComponent();
        }

        private void StudentAttendanceRO_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        string constring = DBconnect.DbConnectstring;
        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT StudentAttendance.Id ,Class.ClassName , Subject.SubjectName, StudentAttendance.SeatNumber ,StudentAttendance.Status , StudentAttendance.Date FROM StudentAttendance INNER JOIN Class on StudentAttendance.ClassId=Class.ClassId JOIN Subject on StudentAttendance.SubjectId=Subject.SubjectId  Where StudentAttendance.IsDeleted IS NULL", con))
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

    }
}
