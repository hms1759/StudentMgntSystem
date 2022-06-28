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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classRegisterBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subjectsRegisterBtn = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
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
            this.label2.Location = new System.Drawing.Point(534, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // classRegisterBtn
            // 
            this.classRegisterBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.classRegisterBtn.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classRegisterBtn.ForeColor = System.Drawing.Color.White;
            this.classRegisterBtn.Location = new System.Drawing.Point(12, 49);
            this.classRegisterBtn.Name = "classRegisterBtn";
            this.classRegisterBtn.Size = new System.Drawing.Size(189, 88);
            this.classRegisterBtn.TabIndex = 3;
            this.classRegisterBtn.Text = "Class";
            this.classRegisterBtn.UseVisualStyleBackColor = false;
            this.classRegisterBtn.Click += new System.EventHandler(this.classRegisterBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.subjectsRegisterBtn);
            this.panel2.Controls.Add(this.classRegisterBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 823);
            this.panel2.TabIndex = 3;
            // 
            // subjectsRegisterBtn
            // 
            this.subjectsRegisterBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subjectsRegisterBtn.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsRegisterBtn.ForeColor = System.Drawing.Color.White;
            this.subjectsRegisterBtn.Location = new System.Drawing.Point(12, 164);
            this.subjectsRegisterBtn.Name = "subjectsRegisterBtn";
            this.subjectsRegisterBtn.Size = new System.Drawing.Size(189, 88);
            this.subjectsRegisterBtn.TabIndex = 4;
            this.subjectsRegisterBtn.Text = "Subjects";
            this.subjectsRegisterBtn.UseVisualStyleBackColor = false;
            this.subjectsRegisterBtn.Click += new System.EventHandler(this.subjectsRegisterBtn_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(206, 88);
            this.panelContent.MaximumSize = new System.Drawing.Size(1493, 823);
            this.panelContent.MinimumSize = new System.Drawing.Size(1493, 823);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1493, 823);
            this.panelContent.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1699, 911);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1725, 982);
            this.MinimumSize = new System.Drawing.Size(1725, 982);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button classRegisterBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button subjectsRegisterBtn;
        private System.Windows.Forms.Panel panelContent;
    }
}