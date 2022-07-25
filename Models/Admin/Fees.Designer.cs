namespace StudentMgntSystem.Models.Admin
{
    partial class FeesForm
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
            this.FeesData = new System.Windows.Forms.DataGridView();
            this.FeesPanel = new System.Windows.Forms.Panel();
            this.feesClassNameComboBox = new System.Windows.Forms.ComboBox();
            this.feesClassNameLabel = new System.Windows.Forms.Label();
            this.feesLabel = new System.Windows.Forms.Label();
            this.feesTextBox = new System.Windows.Forms.TextBox();
            this.feesLabelName = new System.Windows.Forms.Label();
            this.FeesSearchBtn = new System.Windows.Forms.Button();
            this.FeesDeleteBtn = new System.Windows.Forms.Button();
            this.FeesEditBtn = new System.Windows.Forms.Button();
            this.FeesRegisterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FeesData)).BeginInit();
            this.FeesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FeesData
            // 
            this.FeesData.AllowUserToOrderColumns = true;
            this.FeesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.FeesData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.FeesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeesData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.FeesData.Location = new System.Drawing.Point(679, 0);
            this.FeesData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeesData.Name = "FeesData";
            this.FeesData.RowHeadersVisible = false;
            this.FeesData.RowHeadersWidth = 82;
            this.FeesData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FeesData.RowTemplate.Height = 33;
            this.FeesData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FeesData.Size = new System.Drawing.Size(788, 752);
            this.FeesData.TabIndex = 3;
            this.FeesData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeesData_CellClick);
            // 
            // FeesPanel
            // 
            this.FeesPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.FeesPanel.Controls.Add(this.feesClassNameComboBox);
            this.FeesPanel.Controls.Add(this.feesClassNameLabel);
            this.FeesPanel.Controls.Add(this.feesLabel);
            this.FeesPanel.Controls.Add(this.feesTextBox);
            this.FeesPanel.Controls.Add(this.feesLabelName);
            this.FeesPanel.Controls.Add(this.FeesSearchBtn);
            this.FeesPanel.Controls.Add(this.FeesDeleteBtn);
            this.FeesPanel.Controls.Add(this.FeesEditBtn);
            this.FeesPanel.Controls.Add(this.FeesRegisterBtn);
            this.FeesPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FeesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FeesPanel.Location = new System.Drawing.Point(0, 0);
            this.FeesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeesPanel.Name = "FeesPanel";
            this.FeesPanel.Size = new System.Drawing.Size(679, 752);
            this.FeesPanel.TabIndex = 2;
            // 
            // feesClassNameComboBox
            // 
            this.feesClassNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.feesClassNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.feesClassNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feesClassNameComboBox.FormattingEnabled = true;
            this.feesClassNameComboBox.Location = new System.Drawing.Point(291, 194);
            this.feesClassNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feesClassNameComboBox.Name = "feesClassNameComboBox";
            this.feesClassNameComboBox.Size = new System.Drawing.Size(260, 33);
            this.feesClassNameComboBox.TabIndex = 6;
            // 
            // feesClassNameLabel
            // 
            this.feesClassNameLabel.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesClassNameLabel.Location = new System.Drawing.Point(45, 192);
            this.feesClassNameLabel.Name = "feesClassNameLabel";
            this.feesClassNameLabel.Size = new System.Drawing.Size(208, 34);
            this.feesClassNameLabel.TabIndex = 0;
            this.feesClassNameLabel.Text = "Class Name";
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesLabel.ForeColor = System.Drawing.Color.Maroon;
            this.feesLabel.Location = new System.Drawing.Point(117, 74);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(319, 47);
            this.feesLabel.TabIndex = 1;
            this.feesLabel.Text = "Fees Registration";
            // 
            // feesTextBox
            // 
            this.feesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feesTextBox.Location = new System.Drawing.Point(291, 266);
            this.feesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feesTextBox.Multiline = true;
            this.feesTextBox.Name = "feesTextBox";
            this.feesTextBox.Size = new System.Drawing.Size(261, 46);
            this.feesTextBox.TabIndex = 5;
            // 
            // feesLabelName
            // 
            this.feesLabelName.AutoSize = true;
            this.feesLabelName.Font = new System.Drawing.Font("Sitka Small", 7.874999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesLabelName.Location = new System.Drawing.Point(40, 282);
            this.feesLabelName.Name = "feesLabelName";
            this.feesLabelName.Size = new System.Drawing.Size(62, 30);
            this.feesLabelName.TabIndex = 4;
            this.feesLabelName.Text = "Fees";
            // 
            // FeesSearchBtn
            // 
            this.FeesSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FeesSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FeesSearchBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.FeesSearchBtn.Location = new System.Drawing.Point(347, 515);
            this.FeesSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeesSearchBtn.Name = "FeesSearchBtn";
            this.FeesSearchBtn.Size = new System.Drawing.Size(123, 58);
            this.FeesSearchBtn.TabIndex = 3;
            this.FeesSearchBtn.Text = "Search";
            this.FeesSearchBtn.UseVisualStyleBackColor = false;
            this.FeesSearchBtn.Click += new System.EventHandler(this.FeesSearchBtn_Click);
            // 
            // FeesDeleteBtn
            // 
            this.FeesDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.FeesDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FeesDeleteBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesDeleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.FeesDeleteBtn.Location = new System.Drawing.Point(525, 515);
            this.FeesDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeesDeleteBtn.Name = "FeesDeleteBtn";
            this.FeesDeleteBtn.Size = new System.Drawing.Size(112, 58);
            this.FeesDeleteBtn.TabIndex = 2;
            this.FeesDeleteBtn.Text = "Delete";
            this.FeesDeleteBtn.UseVisualStyleBackColor = false;
            this.FeesDeleteBtn.Click += new System.EventHandler(this.FeesDeleteBtn_Click);
            // 
            // FeesEditBtn
            // 
            this.FeesEditBtn.BackColor = System.Drawing.Color.Blue;
            this.FeesEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FeesEditBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesEditBtn.ForeColor = System.Drawing.Color.Transparent;
            this.FeesEditBtn.Location = new System.Drawing.Point(191, 515);
            this.FeesEditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeesEditBtn.Name = "FeesEditBtn";
            this.FeesEditBtn.Size = new System.Drawing.Size(107, 58);
            this.FeesEditBtn.TabIndex = 1;
            this.FeesEditBtn.Text = "Edit";
            this.FeesEditBtn.UseVisualStyleBackColor = false;
            this.FeesEditBtn.Click += new System.EventHandler(this.FeesEditBtn_Click);
            // 
            // FeesRegisterBtn
            // 
            this.FeesRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FeesRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FeesRegisterBtn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesRegisterBtn.ForeColor = System.Drawing.Color.Transparent;
            this.FeesRegisterBtn.Location = new System.Drawing.Point(45, 515);
            this.FeesRegisterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeesRegisterBtn.Name = "FeesRegisterBtn";
            this.FeesRegisterBtn.Size = new System.Drawing.Size(116, 58);
            this.FeesRegisterBtn.TabIndex = 0;
            this.FeesRegisterBtn.Text = "Register";
            this.FeesRegisterBtn.UseVisualStyleBackColor = false;
            this.FeesRegisterBtn.Click += new System.EventHandler(this.FeesRegisterBtn_Click);
            // 
            // FeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 752);
            this.Controls.Add(this.FeesData);
            this.Controls.Add(this.FeesPanel);
            this.MaximumSize = new System.Drawing.Size(1493, 823);
            this.MinimumSize = new System.Drawing.Size(1493, 823);
            this.Name = "FeesForm";
            this.Text = "Fees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeesData)).EndInit();
            this.FeesPanel.ResumeLayout(false);
            this.FeesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FeesData;
        private System.Windows.Forms.Panel FeesPanel;
        private System.Windows.Forms.ComboBox feesClassNameComboBox;
        private System.Windows.Forms.Label feesClassNameLabel;
        private System.Windows.Forms.Label feesLabel;
        private System.Windows.Forms.TextBox feesTextBox;
        private System.Windows.Forms.Label feesLabelName;
        private System.Windows.Forms.Button FeesSearchBtn;
        private System.Windows.Forms.Button FeesDeleteBtn;
        private System.Windows.Forms.Button FeesEditBtn;
        private System.Windows.Forms.Button FeesRegisterBtn;
    }
}