namespace StudentMgntSystem.Models.Admin
{
    partial class Teacher
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
            this.SubjectsPanel = new System.Windows.Forms.Panel();
            this.teacherDOB = new System.Windows.Forms.DateTimePicker();
            this.teacherClassComboBox = new System.Windows.Forms.ComboBox();
            this.teacherGenderComboBox = new System.Windows.Forms.ComboBox();
            this.teacherClassLabel = new System.Windows.Forms.Label();
            this.teacherGenderLabel = new System.Windows.Forms.Label();
            this.teacherDOBLabel = new System.Windows.Forms.Label();
            this.teacherAddressLabel = new System.Windows.Forms.Label();
            this.teacherPasswordLabel = new System.Windows.Forms.Label();
            this.teacherEmailLabel = new System.Windows.Forms.Label();
            this.teacherPhoneLabel = new System.Windows.Forms.Label();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.teacherPasswordTextBox = new System.Windows.Forms.TextBox();
            this.teacherEmailTextBox = new System.Windows.Forms.TextBox();
            this.teacherAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teacherPhoneTextBox = new System.Windows.Forms.TextBox();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.subjectSearchBtn = new System.Windows.Forms.Button();
            this.subjectDeleteBtn = new System.Windows.Forms.Button();
            this.subjectEditBtn = new System.Windows.Forms.Button();
            this.teacherRegisterBtn = new System.Windows.Forms.Button();
            this.teacherData = new System.Windows.Forms.DataGridView();
            this.SubjectsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherData)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectsPanel
            // 
            this.SubjectsPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.SubjectsPanel.Controls.Add(this.teacherDOB);
            this.SubjectsPanel.Controls.Add(this.teacherClassComboBox);
            this.SubjectsPanel.Controls.Add(this.teacherGenderComboBox);
            this.SubjectsPanel.Controls.Add(this.teacherClassLabel);
            this.SubjectsPanel.Controls.Add(this.teacherGenderLabel);
            this.SubjectsPanel.Controls.Add(this.teacherDOBLabel);
            this.SubjectsPanel.Controls.Add(this.teacherAddressLabel);
            this.SubjectsPanel.Controls.Add(this.teacherPasswordLabel);
            this.SubjectsPanel.Controls.Add(this.teacherEmailLabel);
            this.SubjectsPanel.Controls.Add(this.teacherPhoneLabel);
            this.SubjectsPanel.Controls.Add(this.teacherNameTextBox);
            this.SubjectsPanel.Controls.Add(this.teacherPasswordTextBox);
            this.SubjectsPanel.Controls.Add(this.teacherEmailTextBox);
            this.SubjectsPanel.Controls.Add(this.teacherAddressTextBox);
            this.SubjectsPanel.Controls.Add(this.label2);
            this.SubjectsPanel.Controls.Add(this.teacherPhoneTextBox);
            this.SubjectsPanel.Controls.Add(this.teacherNameLabel);
            this.SubjectsPanel.Controls.Add(this.subjectSearchBtn);
            this.SubjectsPanel.Controls.Add(this.subjectDeleteBtn);
            this.SubjectsPanel.Controls.Add(this.subjectEditBtn);
            this.SubjectsPanel.Controls.Add(this.teacherRegisterBtn);
            this.SubjectsPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SubjectsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubjectsPanel.Location = new System.Drawing.Point(0, 0);
            this.SubjectsPanel.Name = "SubjectsPanel";
            this.SubjectsPanel.Size = new System.Drawing.Size(565, 752);
            this.SubjectsPanel.TabIndex = 2;
            // 
            // teacherDOB
            // 
            this.teacherDOB.Location = new System.Drawing.Point(196, 358);
            this.teacherDOB.Name = "teacherDOB";
            this.teacherDOB.Size = new System.Drawing.Size(342, 31);
            this.teacherDOB.TabIndex = 20;
            // 
            // teacherClassComboBox
            // 
            this.teacherClassComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.teacherClassComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.teacherClassComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherClassComboBox.FormattingEnabled = true;
            this.teacherClassComboBox.Location = new System.Drawing.Point(196, 301);
            this.teacherClassComboBox.Name = "teacherClassComboBox";
            this.teacherClassComboBox.Size = new System.Drawing.Size(342, 33);
            this.teacherClassComboBox.TabIndex = 19;
            // 
            // teacherGenderComboBox
            // 
            this.teacherGenderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.teacherGenderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.teacherGenderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherGenderComboBox.FormattingEnabled = true;
            this.teacherGenderComboBox.Location = new System.Drawing.Point(196, 428);
            this.teacherGenderComboBox.Name = "teacherGenderComboBox";
            this.teacherGenderComboBox.Size = new System.Drawing.Size(342, 33);
            this.teacherGenderComboBox.TabIndex = 18;
            // 
            // teacherClassLabel
            // 
            this.teacherClassLabel.AutoSize = true;
            this.teacherClassLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherClassLabel.Location = new System.Drawing.Point(3, 304);
            this.teacherClassLabel.Name = "teacherClassLabel";
            this.teacherClassLabel.Size = new System.Drawing.Size(142, 30);
            this.teacherClassLabel.TabIndex = 17;
            this.teacherClassLabel.Text = "Class Name";
            // 
            // teacherGenderLabel
            // 
            this.teacherGenderLabel.AutoSize = true;
            this.teacherGenderLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherGenderLabel.Location = new System.Drawing.Point(3, 431);
            this.teacherGenderLabel.Name = "teacherGenderLabel";
            this.teacherGenderLabel.Size = new System.Drawing.Size(93, 30);
            this.teacherGenderLabel.TabIndex = 16;
            this.teacherGenderLabel.Text = "Gender";
            // 
            // teacherDOBLabel
            // 
            this.teacherDOBLabel.AutoSize = true;
            this.teacherDOBLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherDOBLabel.Location = new System.Drawing.Point(3, 359);
            this.teacherDOBLabel.Name = "teacherDOBLabel";
            this.teacherDOBLabel.Size = new System.Drawing.Size(155, 30);
            this.teacherDOBLabel.TabIndex = 15;
            this.teacherDOBLabel.Text = "Date of Birth";
            // 
            // teacherAddressLabel
            // 
            this.teacherAddressLabel.AutoSize = true;
            this.teacherAddressLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherAddressLabel.Location = new System.Drawing.Point(3, 237);
            this.teacherAddressLabel.Name = "teacherAddressLabel";
            this.teacherAddressLabel.Size = new System.Drawing.Size(103, 30);
            this.teacherAddressLabel.TabIndex = 14;
            this.teacherAddressLabel.Text = "Address";
            // 
            // teacherPasswordLabel
            // 
            this.teacherPasswordLabel.AutoSize = true;
            this.teacherPasswordLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherPasswordLabel.Location = new System.Drawing.Point(3, 578);
            this.teacherPasswordLabel.Name = "teacherPasswordLabel";
            this.teacherPasswordLabel.Size = new System.Drawing.Size(121, 30);
            this.teacherPasswordLabel.TabIndex = 13;
            this.teacherPasswordLabel.Text = "Password";
            // 
            // teacherEmailLabel
            // 
            this.teacherEmailLabel.AutoSize = true;
            this.teacherEmailLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherEmailLabel.Location = new System.Drawing.Point(3, 505);
            this.teacherEmailLabel.Name = "teacherEmailLabel";
            this.teacherEmailLabel.Size = new System.Drawing.Size(78, 30);
            this.teacherEmailLabel.TabIndex = 12;
            this.teacherEmailLabel.Text = "Email";
            // 
            // teacherPhoneLabel
            // 
            this.teacherPhoneLabel.AutoSize = true;
            this.teacherPhoneLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherPhoneLabel.Location = new System.Drawing.Point(3, 160);
            this.teacherPhoneLabel.Name = "teacherPhoneLabel";
            this.teacherPhoneLabel.Size = new System.Drawing.Size(81, 30);
            this.teacherPhoneLabel.TabIndex = 11;
            this.teacherPhoneLabel.Text = "Phone";
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherNameTextBox.Location = new System.Drawing.Point(196, 71);
            this.teacherNameTextBox.Multiline = true;
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(342, 46);
            this.teacherNameTextBox.TabIndex = 10;
            // 
            // teacherPasswordTextBox
            // 
            this.teacherPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherPasswordTextBox.Location = new System.Drawing.Point(196, 562);
            this.teacherPasswordTextBox.Multiline = true;
            this.teacherPasswordTextBox.Name = "teacherPasswordTextBox";
            this.teacherPasswordTextBox.Size = new System.Drawing.Size(342, 46);
            this.teacherPasswordTextBox.TabIndex = 9;
            // 
            // teacherEmailTextBox
            // 
            this.teacherEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherEmailTextBox.Location = new System.Drawing.Point(196, 489);
            this.teacherEmailTextBox.Multiline = true;
            this.teacherEmailTextBox.Name = "teacherEmailTextBox";
            this.teacherEmailTextBox.Size = new System.Drawing.Size(342, 46);
            this.teacherEmailTextBox.TabIndex = 7;
            // 
            // teacherAddressTextBox
            // 
            this.teacherAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherAddressTextBox.Location = new System.Drawing.Point(196, 221);
            this.teacherAddressTextBox.Multiline = true;
            this.teacherAddressTextBox.Name = "teacherAddressTextBox";
            this.teacherAddressTextBox.Size = new System.Drawing.Size(342, 46);
            this.teacherAddressTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher Registeration";
            // 
            // teacherPhoneTextBox
            // 
            this.teacherPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherPhoneTextBox.Location = new System.Drawing.Point(196, 144);
            this.teacherPhoneTextBox.Multiline = true;
            this.teacherPhoneTextBox.Name = "teacherPhoneTextBox";
            this.teacherPhoneTextBox.Size = new System.Drawing.Size(342, 46);
            this.teacherPhoneTextBox.TabIndex = 5;
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLabel.Location = new System.Drawing.Point(3, 87);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(77, 30);
            this.teacherNameLabel.TabIndex = 4;
            this.teacherNameLabel.Text = "Name";
            // 
            // subjectSearchBtn
            // 
            this.subjectSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.subjectSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjectSearchBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.subjectSearchBtn.Location = new System.Drawing.Point(285, 652);
            this.subjectSearchBtn.Name = "subjectSearchBtn";
            this.subjectSearchBtn.Size = new System.Drawing.Size(122, 58);
            this.subjectSearchBtn.TabIndex = 3;
            this.subjectSearchBtn.Text = "Search";
            this.subjectSearchBtn.UseVisualStyleBackColor = false;
            // 
            // subjectDeleteBtn
            // 
            this.subjectDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.subjectDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjectDeleteBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectDeleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.subjectDeleteBtn.Location = new System.Drawing.Point(426, 652);
            this.subjectDeleteBtn.Name = "subjectDeleteBtn";
            this.subjectDeleteBtn.Size = new System.Drawing.Size(112, 58);
            this.subjectDeleteBtn.TabIndex = 2;
            this.subjectDeleteBtn.Text = "Delete";
            this.subjectDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // subjectEditBtn
            // 
            this.subjectEditBtn.BackColor = System.Drawing.Color.Blue;
            this.subjectEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjectEditBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectEditBtn.ForeColor = System.Drawing.Color.Transparent;
            this.subjectEditBtn.Location = new System.Drawing.Point(152, 652);
            this.subjectEditBtn.Name = "subjectEditBtn";
            this.subjectEditBtn.Size = new System.Drawing.Size(107, 58);
            this.subjectEditBtn.TabIndex = 1;
            this.subjectEditBtn.Text = "Edit";
            this.subjectEditBtn.UseVisualStyleBackColor = false;
            this.subjectEditBtn.Click += new System.EventHandler(this.subjectEditBtn_Click);
            // 
            // teacherRegisterBtn
            // 
            this.teacherRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.teacherRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherRegisterBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherRegisterBtn.ForeColor = System.Drawing.Color.Transparent;
            this.teacherRegisterBtn.Location = new System.Drawing.Point(12, 652);
            this.teacherRegisterBtn.Name = "teacherRegisterBtn";
            this.teacherRegisterBtn.Size = new System.Drawing.Size(116, 58);
            this.teacherRegisterBtn.TabIndex = 0;
            this.teacherRegisterBtn.Text = "Register";
            this.teacherRegisterBtn.UseVisualStyleBackColor = false;
            this.teacherRegisterBtn.Click += new System.EventHandler(this.teacherRegisterBtn_Click);
            // 
            // teacherData
            // 
            this.teacherData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.teacherData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.teacherData.Location = new System.Drawing.Point(565, 0);
            this.teacherData.Name = "teacherData";
            this.teacherData.RowHeadersVisible = false;
            this.teacherData.RowHeadersWidth = 82;
            this.teacherData.RowTemplate.Height = 33;
            this.teacherData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teacherData.Size = new System.Drawing.Size(902, 752);
            this.teacherData.TabIndex = 3;
            this.teacherData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherData_CellClick);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 752);
            this.Controls.Add(this.teacherData);
            this.Controls.Add(this.SubjectsPanel);
            this.MaximumSize = new System.Drawing.Size(1493, 823);
            this.MinimumSize = new System.Drawing.Size(1493, 823);
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.SubjectsPanel.ResumeLayout(false);
            this.SubjectsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SubjectsPanel;
        private System.Windows.Forms.Label teacherClassLabel;
        private System.Windows.Forms.Label teacherGenderLabel;
        private System.Windows.Forms.Label teacherDOBLabel;
        private System.Windows.Forms.Label teacherAddressLabel;
        private System.Windows.Forms.Label teacherPasswordLabel;
        private System.Windows.Forms.Label teacherEmailLabel;
        private System.Windows.Forms.Label teacherPhoneLabel;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.TextBox teacherPasswordTextBox;
        private System.Windows.Forms.TextBox teacherEmailTextBox;
        private System.Windows.Forms.TextBox teacherAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teacherPhoneTextBox;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Button subjectSearchBtn;
        private System.Windows.Forms.Button subjectDeleteBtn;
        private System.Windows.Forms.Button subjectEditBtn;
        private System.Windows.Forms.Button teacherRegisterBtn;
        private System.Windows.Forms.DateTimePicker teacherDOB;
        private System.Windows.Forms.ComboBox teacherClassComboBox;
        private System.Windows.Forms.ComboBox teacherGenderComboBox;
        private System.Windows.Forms.DataGridView teacherData;
    }
}