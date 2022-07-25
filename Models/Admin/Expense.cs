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
                using (SqlCommand cmd = new SqlCommand("SELECT Expense.ExpenseId, Class.ClassName , Subject.SubjectName , Expense.Charges FROM Expense INNER JOIN Class on Expense.ClassId=Class.ClassId JOIN Subject on Expense.SubjectId=Subject.SubjectId Where Expense.IsDeleted IS NULL and Class.IsDeleted IS NULL and Subject.IsDeleted IS NULL", con))
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

            using (SqlCommand cmd = new SqlCommand("INSERT INTO [Expense] (ClassId,SubjectId,Charges) VALUES ((SELECT Class.ClassId FROM Class WHERE ClassName=@ClassName),(SELECT Subject.SubjectId FROM Subject WHERE SubjectName=@SubjectName),@Charges)", con))
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
    }
}
