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
    public partial class TeacherSubject : Form
    {
        public TeacherSubject()
        {
            InitializeComponent();
        }
        string constring = DBconnect.DbConnectstring;

        public void TeacherNameList()
        {
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT Name from Teacher Where IsDeleted IS NULL", conn))
                {

                    using (SqlDataReader reader = cmr.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        teacherNameComboBox.ValueMember = "Name";
                        teacherNameComboBox.SelectedItem = "";
                        teacherNameComboBox.DataSource = dt;
                        teacherNameComboBox.SelectedItem = null;
                    }
                    cmr.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public void TeacherClassNameList()
        {

            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmr = new SqlCommand("SELECT ClassName from Class Where IsDeleted IS NULL", conn))
                {

                    using (SqlDataReader reader = cmr.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        teacherClassNameComboBox.ValueMember = "ClassName";
                        teacherClassNameComboBox.SelectedItem = "";
                        teacherClassNameComboBox.DataSource = dt;
                        teacherClassNameComboBox.SelectedItem = null;
                    }
                    cmr.ExecuteNonQuery();
                }

                conn.Close();
            }
        }


        public void TeacherSubjectList()
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
                        teacherSubjectNameComboBox.ValueMember = "SubjectName";
                        teacherSubjectNameComboBox.SelectedItem = "";
                        teacherSubjectNameComboBox.DataSource = dt;
                        teacherSubjectNameComboBox.SelectedItem = null;
                    }
                    cmr.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void TeacherSubject_Load(object sender, EventArgs e)
        {
            TeacherNameList();
            TeacherClassNameList();
            TeacherSubjectList();
            BindGrid();

        }
        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TeacherSubject.Id, Teacher.Name, Class.ClassName , Subject.SubjectName FROM TeacherSubject INNER JOIN Teacher on TeacherSubject.TeacherId=Teacher.TeacherId JOIN Class on TeacherSubject.ClassId=Class.ClassId JOIN Subject on TeacherSubject.SubjectId=Subject.SubjectId Where TeacherSubject.IsDeleted IS NULL and Class.IsDeleted IS NULL and Teacher.IsDeleted IS NULL and Subject.IsDeleted IS NULL", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            teacherSubjectData.DataSource = ds.Tables[0];
                            teacherSubjectData.Columns[0].Visible = false;
                        }
                    }
                }
            }
        }

        private void teacherSubjectRegisterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO [TeacherSubject] (ClassId,TeacherId,SubjectId) VALUES ((SELECT Class.ClassId FROM Class WHERE ClassName=@ClassName),(SELECT Teacher.TeacherId from Teacher Where Name=@Name),(SELECT Subject.SubjectId FROM Subject WHERE SubjectName=@SubjectName))", con))
            {
                try
                {
                    string errorMessage = "Kindly Select all details";
                    if (isValid(errorMessage))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Name", teacherNameComboBox.Text);
                        cmd.Parameters.AddWithValue("@SubjectName", teacherSubjectNameComboBox.Text);
                        cmd.Parameters.AddWithValue("@ClassName", teacherClassNameComboBox.Text);
                        cmd.ExecuteNonQuery();
                        clearInputs();
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

        private void clearInputs()
        {
            teacherNameComboBox.SelectedItem = null;
            teacherSubjectNameComboBox.SelectedItem = null;
            teacherClassNameComboBox.SelectedItem = null;
        }

        private bool isValid(string errorMessage)
        {
            if (teacherNameComboBox.SelectedItem == null || teacherSubjectNameComboBox.SelectedItem == null)
            {
                MessageBox.Show(errorMessage, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void teacherSubjectDeleteBtn_Click(object sender, EventArgs e)
        {
            string errorMessage = "Select a subject to Delete";
            int ID = Convert.ToInt32(teacherSubjectData.SelectedRows[0].Cells[0].Value);
            if (isValid(errorMessage))
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update TeacherSubject set IsDeleted=@IsDeleted where TeacherID=@Id", con);
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.Parameters.AddWithValue("@IsDeleted", true);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Subject is deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearInputs();
                BindGrid();
            }
        }

        private void teacherSubjectData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                teacherNameComboBox.Text = teacherSubjectData.SelectedRows[0].Cells[1].Value.ToString();
                teacherClassNameComboBox.Text = teacherSubjectData.SelectedRows[0].Cells[2].Value.ToString();
                teacherSubjectNameComboBox.Text = teacherSubjectData.SelectedRows[0].Cells[3].Value.ToString();
                teacherClassNameComboBox.Enabled = false;
                teacherNameComboBox.Enabled = false;
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }

        }

        private void teacherSubjectEditBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Logic not written");
            clearInputs();
        }
        private void teacherSubjectSearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT TeacherSubject.Id, Teacher.Name, Class.ClassName , Subject.SubjectName FROM TeacherSubject JOIN Teacher on TeacherSubject.TeacherId=Teacher.TeacherId JOIN Class on TeacherSubject.ClassId=Class.ClassId JOIN Subject on TeacherSubject.SubjectId=Subject.SubjectId WHERE Teacher.Name=@Name and Class.IsDeleted IS NULL and Subject.IsDeleted IS NULL and Teacher.IsDeleted IS NULL and TeacherSubject.IsDeleted IS NULL", con);
                cmd.Parameters.AddWithValue("@Name", teacherNameComboBox.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                teacherSubjectData.DataSource = dt;
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }
            con.Close();
        }

        private void TeacherSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Hide();
        }
    }
}
