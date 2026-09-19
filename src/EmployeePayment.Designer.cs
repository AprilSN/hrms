namespace HrmsProject
{
    partial class EmployeePayment
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
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.pnlEmployeeInfo = new System.Windows.Forms.Panel();
            this.cbEmployeeID = new System.Windows.Forms.ComboBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbDOB = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbNRCCode = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNRC = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmployeeInfo = new System.Windows.Forms.Label();
            this.lblComplanyName2 = new System.Windows.Forms.Label();
            this.lblComplanyName1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.pnlEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlEmployee.Controls.Add(this.lblComplanyName2);
            this.pnlEmployee.Controls.Add(this.lblComplanyName1);
            this.pnlEmployee.Controls.Add(this.pbLogo);
            this.pnlEmployee.Controls.Add(this.dgvEmployeeList);
            this.pnlEmployee.Controls.Add(this.lblEmployeeList);
            this.pnlEmployee.Controls.Add(this.btnQuit);
            this.pnlEmployee.Controls.Add(this.pnlEmployeeInfo);
            this.pnlEmployee.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(800, 452);
            this.pnlEmployee.TabIndex = 0;
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Location = new System.Drawing.Point(274, 99);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.Size = new System.Drawing.Size(514, 306);
            this.dgvEmployeeList.TabIndex = 47;
            // 
            // lblEmployeeList
            // 
            this.lblEmployeeList.AutoSize = true;
            this.lblEmployeeList.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeList.Location = new System.Drawing.Point(434, 63);
            this.lblEmployeeList.Name = "lblEmployeeList";
            this.lblEmployeeList.Size = new System.Drawing.Size(198, 31);
            this.lblEmployeeList.TabIndex = 46;
            this.lblEmployeeList.Text = "Employees List";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.SeaShell;
            this.btnQuit.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQuit.Location = new System.Drawing.Point(527, 411);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(52, 27);
            this.btnQuit.TabIndex = 44;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.MouseEnter += new System.EventHandler(this.btnQuit_MouseEnter);
            this.btnQuit.MouseLeave += new System.EventHandler(this.btnQuit_MouseLeave);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.SeaShell;
            this.btnPay.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPay.Location = new System.Drawing.Point(96, 396);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(66, 27);
            this.btnPay.TabIndex = 45;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            this.btnPay.MouseEnter += new System.EventHandler(this.btnPay_MouseEnter);
            this.btnPay.MouseLeave += new System.EventHandler(this.btnPay_MouseLeave);
            // 
            // pnlEmployeeInfo
            // 
            this.pnlEmployeeInfo.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlEmployeeInfo.Controls.Add(this.cbEmployeeID);
            this.pnlEmployeeInfo.Controls.Add(this.tbSalary);
            this.pnlEmployeeInfo.Controls.Add(this.tbDepartment);
            this.pnlEmployeeInfo.Controls.Add(this.tbPosition);
            this.pnlEmployeeInfo.Controls.Add(this.tbGender);
            this.pnlEmployeeInfo.Controls.Add(this.tbDOB);
            this.pnlEmployeeInfo.Controls.Add(this.btnPay);
            this.pnlEmployeeInfo.Controls.Add(this.btnSearch);
            this.pnlEmployeeInfo.Controls.Add(this.tbNRCCode);
            this.pnlEmployeeInfo.Controls.Add(this.lblSalary);
            this.pnlEmployeeInfo.Controls.Add(this.lblDepartment);
            this.pnlEmployeeInfo.Controls.Add(this.lblEmployeeID);
            this.pnlEmployeeInfo.Controls.Add(this.tbLastName);
            this.pnlEmployeeInfo.Controls.Add(this.tbStartDate);
            this.pnlEmployeeInfo.Controls.Add(this.tbContact);
            this.pnlEmployeeInfo.Controls.Add(this.tbEmail);
            this.pnlEmployeeInfo.Controls.Add(this.tbAddress);
            this.pnlEmployeeInfo.Controls.Add(this.tbFirstName);
            this.pnlEmployeeInfo.Controls.Add(this.lblPosition);
            this.pnlEmployeeInfo.Controls.Add(this.lblStartDate);
            this.pnlEmployeeInfo.Controls.Add(this.lblContact);
            this.pnlEmployeeInfo.Controls.Add(this.lblEmail);
            this.pnlEmployeeInfo.Controls.Add(this.lblAddress);
            this.pnlEmployeeInfo.Controls.Add(this.lblGender);
            this.pnlEmployeeInfo.Controls.Add(this.lblNRC);
            this.pnlEmployeeInfo.Controls.Add(this.lblDOB);
            this.pnlEmployeeInfo.Controls.Add(this.lblLastName);
            this.pnlEmployeeInfo.Controls.Add(this.lblFirstName);
            this.pnlEmployeeInfo.Controls.Add(this.lblEmployeeInfo);
            this.pnlEmployeeInfo.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEmployeeInfo.Location = new System.Drawing.Point(6, 15);
            this.pnlEmployeeInfo.Name = "pnlEmployeeInfo";
            this.pnlEmployeeInfo.Size = new System.Drawing.Size(262, 430);
            this.pnlEmployeeInfo.TabIndex = 43;
            // 
            // cbEmployeeID
            // 
            this.cbEmployeeID.FormattingEnabled = true;
            this.cbEmployeeID.Location = new System.Drawing.Point(85, 40);
            this.cbEmployeeID.Name = "cbEmployeeID";
            this.cbEmployeeID.Size = new System.Drawing.Size(121, 25);
            this.cbEmployeeID.TabIndex = 42;
            // 
            // tbSalary
            // 
            this.tbSalary.Enabled = false;
            this.tbSalary.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary.Location = new System.Drawing.Point(85, 364);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(174, 25);
            this.tbSalary.TabIndex = 41;
            // 
            // tbDepartment
            // 
            this.tbDepartment.Enabled = false;
            this.tbDepartment.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepartment.Location = new System.Drawing.Point(85, 337);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(174, 25);
            this.tbDepartment.TabIndex = 40;
            // 
            // tbPosition
            // 
            this.tbPosition.Enabled = false;
            this.tbPosition.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.Location = new System.Drawing.Point(85, 310);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(174, 25);
            this.tbPosition.TabIndex = 39;
            // 
            // tbGender
            // 
            this.tbGender.Enabled = false;
            this.tbGender.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGender.Location = new System.Drawing.Point(85, 175);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(174, 25);
            this.tbGender.TabIndex = 38;
            // 
            // tbDOB
            // 
            this.tbDOB.Enabled = false;
            this.tbDOB.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDOB.Location = new System.Drawing.Point(85, 121);
            this.tbDOB.Name = "tbDOB";
            this.tbDOB.Size = new System.Drawing.Size(174, 25);
            this.tbDOB.TabIndex = 37;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaShell;
            this.btnSearch.Font = new System.Drawing.Font("MV Boli", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Location = new System.Drawing.Point(207, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 27);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // tbNRCCode
            // 
            this.tbNRCCode.Enabled = false;
            this.tbNRCCode.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNRCCode.Location = new System.Drawing.Point(85, 148);
            this.tbNRCCode.Name = "tbNRCCode";
            this.tbNRCCode.Size = new System.Drawing.Size(174, 25);
            this.tbNRCCode.TabIndex = 12;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSalary.Location = new System.Drawing.Point(3, 367);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(43, 16);
            this.lblSalary.TabIndex = 23;
            this.lblSalary.Text = "Salary:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDepartment.Location = new System.Drawing.Point(3, 340);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(73, 16);
            this.lblDepartment.TabIndex = 22;
            this.lblDepartment.Text = "Department:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeID.Location = new System.Drawing.Point(3, 43);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(75, 16);
            this.lblEmployeeID.TabIndex = 21;
            this.lblEmployeeID.Text = "Employee ID:\r\n";
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(85, 94);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(174, 25);
            this.tbLastName.TabIndex = 19;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Enabled = false;
            this.tbStartDate.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartDate.Location = new System.Drawing.Point(85, 283);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(174, 25);
            this.tbStartDate.TabIndex = 17;
            // 
            // tbContact
            // 
            this.tbContact.Enabled = false;
            this.tbContact.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(85, 256);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(174, 25);
            this.tbContact.TabIndex = 16;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(85, 229);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(174, 25);
            this.tbEmail.TabIndex = 15;
            // 
            // tbAddress
            // 
            this.tbAddress.Enabled = false;
            this.tbAddress.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(85, 202);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(174, 25);
            this.tbAddress.TabIndex = 14;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(85, 67);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(174, 25);
            this.tbFirstName.TabIndex = 11;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPosition.Location = new System.Drawing.Point(3, 313);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(54, 16);
            this.lblPosition.TabIndex = 10;
            this.lblPosition.Text = "Position:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStartDate.Location = new System.Drawing.Point(3, 286);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(70, 16);
            this.lblStartDate.TabIndex = 9;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContact.Location = new System.Drawing.Point(3, 259);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(53, 16);
            this.lblContact.TabIndex = 8;
            this.lblContact.Text = "Contact:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(3, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 16);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAddress.Location = new System.Drawing.Point(3, 205);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 16);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGender.Location = new System.Drawing.Point(3, 178);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(47, 16);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender:";
            // 
            // lblNRC
            // 
            this.lblNRC.AutoSize = true;
            this.lblNRC.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRC.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNRC.Location = new System.Drawing.Point(3, 151);
            this.lblNRC.Name = "lblNRC";
            this.lblNRC.Size = new System.Drawing.Size(65, 16);
            this.lblNRC.TabIndex = 4;
            this.lblNRC.Text = "NRC Code:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDOB.Location = new System.Drawing.Point(3, 124);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(83, 16);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLastName.Location = new System.Drawing.Point(3, 97);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(68, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFirstName.Location = new System.Drawing.Point(3, 70);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.AutoSize = true;
            this.lblEmployeeInfo.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeInfo.Location = new System.Drawing.Point(40, 6);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(178, 28);
            this.lblEmployeeInfo.TabIndex = 0;
            this.lblEmployeeInfo.Text = "Employee\'s Info";
            // 
            // lblComplanyName2
            // 
            this.lblComplanyName2.AutoSize = true;
            this.lblComplanyName2.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplanyName2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblComplanyName2.Location = new System.Drawing.Point(537, 39);
            this.lblComplanyName2.Name = "lblComplanyName2";
            this.lblComplanyName2.Size = new System.Drawing.Size(196, 24);
            this.lblComplanyName2.TabIndex = 50;
            this.lblComplanyName2.Text = "RESOURCES HR";
            // 
            // lblComplanyName1
            // 
            this.lblComplanyName1.AutoSize = true;
            this.lblComplanyName1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplanyName1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblComplanyName1.Location = new System.Drawing.Point(597, 15);
            this.lblComplanyName1.Name = "lblComplanyName1";
            this.lblComplanyName1.Size = new System.Drawing.Size(135, 24);
            this.lblComplanyName1.TabIndex = 49;
            this.lblComplanyName1.Text = "UlTIMATE";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::HrmsProject.Properties.Resources.pic1;
            this.pbLogo.Location = new System.Drawing.Point(735, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(53, 51);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 48;
            this.pbLogo.TabStop = false;
            // 
            // EmployeePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlEmployee);
            this.Name = "EmployeePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Resources HR: Employee Payment";
            this.Load += new System.EventHandler(this.EmployeePayment_Load);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.pnlEmployeeInfo.ResumeLayout(false);
            this.pnlEmployeeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.Label lblEmployeeList;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel pnlEmployeeInfo;
        private System.Windows.Forms.ComboBox cbEmployeeID;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbDOB;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbNRCCode;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNRC;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmployeeInfo;
        private System.Windows.Forms.Label lblComplanyName2;
        private System.Windows.Forms.Label lblComplanyName1;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}