namespace StudentMgntSystem.Models.Admin
{
    partial class TeacherAttendance
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
            this.attendancePanel = new System.Windows.Forms.Panel();
            this.teacherNameComboBox = new System.Windows.Forms.ComboBox();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.teacherStatus = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.attendanceDate = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.AttendanceSearchBtn = new System.Windows.Forms.Button();
            this.AttendanceDeleteBtn = new System.Windows.Forms.Button();
            this.AttendanceEditBtn = new System.Windows.Forms.Button();
            this.AttendanceRegisterBtn = new System.Windows.Forms.Button();
            this.attendanceData = new System.Windows.Forms.DataGridView();
            this.attendancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceData)).BeginInit();
            this.SuspendLayout();
            // 
            // attendancePanel
            // 
            this.attendancePanel.BackColor = System.Drawing.Color.FloralWhite;
            this.attendancePanel.Controls.Add(this.AttendanceSearchBtn);
            this.attendancePanel.Controls.Add(this.AttendanceDeleteBtn);
            this.attendancePanel.Controls.Add(this.AttendanceEditBtn);
            this.attendancePanel.Controls.Add(this.AttendanceRegisterBtn);
            this.attendancePanel.Controls.Add(this.attendanceDate);
            this.attendancePanel.Controls.Add(this.dateLabel);
            this.attendancePanel.Controls.Add(this.statusComboBox);
            this.attendancePanel.Controls.Add(this.teacherStatus);
            this.attendancePanel.Controls.Add(this.teacherNameComboBox);
            this.attendancePanel.Controls.Add(this.teacherNameLabel);
            this.attendancePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.attendancePanel.Location = new System.Drawing.Point(0, 0);
            this.attendancePanel.Name = "attendancePanel";
            this.attendancePanel.Size = new System.Drawing.Size(586, 752);
            this.attendancePanel.TabIndex = 0;
            // 
            // teacherNameComboBox
            // 
            this.teacherNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.teacherNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.teacherNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherNameComboBox.FormattingEnabled = true;
            this.teacherNameComboBox.Location = new System.Drawing.Point(271, 88);
            this.teacherNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherNameComboBox.Name = "teacherNameComboBox";
            this.teacherNameComboBox.Size = new System.Drawing.Size(260, 33);
            this.teacherNameComboBox.TabIndex = 8;
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLabel.Location = new System.Drawing.Point(25, 86);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(208, 34);
            this.teacherNameLabel.TabIndex = 7;
            this.teacherNameLabel.Text = "Teacher Name";
            // 
            // teacherStatus
            // 
            this.teacherStatus.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherStatus.Location = new System.Drawing.Point(25, 192);
            this.teacherStatus.Name = "teacherStatus";
            this.teacherStatus.Size = new System.Drawing.Size(105, 33);
            this.teacherStatus.TabIndex = 9;
            this.teacherStatus.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.statusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(271, 192);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(260, 33);
            this.statusComboBox.TabIndex = 10;
            // 
            // attendanceDate
            // 
            this.attendanceDate.Location = new System.Drawing.Point(271, 292);
            this.attendanceDate.Name = "attendanceDate";
            this.attendanceDate.Size = new System.Drawing.Size(260, 31);
            this.attendanceDate.TabIndex = 22;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(25, 292);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(64, 30);
            this.dateLabel.TabIndex = 21;
            this.dateLabel.Text = "Date";
            // 
            // AttendanceSearchBtn
            // 
            this.AttendanceSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AttendanceSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AttendanceSearchBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AttendanceSearchBtn.Location = new System.Drawing.Point(308, 557);
            this.AttendanceSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttendanceSearchBtn.Name = "AttendanceSearchBtn";
            this.AttendanceSearchBtn.Size = new System.Drawing.Size(123, 58);
            this.AttendanceSearchBtn.TabIndex = 26;
            this.AttendanceSearchBtn.Text = "Search";
            this.AttendanceSearchBtn.UseVisualStyleBackColor = false;
            this.AttendanceSearchBtn.Click += new System.EventHandler(this.AttendanceSearchBtn_Click);
            // 
            // AttendanceDeleteBtn
            // 
            this.AttendanceDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.AttendanceDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AttendanceDeleteBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceDeleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AttendanceDeleteBtn.Location = new System.Drawing.Point(447, 557);
            this.AttendanceDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttendanceDeleteBtn.Name = "AttendanceDeleteBtn";
            this.AttendanceDeleteBtn.Size = new System.Drawing.Size(112, 58);
            this.AttendanceDeleteBtn.TabIndex = 25;
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
            this.AttendanceEditBtn.Location = new System.Drawing.Point(171, 557);
            this.AttendanceEditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttendanceEditBtn.Name = "AttendanceEditBtn";
            this.AttendanceEditBtn.Size = new System.Drawing.Size(107, 58);
            this.AttendanceEditBtn.TabIndex = 24;
            this.AttendanceEditBtn.Text = "Edit";
            this.AttendanceEditBtn.UseVisualStyleBackColor = false;
            this.AttendanceEditBtn.Click += new System.EventHandler(this.AttendanceEditBtn_Click);
            // 
            // AttendanceRegisterBtn
            // 
            this.AttendanceRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AttendanceRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AttendanceRegisterBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceRegisterBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AttendanceRegisterBtn.Location = new System.Drawing.Point(30, 557);
            this.AttendanceRegisterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttendanceRegisterBtn.Name = "AttendanceRegisterBtn";
            this.AttendanceRegisterBtn.Size = new System.Drawing.Size(116, 58);
            this.AttendanceRegisterBtn.TabIndex = 23;
            this.AttendanceRegisterBtn.Text = "Register";
            this.AttendanceRegisterBtn.UseVisualStyleBackColor = false;
            this.AttendanceRegisterBtn.Click += new System.EventHandler(this.AttendanceRegisterBtn_Click);
            // 
            // attendanceData
            // 
            this.attendanceData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.attendanceData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.attendanceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.attendanceData.Location = new System.Drawing.Point(586, 0);
            this.attendanceData.Name = "attendanceData";
            this.attendanceData.RowHeadersVisible = false;
            this.attendanceData.RowHeadersWidth = 82;
            this.attendanceData.RowTemplate.Height = 33;
            this.attendanceData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attendanceData.Size = new System.Drawing.Size(881, 752);
            this.attendanceData.TabIndex = 6;
            this.attendanceData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendanceData_CellClick);
            // 
            // TeacherAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 752);
            this.Controls.Add(this.attendanceData);
            this.Controls.Add(this.attendancePanel);
            this.MaximumSize = new System.Drawing.Size(1493, 823);
            this.MinimumSize = new System.Drawing.Size(1493, 823);
            this.Name = "TeacherAttendance";
            this.Text = "Teacher Attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherAttendance_FormClosed);
            this.Load += new System.EventHandler(this.TeacherAttendance_Load);
            this.attendancePanel.ResumeLayout(false);
            this.attendancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel attendancePanel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label teacherStatus;
        private System.Windows.Forms.ComboBox teacherNameComboBox;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.DateTimePicker attendanceDate;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button AttendanceSearchBtn;
        private System.Windows.Forms.Button AttendanceDeleteBtn;
        private System.Windows.Forms.Button AttendanceEditBtn;
        private System.Windows.Forms.Button AttendanceRegisterBtn;
        private System.Windows.Forms.DataGridView attendanceData;
    }
}