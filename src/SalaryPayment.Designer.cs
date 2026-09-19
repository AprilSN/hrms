namespace HrmsProject
{
    partial class SalaryPayment
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
            this.pnlSalary = new System.Windows.Forms.Panel();
            this.pbSalary = new System.Windows.Forms.PictureBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblEmployeeSalary = new System.Windows.Forms.Label();
            this.lblEmployeeBonus = new System.Windows.Forms.Label();
            this.lblEmployeeDeduction = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.cbSalary = new System.Windows.Forms.ComboBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbBonus = new System.Windows.Forms.TextBox();
            this.tbPayment = new System.Windows.Forms.TextBox();
            this.tbDeduction = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSalary
            // 
            this.pnlSalary.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlSalary.Controls.Add(this.btnCancel);
            this.pnlSalary.Controls.Add(this.btnPay);
            this.pnlSalary.Controls.Add(this.btnCalculate);
            this.pnlSalary.Controls.Add(this.tbID);
            this.pnlSalary.Controls.Add(this.tbDeduction);
            this.pnlSalary.Controls.Add(this.tbPayment);
            this.pnlSalary.Controls.Add(this.tbBonus);
            this.pnlSalary.Controls.Add(this.tbDate);
            this.pnlSalary.Controls.Add(this.cbSalary);
            this.pnlSalary.Controls.Add(this.lblEmployeeID);
            this.pnlSalary.Controls.Add(this.lblDate);
            this.pnlSalary.Controls.Add(this.lblTotalPayment);
            this.pnlSalary.Controls.Add(this.lblEmployeeDeduction);
            this.pnlSalary.Controls.Add(this.lblEmployeeBonus);
            this.pnlSalary.Controls.Add(this.lblEmployeeSalary);
            this.pnlSalary.Controls.Add(this.lblSalary);
            this.pnlSalary.Controls.Add(this.pbSalary);
            this.pnlSalary.Location = new System.Drawing.Point(0, 0);
            this.pnlSalary.Name = "pnlSalary";
            this.pnlSalary.Size = new System.Drawing.Size(381, 303);
            this.pnlSalary.TabIndex = 0;
            // 
            // pbSalary
            // 
            this.pbSalary.Image = global::HrmsProject.Properties.Resources.pic15;
            this.pbSalary.Location = new System.Drawing.Point(12, 12);
            this.pbSalary.Name = "pbSalary";
            this.pbSalary.Size = new System.Drawing.Size(55, 50);
            this.pbSalary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalary.TabIndex = 0;
            this.pbSalary.TabStop = false;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSalary.Location = new System.Drawing.Point(70, 20);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(102, 31);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Salary";
            // 
            // lblEmployeeSalary
            // 
            this.lblEmployeeSalary.AutoSize = true;
            this.lblEmployeeSalary.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSalary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeSalary.Location = new System.Drawing.Point(12, 92);
            this.lblEmployeeSalary.Name = "lblEmployeeSalary";
            this.lblEmployeeSalary.Size = new System.Drawing.Size(51, 16);
            this.lblEmployeeSalary.TabIndex = 2;
            this.lblEmployeeSalary.Text = "Salary:";
            // 
            // lblEmployeeBonus
            // 
            this.lblEmployeeBonus.AutoSize = true;
            this.lblEmployeeBonus.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeBonus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeBonus.Location = new System.Drawing.Point(12, 134);
            this.lblEmployeeBonus.Name = "lblEmployeeBonus";
            this.lblEmployeeBonus.Size = new System.Drawing.Size(50, 16);
            this.lblEmployeeBonus.TabIndex = 3;
            this.lblEmployeeBonus.Text = "Bonus:";
            // 
            // lblEmployeeDeduction
            // 
            this.lblEmployeeDeduction.AutoSize = true;
            this.lblEmployeeDeduction.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDeduction.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeDeduction.Location = new System.Drawing.Point(12, 178);
            this.lblEmployeeDeduction.Name = "lblEmployeeDeduction";
            this.lblEmployeeDeduction.Size = new System.Drawing.Size(76, 16);
            this.lblEmployeeDeduction.TabIndex = 4;
            this.lblEmployeeDeduction.Text = "Deduction:";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalPayment.Location = new System.Drawing.Point(12, 223);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(102, 16);
            this.lblTotalPayment.TabIndex = 5;
            this.lblTotalPayment.Text = "Total Payment:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDate.Location = new System.Drawing.Point(199, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 16);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Pay Date:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeID.Location = new System.Drawing.Point(199, 12);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(92, 16);
            this.lblEmployeeID.TabIndex = 8;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // cbSalary
            // 
            this.cbSalary.BackColor = System.Drawing.Color.SeaShell;
            this.cbSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalary.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalary.FormattingEnabled = true;
            this.cbSalary.Items.AddRange(new object[] {
            "150,000",
            "200,000",
            "250,000",
            "300,000",
            "350,000",
            "400,000",
            "450,000",
            "500,000",
            "550,000",
            "600,000",
            "650,000",
            "700,000",
            "750,000",
            "800,000",
            "850,000",
            "900,000",
            "950,000",
            "1,000,000",
            "1,200,000",
            "1,500,000",
            "2,000,000",
            "3,000,000"});
            this.cbSalary.Location = new System.Drawing.Point(113, 87);
            this.cbSalary.Name = "cbSalary";
            this.cbSalary.Size = new System.Drawing.Size(254, 24);
            this.cbSalary.TabIndex = 32;
            // 
            // tbDate
            // 
            this.tbDate.Enabled = false;
            this.tbDate.Location = new System.Drawing.Point(267, 46);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 20);
            this.tbDate.TabIndex = 33;
            // 
            // tbBonus
            // 
            this.tbBonus.Location = new System.Drawing.Point(113, 131);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Size = new System.Drawing.Size(254, 20);
            this.tbBonus.TabIndex = 34;
            this.tbBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBonus_KeyPress);
            // 
            // tbPayment
            // 
            this.tbPayment.Enabled = false;
            this.tbPayment.Location = new System.Drawing.Point(113, 220);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(254, 20);
            this.tbPayment.TabIndex = 35;
            // 
            // tbDeduction
            // 
            this.tbDeduction.Location = new System.Drawing.Point(113, 178);
            this.tbDeduction.Name = "tbDeduction";
            this.tbDeduction.Size = new System.Drawing.Size(254, 20);
            this.tbDeduction.TabIndex = 36;
            this.tbDeduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDeduction_KeyPress);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(267, 9);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 37;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SeaShell;
            this.btnCalculate.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalculate.Location = new System.Drawing.Point(144, 259);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(89, 30);
            this.btnCalculate.TabIndex = 38;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.MouseEnter += new System.EventHandler(this.btnCalculate_MouseEnter);
            this.btnCalculate.MouseLeave += new System.EventHandler(this.btnCalculate_MouseLeave);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.SeaShell;
            this.btnPay.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPay.Location = new System.Drawing.Point(15, 259);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(73, 30);
            this.btnPay.TabIndex = 39;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.MouseEnter += new System.EventHandler(this.btnPay_MouseEnter);
            this.btnPay.MouseLeave += new System.EventHandler(this.btnPay_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.Location = new System.Drawing.Point(292, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // SalaryPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 301);
            this.Controls.Add(this.pnlSalary);
            this.Name = "SalaryPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Resources HR: Salary Payment";
            this.pnlSalary.ResumeLayout(false);
            this.pnlSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSalary;
        private System.Windows.Forms.PictureBox pbSalary;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblEmployeeDeduction;
        private System.Windows.Forms.Label lblEmployeeBonus;
        private System.Windows.Forms.Label lblEmployeeSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.ComboBox cbSalary;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbDeduction;
        private System.Windows.Forms.TextBox tbPayment;
        private System.Windows.Forms.TextBox tbBonus;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCalculate;
    }
}