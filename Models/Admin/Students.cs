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
                using (SqlCommand cmr = new SqlCommand("SELECT ClassName from Class", conn))
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
            SeatNumbers();
            BindGrid();
        }
        private void SeatNumbers()
        {
            for (int i = 1; i < 21; i++)
            {
                studentSeatNumberComboBox.Items.Add($"ST {i}");
            }
        }
        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Student.StudentId, Student.Name,Student.DOB,Student.Gender,Student.Phone,Student.Email,Student.SeatNumber,Student.Address,Student.NextOfKin,Student.NextOfKinPhone,Student.NextOfKinAddress,Class.ClassName,Student.ClassId from Student JOIN Class ON Student.ClassId=Class.ClassId", con))
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
                        cmd.Parameters.AddWithValue("@SeatNumber", studentSeatNumberComboBox.Text);
                        cmd.Parameters.AddWithValue("@Address", studentAddressTextBox.Text);
                        cmd.Parameters.AddWithValue("@NextOfKin", studentNextOfKin.Text);
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
                SqlCommand cmd = new SqlCommand("SELECT Student.StudentId, Student.Name,Student.DOB,Student.Gender,Student.Phone,Student.Email,Student.SeatNumber,Student.Address,Student.NextOfKin,Student.NextOfKinPhone,Student.NextOfKinAddress,Class.ClassName,Student.ClassId from Student JOIN Class ON Student.ClassId=Class.ClassId Where Name=@Name", con);
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
    }
}
