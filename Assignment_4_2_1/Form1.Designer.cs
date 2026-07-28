namespace Assignment_4_2_1
{
    partial class Form1
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
            txtOperand1 = new TextBox();
            txtOperand2 = new TextBox();
            chkSum = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkDifference = new CheckBox();
            txtSum = new TextBox();
            txtDifference = new TextBox();
            txtQuotient = new TextBox();
            txtProduct = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            chkQuotient = new CheckBox();
            chkProduct = new CheckBox();
            txtRoot = new TextBox();
            txtPower = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            chkRoot = new CheckBox();
            chkPower = new CheckBox();
            txtRemainder = new TextBox();
            chkRemainder = new CheckBox();
            label19 = new Label();
            label20 = new Label();
            SuspendLayout();
            // 
            // txtOperand1
            // 
            txtOperand1.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            txtOperand1.Location = new Point(16, 12);
            txtOperand1.Margin = new Padding(6);
            txtOperand1.Name = "txtOperand1";
            txtOperand1.Size = new Size(100, 31);
            txtOperand1.TabIndex = 0;
            txtOperand1.TextAlign = HorizontalAlignment.Center;
            txtOperand1.TextChanged += txtOperand1_TextChanged;
            // 
            // txtOperand2
            // 
            txtOperand2.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            txtOperand2.Location = new Point(127, 12);
            txtOperand2.Margin = new Padding(6);
            txtOperand2.Name = "txtOperand2";
            txtOperand2.Size = new Size(100, 31);
            txtOperand2.TabIndex = 1;
            txtOperand2.TextAlign = HorizontalAlignment.Center;
            txtOperand2.TextChanged += txtOperand2_TextChanged;
            // 
            // chkSum
            // 
            chkSum.AutoSize = true;
            chkSum.Checked = true;
            chkSum.CheckState = CheckState.Checked;
            chkSum.Font = new Font("Bauhaus 93", 12F);
            chkSum.Location = new Point(357, 47);
            chkSum.Name = "chkSum";
            chkSum.Size = new Size(55, 22);
            chkSum.TabIndex = 2;
            chkSum.Text = "Sum";
            chkSum.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 12F);
            label1.Location = new Point(35, 49);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 3;
            label1.Text = "Augend";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 12F);
            label2.Location = new Point(146, 49);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 3;
            label2.Text = "Addend";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 12F);
            label3.Location = new Point(31, 81);
            label3.Name = "label3";
            label3.Size = new Size(71, 18);
            label3.TabIndex = 3;
            label3.Text = "Minuend";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 12F);
            label4.Location = new Point(133, 81);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 3;
            label4.Text = "Subtrahend";
            // 
            // chkDifference
            // 
            chkDifference.AutoSize = true;
            chkDifference.Checked = true;
            chkDifference.CheckState = CheckState.Checked;
            chkDifference.Font = new Font("Bauhaus 93", 12F);
            chkDifference.Location = new Point(357, 79);
            chkDifference.Name = "chkDifference";
            chkDifference.Size = new Size(106, 22);
            chkDifference.TabIndex = 3;
            chkDifference.Text = "Difference";
            chkDifference.UseVisualStyleBackColor = true;
            // 
            // txtSum
            // 
            txtSum.BackColor = SystemColors.ActiveCaption;
            txtSum.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            txtSum.Location = new Point(251, 40);
            txtSum.Margin = new Padding(6);
            txtSum.Name = "txtSum";
            txtSum.ReadOnly = true;
            txtSum.Size = new Size(100, 31);
            txtSum.TabIndex = 10;
            txtSum.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDifference
            // 
            txtDifference.BackColor = SystemColors.ActiveCaption;
            txtDifference.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            txtDifference.Location = new Point(251, 72);
            txtDifference.Margin = new Padding(6);
            txtDifference.Name = "txtDifference";
            txtDifference.ReadOnly = true;
            txtDifference.Size = new Size(100, 31);
            txtDifference.TabIndex = 11;
            txtDifference.TextAlign = HorizontalAlignment.Center;
            // 
            // txtQuotient
            // 
            txtQuotient.BackColor = SystemColors.ActiveCaption;
            txtQuotient.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            txtQuotient.Location = new Point(251, 136);
            txtQuotient.Margin = new Padding(6);
            txtQuotient.Name = "txtQuotient";
            txtQuotient.ReadOnly = true;
            txtQuotient.Size = new Size(100, 31);
            txtQuotient.TabIndex = 13;
            txtQuotient.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProduct
            // 
            txtProduct.BackColor = SystemColors.ActiveCaption;
            txtProduct.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            txtProduct.Location = new Point(251, 104);
            txtProduct.Margin = new Padding(6);
            txtProduct.Name = "txtProduct";
            txtProduct.ReadOnly = true;
            txtProduct.Size = new Size(100, 31);
            txtProduct.TabIndex = 12;
            txtProduct.TextAlign = HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bauhaus 93", 12F);
            label15.Location = new Point(149, 145);
            label15.Name = "label15";
            label15.Size = new Size(56, 18);
            label15.TabIndex = 7;
            label15.Text = "Divisor";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bauhaus 93", 12F);
            label16.Location = new Point(138, 113);
            label16.Name = "label16";
            label16.Size = new Size(78, 18);
            label16.TabIndex = 8;
            label16.Text = "Multiplier";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bauhaus 93", 12F);
            label17.Location = new Point(30, 145);
            label17.Name = "label17";
            label17.Size = new Size(72, 18);
            label17.TabIndex = 9;
            label17.Text = "Dividend";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bauhaus 93", 12F);
            label18.Location = new Point(16, 113);
            label18.Name = "label18";
            label18.Size = new Size(100, 18);
            label18.TabIndex = 10;
            label18.Text = "Multiplicand";
            // 
            // chkQuotient
            // 
            chkQuotient.AutoSize = true;
            chkQuotient.Checked = true;
            chkQuotient.CheckState = CheckState.Checked;
            chkQuotient.Font = new Font("Bauhaus 93", 12F);
            chkQuotient.Location = new Point(357, 143);
            chkQuotient.Name = "chkQuotient";
            chkQuotient.Size = new Size(90, 22);
            chkQuotient.TabIndex = 5;
            chkQuotient.Text = "Quotient";
            chkQuotient.UseVisualStyleBackColor = true;
            // 
            // chkProduct
            // 
            chkProduct.AutoSize = true;
            chkProduct.Checked = true;
            chkProduct.CheckState = CheckState.Checked;
            chkProduct.Font = new Font("Bauhaus 93", 12F);
            chkProduct.Location = new Point(357, 111);
            chkProduct.Name = "chkProduct";
            chkProduct.Size = new Size(82, 22);
            chkProduct.TabIndex = 4;
            chkProduct.Text = "Product";
            chkProduct.UseVisualStyleBackColor = true;
            // 
            // txtRoot
            // 
            txtRoot.BackColor = SystemColors.ActiveCaption;
            txtRoot.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            txtRoot.Location = new Point(251, 232);
            txtRoot.Margin = new Padding(6);
            txtRoot.Name = "txtRoot";
            txtRoot.ReadOnly = true;
            txtRoot.Size = new Size(100, 31);
            txtRoot.TabIndex = 16;
            txtRoot.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPower
            // 
            txtPower.BackColor = SystemColors.ActiveCaption;
            txtPower.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            txtPower.Location = new Point(251, 200);
            txtPower.Margin = new Padding(6);
            txtPower.Name = "txtPower";
            txtPower.ReadOnly = true;
            txtPower.Size = new Size(100, 31);
            txtPower.TabIndex = 15;
            txtPower.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bauhaus 93", 12F);
            label5.Location = new Point(139, 241);
            label5.Name = "label5";
            label5.Size = new Size(77, 18);
            label5.TabIndex = 19;
            label5.Text = "Radicand";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bauhaus 93", 12F);
            label6.Location = new Point(140, 209);
            label6.Name = "label6";
            label6.Size = new Size(74, 18);
            label6.TabIndex = 20;
            label6.Text = "Exponent";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bauhaus 93", 12F);
            label9.Location = new Point(36, 241);
            label9.Name = "label9";
            label9.Size = new Size(61, 18);
            label9.TabIndex = 21;
            label9.Text = "Degree";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bauhaus 93", 12F);
            label10.Location = new Point(46, 209);
            label10.Name = "label10";
            label10.Size = new Size(41, 18);
            label10.TabIndex = 22;
            label10.Text = "Base";
            // 
            // chkRoot
            // 
            chkRoot.AutoSize = true;
            chkRoot.Font = new Font("Bauhaus 93", 12F);
            chkRoot.Location = new Point(357, 239);
            chkRoot.Name = "chkRoot";
            chkRoot.Size = new Size(60, 22);
            chkRoot.TabIndex = 8;
            chkRoot.Text = "Root";
            chkRoot.UseVisualStyleBackColor = true;
            // 
            // chkPower
            // 
            chkPower.AutoSize = true;
            chkPower.Font = new Font("Bauhaus 93", 12F);
            chkPower.Location = new Point(357, 207);
            chkPower.Name = "chkPower";
            chkPower.Size = new Size(71, 22);
            chkPower.TabIndex = 7;
            chkPower.Text = "Power";
            chkPower.UseVisualStyleBackColor = true;
            // 
            // txtRemainder
            // 
            txtRemainder.BackColor = SystemColors.ActiveCaption;
            txtRemainder.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            txtRemainder.Location = new Point(251, 168);
            txtRemainder.Margin = new Padding(6);
            txtRemainder.Name = "txtRemainder";
            txtRemainder.ReadOnly = true;
            txtRemainder.Size = new Size(100, 31);
            txtRemainder.TabIndex = 14;
            txtRemainder.TextAlign = HorizontalAlignment.Center;
            // 
            // chkRemainder
            // 
            chkRemainder.AutoSize = true;
            chkRemainder.Checked = true;
            chkRemainder.CheckState = CheckState.Checked;
            chkRemainder.Font = new Font("Bauhaus 93", 12F);
            chkRemainder.Location = new Point(357, 175);
            chkRemainder.Name = "chkRemainder";
            chkRemainder.Size = new Size(104, 22);
            chkRemainder.TabIndex = 6;
            chkRemainder.Text = "Remainder";
            chkRemainder.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bauhaus 93", 12F);
            label19.Location = new Point(30, 177);
            label19.Name = "label19";
            label19.Size = new Size(72, 18);
            label19.TabIndex = 9;
            label19.Text = "Dividend";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Bauhaus 93", 12F);
            label20.Location = new Point(135, 177);
            label20.Name = "label20";
            label20.Size = new Size(85, 18);
            label20.TabIndex = 7;
            label20.Text = "Remainder";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 274);
            Controls.Add(txtRoot);
            Controls.Add(txtPower);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(chkRoot);
            Controls.Add(chkPower);
            Controls.Add(txtRemainder);
            Controls.Add(chkRemainder);
            Controls.Add(txtQuotient);
            Controls.Add(txtProduct);
            Controls.Add(label20);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label19);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(chkQuotient);
            Controls.Add(chkProduct);
            Controls.Add(txtDifference);
            Controls.Add(txtSum);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(chkDifference);
            Controls.Add(chkSum);
            Controls.Add(txtOperand2);
            Controls.Add(txtOperand1);
            Name = "Form1";
            Text = "C Flat Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOperand1;
        private TextBox txtOperand2;
        private CheckBox chkSum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkDifference;
        private TextBox txtSum;
        private TextBox txtDifference;
        private TextBox txtQuotient;
        private TextBox txtProduct;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private CheckBox chkQuotient;
        private CheckBox chkProduct;
        private TextBox txtRoot;
        private TextBox txtPower;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private CheckBox chkRoot;
        private CheckBox chkPower;
        private TextBox txtRemainder;
        private CheckBox chkRemainder;
        private Label label19;
        private Label label20;
    }
}
