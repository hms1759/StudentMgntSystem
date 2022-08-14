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
    public partial class StudentAttendance : Form
    {
        public StudentAttendance()
        {
            InitializeComponent();
        }
        string constring = DBconnect.DbConnectstring;
        private void StudentStatus()
        {
            statusComboBox.Items.Add("PRESENT");
            statusComboBox.Items.Add("ABSENT");
        }
        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            BindGrid();
            StudentStatus();
            StudentNameList();
            DepartmentList();   
        }

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

        public void DepartmentList()
        {

            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT Class.ClassName from Student JOIN Class ON Student.ClassId=Class.ClassId Where Name=@Name and Student.IsDeleted IS NULL", conn))
                {
                    cmr.Parameters.AddWithValue("@Name", studentNameComboBox.Text);
                    using (SqlDataReader reader = cmr.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        classNameComboBox.ValueMember = "ClassName";
                        classNameComboBox.SelectedItem = "";
                        classNameComboBox.DataSource = dt;
                        classNameComboBox.SelectedItem = null;
                    }
                    cmr.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
        private void SeatNumbers()
        {
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT SeatNumber from Student JOIN Class ON Class.ClassId=Student.ClassId Where student.IsDeleted IS NULL and Class.ClassName=@ClassName", conn))
                {
                    cmr.Parameters.AddWithValue("@ClassName", classNameComboBox.Text);
                    using (SqlDataReader reader = cmr.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        seatNumberComboBox.ValueMember = "SeatNUmber";
                        seatNumberComboBox.SelectedItem = "";
                        seatNumberComboBox.DataSource = dt;
                        seatNumberComboBox.SelectedItem = null;
                    }
                    cmr.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void SubjectList()
        {
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT SubjectName from Subject JOIN Class ON Class.ClassId=Subject.ClassId Where Subject.IsDeleted IS NULL and Class.ClassName=@ClassName", conn))
                {
                    cmr.Parameters.AddWithValue("@ClassName", classNameComboBox.Text);
                    using (SqlDataReader reader = cmr.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        subjectNameComboBox.ValueMember = "SubjectName";
                        subjectNameComboBox.SelectedItem = "";
                        subjectNameComboBox.DataSource = dt;
                        subjectNameComboBox.SelectedItem = null;
                    }
                    cmr.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        private void StudentNameList()
        {
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT Name from Student Where IsDeleted IS NULL", conn))
                {

                    using (SqlDataReader reader = cmr.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        studentNameComboBox.ValueMember = "Name";
                        studentNameComboBox.SelectedItem = "";
                        studentNameComboBox.DataSource = dt;
                        studentNameComboBox.SelectedItem = null;
                    }
                    cmr.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void AttendanceRegisterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO [StudentAttendance] (ClassId,SubjectId,SeatNumber,Status,Date) VALUES ((SELECT Class.ClassId from Class Where ClassName=@ClassName),(SELECT Subject.SubjectId from Subject where SubjectName=@SubjectName),@SeatNumber,@Status,@Date)", con))
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
                    cmd.Parameters.AddWithValue("@ClassName", classNameComboBox.Text);
                    cmd.Parameters.AddWithValue("@SubjectName", subjectNameComboBox.Text);
                    cmd.Parameters.AddWithValue("@SeatNumber", seatNumberComboBox.Text);
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

        private void classNameComboBox_TextChanged(object sender, EventArgs e)
        {
            SeatNumbers();
            SubjectList();
        }

        private void studentNameComboBox_TextChanged(object sender, EventArgs e)
        {
            DepartmentList();
        }

        private void AttendanceDeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
