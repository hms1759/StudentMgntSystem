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
                using (SqlCommand cmd = new SqlCommand("SELECT ClassName from Class", conn))
                {
                   
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        classComboBox.ValueMember = "ClassName";
                        classComboBox.SelectedItem = "";
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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Subject", con))
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

                }

            }
        }
        private void subjectRegisterBtn_Click(object sender, EventArgs e)
        {
            int id = 0;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT ClassId FROM Class where ClassName=@ClassName", con))
            {
                string errorMessage = "Kindly enter all Details";
                try
                {
                    if (isValid(errorMessage))
                    {
                        cmd.Parameters.AddWithValue("@ClassName", classComboBox.SelectedValue);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                id = Convert.ToInt32(reader[0]);
                            }
                            reader.Close();
                            reader.Dispose();
                        }
                        if (id != 0)
                        {
                            SqlCommand command = new SqlCommand("insert into Subject values (@ClassId,@SubjectName)", con);
                            command.Parameters.AddWithValue("@SubjectName", SubjectNameTextBox.Text);
                            command.Parameters.AddWithValue("@ClassId", id);
                            command.ExecuteNonQuery();
                            BindGrid();
                            SubjectNameTextBox.Text = "";

                        }
                       
                    }
                }
                catch (Exception error)
                {
                    var err = error.Message;
                    MessageBox.Show($"No Data available\n Reason: {err}");
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
            string errorMessage = "Unable to delete";
            if (isValid(errorMessage))
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();


                SqlCommand cmd = new SqlCommand("Delete from Subject where SubjectName=@KEYWORD", con);


                cmd.Parameters.AddWithValue("@KEYWORD", SubjectNameTextBox.Text);
                cmd.ExecuteNonQuery();
                BindGrid();
                con.Close();
                MessageBox.Show("Successfully Deleted");
                SubjectNameTextBox.Text = "";
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
                SubjectNameTextBox.Text = "";
            }
            //else
            //{
            //    MessageBox.Show("Please select a Class to update informations", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void subjectData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string className = "";
                int classId = Convert.ToInt32(subjectData.SelectedRows[0].Cells[1].Value);
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select ClassName from Class where ClassId=@ClassId", con);
                cmd.Parameters.AddWithValue("ClassId", classId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        className = reader[0].ToString();
                    }
                    if (className != string.Empty)
                    {
                        SubjectNameTextBox.Text = subjectData.SelectedRows[0].Cells[2].Value.ToString();
                        classComboBox.Text = className;
                        classComboBox.Enabled = false;
                    }
                }
              

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
            SqlCommand cmd = new SqlCommand("Select * from Subject where SubjectName=@SubjectName", con);
            cmd.Parameters.AddWithValue("SubjectName", SubjectNameTextBox.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            subjectData.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("No result");

            }
            else if (dt.Rows.Count != 0)
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Search Successful");

            }
        }

        private void subjectData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
