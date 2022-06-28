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
            this.subjectRegisterBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectData = new System.Windows.Forms.DataGridView();
            this.SubjectsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectData)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectsPanel
            // 
            this.SubjectsPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.SubjectsPanel.Controls.Add(this.label2);
            this.SubjectsPanel.Controls.Add(this.SubjectNameTextBox);
            this.SubjectsPanel.Controls.Add(this.label1);
            this.SubjectsPanel.Controls.Add(this.button4);
            this.SubjectsPanel.Controls.Add(this.button3);
            this.SubjectsPanel.Controls.Add(this.button2);
            this.SubjectsPanel.Controls.Add(this.subjectRegisterBtn);
            this.SubjectsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubjectsPanel.Location = new System.Drawing.Point(0, 0);
            this.SubjectsPanel.Name = "SubjectsPanel";
            this.SubjectsPanel.Size = new System.Drawing.Size(546, 660);
            this.SubjectsPanel.TabIndex = 0;
            // 
            // subjectRegisterBtn
            // 
            this.subjectRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.subjectRegisterBtn.Location = new System.Drawing.Point(12, 325);
            this.subjectRegisterBtn.Name = "subjectRegisterBtn";
            this.subjectRegisterBtn.Size = new System.Drawing.Size(116, 58);
            this.subjectRegisterBtn.TabIndex = 0;
            this.subjectRegisterBtn.Text = "Register";
            this.subjectRegisterBtn.UseVisualStyleBackColor = false;
            this.subjectRegisterBtn.Click += new System.EventHandler(this.subjectRegisterBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(134, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(404, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(262, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 58);
            this.button4.TabIndex = 3;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject Name";
            // 
            // SubjectNameTextBox
            // 
            this.SubjectNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectNameTextBox.Location = new System.Drawing.Point(174, 193);
            this.SubjectNameTextBox.Multiline = true;
            this.SubjectNameTextBox.Name = "SubjectNameTextBox";
            this.SubjectNameTextBox.Size = new System.Drawing.Size(262, 46);
            this.SubjectNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(64, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Registeration";
            // 
            // subjectData
            // 
            this.subjectData.AllowUserToOrderColumns = true;
            this.subjectData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectData.Location = new System.Drawing.Point(546, 0);
            this.subjectData.Name = "subjectData";
            this.subjectData.RowHeadersVisible = false;
            this.subjectData.RowHeadersWidth = 82;
            this.subjectData.RowTemplate.Height = 33;
            this.subjectData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectData.Size = new System.Drawing.Size(569, 660);
            this.subjectData.TabIndex = 1;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 660);
            this.Controls.Add(this.subjectData);
            this.Controls.Add(this.SubjectsPanel);
            this.Name = "Subjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject";
            this.SubjectsPanel.ResumeLayout(false);
            this.SubjectsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SubjectsPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button subjectRegisterBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SubjectNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView subjectData;
    }
}