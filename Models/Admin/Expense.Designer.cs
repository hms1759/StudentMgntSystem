namespace StudentMgntSystem.Models.Admin
{
    partial class Expense
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
            this.feesData = new System.Windows.Forms.DataGridView();
            this.ClassFeePanel = new System.Windows.Forms.Panel();
            this.classNameComboBox = new System.Windows.Forms.ComboBox();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.SubjectNameComboBox = new System.Windows.Forms.ComboBox();
            this.subjectNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.feeSearchBtn = new System.Windows.Forms.Button();
            this.feeDeleteBtn = new System.Windows.Forms.Button();
            this.FeeEditBtn = new System.Windows.Forms.Button();
            this.FeeRegisterBtn = new System.Windows.Forms.Button();
            this.chargesLabel = new System.Windows.Forms.Label();
            this.chargesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.feesData)).BeginInit();
            this.ClassFeePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // feesData
            // 
            this.feesData.AllowUserToOrderColumns = true;
            this.feesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.feesData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.feesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feesData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.feesData.Location = new System.Drawing.Point(679, 0);
            this.feesData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feesData.Name = "feesData";
            this.feesData.RowHeadersVisible = false;
            this.feesData.RowHeadersWidth = 82;
            this.feesData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.feesData.RowTemplate.Height = 33;
            this.feesData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.feesData.Size = new System.Drawing.Size(786, 749);
            this.feesData.TabIndex = 5;
            // 
            // ClassFeePanel
            // 
            this.ClassFeePanel.BackColor = System.Drawing.Color.FloralWhite;
            this.ClassFeePanel.Controls.Add(this.chargesTextBox);
            this.ClassFeePanel.Controls.Add(this.chargesLabel);
            this.ClassFeePanel.Controls.Add(this.classNameComboBox);
            this.ClassFeePanel.Controls.Add(this.classNameLabel);
            this.ClassFeePanel.Controls.Add(this.SubjectNameComboBox);
            this.ClassFeePanel.Controls.Add(this.subjectNameLabel);
            this.ClassFeePanel.Controls.Add(this.label2);
            this.ClassFeePanel.Controls.Add(this.feeSearchBtn);
            this.ClassFeePanel.Controls.Add(this.feeDeleteBtn);
            this.ClassFeePanel.Controls.Add(this.FeeEditBtn);
            this.ClassFeePanel.Controls.Add(this.FeeRegisterBtn);
            this.ClassFeePanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ClassFeePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClassFeePanel.Location = new System.Drawing.Point(0, 0);
            this.ClassFeePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassFeePanel.Name = "ClassFeePanel";
            this.ClassFeePanel.Size = new System.Drawing.Size(679, 749);
            this.ClassFeePanel.TabIndex = 4;
            // 
            // classNameComboBox
            // 
            this.classNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.classNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.classNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.classNameComboBox.FormattingEnabled = true;
            this.classNameComboBox.Location = new System.Drawing.Point(291, 164);
            this.classNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classNameComboBox.Name = "classNameComboBox";
            this.classNameComboBox.Size = new System.Drawing.Size(260, 33);
            this.classNameComboBox.TabIndex = 10;
            // 
            // classNameLabel
            // 
            this.classNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameLabel.Location = new System.Drawing.Point(40, 164);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(208, 34);
            this.classNameLabel.TabIndex = 9;
            this.classNameLabel.Text = "Class Name";
            // 
            // SubjectNameComboBox
            // 
            this.SubjectNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SubjectNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SubjectNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubjectNameComboBox.FormattingEnabled = true;
            this.SubjectNameComboBox.Location = new System.Drawing.Point(291, 267);
            this.SubjectNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectNameComboBox.Name = "SubjectNameComboBox";
            this.SubjectNameComboBox.Size = new System.Drawing.Size(260, 33);
            this.SubjectNameComboBox.TabIndex = 8;
            // 
            // subjectNameLabel
            // 
            this.subjectNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNameLabel.Location = new System.Drawing.Point(40, 266);
            this.subjectNameLabel.Name = "subjectNameLabel";
            this.subjectNameLabel.Size = new System.Drawing.Size(208, 34);
            this.subjectNameLabel.TabIndex = 7;
            this.subjectNameLabel.Text = "Subject Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(53, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class Lecture Fees";
            // 
            // feeSearchBtn
            // 
            this.feeSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.feeSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feeSearchBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.feeSearchBtn.Location = new System.Drawing.Point(347, 515);
            this.feeSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feeSearchBtn.Name = "feeSearchBtn";
            this.feeSearchBtn.Size = new System.Drawing.Size(123, 58);
            this.feeSearchBtn.TabIndex = 3;
            this.feeSearchBtn.Text = "Search";
            this.feeSearchBtn.UseVisualStyleBackColor = false;
            // 
            // feeDeleteBtn
            // 
            this.feeDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.feeDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feeDeleteBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeDeleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.feeDeleteBtn.Location = new System.Drawing.Point(525, 515);
            this.feeDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feeDeleteBtn.Name = "feeDeleteBtn";
            this.feeDeleteBtn.Size = new System.Drawing.Size(112, 58);
            this.feeDeleteBtn.TabIndex = 2;
            this.feeDeleteBtn.Text = "Delete";
            this.feeDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // FeeEditBtn
            // 
            this.FeeEditBtn.BackColor = System.Drawing.Color.Blue;
            this.FeeEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FeeEditBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeEditBtn.ForeColor = System.Drawing.Color.Transparent;
            this.FeeEditBtn.Location = new System.Drawing.Point(191, 515);
            this.FeeEditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeeEditBtn.Name = "FeeEditBtn";
            this.FeeEditBtn.Size = new System.Drawing.Size(107, 58);
            this.FeeEditBtn.TabIndex = 1;
            this.FeeEditBtn.Text = "Edit";
            this.FeeEditBtn.UseVisualStyleBackColor = false;
            // 
            // FeeRegisterBtn
            // 
            this.FeeRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FeeRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FeeRegisterBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeRegisterBtn.ForeColor = System.Drawing.Color.Transparent;
            this.FeeRegisterBtn.Location = new System.Drawing.Point(45, 515);
            this.FeeRegisterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeeRegisterBtn.Name = "FeeRegisterBtn";
            this.FeeRegisterBtn.Size = new System.Drawing.Size(116, 58);
            this.FeeRegisterBtn.TabIndex = 0;
            this.FeeRegisterBtn.Text = "Register";
            this.FeeRegisterBtn.UseVisualStyleBackColor = false;
            this.FeeRegisterBtn.Click += new System.EventHandler(this.FeeRegisterBtn_Click);
            // 
            // chargesLabel
            // 
            this.chargesLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargesLabel.Location = new System.Drawing.Point(40, 370);
            this.chargesLabel.Name = "chargesLabel";
            this.chargesLabel.Size = new System.Drawing.Size(130, 34);
            this.chargesLabel.TabIndex = 11;
            this.chargesLabel.Text = "Charges";
            // 
            // chargesTextBox
            // 
            this.chargesTextBox.Location = new System.Drawing.Point(291, 370);
            this.chargesTextBox.Name = "chargesTextBox";
            this.chargesTextBox.Size = new System.Drawing.Size(260, 31);
            this.chargesTextBox.TabIndex = 13;
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 749);
            this.Controls.Add(this.feesData);
            this.Controls.Add(this.ClassFeePanel);
            this.MaximumSize = new System.Drawing.Size(1491, 820);
            this.MinimumSize = new System.Drawing.Size(1491, 820);
            this.Name = "Expense";
            this.Text = "Expense";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feesData)).EndInit();
            this.ClassFeePanel.ResumeLayout(false);
            this.ClassFeePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView feesData;
        private System.Windows.Forms.Panel ClassFeePanel;
        private System.Windows.Forms.ComboBox classNameComboBox;
        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.ComboBox SubjectNameComboBox;
        private System.Windows.Forms.Label subjectNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button feeSearchBtn;
        private System.Windows.Forms.Button feeDeleteBtn;
        private System.Windows.Forms.Button FeeEditBtn;
        private System.Windows.Forms.Button FeeRegisterBtn;
        private System.Windows.Forms.Label chargesLabel;
        private System.Windows.Forms.TextBox chargesTextBox;
    }
}