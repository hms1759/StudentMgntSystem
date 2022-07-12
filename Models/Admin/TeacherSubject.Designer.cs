namespace StudentMgntSystem.Models.Admin
{
    partial class TeacherSubject
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
            this.teacherSubjectData = new System.Windows.Forms.DataGridView();
            this.TeacherSubjectsPanel = new System.Windows.Forms.Panel();
            this.teacherClassNameComboBox = new System.Windows.Forms.ComboBox();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.teacherSubjectNameComboBox = new System.Windows.Forms.ComboBox();
            this.subjectNameLabel = new System.Windows.Forms.Label();
            this.teacherNameComboBox = new System.Windows.Forms.ComboBox();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teacherSubjectSearchBtn = new System.Windows.Forms.Button();
            this.teacherSubjectDeleteBtn = new System.Windows.Forms.Button();
            this.teacherSubjectEditBtn = new System.Windows.Forms.Button();
            this.teacherSubjectRegisterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSubjectData)).BeginInit();
            this.TeacherSubjectsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherSubjectData
            // 
            this.teacherSubjectData.AllowUserToOrderColumns = true;
            this.teacherSubjectData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.teacherSubjectData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherSubjectData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherSubjectData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.teacherSubjectData.Location = new System.Drawing.Point(679, 0);
            this.teacherSubjectData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherSubjectData.Name = "teacherSubjectData";
            this.teacherSubjectData.RowHeadersVisible = false;
            this.teacherSubjectData.RowHeadersWidth = 82;
            this.teacherSubjectData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.teacherSubjectData.RowTemplate.Height = 33;
            this.teacherSubjectData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teacherSubjectData.Size = new System.Drawing.Size(630, 770);
            this.teacherSubjectData.TabIndex = 3;
            this.teacherSubjectData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherSubjectData_CellClick);
            // 
            // TeacherSubjectsPanel
            // 
            this.TeacherSubjectsPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.TeacherSubjectsPanel.Controls.Add(this.teacherClassNameComboBox);
            this.TeacherSubjectsPanel.Controls.Add(this.classNameLabel);
            this.TeacherSubjectsPanel.Controls.Add(this.teacherSubjectNameComboBox);
            this.TeacherSubjectsPanel.Controls.Add(this.subjectNameLabel);
            this.TeacherSubjectsPanel.Controls.Add(this.teacherNameComboBox);
            this.TeacherSubjectsPanel.Controls.Add(this.teacherNameLabel);
            this.TeacherSubjectsPanel.Controls.Add(this.label2);
            this.TeacherSubjectsPanel.Controls.Add(this.teacherSubjectSearchBtn);
            this.TeacherSubjectsPanel.Controls.Add(this.teacherSubjectDeleteBtn);
            this.TeacherSubjectsPanel.Controls.Add(this.teacherSubjectEditBtn);
            this.TeacherSubjectsPanel.Controls.Add(this.teacherSubjectRegisterBtn);
            this.TeacherSubjectsPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TeacherSubjectsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TeacherSubjectsPanel.Location = new System.Drawing.Point(0, 0);
            this.TeacherSubjectsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeacherSubjectsPanel.Name = "TeacherSubjectsPanel";
            this.TeacherSubjectsPanel.Size = new System.Drawing.Size(679, 770);
            this.TeacherSubjectsPanel.TabIndex = 2;
            // 
            // teacherClassNameComboBox
            // 
            this.teacherClassNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.teacherClassNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.teacherClassNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherClassNameComboBox.FormattingEnabled = true;
            this.teacherClassNameComboBox.Location = new System.Drawing.Point(291, 276);
            this.teacherClassNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherClassNameComboBox.Name = "teacherClassNameComboBox";
            this.teacherClassNameComboBox.Size = new System.Drawing.Size(260, 33);
            this.teacherClassNameComboBox.TabIndex = 10;
            // 
            // classNameLabel
            // 
            this.classNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameLabel.Location = new System.Drawing.Point(45, 275);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(208, 34);
            this.classNameLabel.TabIndex = 9;
            this.classNameLabel.Text = "Class Name";
            // 
            // teacherSubjectNameComboBox
            // 
            this.teacherSubjectNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.teacherSubjectNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.teacherSubjectNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherSubjectNameComboBox.FormattingEnabled = true;
            this.teacherSubjectNameComboBox.Location = new System.Drawing.Point(291, 366);
            this.teacherSubjectNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherSubjectNameComboBox.Name = "teacherSubjectNameComboBox";
            this.teacherSubjectNameComboBox.Size = new System.Drawing.Size(260, 33);
            this.teacherSubjectNameComboBox.TabIndex = 8;
            // 
            // subjectNameLabel
            // 
            this.subjectNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNameLabel.Location = new System.Drawing.Point(45, 365);
            this.subjectNameLabel.Name = "subjectNameLabel";
            this.subjectNameLabel.Size = new System.Drawing.Size(208, 34);
            this.subjectNameLabel.TabIndex = 7;
            this.subjectNameLabel.Text = "Subject Name";
            // 
            // teacherNameComboBox
            // 
            this.teacherNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.teacherNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.teacherNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherNameComboBox.FormattingEnabled = true;
            this.teacherNameComboBox.Location = new System.Drawing.Point(291, 194);
            this.teacherNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherNameComboBox.Name = "teacherNameComboBox";
            this.teacherNameComboBox.Size = new System.Drawing.Size(260, 33);
            this.teacherNameComboBox.TabIndex = 6;
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLabel.Location = new System.Drawing.Point(45, 192);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(208, 34);
            this.teacherNameLabel.TabIndex = 0;
            this.teacherNameLabel.Text = "Teacher Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(53, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher Subject Registration";
            // 
            // teacherSubjectSearchBtn
            // 
            this.teacherSubjectSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.teacherSubjectSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherSubjectSearchBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherSubjectSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.teacherSubjectSearchBtn.Location = new System.Drawing.Point(347, 515);
            this.teacherSubjectSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherSubjectSearchBtn.Name = "teacherSubjectSearchBtn";
            this.teacherSubjectSearchBtn.Size = new System.Drawing.Size(123, 58);
            this.teacherSubjectSearchBtn.TabIndex = 3;
            this.teacherSubjectSearchBtn.Text = "Search";
            this.teacherSubjectSearchBtn.UseVisualStyleBackColor = false;
            this.teacherSubjectSearchBtn.Click += new System.EventHandler(this.teacherSubjectSearchBtn_Click);
            // 
            // teacherSubjectDeleteBtn
            // 
            this.teacherSubjectDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.teacherSubjectDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherSubjectDeleteBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherSubjectDeleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.teacherSubjectDeleteBtn.Location = new System.Drawing.Point(525, 515);
            this.teacherSubjectDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherSubjectDeleteBtn.Name = "teacherSubjectDeleteBtn";
            this.teacherSubjectDeleteBtn.Size = new System.Drawing.Size(112, 58);
            this.teacherSubjectDeleteBtn.TabIndex = 2;
            this.teacherSubjectDeleteBtn.Text = "Delete";
            this.teacherSubjectDeleteBtn.UseVisualStyleBackColor = false;
            this.teacherSubjectDeleteBtn.Click += new System.EventHandler(this.teacherSubjectDeleteBtn_Click);
            // 
            // teacherSubjectEditBtn
            // 
            this.teacherSubjectEditBtn.BackColor = System.Drawing.Color.Blue;
            this.teacherSubjectEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherSubjectEditBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherSubjectEditBtn.ForeColor = System.Drawing.Color.Transparent;
            this.teacherSubjectEditBtn.Location = new System.Drawing.Point(191, 515);
            this.teacherSubjectEditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherSubjectEditBtn.Name = "teacherSubjectEditBtn";
            this.teacherSubjectEditBtn.Size = new System.Drawing.Size(107, 58);
            this.teacherSubjectEditBtn.TabIndex = 1;
            this.teacherSubjectEditBtn.Text = "Edit";
            this.teacherSubjectEditBtn.UseVisualStyleBackColor = false;
            this.teacherSubjectEditBtn.Click += new System.EventHandler(this.teacherSubjectEditBtn_Click);
            // 
            // teacherSubjectRegisterBtn
            // 
            this.teacherSubjectRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.teacherSubjectRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherSubjectRegisterBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherSubjectRegisterBtn.ForeColor = System.Drawing.Color.Transparent;
            this.teacherSubjectRegisterBtn.Location = new System.Drawing.Point(45, 515);
            this.teacherSubjectRegisterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherSubjectRegisterBtn.Name = "teacherSubjectRegisterBtn";
            this.teacherSubjectRegisterBtn.Size = new System.Drawing.Size(116, 58);
            this.teacherSubjectRegisterBtn.TabIndex = 0;
            this.teacherSubjectRegisterBtn.Text = "Register";
            this.teacherSubjectRegisterBtn.UseVisualStyleBackColor = false;
            this.teacherSubjectRegisterBtn.Click += new System.EventHandler(this.teacherSubjectRegisterBtn_Click);
            // 
            // TeacherSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 770);
            this.Controls.Add(this.teacherSubjectData);
            this.Controls.Add(this.TeacherSubjectsPanel);
            this.Name = "TeacherSubject";
            this.Text = "Teacher Subject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherSubject_FormClosed);
            this.Load += new System.EventHandler(this.TeacherSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherSubjectData)).EndInit();
            this.TeacherSubjectsPanel.ResumeLayout(false);
            this.TeacherSubjectsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView teacherSubjectData;
        private System.Windows.Forms.Panel TeacherSubjectsPanel;
        private System.Windows.Forms.ComboBox teacherClassNameComboBox;
        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.ComboBox teacherSubjectNameComboBox;
        private System.Windows.Forms.Label subjectNameLabel;
        private System.Windows.Forms.ComboBox teacherNameComboBox;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button teacherSubjectSearchBtn;
        private System.Windows.Forms.Button teacherSubjectDeleteBtn;
        private System.Windows.Forms.Button teacherSubjectEditBtn;
        private System.Windows.Forms.Button teacherSubjectRegisterBtn;
    }
}