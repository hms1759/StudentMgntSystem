namespace StudentMgntSystem.Models.Admin
{
    partial class StudentAttendance
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
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.AttendanceSearchBtn = new System.Windows.Forms.Button();
            this.AttendanceDeleteBtn = new System.Windows.Forms.Button();
            this.AttendanceEditBtn = new System.Windows.Forms.Button();
            this.AttendanceRegisterBtn = new System.Windows.Forms.Button();
            this.attendanceDate = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.studentStatus = new System.Windows.Forms.Label();
            this.studentNameComboBox = new System.Windows.Forms.ComboBox();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.attendanceData = new System.Windows.Forms.DataGridView();
            this.classNameComboBox = new System.Windows.Forms.ComboBox();
            this.subjectNameComboBox = new System.Windows.Forms.ComboBox();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.subjectNameLabel = new System.Windows.Forms.Label();
            this.seatNumberLabel = new System.Windows.Forms.Label();
            this.seatNumberComboBox = new System.Windows.Forms.ComboBox();
            this.detailsPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceData)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsPanel
            // 
            this.detailsPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.detailsPanel.Controls.Add(this.seatNumberComboBox);
            this.detailsPanel.Controls.Add(this.seatNumberLabel);
            this.detailsPanel.Controls.Add(this.subjectNameLabel);
            this.detailsPanel.Controls.Add(this.classNameLabel);
            this.detailsPanel.Controls.Add(this.subjectNameComboBox);
            this.detailsPanel.Controls.Add(this.classNameComboBox);
            this.detailsPanel.Controls.Add(this.AttendanceSearchBtn);
            this.detailsPanel.Controls.Add(this.AttendanceDeleteBtn);
            this.detailsPanel.Controls.Add(this.AttendanceEditBtn);
            this.detailsPanel.Controls.Add(this.AttendanceRegisterBtn);
            this.detailsPanel.Controls.Add(this.attendanceDate);
            this.detailsPanel.Controls.Add(this.dateLabel);
            this.detailsPanel.Controls.Add(this.statusComboBox);
            this.detailsPanel.Controls.Add(this.studentStatus);
            this.detailsPanel.Controls.Add(this.studentNameComboBox);
            this.detailsPanel.Controls.Add(this.studentNameLabel);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(586, 752);
            this.detailsPanel.TabIndex = 0;
            // 
            // AttendanceSearchBtn
            // 
            this.AttendanceSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AttendanceSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AttendanceSearchBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AttendanceSearchBtn.Location = new System.Drawing.Point(309, 583);
            this.AttendanceSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttendanceSearchBtn.Name = "AttendanceSearchBtn";
            this.AttendanceSearchBtn.Size = new System.Drawing.Size(123, 58);
            this.AttendanceSearchBtn.TabIndex = 36;
            this.AttendanceSearchBtn.Text = "Search";
            this.AttendanceSearchBtn.UseVisualStyleBackColor = false;
            // 
            // AttendanceDeleteBtn
            // 
            this.AttendanceDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.AttendanceDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AttendanceDeleteBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceDeleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AttendanceDeleteBtn.Location = new System.Drawing.Point(448, 583);
            this.AttendanceDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttendanceDeleteBtn.Name = "AttendanceDeleteBtn";
            this.AttendanceDeleteBtn.Size = new System.Drawing.Size(112, 58);
            this.AttendanceDeleteBtn.TabIndex = 35;
            this.AttendanceDeleteBtn.Text = "Delete";
            this.AttendanceDeleteBtn.UseVisualStyleBackColor = false;
            this.AttendanceDeleteBtn.Click += new System.EventHandler(this.AttendanceDeleteBtn_Click);
            // 
            // AttendanceEditBtn
            // 
            this.AttendanceEditBtn.BackColor = System.Drawing.Color.Blue;
            this.AttendanceEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AttendanceEditBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceEditBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AttendanceEditBtn.Location = new System.Drawing.Point(172, 583);
            this.AttendanceEditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttendanceEditBtn.Name = "AttendanceEditBtn";
            this.AttendanceEditBtn.Size = new System.Drawing.Size(107, 58);
            this.AttendanceEditBtn.TabIndex = 34;
            this.AttendanceEditBtn.Text = "Edit";
            this.AttendanceEditBtn.UseVisualStyleBackColor = false;
            // 
            // AttendanceRegisterBtn
            // 
            this.AttendanceRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AttendanceRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AttendanceRegisterBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceRegisterBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AttendanceRegisterBtn.Location = new System.Drawing.Point(31, 583);
            this.AttendanceRegisterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttendanceRegisterBtn.Name = "AttendanceRegisterBtn";
            this.AttendanceRegisterBtn.Size = new System.Drawing.Size(116, 58);
            this.AttendanceRegisterBtn.TabIndex = 33;
            this.AttendanceRegisterBtn.Text = "Register";
            this.AttendanceRegisterBtn.UseVisualStyleBackColor = false;
            this.AttendanceRegisterBtn.Click += new System.EventHandler(this.AttendanceRegisterBtn_Click);
            // 
            // attendanceDate
            // 
            this.attendanceDate.Location = new System.Drawing.Point(272, 436);
            this.attendanceDate.Name = "attendanceDate";
            this.attendanceDate.Size = new System.Drawing.Size(260, 31);
            this.attendanceDate.TabIndex = 32;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(26, 437);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(64, 30);
            this.dateLabel.TabIndex = 31;
            this.dateLabel.Text = "Date";
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.statusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(272, 370);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(260, 33);
            this.statusComboBox.TabIndex = 30;
            // 
            // studentStatus
            // 
            this.studentStatus.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentStatus.Location = new System.Drawing.Point(26, 370);
            this.studentStatus.Name = "studentStatus";
            this.studentStatus.Size = new System.Drawing.Size(105, 33);
            this.studentStatus.TabIndex = 29;
            this.studentStatus.Text = "Status";
            // 
            // studentNameComboBox
            // 
            this.studentNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.studentNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.studentNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentNameComboBox.FormattingEnabled = true;
            this.studentNameComboBox.Location = new System.Drawing.Point(272, 38);
            this.studentNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentNameComboBox.Name = "studentNameComboBox";
            this.studentNameComboBox.Size = new System.Drawing.Size(260, 33);
            this.studentNameComboBox.TabIndex = 28;
            this.studentNameComboBox.TextChanged += new System.EventHandler(this.studentNameComboBox_TextChanged);
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(26, 37);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(208, 34);
            this.studentNameLabel.TabIndex = 27;
            this.studentNameLabel.Text = "Student Name";
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.attendanceData);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(586, 0);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(881, 752);
            this.dataPanel.TabIndex = 1;
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
            this.attendanceData.Size = new System.Drawing.Size(881, 752);
            this.attendanceData.TabIndex = 7;
            // 
            // classNameComboBox
            // 
            this.classNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.classNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.classNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.classNameComboBox.FormattingEnabled = true;
            this.classNameComboBox.Location = new System.Drawing.Point(272, 116);
            this.classNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classNameComboBox.Name = "classNameComboBox";
            this.classNameComboBox.Size = new System.Drawing.Size(260, 33);
            this.classNameComboBox.TabIndex = 37;
            this.classNameComboBox.TextChanged += new System.EventHandler(this.classNameComboBox_TextChanged);
            // 
            // subjectNameComboBox
            // 
            this.subjectNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.subjectNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.subjectNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjectNameComboBox.FormattingEnabled = true;
            this.subjectNameComboBox.Location = new System.Drawing.Point(272, 210);
            this.subjectNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectNameComboBox.Name = "subjectNameComboBox";
            this.subjectNameComboBox.Size = new System.Drawing.Size(260, 33);
            this.subjectNameComboBox.TabIndex = 38;
            // 
            // classNameLabel
            // 
            this.classNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameLabel.Location = new System.Drawing.Point(26, 116);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(208, 34);
            this.classNameLabel.TabIndex = 39;
            this.classNameLabel.Text = "Class Name";
            // 
            // subjectNameLabel
            // 
            this.subjectNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNameLabel.Location = new System.Drawing.Point(26, 209);
            this.subjectNameLabel.Name = "subjectNameLabel";
            this.subjectNameLabel.Size = new System.Drawing.Size(208, 34);
            this.subjectNameLabel.TabIndex = 40;
            this.subjectNameLabel.Text = "Subject Name";
            // 
            // seatNumberLabel
            // 
            this.seatNumberLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatNumberLabel.Location = new System.Drawing.Point(26, 292);
            this.seatNumberLabel.Name = "seatNumberLabel";
            this.seatNumberLabel.Size = new System.Drawing.Size(208, 34);
            this.seatNumberLabel.TabIndex = 41;
            this.seatNumberLabel.Text = "Seat Number";
            // 
            // seatNumberComboBox
            // 
            this.seatNumberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.seatNumberComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.seatNumberComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seatNumberComboBox.FormattingEnabled = true;
            this.seatNumberComboBox.Location = new System.Drawing.Point(272, 292);
            this.seatNumberComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seatNumberComboBox.Name = "seatNumberComboBox";
            this.seatNumberComboBox.Size = new System.Drawing.Size(260, 33);
            this.seatNumberComboBox.TabIndex = 42;
            // 
            // StudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 752);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.detailsPanel);
            this.MaximumSize = new System.Drawing.Size(1493, 823);
            this.MinimumSize = new System.Drawing.Size(1493, 823);
            this.Name = "StudentAttendance";
            this.Text = "Student Attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentAttendance_Load);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Button AttendanceSearchBtn;
        private System.Windows.Forms.Button AttendanceDeleteBtn;
        private System.Windows.Forms.Button AttendanceEditBtn;
        private System.Windows.Forms.Button AttendanceRegisterBtn;
        private System.Windows.Forms.DateTimePicker attendanceDate;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label studentStatus;
        private System.Windows.Forms.ComboBox studentNameComboBox;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView attendanceData;
        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.ComboBox subjectNameComboBox;
        private System.Windows.Forms.ComboBox classNameComboBox;
        private System.Windows.Forms.Label subjectNameLabel;
        private System.Windows.Forms.ComboBox seatNumberComboBox;
        private System.Windows.Forms.Label seatNumberLabel;
    }
}