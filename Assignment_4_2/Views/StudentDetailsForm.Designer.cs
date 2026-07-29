namespace Assignment_4_2
{
    partial class StudentDetailsForm
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
            txtStudentID = new TextBox();
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtMonthOfAdmission = new TextBox();
            label5 = new Label();
            txtGrade = new TextBox();
            label6 = new Label();
            btnDelete = new Button();
            btnAddNew = new Button();
            dataGridView1 = new DataGridView();
            btnNext = new Button();
            btnPrev = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(89, 23);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(100, 23);
            txtStudentID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(89, 64);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(164, 23);
            txtFirstName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 72);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(492, 64);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(164, 23);
            txtAddress.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 101);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(89, 93);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(164, 23);
            txtLastName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 72);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // txtMonthOfAdmission
            // 
            txtMonthOfAdmission.Location = new Point(556, 23);
            txtMonthOfAdmission.Name = "txtMonthOfAdmission";
            txtMonthOfAdmission.Size = new Size(100, 23);
            txtMonthOfAdmission.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 31);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 8;
            label5.Text = "Month of Admission";
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(246, 23);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(100, 23);
            txtGrade.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 31);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 10;
            label6.Text = "Grade";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(371, 113);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 27);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(274, 113);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(91, 27);
            btnAddNew.TabIndex = 12;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(644, 178);
            dataGridView1.TabIndex = 13;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(569, 113);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(91, 27);
            btnNext.TabIndex = 11;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(472, 113);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(91, 27);
            btnPrev.TabIndex = 12;
            btnPrev.Text = "Previous";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // StudentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 349);
            Controls.Add(dataGridView1);
            Controls.Add(btnPrev);
            Controls.Add(btnAddNew);
            Controls.Add(btnNext);
            Controls.Add(btnDelete);
            Controls.Add(label6);
            Controls.Add(txtGrade);
            Controls.Add(label5);
            Controls.Add(txtMonthOfAdmission);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStudentID);
            Name = "StudentDetailsForm";
            Text = "Student Editor Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtMonthOfAdmission;
        private Label label5;
        private TextBox txtGrade;
        private Label label6;
        private Button btnDelete;
        private Button btnAddNew;
        private DataGridView dataGridView1;
        private Button btnNext;
        private Button btnPrev;
    }
}