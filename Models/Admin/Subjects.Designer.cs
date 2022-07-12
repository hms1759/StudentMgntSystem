namespace StudentMgntSystem.Models.Admin
{
    partial class Subjects
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
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectSearchBtn = new System.Windows.Forms.Button();
            this.subjectDeleteBtn = new System.Windows.Forms.Button();
            this.subjectEditBtn = new System.Windows.Forms.Button();
            this.subjectRegisterBtn = new System.Windows.Forms.Button();
            this.subjectData = new System.Windows.Forms.DataGridView();
            this.SubjectsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectData)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectsPanel
            // 
            this.SubjectsPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.SubjectsPanel.Controls.Add(this.classComboBox);
            this.SubjectsPanel.Controls.Add(this.label3);
            this.SubjectsPanel.Controls.Add(this.label2);
            this.SubjectsPanel.Controls.Add(this.SubjectNameTextBox);
            this.SubjectsPanel.Controls.Add(this.label1);
            this.SubjectsPanel.Controls.Add(this.subjectSearchBtn);
            this.SubjectsPanel.Controls.Add(this.subjectDeleteBtn);
            this.SubjectsPanel.Controls.Add(this.subjectEditBtn);
            this.SubjectsPanel.Controls.Add(this.subjectRegisterBtn);
            this.SubjectsPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SubjectsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubjectsPanel.Location = new System.Drawing.Point(0, 0);
            this.SubjectsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectsPanel.Name = "SubjectsPanel";
            this.SubjectsPanel.Size = new System.Drawing.Size(679, 749);
            this.SubjectsPanel.TabIndex = 0;
            // 
            // classComboBox
            // 
            this.classComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.classComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.classComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(291, 194);
            this.classComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(260, 33);
            this.classComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Class Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(117, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Registration";
            // 
            // SubjectNameTextBox
            // 
            this.SubjectNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectNameTextBox.Location = new System.Drawing.Point(291, 266);
            this.SubjectNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectNameTextBox.Multiline = true;
            this.SubjectNameTextBox.Name = "SubjectNameTextBox";
            this.SubjectNameTextBox.Size = new System.Drawing.Size(261, 46);
            this.SubjectNameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject Name";
            // 
            // subjectSearchBtn
            // 
            this.subjectSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.subjectSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjectSearchBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.subjectSearchBtn.Location = new System.Drawing.Point(347, 515);
            this.subjectSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectSearchBtn.Name = "subjectSearchBtn";
            this.subjectSearchBtn.Size = new System.Drawing.Size(123, 58);
            this.subjectSearchBtn.TabIndex = 3;
            this.subjectSearchBtn.Text = "Search";
            this.subjectSearchBtn.UseVisualStyleBackColor = false;
            this.subjectSearchBtn.Click += new System.EventHandler(this.subjectSearchBtn_Click);
            // 
            // subjectDeleteBtn
            // 
            this.subjectDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.subjectDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjectDeleteBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectDeleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.subjectDeleteBtn.Location = new System.Drawing.Point(525, 515);
            this.subjectDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectDeleteBtn.Name = "subjectDeleteBtn";
            this.subjectDeleteBtn.Size = new System.Drawing.Size(112, 58);
            this.subjectDeleteBtn.TabIndex = 2;
            this.subjectDeleteBtn.Text = "Delete";
            this.subjectDeleteBtn.UseVisualStyleBackColor = false;
            this.subjectDeleteBtn.Click += new System.EventHandler(this.subjectDeleteBtn_Click);
            // 
            // subjectEditBtn
            // 
            this.subjectEditBtn.BackColor = System.Drawing.Color.Blue;
            this.subjectEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjectEditBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectEditBtn.ForeColor = System.Drawing.Color.Transparent;
            this.subjectEditBtn.Location = new System.Drawing.Point(191, 515);
            this.subjectEditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectEditBtn.Name = "subjectEditBtn";
            this.subjectEditBtn.Size = new System.Drawing.Size(107, 58);
            this.subjectEditBtn.TabIndex = 1;
            this.subjectEditBtn.Text = "Edit";
            this.subjectEditBtn.UseVisualStyleBackColor = false;
            this.subjectEditBtn.Click += new System.EventHandler(this.subjectEditBtn_Click);
            // 
            // subjectRegisterBtn
            // 
            this.subjectRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.subjectRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjectRegisterBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectRegisterBtn.ForeColor = System.Drawing.Color.Transparent;
            this.subjectRegisterBtn.Location = new System.Drawing.Point(45, 515);
            this.subjectRegisterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectRegisterBtn.Name = "subjectRegisterBtn";
            this.subjectRegisterBtn.Size = new System.Drawing.Size(116, 58);
            this.subjectRegisterBtn.TabIndex = 0;
            this.subjectRegisterBtn.Text = "Register";
            this.subjectRegisterBtn.UseVisualStyleBackColor = false;
            this.subjectRegisterBtn.Click += new System.EventHandler(this.subjectRegisterBtn_Click);
            // 
            // subjectData
            // 
            this.subjectData.AllowUserToOrderColumns = true;
            this.subjectData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.subjectData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.subjectData.Location = new System.Drawing.Point(679, 0);
            this.subjectData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectData.Name = "subjectData";
            this.subjectData.RowHeadersVisible = false;
            this.subjectData.RowHeadersWidth = 82;
            this.subjectData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.subjectData.RowTemplate.Height = 33;
            this.subjectData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectData.Size = new System.Drawing.Size(786, 749);
            this.subjectData.TabIndex = 1;
            this.subjectData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectData_CellClick);
            this.subjectData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectData_CellContentClick);
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 749);
            this.Controls.Add(this.subjectData);
            this.Controls.Add(this.SubjectsPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1491, 820);
            this.MinimumSize = new System.Drawing.Size(1491, 820);
            this.Name = "Subjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subjects_Load);
            this.SubjectsPanel.ResumeLayout(false);
            this.SubjectsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SubjectsPanel;
        private System.Windows.Forms.Button subjectSearchBtn;
        private System.Windows.Forms.Button subjectDeleteBtn;
        private System.Windows.Forms.Button subjectEditBtn;
        private System.Windows.Forms.Button subjectRegisterBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SubjectNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView subjectData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox classComboBox;
    }
}