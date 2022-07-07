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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
            BindGrid();
        }

        string constring = DBconnect.DbConnectstring;

        public void genderList()
        {
            teacherGenderComboBox.Items.Add("MALE");
            teacherGenderComboBox.Items.Add("FEMALE");
            teacherGenderComboBox.Items.Add("OTHERS");
        }
        private void departmentList()
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
                        teacherClassComboBox.ValueMember = "ClassName";
                        teacherClassComboBox.SelectedItem = "";
                        teacherClassComboBox.DataSource = dt;
                        teacherClassComboBox.SelectedItem = null;
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
                using (SqlCommand cmd = new SqlCommand("SELECT Teacher.TeacherId, Teacher.Name,Teacher.Email,Teacher.Phone,Teacher.DOB,Teacher.Gender,Teacher.Address,Class.ClassName,Teacher.Password,Teacher.ClassId from Teacher JOIN Class ON Teacher.ClassId=Class.ClassId", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            teacherData.DataSource = ds.Tables[0];
                            teacherData.Columns[0].Visible = false;
                            teacherData.Columns[9].Visible = false;
                        }
                    }
                    teacherClassComboBox.Enabled = true;
                    teacherGenderComboBox.Enabled = true;
                }
            }
        }
        private void teacherRegisterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [Teacher] (Name,DOB,Gender,Phone,Email,Address,Password,ClassId) VALUES (@Name,@DOB,@Gender,@Phone,@Email,@Address,@Password,(SELECT ClassId FROM Class WHERE ClassName=@ClassName))", con))
            {
                try
                {
                    string errorMessage = "Kindly enter all details";
                    if (isValid(errorMessage))
                    {
                        cmd.Parameters.AddWithValue("@Name", teacherNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@DOB", teacherDOB.Value.ToString());
                        cmd.Parameters.AddWithValue("@Gender", teacherGenderComboBox.Text);
                        cmd.Parameters.AddWithValue("@Phone", teacherPhoneTextBox.Text);
                        cmd.Parameters.AddWithValue("@Email", teacherEmailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Address", teacherAddressTextBox.Text);
                        cmd.Parameters.AddWithValue("@PassWord", teacherPasswordTextBox.Text);
                        cmd.Parameters.AddWithValue("@ClassName", teacherClassComboBox.Text);
                        cmd.ExecuteNonQuery();
                        ClearInputs();
                        BindGrid();
                    }
                }
                catch (Exception error)
                {
                    var err = error.Message;
                    MessageBox.Show($"Reason: {err}");
                }
            }
            con.Close();
        }

        private bool isValid(string errorMessage)
        {
            if (
                teacherNameTextBox.Text == string.Empty ||
                teacherClassComboBox.SelectedItem == null ||
                teacherPhoneTextBox.Text == string.Empty ||
                teacherAddressTextBox.Text == string.Empty ||
                teacherDOB.Value.ToString() == string.Empty ||
                teacherGenderComboBox.SelectedItem == null ||
                teacherEmailTextBox.Text == string.Empty ||
                teacherPasswordTextBox.Text == string.Empty 
                )
            {
                MessageBox.Show(errorMessage, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            departmentList();
            genderList();
        }

        private void ClearInputs()
        {
            teacherNameTextBox.Text = string.Empty;
            teacherAddressTextBox.Text = String.Empty;
            teacherPhoneTextBox.Text = String.Empty;
            teacherClassComboBox.SelectedItem = null;
            teacherGenderComboBox.SelectedItem = null;
            teacherEmailTextBox.Text = String.Empty;
            teacherPasswordTextBox.Text = string.Empty; 
        }

        private void teacherData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                teacherNameTextBox.Text = teacherData.SelectedRows[0].Cells[1].Value.ToString();
                teacherEmailTextBox.Text = teacherData.SelectedRows[0].Cells[2].Value.ToString();
                teacherPhoneTextBox.Text = teacherData.SelectedRows[0].Cells[3].Value.ToString();
                teacherDOB.Text = teacherData.SelectedRows[0].Cells[4].Value.ToString();
                teacherGenderComboBox.Text = teacherData.SelectedRows[0].Cells[5].Value.ToString();
                teacherAddressTextBox.Text = teacherData.SelectedRows[0].Cells[6].Value.ToString();
                teacherClassComboBox.Text = teacherData.SelectedRows[0].Cells[7].Value.ToString();
                teacherPasswordTextBox.Text = teacherData.SelectedRows[0].Cells[8].Value.ToString();
                teacherClassComboBox.Enabled = false;
                teacherGenderComboBox.Enabled = false;
                if (teacherNameTextBox.Text == string.Empty)
                {
                    MessageBox.Show("No Data available");
                }
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }
        }

        private void subjectEditBtn_Click(object sender, EventArgs e)
        {
            string errorMessage = "Select a the teacher to Edit";
            int ID = Convert.ToInt32(teacherData.SelectedRows[0].Cells[0].Value);
            if (isValid(errorMessage))
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Teacher set Name=@Name,DOB=@DOB,Phone=@Phone,Email=@Email,Address=@Address,Password=@Password where TeacherID=@Id", con);
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.Parameters.AddWithValue("@Name", teacherNameTextBox.Text);
                cmd.Parameters.AddWithValue("@DOB", teacherDOB.Value.ToString());
                cmd.Parameters.AddWithValue("@Phone", teacherPhoneTextBox.Text);
                cmd.Parameters.AddWithValue("@Email", teacherEmailTextBox.Text);
                cmd.Parameters.AddWithValue("@Address", teacherAddressTextBox.Text);
                cmd.Parameters.AddWithValue("@PassWord", teacherPasswordTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Subject Name is updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                BindGrid();
            }
        }
    }
}
