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

namespace StudentMgntSystem.Models.Teachers
{
    public partial class ExamRO : Form
    {
        public ExamRO()
        {
            InitializeComponent();
        }
        string constring = DBconnect.DbConnectstring;
        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Exam.ExamId, Class.ClassName,Subject.SubjectName, Exam.SeatNumber , Exam.CAT , Exam.Exam , Exam.TotalMark , Exam.Percentage  from Exam JOIN Class ON Exam.ClassId=Class.ClassId JOIN Subject on Exam.SubjectId=Subject.SubjectId where Exam.IsDeleted IS NULL and Class.IsDeleted IS NULL and Subject.IsDeleted IS NULL", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            examData.DataSource = ds.Tables[0];
                            examData.Columns[0].Visible = false;
                        }
                    }
                }
            }
        }
        private void ExamRO_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
