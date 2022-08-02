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
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }
        string constring = DBconnect.DbConnectstring;
        private void Expense_Load(object sender, EventArgs e)
        {
            BindGrid();
            DepartmentList();
            SubjectList();
        }

        private void SubjectList()
        {
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT SubjectName from Subject Where IsDeleted IS NULL", conn))
                {

                    using (SqlDataReader reader = cmr.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        SubjectNameComboBox.ValueMember = "SubjectName";
                        SubjectNameComboBox.DataSource = dt;
                        SubjectNameComboBox.SelectedItem = null;
                    }
                    cmr.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void DepartmentList()
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
                        classNameComboBox.DisplayMember = "ClassName";
                        classNameComboBox.DataSource = dt;
                        classNameComboBox.SelectedItem = null;
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
                using (SqlCommand cmd = new SqlCommand("SELECT Expense.ExpenseId, Class.ClassName , Subject.SubjectName , Expense.Charges , Expense.ClassLevel FROM Expense INNER JOIN Class on Expense.ClassId=Class.ClassId JOIN Subject on Expense.SubjectId=Subject.SubjectId Where Expense.IsDeleted IS NULL and Class.IsDeleted IS NULL and Subject.IsDeleted IS NULL", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            feesData.DataSource = ds.Tables[0];
                            feesData.Columns[0].Visible = false;
                        }
                    }
                }
            }
        }

        private void FeeRegisterBtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(constring);
            con.Open();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO [Expense] (ClassId,SubjectId,Charges,ClassLevel) VALUES ((SELECT Class.ClassId FROM Class WHERE ClassName=@ClassName and Class.IsDeleted IS NULL),(SELECT Subject.SubjectId FROM Subject WHERE SubjectName=@SubjectName and Subject.IsDeleted IS NULL),@Charges,@ClassLevel)", con))
            {
                try
                {
                   // string errorMessage = "Kindly Select all details";
                    //if (isValid(errorMessage))
                   // {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Charges", chargesTextBox.Text);
                        cmd.Parameters.AddWithValue("@SubjectName", SubjectNameComboBox.Text);
                        cmd.Parameters.AddWithValue("@ClassName", classNameComboBox.Text);
                        cmd.Parameters.AddWithValue("@ClassLevel", classLevelTextBox.Text);
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

        private void feesData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                classNameComboBox.Text = feesData.SelectedRows[0].Cells[1].Value.ToString();
                SubjectNameComboBox.Text = feesData.SelectedRows[0].Cells[2].Value.ToString();
                chargesTextBox.Text = feesData.SelectedRows[0].Cells[3].Value.ToString();
                classLevelTextBox.Text = feesData.SelectedRows[0].Cells[4].Value.ToString();
                classNameComboBox.Enabled = false;
                SubjectNameComboBox.Enabled = false;
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }
        }

        private void feeSearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Expense.ExpenseId, Class.ClassName, Subject.SubjectName, Expense.Charges , Expense.ClassLevel FROM Expense INNER JOIN Class on Expense.ClassId = Class.ClassId JOIN Subject on Expense.SubjectId = Subject.SubjectId Where Expense.IsDeleted IS NULL and Class.IsDeleted IS NULL and Subject.IsDeleted IS NULL and ClassName=@ClassName OR SubjectName=@SubjectName", con);
                cmd.Parameters.AddWithValue("@SubjectName", SubjectNameComboBox.Text);
                cmd.Parameters.AddWithValue("@ClassName", classNameComboBox.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                feesData.DataSource = dt;
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }
            //clearInputs();
            con.Close();
        }

        private void feeDeleteBtn_Click(object sender, EventArgs e)
        {
            //string errorMessage = "Kindly Select subject to delete";
            int ID = Convert.ToInt32(feesData.SelectedRows[0].Cells[0].Value);
            //if (isValid(errorMessage))
            //{
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Expense set IsDeleted=@IsDeleted where ExpenseId=@ExpenseId", con);
                cmd.Parameters.AddWithValue("@IsDeleted", true);
                cmd.Parameters.AddWithValue("@ExpenseId", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                BindGrid();
                MessageBox.Show("Charges Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clearInputs();
            //}
        }

        private void FeeEditBtn_Click(object sender, EventArgs e)
        {
            //string errorMessage = "Kindly fill all details";
            int ID = Convert.ToInt32(feesData.SelectedRows[0].Cells[0].Value);
            //if (isValid(errorMessage))
            //{
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Expense set Charges=@Charges, ClassLevel=@ClassLevel where ExpenseId=@ExpenseId", con);
            cmd.Parameters.AddWithValue("@Charges", chargesTextBox.Text);
            cmd.Parameters.AddWithValue("@ClassLevel", classLevelTextBox.Text);
            cmd.Parameters.AddWithValue("@ExpenseId", ID);
            cmd.ExecuteNonQuery();
            con.Close();
            BindGrid();
            MessageBox.Show("Expense Edited successfully", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //clearInputs();
            //}
        }
    }
}
