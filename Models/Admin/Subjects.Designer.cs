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
            this.SubjectName = new System.Windows.Forms.Label();
            this.SubjectNameText = new System.Windows.Forms.TextBox();
            this.ClassID = new System.Windows.Forms.Label();
            this.classIDText = new System.Windows.Forms.TextBox();
            this.SubjectRegBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectName
            // 
            this.SubjectName.AutoSize = true;
            this.SubjectName.Location = new System.Drawing.Point(927, 144);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(146, 25);
            this.SubjectName.TabIndex = 0;
            this.SubjectName.Text = "Subject Name";
            // 
            // SubjectNameText
            // 
            this.SubjectNameText.Location = new System.Drawing.Point(1154, 138);
            this.SubjectNameText.Name = "SubjectNameText";
            this.SubjectNameText.Size = new System.Drawing.Size(349, 31);
            this.SubjectNameText.TabIndex = 1;
            // 
            // ClassID
            // 
            this.ClassID.AutoSize = true;
            this.ClassID.Location = new System.Drawing.Point(927, 82);
            this.ClassID.Name = "ClassID";
            this.ClassID.Size = new System.Drawing.Size(92, 25);
            this.ClassID.TabIndex = 2;
            this.ClassID.Text = "Class ID";
            // 
            // classIDText
            // 
            this.classIDText.Location = new System.Drawing.Point(1154, 79);
            this.classIDText.Name = "classIDText";
            this.classIDText.Size = new System.Drawing.Size(349, 31);
            this.classIDText.TabIndex = 3;
            // 
            // SubjectRegBtn
            // 
            this.SubjectRegBtn.Location = new System.Drawing.Point(1340, 195);
            this.SubjectRegBtn.Name = "SubjectRegBtn";
            this.SubjectRegBtn.Size = new System.Drawing.Size(163, 42);
            this.SubjectRegBtn.TabIndex = 4;
            this.SubjectRegBtn.Text = "Register";
            this.SubjectRegBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(932, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(571, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 761);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SubjectRegBtn);
            this.Controls.Add(this.classIDText);
            this.Controls.Add(this.ClassID);
            this.Controls.Add(this.SubjectNameText);
            this.Controls.Add(this.SubjectName);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubjectName;
        private System.Windows.Forms.TextBox SubjectNameText;
        private System.Windows.Forms.Label ClassID;
        private System.Windows.Forms.TextBox classIDText;
        private System.Windows.Forms.Button SubjectRegBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}