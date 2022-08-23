namespace StudentMgntSystem.Models.Teachers
{
    partial class Home1
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
            this.StudentRegisterationBtn = new System.Windows.Forms.Button();
            this.ExamMarkBtn = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.StudentAttendanceBtn = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.titlePanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentRegisterationBtn
            // 
            this.StudentRegisterationBtn.BackColor = System.Drawing.Color.Black;
            this.StudentRegisterationBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentRegisterationBtn.Location = new System.Drawing.Point(12, 28);
            this.StudentRegisterationBtn.Name = "StudentRegisterationBtn";
            this.StudentRegisterationBtn.Size = new System.Drawing.Size(181, 78);
            this.StudentRegisterationBtn.TabIndex = 0;
            this.StudentRegisterationBtn.Text = "Attendance Registration";
            this.StudentRegisterationBtn.UseVisualStyleBackColor = false;
            this.StudentRegisterationBtn.Click += new System.EventHandler(this.StudentRegisterationBtn_Click);
            // 
            // ExamMarkBtn
            // 
            this.ExamMarkBtn.BackColor = System.Drawing.Color.Black;
            this.ExamMarkBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExamMarkBtn.Location = new System.Drawing.Point(12, 136);
            this.ExamMarkBtn.Name = "ExamMarkBtn";
            this.ExamMarkBtn.Size = new System.Drawing.Size(181, 62);
            this.ExamMarkBtn.TabIndex = 1;
            this.ExamMarkBtn.Text = "Exam Mark";
            this.ExamMarkBtn.UseVisualStyleBackColor = false;
            this.ExamMarkBtn.Click += new System.EventHandler(this.ExamMarkBtn_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.titlePanel.Controls.Add(this.Logout);
            this.titlePanel.Controls.Add(this.label2);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1699, 88);
            this.titlePanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Management System";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FloralWhite;
            this.sidePanel.Controls.Add(this.StudentAttendanceBtn);
            this.sidePanel.Controls.Add(this.StudentRegisterationBtn);
            this.sidePanel.Controls.Add(this.ExamMarkBtn);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 88);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 823);
            this.sidePanel.TabIndex = 7;
            // 
            // panelContent
            // 
            this.panelContent.BackgroundImage = global::StudentMgntSystem.Properties.Resources.imgHome;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 88);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1499, 823);
            this.panelContent.TabIndex = 8;
            // 
            // StudentAttendanceBtn
            // 
            this.StudentAttendanceBtn.BackColor = System.Drawing.Color.Black;
            this.StudentAttendanceBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentAttendanceBtn.Location = new System.Drawing.Point(12, 223);
            this.StudentAttendanceBtn.Name = "StudentAttendanceBtn";
            this.StudentAttendanceBtn.Size = new System.Drawing.Size(181, 78);
            this.StudentAttendanceBtn.TabIndex = 2;
            this.StudentAttendanceBtn.Text = "Student Attendance";
            this.StudentAttendanceBtn.UseVisualStyleBackColor = false;
            this.StudentAttendanceBtn.Click += new System.EventHandler(this.StudentAttendanceBtn_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.LinkColor = System.Drawing.Color.Red;
            this.Logout.Location = new System.Drawing.Point(1499, 30);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(97, 31);
            this.Logout.TabIndex = 2;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // Home1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 911);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.titlePanel);
            this.MaximumSize = new System.Drawing.Size(1725, 982);
            this.MinimumSize = new System.Drawing.Size(1725, 982);
            this.Name = "Home1";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentRegisterationBtn;
        private System.Windows.Forms.Button ExamMarkBtn;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button StudentAttendanceBtn;
        private System.Windows.Forms.LinkLabel Logout;
    }
}