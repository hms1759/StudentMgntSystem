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
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
            BindGrid();
        }

        string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SchoolMgnDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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
        private bool isValid()
        {
            if (ClassNameTxt.Text == string.Empty){
                MessageBox.Show("Class Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void classRegisterBtn_Click(object sender, EventArgs e)
        {
            
            if (isValid())
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into Class values (@ClassName)", con);
                cmd.Parameters.AddWithValue("@ClassName", ClassNameTxt.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                BindGrid();
                ClassNameTxt.Text = "";
            }
            
            //clearTextBox();
        }

        private void classDeleteBtn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();


                SqlCommand cmd = new SqlCommand("Delete from Class where ClassName=@KEYWORD", con);


                cmd.Parameters.AddWithValue("KEYWORD", ClassNameTxt.Text);
                cmd.ExecuteNonQuery();
                BindGrid();
                con.Close();
                MessageBox.Show("Successfully Deleted");
                ClassNameTxt.Text = "";
            }
        }

        private void classEditBtn_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(classData.SelectedRows[0].Cells[0].Value);
            if (isValid())
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
                ClassNameTxt.Text = "";
            }
            else
            {
                MessageBox.Show("Please select a Class to update informations", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}