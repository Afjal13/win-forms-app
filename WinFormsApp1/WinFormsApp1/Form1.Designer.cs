namespace WinFormsApp1
{
    partial class EmployeeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EmpInfoPanel = new Panel();
            txtCity = new TextBox();
            txtSalary = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblId = new Label();
            lblCity = new Label();
            lblSalary = new Label();
            lblName = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            button4 = new Button();
            txtSearchId = new TextBox();
            label2 = new Label();
            EmployeedataGridView = new DataGridView();
            EmpInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeedataGridView).BeginInit();
            SuspendLayout();
            // 
            // EmpInfoPanel
            // 
            EmpInfoPanel.BackColor = Color.DarkCyan;
            EmpInfoPanel.Controls.Add(txtCity);
            EmpInfoPanel.Controls.Add(txtSalary);
            EmpInfoPanel.Controls.Add(txtName);
            EmpInfoPanel.Controls.Add(txtId);
            EmpInfoPanel.Controls.Add(lblId);
            EmpInfoPanel.Controls.Add(lblCity);
            EmpInfoPanel.Controls.Add(lblSalary);
            EmpInfoPanel.Controls.Add(lblName);
            EmpInfoPanel.Location = new Point(105, 83);
            EmpInfoPanel.Name = "EmpInfoPanel";
            EmpInfoPanel.Size = new Size(679, 215);
            EmpInfoPanel.TabIndex = 0;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(319, 163);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(321, 27);
            txtCity.TabIndex = 9;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(319, 122);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(321, 27);
            txtSalary.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(319, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(321, 27);
            txtName.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(319, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(321, 27);
            txtId.TabIndex = 10;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(13, 28);
            lblId.Name = "lblId";
            lblId.Size = new Size(146, 32);
            lblId.TabIndex = 5;
            lblId.Text = "Employee Id";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCity.ForeColor = Color.White;
            lblCity.Location = new Point(13, 163);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(167, 32);
            lblCity.TabIndex = 4;
            lblCity.Text = "Employee City";
            lblCity.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalary.ForeColor = Color.White;
            lblSalary.Location = new Point(13, 116);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(189, 32);
            lblSalary.TabIndex = 3;
            lblSalary.Text = "Employee Salary";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(13, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(197, 32);
            lblName.TabIndex = 2;
            lblName.Text = "Employee Name ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(204, 9);
            label1.Name = "label1";
            label1.Size = new Size(481, 54);
            label1.TabIndex = 1;
            label1.Text = "Employee Management ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(690, 319);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(357, 319);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(527, 319);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(660, 373);
            button4.Name = "button4";
            button4.Size = new Size(124, 29);
            button4.TabIndex = 5;
            button4.Text = "Find Employee";
            button4.UseVisualStyleBackColor = true;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(357, 373);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new Size(269, 27);
            txtSearchId.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(118, 370);
            label2.Name = "label2";
            label2.Size = new Size(208, 32);
            label2.TabIndex = 10;
            label2.Text = "Enter Employee Id";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // EmployeedataGridView
            // 
            EmployeedataGridView.BackgroundColor = SystemColors.ActiveCaption;
            EmployeedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeedataGridView.Location = new Point(12, 417);
            EmployeedataGridView.Name = "EmployeedataGridView";
            EmployeedataGridView.RowHeadersWidth = 51;
            EmployeedataGridView.RowTemplate.Height = 29;
            EmployeedataGridView.Size = new Size(935, 143);
            EmployeedataGridView.TabIndex = 11;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Teal;
            ClientSize = new Size(958, 573);
            Controls.Add(EmployeedataGridView);
            Controls.Add(label2);
            Controls.Add(txtSearchId);
            Controls.Add(button4);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(EmpInfoPanel);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Management ";
            EmpInfoPanel.ResumeLayout(false);
            EmpInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeedataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel EmpInfoPanel;
        private Label label1;
        private Label lblCity;
        private Label lblSalary;
        private Label lblName;
        private Label lblId;
        private TextBox txtCity;
        private TextBox txtSalary;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Button button4;
        private TextBox txtSearchId;
        private Label label2;
        private DataGridView EmployeedataGridView;
    }
}
