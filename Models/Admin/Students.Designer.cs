namespace StudentMgntSystem.Models.Admin
{
    partial class Students
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
            this.studentDOB = new System.Windows.Forms.DateTimePicker();
            this.studentClassComboBox = new System.Windows.Forms.ComboBox();
            this.studentGenderComboBox = new System.Windows.Forms.ComboBox();
            this.teacherClassLabel = new System.Windows.Forms.Label();
            this.teacherGenderLabel = new System.Windows.Forms.Label();
            this.teacherDOBLabel = new System.Windows.Forms.Label();
            this.teacherAddressLabel = new System.Windows.Forms.Label();
            this.teacherPasswordLabel = new System.Windows.Forms.Label();
            this.teacherEmailLabel = new System.Windows.Forms.Label();
            this.teacherPhoneLabel = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentNextOfKinTextBox = new System.Windows.Forms.TextBox();
            this.studentEmailTextBox = new System.Windows.Forms.TextBox();
            this.studentAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentPhoneTextBox = new System.Windows.Forms.TextBox();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.studentSearchBtn = new System.Windows.Forms.Button();
            this.studentDeleteBtn = new System.Windows.Forms.Button();
            this.studentEditBtn = new System.Windows.Forms.Button();
            this.studentRegisterBtn = new System.Windows.Forms.Button();
            this.studentData = new System.Windows.Forms.DataGridView();
            this.SubjectsPanel = new System.Windows.Forms.Panel();
            this.studentNextOfKinAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentNextOfKinPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentSeatNumberComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).BeginInit();
            this.SubjectsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentDOB
            // 
            this.studentDOB.Location = new System.Drawing.Point(275, 160);
            this.studentDOB.Name = "studentDOB";
            this.studentDOB.Size = new System.Drawing.Size(342, 31);
            this.studentDOB.TabIndex = 20;
            // 
            // studentClassComboBox
            // 
            this.studentClassComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.studentClassComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.studentClassComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentClassComboBox.FormattingEnabled = true;
            this.studentClassComboBox.Location = new System.Drawing.Point(275, 597);
            this.studentClassComboBox.Name = "studentClassComboBox";
            this.studentClassComboBox.Size = new System.Drawing.Size(342, 33);
            this.studentClassComboBox.TabIndex = 19;
            // 
            // studentGenderComboBox
            // 
            this.studentGenderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.studentGenderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.studentGenderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentGenderComboBox.FormattingEnabled = true;
            this.studentGenderComboBox.Location = new System.Drawing.Point(275, 102);
            this.studentGenderComboBox.Name = "studentGenderComboBox";
            this.studentGenderComboBox.Size = new System.Drawing.Size(342, 33);
            this.studentGenderComboBox.TabIndex = 18;
            // 
            // teacherClassLabel
            // 
            this.teacherClassLabel.AutoSize = true;
            this.teacherClassLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherClassLabel.Location = new System.Drawing.Point(14, 600);
            this.teacherClassLabel.Name = "teacherClassLabel";
            this.teacherClassLabel.Size = new System.Drawing.Size(142, 30);
            this.teacherClassLabel.TabIndex = 17;
            this.teacherClassLabel.Text = "Class Name";
            // 
            // teacherGenderLabel
            // 
            this.teacherGenderLabel.AutoSize = true;
            this.teacherGenderLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherGenderLabel.Location = new System.Drawing.Point(12, 105);
            this.teacherGenderLabel.Name = "teacherGenderLabel";
            this.teacherGenderLabel.Size = new System.Drawing.Size(93, 30);
            this.teacherGenderLabel.TabIndex = 16;
            this.teacherGenderLabel.Text = "Gender";
            // 
            // teacherDOBLabel
            // 
            this.teacherDOBLabel.AutoSize = true;
            this.teacherDOBLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherDOBLabel.Location = new System.Drawing.Point(12, 161);
            this.teacherDOBLabel.Name = "teacherDOBLabel";
            this.teacherDOBLabel.Size = new System.Drawing.Size(155, 30);
            this.teacherDOBLabel.TabIndex = 15;
            this.teacherDOBLabel.Text = "Date of Birth";
            // 
            // teacherAddressLabel
            // 
            this.teacherAddressLabel.AutoSize = true;
            this.teacherAddressLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherAddressLabel.Location = new System.Drawing.Point(12, 218);
            this.teacherAddressLabel.Name = "teacherAddressLabel";
            this.teacherAddressLabel.Size = new System.Drawing.Size(103, 30);
            this.teacherAddressLabel.TabIndex = 14;
            this.teacherAddressLabel.Text = "Address";
            // 
            // teacherPasswordLabel
            // 
            this.teacherPasswordLabel.AutoSize = true;
            this.teacherPasswordLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherPasswordLabel.Location = new System.Drawing.Point(12, 434);
            this.teacherPasswordLabel.Name = "teacherPasswordLabel";
            this.teacherPasswordLabel.Size = new System.Drawing.Size(136, 30);
            this.teacherPasswordLabel.TabIndex = 13;
            this.teacherPasswordLabel.Text = "Next of kin";
            // 
            // teacherEmailLabel
            // 
            this.teacherEmailLabel.AutoSize = true;
            this.teacherEmailLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherEmailLabel.Location = new System.Drawing.Point(14, 322);
            this.teacherEmailLabel.Name = "teacherEmailLabel";
            this.teacherEmailLabel.Size = new System.Drawing.Size(78, 30);
            this.teacherEmailLabel.TabIndex = 12;
            this.teacherEmailLabel.Text = "Email";
            // 
            // teacherPhoneLabel
            // 
            this.teacherPhoneLabel.AutoSize = true;
            this.teacherPhoneLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherPhoneLabel.Location = new System.Drawing.Point(14, 268);
            this.teacherPhoneLabel.Name = "teacherPhoneLabel";
            this.teacherPhoneLabel.Size = new System.Drawing.Size(81, 30);
            this.teacherPhoneLabel.TabIndex = 11;
            this.teacherPhoneLabel.Text = "Phone";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNameTextBox.Location = new System.Drawing.Point(275, 50);
            this.studentNameTextBox.Multiline = true;
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(342, 35);
            this.studentNameTextBox.TabIndex = 10;
            // 
            // studentNextOfKinTextBox
            // 
            this.studentNextOfKinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNextOfKinTextBox.Location = new System.Drawing.Point(275, 429);
            this.studentNextOfKinTextBox.Multiline = true;
            this.studentNextOfKinTextBox.Name = "studentNextOfKinTextBox";
            this.studentNextOfKinTextBox.Size = new System.Drawing.Size(342, 34);
            this.studentNextOfKinTextBox.TabIndex = 9;
            // 
            // studentEmailTextBox
            // 
            this.studentEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentEmailTextBox.Location = new System.Drawing.Point(275, 316);
            this.studentEmailTextBox.Multiline = true;
            this.studentEmailTextBox.Name = "studentEmailTextBox";
            this.studentEmailTextBox.Size = new System.Drawing.Size(342, 35);
            this.studentEmailTextBox.TabIndex = 7;
            // 
            // studentAddressTextBox
            // 
            this.studentAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentAddressTextBox.Location = new System.Drawing.Point(275, 213);
            this.studentAddressTextBox.Multiline = true;
            this.studentAddressTextBox.Name = "studentAddressTextBox";
            this.studentAddressTextBox.Size = new System.Drawing.Size(342, 35);
            this.studentAddressTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(84, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Registration";
            // 
            // studentPhoneTextBox
            // 
            this.studentPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentPhoneTextBox.Location = new System.Drawing.Point(275, 265);
            this.studentPhoneTextBox.Multiline = true;
            this.studentPhoneTextBox.Name = "studentPhoneTextBox";
            this.studentPhoneTextBox.Size = new System.Drawing.Size(342, 33);
            this.studentPhoneTextBox.TabIndex = 5;
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLabel.Location = new System.Drawing.Point(11, 55);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(77, 30);
            this.teacherNameLabel.TabIndex = 4;
            this.teacherNameLabel.Text = "Name";
            // 
            // studentSearchBtn
            // 
            this.studentSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.studentSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentSearchBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.studentSearchBtn.Location = new System.Drawing.Point(298, 675);
            this.studentSearchBtn.Name = "studentSearchBtn";
            this.studentSearchBtn.Size = new System.Drawing.Size(122, 58);
            this.studentSearchBtn.TabIndex = 3;
            this.studentSearchBtn.Text = "Search";
            this.studentSearchBtn.UseVisualStyleBackColor = false;
            this.studentSearchBtn.Click += new System.EventHandler(this.studentSearchBtn_Click);
            // 
            // studentDeleteBtn
            // 
            this.studentDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.studentDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentDeleteBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDeleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.studentDeleteBtn.Location = new System.Drawing.Point(451, 675);
            this.studentDeleteBtn.Name = "studentDeleteBtn";
            this.studentDeleteBtn.Size = new System.Drawing.Size(112, 58);
            this.studentDeleteBtn.TabIndex = 2;
            this.studentDeleteBtn.Text = "Delete";
            this.studentDeleteBtn.UseVisualStyleBackColor = false;
            this.studentDeleteBtn.Click += new System.EventHandler(this.studentDeleteBtn_Click);
            // 
            // studentEditBtn
            // 
            this.studentEditBtn.BackColor = System.Drawing.Color.Blue;
            this.studentEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentEditBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEditBtn.ForeColor = System.Drawing.Color.Transparent;
            this.studentEditBtn.Location = new System.Drawing.Point(162, 675);
            this.studentEditBtn.Name = "studentEditBtn";
            this.studentEditBtn.Size = new System.Drawing.Size(107, 58);
            this.studentEditBtn.TabIndex = 1;
            this.studentEditBtn.Text = "Edit";
            this.studentEditBtn.UseVisualStyleBackColor = false;
            this.studentEditBtn.Click += new System.EventHandler(this.studentEditBtn_Click);
            // 
            // studentRegisterBtn
            // 
            this.studentRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.studentRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentRegisterBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRegisterBtn.ForeColor = System.Drawing.Color.Transparent;
            this.studentRegisterBtn.Location = new System.Drawing.Point(16, 675);
            this.studentRegisterBtn.Name = "studentRegisterBtn";
            this.studentRegisterBtn.Size = new System.Drawing.Size(116, 58);
            this.studentRegisterBtn.TabIndex = 0;
            this.studentRegisterBtn.Text = "Register";
            this.studentRegisterBtn.UseVisualStyleBackColor = false;
            this.studentRegisterBtn.Click += new System.EventHandler(this.studentRegisterBtn_Click);
            // 
            // studentData
            // 
            this.studentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.studentData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.studentData.Location = new System.Drawing.Point(623, 0);
            this.studentData.Name = "studentData";
            this.studentData.RowHeadersVisible = false;
            this.studentData.RowHeadersWidth = 82;
            this.studentData.RowTemplate.Height = 33;
            this.studentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentData.Size = new System.Drawing.Size(844, 752);
            this.studentData.TabIndex = 5;
            this.studentData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentData_CellClick);
            // 
            // SubjectsPanel
            // 
            this.SubjectsPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.SubjectsPanel.Controls.Add(this.studentNextOfKinAddress);
            this.SubjectsPanel.Controls.Add(this.label4);
            this.SubjectsPanel.Controls.Add(this.studentNextOfKinPhone);
            this.SubjectsPanel.Controls.Add(this.label3);
            this.SubjectsPanel.Controls.Add(this.label1);
            this.SubjectsPanel.Controls.Add(this.studentSeatNumberComboBox);
            this.SubjectsPanel.Controls.Add(this.studentDOB);
            this.SubjectsPanel.Controls.Add(this.studentClassComboBox);
            this.SubjectsPanel.Controls.Add(this.studentGenderComboBox);
            this.SubjectsPanel.Controls.Add(this.teacherClassLabel);
            this.SubjectsPanel.Controls.Add(this.teacherGenderLabel);
            this.SubjectsPanel.Controls.Add(this.teacherDOBLabel);
            this.SubjectsPanel.Controls.Add(this.teacherAddressLabel);
            this.SubjectsPanel.Controls.Add(this.teacherPasswordLabel);
            this.SubjectsPanel.Controls.Add(this.teacherEmailLabel);
            this.SubjectsPanel.Controls.Add(this.teacherPhoneLabel);
            this.SubjectsPanel.Controls.Add(this.studentNameTextBox);
            this.SubjectsPanel.Controls.Add(this.studentNextOfKinTextBox);
            this.SubjectsPanel.Controls.Add(this.studentEmailTextBox);
            this.SubjectsPanel.Controls.Add(this.studentAddressTextBox);
            this.SubjectsPanel.Controls.Add(this.label2);
            this.SubjectsPanel.Controls.Add(this.studentPhoneTextBox);
            this.SubjectsPanel.Controls.Add(this.teacherNameLabel);
            this.SubjectsPanel.Controls.Add(this.studentSearchBtn);
            this.SubjectsPanel.Controls.Add(this.studentDeleteBtn);
            this.SubjectsPanel.Controls.Add(this.studentEditBtn);
            this.SubjectsPanel.Controls.Add(this.studentRegisterBtn);
            this.SubjectsPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SubjectsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubjectsPanel.Location = new System.Drawing.Point(0, 0);
            this.SubjectsPanel.Name = "SubjectsPanel";
            this.SubjectsPanel.Size = new System.Drawing.Size(623, 752);
            this.SubjectsPanel.TabIndex = 4;
            // 
            // studentNextOfKinAddress
            // 
            this.studentNextOfKinAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNextOfKinAddress.Location = new System.Drawing.Point(275, 536);
            this.studentNextOfKinAddress.Multiline = true;
            this.studentNextOfKinAddress.Name = "studentNextOfKinAddress";
            this.studentNextOfKinAddress.Size = new System.Drawing.Size(342, 30);
            this.studentNextOfKinAddress.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "Next of kin Address";
            // 
            // studentNextOfKinPhone
            // 
            this.studentNextOfKinPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNextOfKinPhone.Location = new System.Drawing.Point(275, 481);
            this.studentNextOfKinPhone.Multiline = true;
            this.studentNextOfKinPhone.Name = "studentNextOfKinPhone";
            this.studentNextOfKinPhone.Size = new System.Drawing.Size(342, 30);
            this.studentNextOfKinPhone.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "Next of kin Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Seat Number";
            // 
            // studentSeatNumberComboBox
            // 
            this.studentSeatNumberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.studentSeatNumberComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.studentSeatNumberComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentSeatNumberComboBox.FormattingEnabled = true;
            this.studentSeatNumberComboBox.Location = new System.Drawing.Point(275, 370);
            this.studentSeatNumberComboBox.Name = "studentSeatNumberComboBox";
            this.studentSeatNumberComboBox.Size = new System.Drawing.Size(342, 33);
            this.studentSeatNumberComboBox.TabIndex = 21;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 752);
            this.Controls.Add(this.studentData);
            this.Controls.Add(this.SubjectsPanel);
            this.MaximumSize = new System.Drawing.Size(1493, 823);
            this.MinimumSize = new System.Drawing.Size(1493, 823);
            this.Name = "Students";
            this.Text = "Students";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).EndInit();
            this.SubjectsPanel.ResumeLayout(false);
            this.SubjectsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker studentDOB;
        private System.Windows.Forms.ComboBox studentClassComboBox;
        private System.Windows.Forms.ComboBox studentGenderComboBox;
        private System.Windows.Forms.Label teacherClassLabel;
        private System.Windows.Forms.Label teacherGenderLabel;
        private System.Windows.Forms.Label teacherDOBLabel;
        private System.Windows.Forms.Label teacherAddressLabel;
        private System.Windows.Forms.Label teacherPasswordLabel;
        private System.Windows.Forms.Label teacherEmailLabel;
        private System.Windows.Forms.Label teacherPhoneLabel;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentNextOfKinTextBox;
        private System.Windows.Forms.TextBox studentEmailTextBox;
        private System.Windows.Forms.TextBox studentAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentPhoneTextBox;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Button studentSearchBtn;
        private System.Windows.Forms.Button studentDeleteBtn;
        private System.Windows.Forms.Button studentEditBtn;
        private System.Windows.Forms.Button studentRegisterBtn;
        private System.Windows.Forms.DataGridView studentData;
        private System.Windows.Forms.Panel SubjectsPanel;
        private System.Windows.Forms.TextBox studentNextOfKinAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentNextOfKinPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox studentSeatNumberComboBox;
    }
}