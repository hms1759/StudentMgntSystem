namespace StudentMgntSystem.Models.Admin
{
    partial class Class
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
            this.label2 = new System.Windows.Forms.Label();
            this.ClassNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classSearchBtn = new System.Windows.Forms.Button();
            this.classDeleteBtn = new System.Windows.Forms.Button();
            this.classEditBtn = new System.Windows.Forms.Button();
            this.classRegisterBtn = new System.Windows.Forms.Button();
            this.classData = new System.Windows.Forms.DataGridView();
            this.SubjectsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classData)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectsPanel
            // 
            this.SubjectsPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.SubjectsPanel.Controls.Add(this.label2);
            this.SubjectsPanel.Controls.Add(this.ClassNameTxt);
            this.SubjectsPanel.Controls.Add(this.label1);
            this.SubjectsPanel.Controls.Add(this.classSearchBtn);
            this.SubjectsPanel.Controls.Add(this.classDeleteBtn);
            this.SubjectsPanel.Controls.Add(this.classEditBtn);
            this.SubjectsPanel.Controls.Add(this.classRegisterBtn);
            this.SubjectsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubjectsPanel.Location = new System.Drawing.Point(0, 0);
            this.SubjectsPanel.Name = "SubjectsPanel";
            this.SubjectsPanel.Size = new System.Drawing.Size(597, 752);
            this.SubjectsPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(64, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class Registration";
            // 
            // ClassNameTxt
            // 
            this.ClassNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassNameTxt.Location = new System.Drawing.Point(186, 202);
            this.ClassNameTxt.Multiline = true;
            this.ClassNameTxt.Name = "ClassNameTxt";
            this.ClassNameTxt.Size = new System.Drawing.Size(262, 55);
            this.ClassNameTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class Name";
            // 
            // classSearchBtn
            // 
            this.classSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.classSearchBtn.Location = new System.Drawing.Point(277, 325);
            this.classSearchBtn.Name = "classSearchBtn";
            this.classSearchBtn.Size = new System.Drawing.Size(133, 81);
            this.classSearchBtn.TabIndex = 3;
            this.classSearchBtn.Text = "Search";
            this.classSearchBtn.UseVisualStyleBackColor = false;
            this.classSearchBtn.Click += new System.EventHandler(this.classSearchBtn_Click);
            // 
            // classDeleteBtn
            // 
            this.classDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.classDeleteBtn.Location = new System.Drawing.Point(438, 325);
            this.classDeleteBtn.Name = "classDeleteBtn";
            this.classDeleteBtn.Size = new System.Drawing.Size(116, 81);
            this.classDeleteBtn.TabIndex = 2;
            this.classDeleteBtn.Text = "Delete";
            this.classDeleteBtn.UseVisualStyleBackColor = false;
            this.classDeleteBtn.Click += new System.EventHandler(this.classDeleteBtn_Click);
            // 
            // classEditBtn
            // 
            this.classEditBtn.BackColor = System.Drawing.Color.Blue;
            this.classEditBtn.Location = new System.Drawing.Point(164, 325);
            this.classEditBtn.Name = "classEditBtn";
            this.classEditBtn.Size = new System.Drawing.Size(107, 81);
            this.classEditBtn.TabIndex = 1;
            this.classEditBtn.Text = "Edit";
            this.classEditBtn.UseVisualStyleBackColor = false;
            this.classEditBtn.Click += new System.EventHandler(this.classEditBtn_Click);
            // 
            // classRegisterBtn
            // 
            this.classRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.classRegisterBtn.Location = new System.Drawing.Point(12, 325);
            this.classRegisterBtn.Name = "classRegisterBtn";
            this.classRegisterBtn.Size = new System.Drawing.Size(134, 81);
            this.classRegisterBtn.TabIndex = 0;
            this.classRegisterBtn.Text = "Register";
            this.classRegisterBtn.UseVisualStyleBackColor = false;
            this.classRegisterBtn.Click += new System.EventHandler(this.classRegisterBtn_Click);
            // 
            // classData
            // 
            this.classData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.classData.BackgroundColor = System.Drawing.Color.White;
            this.classData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classData.Location = new System.Drawing.Point(597, 0);
            this.classData.Name = "classData";
            this.classData.RowHeadersVisible = false;
            this.classData.RowHeadersWidth = 82;
            this.classData.RowTemplate.Height = 33;
            this.classData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classData.Size = new System.Drawing.Size(870, 752);
            this.classData.TabIndex = 3;
            this.classData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classData_CellClick);
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 752);
            this.Controls.Add(this.classData);
            this.Controls.Add(this.SubjectsPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1493, 823);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1493, 823);
            this.Name = "Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SubjectsPanel.ResumeLayout(false);
            this.SubjectsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SubjectsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button classSearchBtn;
        private System.Windows.Forms.Button classDeleteBtn;
        private System.Windows.Forms.Button classEditBtn;
        private System.Windows.Forms.Button classRegisterBtn;
        private System.Windows.Forms.DataGridView classData;
    }
}