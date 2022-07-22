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
    public partial class FeesForm : Form
    {
        public FeesForm()
        {
            InitializeComponent();
        }
        string constring = DBconnect.DbConnectstring;

        private void departmentList()
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
                        feesClassNameComboBox.ValueMember = "ClassName";
                        feesClassNameComboBox.SelectedItem = "";
                        feesClassNameComboBox.DataSource = dt;
                        feesClassNameComboBox.SelectedItem = null;
                    }
                    cmr.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
        private void FeesRegisterBtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [Fees] (FeesAmount,ClassId) VALUES (@FeesAmount,(SELECT ClassId FROM Class WHERE ClassName=@ClassName))", con))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@FeesAmount", feesTextBox.Text);
                    cmd.Parameters.AddWithValue("@ClassName", feesClassNameComboBox.Text);
                    cmd.ExecuteNonQuery();
                    BindGrid();
                }
                catch (Exception error)
                {
                    var err = error.Message;
                    MessageBox.Show($"Reason: {err}");
                }
            }
            con.Close();
        }

        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Fees.FessId, Class.ClassName,Fees.FeesAmount from Fees JOIN Class ON Fees.ClassId=Class.ClassId where Fees.IsDeleted IS NULL and Class.IsDeleted IS NULL", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            FeesData.DataSource = ds.Tables[0];
                            FeesData.Columns[0].Visible = false;
                        }
                    }
                    //teacherClassComboBox.Enabled = true;
                    //teacherGenderComboBox.Enabled = true;
                }
            }
        }

        private void FeesForm_Load(object sender, EventArgs e)
        {
            departmentList();
        }
    }
}