namespace HrmsProject
{
    partial class InquirerForm
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
            this.pnlInquirer = new System.Windows.Forms.Panel();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblComplanyName2 = new System.Windows.Forms.Label();
            this.lblComplanyName1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlInquirer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.pnlEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInquirer
            // 
            this.pnlInquirer.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlInquirer.Controls.Add(this.dgvEmployeeList);
            this.pnlInquirer.Controls.Add(this.lblEmployeeList);
            this.pnlInquirer.Controls.Add(this.btnQuit);
            this.pnlInquirer.Controls.Add(this.btnDelete);
            this.pnlInquirer.Controls.Add(this.btnEdit);
            this.pnlInquirer.Controls.Add(this.pnlEmployeeInfo);
            this.pnlInquirer.Controls.Add(this.label1);
            this.pnlInquirer.Controls.Add(this.pictureBox1);
            this.pnlInquirer.Controls.Add(this.btnAdd);
            this.pnlInquirer.Controls.Add(this.lblComplanyName2);
            this.pnlInquirer.Controls.Add(this.lblComplanyName1);
            this.pnlInquirer.Controls.Add(this.pbLogo);
            this.pnlInquirer.Location = new System.Drawing.Point(0, 0);
            this.pnlInquirer.Name = "pnlInquirer";
            this.pnlInquirer.Size = new System.Drawing.Size(801, 449);
            this.pnlInquirer.TabIndex = 0;
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Location = new System.Drawing.Point(280, 96);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.Size = new System.Drawing.Size(508, 309);
            this.dgvEmployeeList.TabIndex = 42;
            // 
            // lblEmployeeList
            // 
            this.lblEmployeeList.AutoSize = true;
            this.lblEmployeeList.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeList.Location = new System.Drawing.Point(440, 60);
            this.lblEmployeeList.Name = "lblEmployeeList";
            this.lblEmployeeList.Size = new System.Drawing.Size(198, 31);
            this.lblEmployeeList.TabIndex = 41;
            this.lblEmployeeList.Text = "Employees List";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.SeaShell;
            this.btnQuit.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQuit.Location = new System.Drawing.Point(736, 411);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(52, 27);
            this.btnQuit.TabIndex = 38;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.MouseEnter += new System.EventHandler(this.btnQuit_MouseEnter);
            this.btnQuit.MouseLeave += new System.EventHandler(this.btnQuit_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaShell;
            this.btnDelete.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Location = new System.Drawing.Point(585, 411);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 27);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaShell;
            this.btnEdit.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEdit.Location = new System.Drawing.Point(430, 411);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(52, 27);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnEdit_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
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
            this.pnlEmployeeInfo.Location = new System.Drawing.Point(12, 62);
            this.pnlEmployeeInfo.Name = "pnlEmployeeInfo";
            this.pnlEmployeeInfo.Size = new System.Drawing.Size(262, 384);
            this.pnlEmployeeInfo.TabIndex = 31;
            // 
            // cbEmployeeID
            // 
            this.cbEmployeeID.FormattingEnabled = true;
            this.cbEmployeeID.Location = new System.Drawing.Point(83, 31);
            this.cbEmployeeID.Name = "cbEmployeeID";
            this.cbEmployeeID.Size = new System.Drawing.Size(121, 25);
            this.cbEmployeeID.TabIndex = 42;
            // 
            // tbSalary
            // 
            this.tbSalary.Enabled = false;
            this.tbSalary.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary.Location = new System.Drawing.Point(83, 355);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(174, 25);
            this.tbSalary.TabIndex = 41;
            // 
            // tbDepartment
            // 
            this.tbDepartment.Enabled = false;
            this.tbDepartment.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepartment.Location = new System.Drawing.Point(83, 328);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(174, 25);
            this.tbDepartment.TabIndex = 40;
            // 
            // tbPosition
            // 
            this.tbPosition.Enabled = false;
            this.tbPosition.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.Location = new System.Drawing.Point(83, 301);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(174, 25);
            this.tbPosition.TabIndex = 39;
            // 
            // tbGender
            // 
            this.tbGender.Enabled = false;
            this.tbGender.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGender.Location = new System.Drawing.Point(83, 166);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(174, 25);
            this.tbGender.TabIndex = 38;
            // 
            // tbDOB
            // 
            this.tbDOB.Enabled = false;
            this.tbDOB.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDOB.Location = new System.Drawing.Point(83, 112);
            this.tbDOB.Name = "tbDOB";
            this.tbDOB.Size = new System.Drawing.Size(174, 25);
            this.tbDOB.TabIndex = 37;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaShell;
            this.btnSearch.Font = new System.Drawing.Font("MV Boli", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Location = new System.Drawing.Point(205, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 27);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // tbNRCCode
            // 
            this.tbNRCCode.Enabled = false;
            this.tbNRCCode.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNRCCode.Location = new System.Drawing.Point(83, 139);
            this.tbNRCCode.Name = "tbNRCCode";
            this.tbNRCCode.Size = new System.Drawing.Size(174, 25);
            this.tbNRCCode.TabIndex = 12;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSalary.Location = new System.Drawing.Point(1, 358);
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
            this.lblDepartment.Location = new System.Drawing.Point(1, 331);
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
            this.lblEmployeeID.Location = new System.Drawing.Point(1, 34);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(75, 16);
            this.lblEmployeeID.TabIndex = 21;
            this.lblEmployeeID.Text = "Employee ID:\r\n";
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(83, 85);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(174, 25);
            this.tbLastName.TabIndex = 19;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Enabled = false;
            this.tbStartDate.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartDate.Location = new System.Drawing.Point(83, 274);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(174, 25);
            this.tbStartDate.TabIndex = 17;
            // 
            // tbContact
            // 
            this.tbContact.Enabled = false;
            this.tbContact.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(83, 247);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(174, 25);
            this.tbContact.TabIndex = 16;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(83, 220);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(174, 25);
            this.tbEmail.TabIndex = 15;
            // 
            // tbAddress
            // 
            this.tbAddress.Enabled = false;
            this.tbAddress.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(83, 193);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(174, 25);
            this.tbAddress.TabIndex = 14;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(83, 58);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(174, 25);
            this.tbFirstName.TabIndex = 11;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPosition.Location = new System.Drawing.Point(1, 304);
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
            this.lblStartDate.Location = new System.Drawing.Point(1, 277);
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
            this.lblContact.Location = new System.Drawing.Point(1, 250);
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
            this.lblEmail.Location = new System.Drawing.Point(1, 223);
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
            this.lblAddress.Location = new System.Drawing.Point(1, 196);
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
            this.lblGender.Location = new System.Drawing.Point(1, 169);
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
            this.lblNRC.Location = new System.Drawing.Point(1, 142);
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
            this.lblDOB.Location = new System.Drawing.Point(1, 115);
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
            this.lblLastName.Location = new System.Drawing.Point(1, 88);
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
            this.lblFirstName.Location = new System.Drawing.Point(1, 61);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.AutoSize = true;
            this.lblEmployeeInfo.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeInfo.Location = new System.Drawing.Point(62, 4);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(141, 21);
            this.lblEmployeeInfo.TabIndex = 0;
            this.lblEmployeeInfo.Text = "Employee\'s Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "INQUIRER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HrmsProject.Properties.Resources.pic11;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaShell;
            this.btnAdd.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.Location = new System.Drawing.Point(280, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 27);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // lblComplanyName2
            // 
            this.lblComplanyName2.AutoSize = true;
            this.lblComplanyName2.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplanyName2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblComplanyName2.Location = new System.Drawing.Point(537, 39);
            this.lblComplanyName2.Name = "lblComplanyName2";
            this.lblComplanyName2.Size = new System.Drawing.Size(196, 24);
            this.lblComplanyName2.TabIndex = 9;
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
            this.lblComplanyName1.TabIndex = 8;
            this.lblComplanyName1.Text = "UlTIMATE";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::HrmsProject.Properties.Resources.pic1;
            this.pbLogo.Location = new System.Drawing.Point(735, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(53, 51);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // InquirerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlInquirer);
            this.Name = "InquirerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Resources HR: Inquirer Form";
            this.Load += new System.EventHandler(this.InquirerForm_Load);
            this.pnlInquirer.ResumeLayout(false);
            this.pnlInquirer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.pnlEmployeeInfo.ResumeLayout(false);
            this.pnlEmployeeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInquirer;
        private System.Windows.Forms.Label lblComplanyName2;
        private System.Windows.Forms.Label lblComplanyName1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEmployeeInfo;
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
        private System.Windows.Forms.Label lblEmployeeList;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbDOB;
        private System.Windows.Forms.ComboBox cbEmployeeID;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
    }
}