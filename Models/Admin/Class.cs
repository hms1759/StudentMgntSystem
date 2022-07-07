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
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
            BindGrid();
        }
        string constring = DBconnect.DbConnectstring;
     
        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Class", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            classData.DataSource = ds.Tables[0];
                            classData.Columns[0].Visible = false;
                        }
                    }
                }
            }
        }
        private bool isValid(string errorMessage)
        {
            if (ClassNameTxt.Text == string.Empty)
            {
                MessageBox.Show(errorMessage, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void classRegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = "Kindly enter all details";
                if (isValid(errorMessage))
                {
                    SqlConnection con = new SqlConnection(constring);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Class values (@ClassName)", con);
                    cmd.Parameters.AddWithValue("@ClassName", ClassNameTxt.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    BindGrid();

                }
            }
            catch(Exception error)
            {
                var err = error.Message;
                MessageBox.Show(err, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void classDeleteBtn_Click(object sender, EventArgs e)
        {
            string errorMessage = "Unable to delete";
            if (isValid(errorMessage))
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Class where ClassName=@KEYWORD", con);
                cmd.Parameters.AddWithValue("@KEYWORD", ClassNameTxt.Text);
                cmd.ExecuteNonQuery();
                BindGrid();
                con.Close();
                MessageBox.Show("Successfully Deleted");
            }
        }
        private void classEditBtn_Click(object sender, EventArgs e)
        {
            string errorMessage = "Please select a Class to update informations";
            int ID = Convert.ToInt32(classData.SelectedRows[0].Cells[0].Value);
            if (isValid(errorMessage) && ID != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Class set ClassName=@ClassName where ClassId=@ClassId", con);
                cmd.Parameters.AddWithValue("@ClassName", ClassNameTxt.Text);
                cmd.Parameters.AddWithValue("@ClassId", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                BindGrid();
                MessageBox.Show("Class Name is updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void classData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ClassNameTxt.Text = classData.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }

        }
        private void classSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = "Kindly enter all details";
                if (isValid(errorMessage))
                {
                    SqlConnection con = new SqlConnection(constring);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Class where ClassName=@ClassName", con);
                    cmd.Parameters.AddWithValue("ClassName", ClassNameTxt.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    classData.DataSource = dt;
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
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show(err, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
