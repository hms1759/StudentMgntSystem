namespace StudentMgntSystem.Models.Admin
{
    partial class TeacherAttendanceRO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.attendanceData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceData)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceData
            // 
            this.attendanceData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.attendanceData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.attendanceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.attendanceData.Location = new System.Drawing.Point(0, 0);
            this.attendanceData.Name = "attendanceData";
            this.attendanceData.RowHeadersVisible = false;
            this.attendanceData.RowHeadersWidth = 82;
            this.attendanceData.RowTemplate.Height = 33;
            this.attendanceData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attendanceData.Size = new System.Drawing.Size(1467, 752);
            this.attendanceData.TabIndex = 7;
            // 
            // TeacherAttendanceRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 752);
            this.Controls.Add(this.attendanceData);
            this.MaximumSize = new System.Drawing.Size(1493, 823);
            this.MinimumSize = new System.Drawing.Size(1493, 823);
            this.Name = "TeacherAttendanceRO";
            this.Text = "TeacherAttendanceRO";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.TeacherAttendanceRO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView attendanceData;
    }
}