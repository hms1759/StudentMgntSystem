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
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
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
        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            DepartmentList();
            GenderList();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [Student] (Name,DOB,Gender,Phone,Email,SeatNumber,Address,NextOfKin,NextOfKinPhone,NextOfKinAddress,ClassId) VALUES (@Name,@DOB,@Gender,@Phone,@Email,@SeatNumber,@Address,@NextOfKin,@NextOfKinPhone,@NextOfKinAddress,(SELECT ClassId FROM Class WHERE ClassName=@ClassName))", con))
            {
                try
                {
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
                    cmd.Parameters.AddWithValue("@ClassName", studentClassComboBox.Text);
                    cmd.ExecuteNonQuery();
                    this.Controls.Clear();
                    SuccessMessage successMessage = new SuccessMessage();
                    successMessage.TopLevel = false;
                    this.Controls.Add(successMessage);
                    successMessage.Show();

                }
                catch (Exception error)
                {
                    var err = error.Message;
                    MessageBox.Show($"Reason: {err}");
                }
            }
            con.Close();
        }
    }
}
