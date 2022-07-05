﻿using System;
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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Teacher", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            teacherData.DataSource = ds.Tables[0];
                            teacherData.Columns[0].Visible = false;
                            teacherData.Columns[8].Visible = false;
                        }
                    }

                }

            }

            ClearInputs();
        }
        private void teacherRegisterBtn_Click(object sender, EventArgs e)
        {
            int id = 0;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            using (SqlCommand command = new SqlCommand("SELECT ClassId FROM Class where ClassName=@ClassName", con))
            {
                command.Parameters.AddWithValue("@ClassName", teacherClassComboBox.SelectedValue);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = Convert.ToInt32(reader[0]);
                    }
                    reader.Close();
                    reader.Dispose();

                    if (id != 0)
                    {
                        SqlCommand cmd = new SqlCommand("insert into Teacher values (@TeacherName, @TeacherDOB , @TeacherGender , @TeacherPhone ,  @TeacherEmail , @TeacherAddress , @TeacherPassword , @TeacherClassId )", con);
                        cmd.Parameters.AddWithValue("@TeacherName", teacherNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@TeacherPhone", teacherPhoneTextBox.Text);
                        cmd.Parameters.AddWithValue("@TeacherAddress", teacherAddressTextBox.Text);
                        cmd.Parameters.AddWithValue("@TeacherClassId", id);
                        cmd.Parameters.AddWithValue("@TeacherDOB", teacherDOB.Value.ToString());
                        cmd.Parameters.AddWithValue("@TeacherGender", teacherGenderComboBox.Text);
                        cmd.Parameters.AddWithValue("@TeacherEmail", teacherEmailTextBox.Text);
                        cmd.Parameters.AddWithValue("@TeacherPassWord", teacherPasswordTextBox.Text);
                        cmd.ExecuteNonQuery();
                        BindGrid();
                    }
                }
            };
            con.Close();
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
            teacherEmailTextBox.Text = String.Empty;
            teacherPasswordTextBox.Text = string.Empty; 
        }

        private void teacherData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string className = "";
                int classId = 0; classId =  Convert.ToInt32(teacherData.SelectedRows[0].Cells[8].Value);
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

                    reader.Close();
                    reader.Dispose();


                    if (className != string.Empty)
                    {
                        teacherNameTextBox.Text = teacherData.SelectedRows[0].Cells[1].Value.ToString();
                        teacherDOB.Text = teacherData.SelectedRows[0].Cells[2].Value.ToString();
                        teacherGenderComboBox.Text = teacherData.SelectedRows[0].Cells[3].Value.ToString();
                        teacherPhoneTextBox.Text = teacherData.SelectedRows[0].Cells[4].Value.ToString();
                        teacherEmailTextBox.Text = teacherData.SelectedRows[0].Cells[5].Value.ToString();
                        teacherAddressTextBox.Text = teacherData.SelectedRows[0].Cells[6].Value.ToString();
                        teacherPasswordTextBox.Text = teacherData.SelectedRows[0].Cells[7].Value.ToString();
                        teacherClassComboBox.Text = className;
                        teacherClassComboBox.Enabled = false;
                        teacherGenderComboBox.Enabled = false;
                    }
                }
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }
        }
    }
}
