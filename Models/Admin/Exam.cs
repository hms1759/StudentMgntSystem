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
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
        }
        string constring  = DBconnect.DbConnectstring;
        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Exam.ExamId, Class.ClassName,Subject.SubjectName, Exam.SeatNumber , Exam.CAT , Exam.Exam , Exam.TotalMark , Exam.Percentage  from Exam JOIN Class ON Exam.ClassId=Class.ClassId JOIN Subject on Exam.SubjectId=Subject.SubjectId where Exam.IsDeleted IS NULL and Class.IsDeleted IS NULL and Subject.IsDeleted IS NULL", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            examData.DataSource = ds.Tables[0];
                            examData.Columns[0].Visible = false;
                        }
                    }
                    classNameComboBox.Enabled = true;
                    subjectNameComboBox.Enabled = true;
                    seatNumberComboBox.Enabled = true;
                }
            }
        }
        private void Exam_Load(object sender, EventArgs e)
        {
            BindGrid();
            DepartmentList();
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
        public void DepartmentList()
        {

            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT ClassName from Class Where IsDeleted IS NULL", conn))
                {

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
        private void examRegisterBtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(constring);
            con.Open();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO [Exam] (ClassId,SubjectId,SeatNumber,CAT,Exam,TotalMark,Percentage) VALUES ((SELECT Class.ClassId FROM Class WHERE ClassName=@ClassName and Class.IsDeleted IS NULL),(SELECT Subject.SubjectId FROM Subject WHERE SubjectName=@SubjectName and Subject.IsDeleted IS NULL),@SeatNumber,@CAT,@Exam,@TotalMark,@Percentage)", con))
            {
                try
                {
                    // string errorMessage = "Kindly Select all details";
                    //if (isValid(errorMessage))
                    // {
                    double total = 100;
                    double totalmark = Convert.ToDouble(testScoreTextBox.Text) + Convert.ToDouble(examScoreTextBox.Text);
                    double percentage = (totalmark/total) * 100;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@SubjectName", subjectNameComboBox.Text);
                    cmd.Parameters.AddWithValue("@ClassName", classNameComboBox.Text);
                    cmd.Parameters.AddWithValue("@Exam", examScoreTextBox.Text);
                    cmd.Parameters.AddWithValue("@CAT", testScoreTextBox.Text);
                    cmd.Parameters.AddWithValue("@SeatNumber", seatNumberComboBox.Text);
                    cmd.Parameters.AddWithValue("@TotalMark", totalmark);
                    cmd.Parameters.AddWithValue("@Percentage", percentage);
                    cmd.ExecuteNonQuery();
                    //clearInputs();
                    BindGrid();
                    // }
                }
                catch (Exception error)
                {
                    var err = error.Message;
                    MessageBox.Show($"Reason: {err}");
                }
            }
            con.Close();
        }

        private void examData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                classNameComboBox.Text = examData.SelectedRows[0].Cells[1].Value.ToString();
                subjectNameComboBox.Text = examData.SelectedRows[0].Cells[2].Value.ToString();
                seatNumberComboBox.Text = examData.SelectedRows[0].Cells[3].Value.ToString();
                testScoreTextBox.Text = examData.SelectedRows[0].Cells[4].Value.ToString();
                examScoreTextBox.Text = examData.SelectedRows[0].Cells[5].Value.ToString();
                classNameComboBox.Enabled = false;
                subjectNameComboBox.Enabled = false;
                seatNumberComboBox.Enabled = false;
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }
        }

        private void examEditBtn_Click(object sender, EventArgs e)
        {
            //string errorMessage = "Kindly fill all details";
            int ID = Convert.ToInt32(examData.SelectedRows[0].Cells[0].Value);
            double total = 100;
            double totalmark = Convert.ToDouble(testScoreTextBox.Text) + Convert.ToDouble(examScoreTextBox.Text);
            double percentage = (totalmark / total) * 100;
            //if (isValid(errorMessage))
            //{
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Exam set CAT=@TestScore,Exam=@Exam,TotalMark=@TotalMark,Percentage=@Percentage where ExamId=@ExamId", con);
            cmd.Parameters.AddWithValue("@TestScore", testScoreTextBox.Text);
            cmd.Parameters.AddWithValue("@Exam", examScoreTextBox.Text);
            cmd.Parameters.AddWithValue("@TotalMark", totalmark);
            cmd.Parameters.AddWithValue("@Percentage", percentage);
            cmd.Parameters.AddWithValue("@ExamId", ID);
            cmd.ExecuteNonQuery();
            con.Close();
            BindGrid();
            MessageBox.Show("updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //clearInputs();
            //}
        }

        private void examSearchBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Exam.ExamId, Class.ClassName,Subject.SubjectName, Exam.SeatNumber , Exam.CAT , Exam.Exam , Exam.TotalMark , Exam.Percentage  from Exam JOIN Class ON Exam.ClassId=Class.ClassId JOIN Subject on Exam.SubjectId=Subject.SubjectId where Class.ClassName=@ClassName and Exam.IsDeleted IS NULL and Class.IsDeleted IS NULL and Subject.IsDeleted IS NULL", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ClassName", classNameComboBox.Text);
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            examData.DataSource = ds.Tables[0];
                            examData.Columns[0].Visible = false;
                        }
                    }
                    //MessageBox.Show("Search successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classNameComboBox.Enabled = true;
                    subjectNameComboBox.Enabled = true;
                    seatNumberComboBox.Enabled = true;
                }
            }
        }

        private void examDeleteBtn_Click(object sender, EventArgs e)
        {
            //string errorMessage = "Kindly Select subject to delete";
            int ID = Convert.ToInt32(examData.SelectedRows[0].Cells[0].Value);
            //if (isValid(errorMessage))
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Exam set IsDeleted=@IsDeleted where ExamId=@ExamId", con);
                cmd.Parameters.AddWithValue("@IsDeleted", true);
                cmd.Parameters.AddWithValue("@ExamId", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                BindGrid();
                MessageBox.Show("Exam details Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clearInputs();
            }
        }
        private void classNameComboBox_TextChanged(object sender, EventArgs e)
        {
            SeatNumbers();
            SubjectList();
        }
    }
}
