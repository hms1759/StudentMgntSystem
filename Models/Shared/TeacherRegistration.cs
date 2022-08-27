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

namespace StudentMgntSystem.Models.Shared
{
    public partial class TeacherRegistration : Form
    {
        public TeacherRegistration()
        {
            InitializeComponent();
        }
        string constring = DBconnect.DbConnectstring;
        public void GenderList()
        {
            teacherGenderComboBox.Items.Add("MALE");
            teacherGenderComboBox.Items.Add("FEMALE");
            teacherGenderComboBox.Items.Add("OTHERS");
        }
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
        private void SignUpBtn_Click(object sender, EventArgs e)
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
                        this.Controls.Clear();
                        SuccessMessage successMessage = new SuccessMessage();
                        successMessage.TopLevel = false;
                        this.Controls.Add(successMessage);
                        successMessage.Show();
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

        private void TeacherRegistration_Load(object sender, EventArgs e)
        {
            DepartmentList();
            GenderList();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
