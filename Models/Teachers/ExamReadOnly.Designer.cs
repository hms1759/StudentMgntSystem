namespace StudentMgntSystem.Models.Teachers
{
    partial class ExamReadOnly
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
            this.examData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.examData)).BeginInit();
            this.SuspendLayout();
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
            this.examData.Size = new System.Drawing.Size(1467, 752);
            this.examData.TabIndex = 6;
            // 
            // ExamReadOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 752);
            this.Controls.Add(this.examData);
            this.MaximumSize = new System.Drawing.Size(1493, 823);
            this.MinimumSize = new System.Drawing.Size(1493, 823);
            this.Name = "ExamReadOnly";
            this.Text = "ExamReadOnly";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExamReadOnly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView examData;
    }
}