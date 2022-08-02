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

        private void TeacherAttendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Hide();
        }

        private void AttendanceRegisterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO [TeacherAttendance] (TeacherId,Status,Date) VALUES ((SELECT Teacher.TeacherId from Teacher Where Name=@Name),@Status,@Date)", con))
            {
                try
                {
                    bool status = false;
                    if (statusComboBox.Text == "PRESENT")
                    {
                         status = true;
                    }
                    //string errorMessage = "Kindly Select all details";
                    //if (isValid(errorMessage))
                    //{
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Name", teacherNameComboBox.Text);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Date", attendanceDate.Value.ToString());
                        cmd.ExecuteNonQuery();
                        //clearInputs();
                        BindGrid();
                    //}
                }
                catch (Exception error)
                {
                    var err = error.Message;
                    MessageBox.Show($"Reason: {err}");
                }
            }
            con.Close();
        }

        private void AttendanceEditBtn_Click(object sender, EventArgs e)
        {
                int ID = Convert.ToInt32(attendanceData.SelectedRows[0].Cells[0].Value);
                //if (isValid(errorMessage))
                //{
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update TeacherAttendance set Status=@Status, Date=@Date  where Id=@Id", con);

                if (statusComboBox.Text == "PRESENT")
                {
                    cmd.Parameters.AddWithValue("@Status", true);
                } 
                else if(statusComboBox.Text == "ABSENT")
                {
                cmd.Parameters.AddWithValue("@Status", false);
                }
                cmd.Parameters.AddWithValue("@Date", attendanceDate.Value.ToString());
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                BindGrid();
                MessageBox.Show("Attendance detaiks updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clearInputs();
            //}
        }

        private void attendanceData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                teacherNameComboBox.Text = attendanceData.SelectedRows[0].Cells[1].Value.ToString();
                if (attendanceData.SelectedRows[0].Cells[2].Value is true)
                {
                    statusComboBox.Text = "PRESENT";
                }
                else if (attendanceData.SelectedRows[0].Cells[2].Value is false) 
                {
                    statusComboBox.Text = "ABSENT";
                }
                attendanceDate.Text = attendanceData.SelectedRows[0].Cells[3].Value.ToString();
                teacherNameComboBox.Enabled = false;
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }
        }
    }
}
