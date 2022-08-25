namespace StudentMgntSystem.Models.Admin
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.AttendanceBtn = new System.Windows.Forms.Button();
            this.examBtn = new System.Windows.Forms.Button();
            this.ExpenseBtn = new System.Windows.Forms.Button();
            this.feesBtn = new System.Windows.Forms.Button();
            this.studentsBtn = new System.Windows.Forms.Button();
            this.teacherBtn = new System.Windows.Forms.Button();
            this.subjectsRegisterBtn = new System.Windows.Forms.Button();
            this.classRegisterBtn = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1699, 88);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Management System";
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackgroundImage = global::StudentMgntSystem.Properties.Resources.imgHome;
            this.bodyPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bodyPanel.Controls.Add(this.panelContent);
            this.bodyPanel.Controls.Add(this.sidePanel);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 88);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1699, 823);
            this.bodyPanel.TabIndex = 2;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(206, 0);
            this.panelContent.MaximumSize = new System.Drawing.Size(1493, 823);
            this.panelContent.MinimumSize = new System.Drawing.Size(1493, 823);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1493, 823);
            this.panelContent.TabIndex = 4;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel.Controls.Add(this.AttendanceBtn);
            this.sidePanel.Controls.Add(this.examBtn);
            this.sidePanel.Controls.Add(this.ExpenseBtn);
            this.sidePanel.Controls.Add(this.feesBtn);
            this.sidePanel.Controls.Add(this.studentsBtn);
            this.sidePanel.Controls.Add(this.teacherBtn);
            this.sidePanel.Controls.Add(this.subjectsRegisterBtn);
            this.sidePanel.Controls.Add(this.classRegisterBtn);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(206, 823);
            this.sidePanel.TabIndex = 3;
            // 
            // AttendanceBtn
            // 
            this.AttendanceBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AttendanceBtn.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceBtn.ForeColor = System.Drawing.Color.White;
            this.AttendanceBtn.Location = new System.Drawing.Point(11, 680);
            this.AttendanceBtn.Name = "AttendanceBtn";
            this.AttendanceBtn.Size = new System.Drawing.Size(189, 88);
            this.AttendanceBtn.TabIndex = 10;
            this.AttendanceBtn.Text = "Attendace";
            this.AttendanceBtn.UseVisualStyleBackColor = false;
            this.AttendanceBtn.Click += new System.EventHandler(this.AttendanceBtn_Click);
            // 
            // examBtn
            // 
            this.examBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.examBtn.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examBtn.ForeColor = System.Drawing.Color.White;
            this.examBtn.Location = new System.Drawing.Point(11, 389);
            this.examBtn.Name = "examBtn";
            this.examBtn.Size = new System.Drawing.Size(189, 88);
            this.examBtn.TabIndex = 9;
            this.examBtn.Text = "Exam";
            this.examBtn.UseVisualStyleBackColor = false;
            this.examBtn.Click += new System.EventHandler(this.examBtn_Click);
            // 
            // ExpenseBtn
            // 
            this.ExpenseBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExpenseBtn.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseBtn.ForeColor = System.Drawing.Color.White;
            this.ExpenseBtn.Location = new System.Drawing.Point(11, 586);
            this.ExpenseBtn.Name = "ExpenseBtn";
            this.ExpenseBtn.Size = new System.Drawing.Size(189, 88);
            this.ExpenseBtn.TabIndex = 8;
            this.ExpenseBtn.Text = "Expense";
            this.ExpenseBtn.UseVisualStyleBackColor = false;
            this.ExpenseBtn.Click += new System.EventHandler(this.ExpenseBtn_Click);
            // 
            // feesBtn
            // 
            this.feesBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.feesBtn.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesBtn.ForeColor = System.Drawing.Color.White;
            this.feesBtn.Location = new System.Drawing.Point(12, 483);
            this.feesBtn.Name = "feesBtn";
            this.feesBtn.Size = new System.Drawing.Size(189, 88);
            this.feesBtn.TabIndex = 7;
            this.feesBtn.Text = "Fees";
            this.feesBtn.UseVisualStyleBackColor = false;
            this.feesBtn.Click += new System.EventHandler(this.feesBtn_Click);
            // 
            // studentsBtn
            // 
            this.studentsBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentsBtn.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsBtn.ForeColor = System.Drawing.Color.White;
            this.studentsBtn.Location = new System.Drawing.Point(14, 289);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(189, 88);
            this.studentsBtn.TabIndex = 6;
            this.studentsBtn.Text = "Students";
            this.studentsBtn.UseVisualStyleBackColor = false;
            this.studentsBtn.Click += new System.EventHandler(this.studentsBtn_Click);
            // 
            // teacherBtn
            // 
            this.teacherBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teacherBtn.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherBtn.ForeColor = System.Drawing.Color.White;
            this.teacherBtn.Location = new System.Drawing.Point(11, 195);
            this.teacherBtn.Name = "teacherBtn";
            this.teacherBtn.Size = new System.Drawing.Size(189, 88);
            this.teacherBtn.TabIndex = 5;
            this.teacherBtn.Text = "Teachers";
            this.teacherBtn.UseVisualStyleBackColor = false;
            this.teacherBtn.Click += new System.EventHandler(this.teacherBtn_Click);
            // 
            // subjectsRegisterBtn
            // 
            this.subjectsRegisterBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subjectsRegisterBtn.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsRegisterBtn.ForeColor = System.Drawing.Color.White;
            this.subjectsRegisterBtn.Location = new System.Drawing.Point(11, 101);
            this.subjectsRegisterBtn.Name = "subjectsRegisterBtn";
            this.subjectsRegisterBtn.Size = new System.Drawing.Size(189, 88);
            this.subjectsRegisterBtn.TabIndex = 4;
            this.subjectsRegisterBtn.Text = "Subjects";
            this.subjectsRegisterBtn.UseVisualStyleBackColor = false;
            this.subjectsRegisterBtn.Click += new System.EventHandler(this.subjectsRegisterBtn_Click);
            // 
            // classRegisterBtn
            // 
            this.classRegisterBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.classRegisterBtn.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classRegisterBtn.ForeColor = System.Drawing.Color.White;
            this.classRegisterBtn.Location = new System.Drawing.Point(11, 7);
            this.classRegisterBtn.Name = "classRegisterBtn";
            this.classRegisterBtn.Size = new System.Drawing.Size(189, 88);
            this.classRegisterBtn.TabIndex = 3;
            this.classRegisterBtn.Text = "Class";
            this.classRegisterBtn.UseVisualStyleBackColor = false;
            this.classRegisterBtn.Click += new System.EventHandler(this.classRegisterBtn_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.LinkColor = System.Drawing.Color.Red;
            this.Logout.Location = new System.Drawing.Point(1558, 36);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(97, 31);
            this.Logout.TabIndex = 3;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 911);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1725, 982);
            this.MinimumSize = new System.Drawing.Size(1725, 982);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bodyPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button classRegisterBtn;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button subjectsRegisterBtn;
        public System.Windows.Forms.Panel panelContent;
        public System.Windows.Forms.Button teacherBtn;
        public System.Windows.Forms.Button studentsBtn;
        public System.Windows.Forms.Button feesBtn;
        public System.Windows.Forms.Button ExpenseBtn;
        public System.Windows.Forms.Button examBtn;
        public System.Windows.Forms.Button AttendanceBtn;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.LinkLabel Logout;
    }
}