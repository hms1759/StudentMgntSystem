namespace StudentMgntSystem.Models.Admin
{
    partial class Exam
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
            this.examDetailsPanel = new System.Windows.Forms.Panel();
            this.examDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.classNameComboBox = new System.Windows.Forms.ComboBox();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.subjectNameComboBox = new System.Windows.Forms.ComboBox();
            this.subjectNameLabel = new System.Windows.Forms.Label();
            this.testScoreLabel = new System.Windows.Forms.Label();
            this.testScoreTextBox = new System.Windows.Forms.TextBox();
            this.examScoreLabel = new System.Windows.Forms.Label();
            this.examScoreTextBox = new System.Windows.Forms.TextBox();
            this.examSearchBtn = new System.Windows.Forms.Button();
            this.examDeleteBtn = new System.Windows.Forms.Button();
            this.examEditBtn = new System.Windows.Forms.Button();
            this.examRegisterBtn = new System.Windows.Forms.Button();
            this.examData = new System.Windows.Forms.DataGridView();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.seatNumberLabel = new System.Windows.Forms.Label();
            this.seatNumberComboBox = new System.Windows.Forms.ComboBox();
            this.examDetailsPanel.SuspendLayout();
            this.examDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examData)).BeginInit();
            this.dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // examDetailsPanel
            // 
            this.examDetailsPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.examDetailsPanel.Controls.Add(this.examDetailsGroupBox);
            this.examDetailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.examDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.examDetailsPanel.Name = "examDetailsPanel";
            this.examDetailsPanel.Size = new System.Drawing.Size(551, 752);
            this.examDetailsPanel.TabIndex = 0;
            // 
            // examDetailsGroupBox
            // 
            this.examDetailsGroupBox.Controls.Add(this.seatNumberLabel);
            this.examDetailsGroupBox.Controls.Add(this.seatNumberComboBox);
            this.examDetailsGroupBox.Controls.Add(this.examSearchBtn);
            this.examDetailsGroupBox.Controls.Add(this.examDeleteBtn);
            this.examDetailsGroupBox.Controls.Add(this.examEditBtn);
            this.examDetailsGroupBox.Controls.Add(this.examRegisterBtn);
            this.examDetailsGroupBox.Controls.Add(this.examScoreTextBox);
            this.examDetailsGroupBox.Controls.Add(this.examScoreLabel);
            this.examDetailsGroupBox.Controls.Add(this.testScoreTextBox);
            this.examDetailsGroupBox.Controls.Add(this.testScoreLabel);
            this.examDetailsGroupBox.Controls.Add(this.classNameComboBox);
            this.examDetailsGroupBox.Controls.Add(this.classNameLabel);
            this.examDetailsGroupBox.Controls.Add(this.subjectNameComboBox);
            this.examDetailsGroupBox.Controls.Add(this.subjectNameLabel);
            this.examDetailsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.examDetailsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.examDetailsGroupBox.Name = "examDetailsGroupBox";
            this.examDetailsGroupBox.Size = new System.Drawing.Size(551, 752);
            this.examDetailsGroupBox.TabIndex = 1;
            this.examDetailsGroupBox.TabStop = false;
            this.examDetailsGroupBox.Text = "Kindly fill all details";
            // 
            // classNameComboBox
            // 
            this.classNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.classNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.classNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.classNameComboBox.FormattingEnabled = true;
            this.classNameComboBox.Location = new System.Drawing.Point(268, 66);
            this.classNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classNameComboBox.Name = "classNameComboBox";
            this.classNameComboBox.Size = new System.Drawing.Size(260, 33);
            this.classNameComboBox.TabIndex = 14;
            this.classNameComboBox.TextChanged += new System.EventHandler(this.classNameComboBox_TextChanged);
            // 
            // classNameLabel
            // 
            this.classNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameLabel.Location = new System.Drawing.Point(12, 65);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(208, 34);
            this.classNameLabel.TabIndex = 13;
            this.classNameLabel.Text = "Class Name";
            // 
            // subjectNameComboBox
            // 
            this.subjectNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.subjectNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.subjectNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjectNameComboBox.FormattingEnabled = true;
            this.subjectNameComboBox.Location = new System.Drawing.Point(268, 157);
            this.subjectNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectNameComboBox.Name = "subjectNameComboBox";
            this.subjectNameComboBox.Size = new System.Drawing.Size(260, 33);
            this.subjectNameComboBox.TabIndex = 12;
            // 
            // subjectNameLabel
            // 
            this.subjectNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNameLabel.Location = new System.Drawing.Point(12, 157);
            this.subjectNameLabel.Name = "subjectNameLabel";
            this.subjectNameLabel.Size = new System.Drawing.Size(208, 34);
            this.subjectNameLabel.TabIndex = 11;
            this.subjectNameLabel.Text = "Subject Name";
            // 
            // testScoreLabel
            // 
            this.testScoreLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testScoreLabel.Location = new System.Drawing.Point(12, 331);
            this.testScoreLabel.Name = "testScoreLabel";
            this.testScoreLabel.Size = new System.Drawing.Size(208, 34);
            this.testScoreLabel.TabIndex = 15;
            this.testScoreLabel.Text = "Test Score";
            // 
            // testScoreTextBox
            // 
            this.testScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testScoreTextBox.Location = new System.Drawing.Point(268, 331);
            this.testScoreTextBox.Multiline = true;
            this.testScoreTextBox.Name = "testScoreTextBox";
            this.testScoreTextBox.Size = new System.Drawing.Size(260, 34);
            this.testScoreTextBox.TabIndex = 16;
            // 
            // examScoreLabel
            // 
            this.examScoreLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examScoreLabel.Location = new System.Drawing.Point(12, 422);
            this.examScoreLabel.Name = "examScoreLabel";
            this.examScoreLabel.Size = new System.Drawing.Size(180, 34);
            this.examScoreLabel.TabIndex = 17;
            this.examScoreLabel.Text = "Exam Score";
            // 
            // examScoreTextBox
            // 
            this.examScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examScoreTextBox.Location = new System.Drawing.Point(268, 422);
            this.examScoreTextBox.Multiline = true;
            this.examScoreTextBox.Name = "examScoreTextBox";
            this.examScoreTextBox.Size = new System.Drawing.Size(260, 34);
            this.examScoreTextBox.TabIndex = 18;
            // 
            // examSearchBtn
            // 
            this.examSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.examSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.examSearchBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.examSearchBtn.Location = new System.Drawing.Point(284, 533);
            this.examSearchBtn.Name = "examSearchBtn";
            this.examSearchBtn.Size = new System.Drawing.Size(122, 58);
            this.examSearchBtn.TabIndex = 22;
            this.examSearchBtn.Text = "Search";
            this.examSearchBtn.UseVisualStyleBackColor = false;
            this.examSearchBtn.Click += new System.EventHandler(this.examSearchBtn_Click);
            // 
            // examDeleteBtn
            // 
            this.examDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.examDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.examDeleteBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examDeleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.examDeleteBtn.Location = new System.Drawing.Point(433, 533);
            this.examDeleteBtn.Name = "examDeleteBtn";
            this.examDeleteBtn.Size = new System.Drawing.Size(112, 58);
            this.examDeleteBtn.TabIndex = 21;
            this.examDeleteBtn.Text = "Delete";
            this.examDeleteBtn.UseVisualStyleBackColor = false;
            this.examDeleteBtn.Click += new System.EventHandler(this.examDeleteBtn_Click);
            // 
            // examEditBtn
            // 
            this.examEditBtn.BackColor = System.Drawing.Color.Blue;
            this.examEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.examEditBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examEditBtn.ForeColor = System.Drawing.Color.Transparent;
            this.examEditBtn.Location = new System.Drawing.Point(148, 533);
            this.examEditBtn.Name = "examEditBtn";
            this.examEditBtn.Size = new System.Drawing.Size(107, 58);
            this.examEditBtn.TabIndex = 20;
            this.examEditBtn.Text = "Edit";
            this.examEditBtn.UseVisualStyleBackColor = false;
            this.examEditBtn.Click += new System.EventHandler(this.examEditBtn_Click);
            // 
            // examRegisterBtn
            // 
            this.examRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.examRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.examRegisterBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examRegisterBtn.ForeColor = System.Drawing.Color.Transparent;
            this.examRegisterBtn.Location = new System.Drawing.Point(6, 533);
            this.examRegisterBtn.Name = "examRegisterBtn";
            this.examRegisterBtn.Size = new System.Drawing.Size(125, 58);
            this.examRegisterBtn.TabIndex = 19;
            this.examRegisterBtn.Text = "Register";
            this.examRegisterBtn.UseVisualStyleBackColor = false;
            this.examRegisterBtn.Click += new System.EventHandler(this.examRegisterBtn_Click);
            // 
            // examData
            // 
            this.examData.AllowUserToOrderColumns = true;
            this.examData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.examData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.examData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.examData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.examData.Location = new System.Drawing.Point(0, 0);
            this.examData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.examData.Name = "examData";
            this.examData.RowHeadersVisible = false;
            this.examData.RowHeadersWidth = 82;
            this.examData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.examData.RowTemplate.Height = 33;
            this.examData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.examData.Size = new System.Drawing.Size(916, 752);
            this.examData.TabIndex = 4;
            this.examData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.examData_CellClick);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.examData);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(551, 0);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(916, 752);
            this.dataPanel.TabIndex = 5;
            // 
            // seatNumberLabel
            // 
            this.seatNumberLabel.AutoSize = true;
            this.seatNumberLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatNumberLabel.Location = new System.Drawing.Point(12, 246);
            this.seatNumberLabel.Name = "seatNumberLabel";
            this.seatNumberLabel.Size = new System.Drawing.Size(157, 30);
            this.seatNumberLabel.TabIndex = 24;
            this.seatNumberLabel.Text = "Seat Number";
            // 
            // seatNumberComboBox
            // 
            this.seatNumberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.seatNumberComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.seatNumberComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seatNumberComboBox.FormattingEnabled = true;
            this.seatNumberComboBox.Location = new System.Drawing.Point(268, 242);
            this.seatNumberComboBox.Name = "seatNumberComboBox";
            this.seatNumberComboBox.Size = new System.Drawing.Size(260, 33);
            this.seatNumberComboBox.TabIndex = 23;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 752);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.examDetailsPanel);
            this.MaximumSize = new System.Drawing.Size(1493, 823);
            this.MinimumSize = new System.Drawing.Size(1493, 823);
            this.Name = "Exam";
            this.Text = "Exam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Exam_Load);
            this.examDetailsPanel.ResumeLayout(false);
            this.examDetailsGroupBox.ResumeLayout(false);
            this.examDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examData)).EndInit();
            this.dataPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel examDetailsPanel;
        private System.Windows.Forms.GroupBox examDetailsGroupBox;
        private System.Windows.Forms.ComboBox classNameComboBox;
        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.ComboBox subjectNameComboBox;
        private System.Windows.Forms.Label subjectNameLabel;
        private System.Windows.Forms.Label testScoreLabel;
        private System.Windows.Forms.TextBox examScoreTextBox;
        private System.Windows.Forms.Label examScoreLabel;
        private System.Windows.Forms.TextBox testScoreTextBox;
        private System.Windows.Forms.Button examSearchBtn;
        private System.Windows.Forms.Button examDeleteBtn;
        private System.Windows.Forms.Button examEditBtn;
        private System.Windows.Forms.Button examRegisterBtn;
        private System.Windows.Forms.DataGridView examData;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Label seatNumberLabel;
        private System.Windows.Forms.ComboBox seatNumberComboBox;
    }
}