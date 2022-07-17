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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            BindGrid();
        }
        string constring = DBconnect.DbConnectstring;
        private void departmentList()
        {
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ClassName from Class Where IsDeleted IS NULL", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        classComboBox.DisplayMember = "ClassName";
                        classComboBox.DataSource = dt;
                        classComboBox.SelectedItem = null;
                    }
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Subject.SubjectId , Class.ClassId, Class.ClassName , Subject.SubjectName from Subject JOIN Class ON Subject.ClassId=Class.ClassId WHERE Subject.IsDeleted IS NULL and Class.IsDeleted IS NULL", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            subjectData.DataSource = ds.Tables[0];
                            subjectData.Columns[0].Visible = false;
                            subjectData.Columns[1].Visible = false;
                        }
                    }
                    classComboBox.Enabled = true;
                }
            }
        }
        private void subjectRegisterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [Subject] (ClassId, SubjectName) VALUES ((SELECT ClassId FROM Class WHERE ClassName=@ClassName), @SubjectName)", con))
            {
                try
                {
                    string errorMessage = "Kindly enter all details";
                    if (isValid(errorMessage))
                    {
                        cmd.Parameters.AddWithValue("@SubjectName", SubjectNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@ClassName", classComboBox.Text);
                        cmd.ExecuteNonQuery();
                        BindGrid();
                        clearInputs();
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
        private void Subjects_Load(object sender, EventArgs e)
        {
            departmentList();
        }
        private void subjectDeleteBtn_Click(object sender, EventArgs e)
        {
            string errorMessage = "Kindly Select subject to delete";
            int ID = Convert.ToInt32(subjectData.SelectedRows[0].Cells[0].Value);
            if (isValid(errorMessage))
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Subject set IsDeleted=@IsDeleted where SubjectId=@SubjectId", con);
                cmd.Parameters.AddWithValue("@IsDeleted", true);
                cmd.Parameters.AddWithValue("@SubjectId", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                BindGrid();
                MessageBox.Show("Subject Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearInputs();
            }
        }
        private bool isValid(string errorMessage)
        {

            if (SubjectNameTextBox.Text == string.Empty || classComboBox.SelectedItem == null)
            {
                MessageBox.Show(errorMessage, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void subjectEditBtn_Click(object sender, EventArgs e)
        {
            string errorMessage = "Kindly fill all details";
            int ID = Convert.ToInt32(subjectData.SelectedRows[0].Cells[0].Value);
            if (isValid(errorMessage))
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Subject set SubjectName=@SubjectName where SubjectId=@SubjectId", con);
                cmd.Parameters.AddWithValue("@SubjectName", SubjectNameTextBox.Text);
                cmd.Parameters.AddWithValue("@SubjectId", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                BindGrid();
                MessageBox.Show("Subject Name is updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearInputs();
            }
        }

        private void subjectData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                classComboBox.Text = subjectData.SelectedRows[0].Cells[2].Value.ToString();
                SubjectNameTextBox.Text = subjectData.SelectedRows[0].Cells[3].Value.ToString();
                classComboBox.Enabled = false;
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }
        }
        private void subjectSearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Subject.SubjectId,Class.ClassId, Class.ClassName , Subject.SubjectName from Subject JOIN Class ON Subject.ClassId=Class.ClassId WHERE ClassName=@ClassName OR SubjectName=@SubjectName AND Class.IsDeleted IS NULL AND Subject.IsDeleted IS NULL", con);
                cmd.Parameters.AddWithValue("@SubjectName", SubjectNameTextBox.Text);
                cmd.Parameters.AddWithValue("@ClassName", classComboBox.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                subjectData.DataSource = dt;
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }
            clearInputs();
            con.Close();
        }
        private void subjectData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void clearInputs()
        {
            SubjectNameTextBox.Text = "";
            classComboBox.SelectedItem = null;
        }
    }
}
