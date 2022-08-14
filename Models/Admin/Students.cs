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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }
        string constring = DBconnect.DbConnectstring;
        private void DepartmentList()
        {
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT ClassName from Class where IsDeleted IS NULL", conn))
                {

                    using (SqlDataReader reader = cmr.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        studentClassComboBox.ValueMember = "ClassName";
                        studentClassComboBox.SelectedItem = "";
                        studentClassComboBox.DataSource = dt;
                        studentClassComboBox.SelectedItem = null;
                    }
                    cmr.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
        public void GenderList()
        {
            studentGenderComboBox.Items.Add("MALE");
            studentGenderComboBox.Items.Add("FEMALE");
            studentGenderComboBox.Items.Add("OTHERS");
        }
        private void Students_Load(object sender, EventArgs e)
        {
            DepartmentList();
            GenderList();
            BindGrid();
        }
        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Student.StudentId, Student.Name,Student.DOB,Student.Gender,Student.Phone,Student.Email,Student.SeatNumber,Student.Address,Student.NextOfKin,Student.NextOfKinPhone,Student.NextOfKinAddress,Class.ClassName,Student.ClassId from Student JOIN Class ON Student.ClassId=Class.ClassId where Student.IsDeleted IS NULL", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            studentData.DataSource = ds.Tables[0];
                            studentData.Columns[0].Visible = false;
                            studentData.Columns[9].Visible = false;
                        }
                    }
                }
            }
        }
        private void studentRegisterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [Student] (Name,DOB,Gender,Phone,Email,SeatNumber,Address,NextOfKin,NextOfKinPhone,NextOfKinAddress,ClassId) VALUES (@Name,@DOB,@Gender,@Phone,@Email,@SeatNumber,@Address,@NextOfKin,@NextOfKinPhone,@NextOfKinAddress,(SELECT ClassId FROM Class WHERE ClassName=@ClassName))", con))
            {
                try
                {
                        cmd.Parameters.AddWithValue("@Name", studentNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@DOB", studentDOB.Value.ToString());
                        cmd.Parameters.AddWithValue("@Gender",studentGenderComboBox.Text);
                        cmd.Parameters.AddWithValue("@Phone", studentPhoneTextBox.Text);
                        cmd.Parameters.AddWithValue("@Email", studentEmailTextBox.Text);
                        cmd.Parameters.AddWithValue("@SeatNumber", seatNumber.Text);
                        cmd.Parameters.AddWithValue("@Address", studentAddressTextBox.Text);
                        cmd.Parameters.AddWithValue("@NextOfKin", studentNextOfKinTextBox.Text);
                        cmd.Parameters.AddWithValue("@NextOfKinPhone", studentNextOfKinPhone.Text);
                        cmd.Parameters.AddWithValue("@NextOfKinAddress", studentNextOfKinAddress.Text);
                        cmd.Parameters.AddWithValue("@ClassName", studentClassComboBox.Text);
                        cmd.ExecuteNonQuery();
                        BindGrid();
                }
                catch (Exception error)
                {
                    var err = error.Message;
                    MessageBox.Show($"Reason: {err}");
                }
            }
            con.Close();
        }

        private void studentSearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Student.StudentId, Student.Name,Student.DOB,Student.Gender,Student.Phone,Student.Email,Student.SeatNumber,Student.Address,Student.NextOfKin,Student.NextOfKinPhone,Student.NextOfKinAddress,Class.ClassName,Student.ClassId from Student JOIN Class ON Student.ClassId=Class.ClassId Where Name=@Name and IsDeleted IS NULL", con);
                cmd.Parameters.AddWithValue("@Name", studentNameTextBox.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                studentData.DataSource = dt;
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }
            con.Close();
        }

        private void studentDeleteBtn_Click(object sender, EventArgs e)
        {
            //string errorMessage = "Select a subject to Delete";
            int Id = Convert.ToInt32(studentData.SelectedRows[0].Cells[0].Value);
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Update Student set IsDeleted=@IsDeleted where StudentId=@Id", con);
                cmd.Parameters.AddWithValue("@IsDeleted", true);
                cmd.Parameters.AddWithValue("@StudentId", Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                studentData.DataSource = dt;
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }
            con.Close();
        }

        private void studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                studentNameTextBox.Text = studentData.SelectedRows[0].Cells[1].Value.ToString();
                studentDOB.Text = studentData.SelectedRows[0].Cells[2].Value.ToString();
                studentGenderComboBox.SelectedItem = studentData.SelectedRows[0].Cells[3].Value.ToString();
                studentPhoneTextBox.Text = studentData.SelectedRows[0].Cells[4].Value.ToString();
                studentEmailTextBox.Text = studentData.SelectedRows[0].Cells[5].Value.ToString();
                seatNumber.Text = studentData.SelectedRows[0].Cells[6].Value.ToString();
                studentAddressTextBox.Text = studentData.SelectedRows[0].Cells[7].Value.ToString();
                studentNextOfKinTextBox.Text = studentData.SelectedRows[0].Cells[8].Value.ToString();
                studentNextOfKinPhone.Text = studentData.SelectedRows[0].Cells[9].Value.ToString();
                studentNextOfKinAddress.Text = studentData.SelectedRows[0].Cells[10].Value.ToString();
                studentClassComboBox.Text = studentData.SelectedRows[0].Cells[11].Value.ToString();
                studentClassComboBox.Enabled = false;
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }
        }

        private void studentEditBtn_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(studentData.SelectedRows[0].Cells[0].Value);
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Student set Name=@Name,DOB=@DOB,Phone=@Phone,Email=@Email,Address=@Address,SeatNumber=@SeatNumber, NextOfKin=@NextOfKin, NextOfKinPhone=@NextOfKinPhone, NextOfKinAddress=@NextOfKinAddress where studentId=@Id", con);
            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.Parameters.AddWithValue("@Name", studentNameTextBox.Text);
            cmd.Parameters.AddWithValue("@DOB", studentDOB.Value.ToString());
            cmd.Parameters.AddWithValue("@Gender", studentGenderComboBox.Text);
            cmd.Parameters.AddWithValue("@Phone", studentPhoneTextBox.Text);
            cmd.Parameters.AddWithValue("@Email", studentEmailTextBox.Text);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber.Text);
            cmd.Parameters.AddWithValue("@Address", studentAddressTextBox.Text);
            cmd.Parameters.AddWithValue("@NextOfKin", studentNextOfKinTextBox.Text);
            cmd.Parameters.AddWithValue("@NextOfKinPhone", studentNextOfKinPhone.Text);
            cmd.Parameters.AddWithValue("@NextOfKinAddress", studentNextOfKinAddress.Text);
            cmd.ExecuteNonQuery();
            BindGrid();
            MessageBox.Show("Student details is updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BindGrid();
        }
    }
}
