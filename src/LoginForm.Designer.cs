namespace HrmsProject
{
    partial class LoginForm
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegisterGuide = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLoginGuide = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblComplanyName2 = new System.Windows.Forms.Label();
            this.lblComplanyName1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbWelcome = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlLogin.Controls.Add(this.lblRegister);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblRegisterGuide);
            this.pnlLogin.Controls.Add(this.tbPassword);
            this.pnlLogin.Controls.Add(this.tbEmail);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblEmail);
            this.pnlLogin.Controls.Add(this.lblLoginGuide);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.lblComplanyName2);
            this.pnlLogin.Controls.Add(this.lblComplanyName1);
            this.pnlLogin.Controls.Add(this.pbLogo);
            this.pnlLogin.Controls.Add(this.pbWelcome);
            this.pnlLogin.Location = new System.Drawing.Point(1, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(800, 450);
            this.pnlLogin.TabIndex = 0;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRegister.Location = new System.Drawing.Point(557, 345);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(103, 16);
            this.lblRegister.TabIndex = 12;
            this.lblRegister.Text = "REGISTER>>";
            this.lblRegister.Click += new System.EventHandler(this.label1_Click);
            this.lblRegister.MouseEnter += new System.EventHandler(this.lblRegister_MouseEnter);
            this.lblRegister.MouseLeave += new System.EventHandler(this.lblRegister_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SeaShell;
            this.btnLogin.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogin.Location = new System.Drawing.Point(566, 287);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 30);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // lblRegisterGuide
            // 
            this.lblRegisterGuide.AutoSize = true;
            this.lblRegisterGuide.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterGuide.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRegisterGuide.Location = new System.Drawing.Point(520, 324);
            this.lblRegisterGuide.Name = "lblRegisterGuide";
            this.lblRegisterGuide.Size = new System.Drawing.Size(178, 16);
            this.lblRegisterGuide.TabIndex = 10;
            this.lblRegisterGuide.Text = "Haven\'t got an account yet?";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.SeaShell;
            this.tbPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbPassword.Location = new System.Drawing.Point(397, 227);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(391, 20);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.SeaShell;
            this.tbEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbEmail.Location = new System.Drawing.Point(397, 166);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(391, 20);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmail_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPassword.Location = new System.Drawing.Point(394, 199);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 18);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(394, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 18);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "EMAIL:";
            // 
            // lblLoginGuide
            // 
            this.lblLoginGuide.AutoSize = true;
            this.lblLoginGuide.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginGuide.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLoginGuide.Location = new System.Drawing.Point(529, 107);
            this.lblLoginGuide.Name = "lblLoginGuide";
            this.lblLoginGuide.Size = new System.Drawing.Size(158, 14);
            this.lblLoginGuide.TabIndex = 5;
            this.lblLoginGuide.Text = "Sign in with your account";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLogin.Location = new System.Drawing.Point(554, 79);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(99, 29);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "LOGIN";
            // 
            // lblComplanyName2
            // 
            this.lblComplanyName2.AutoSize = true;
            this.lblComplanyName2.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplanyName2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblComplanyName2.Location = new System.Drawing.Point(538, 38);
            this.lblComplanyName2.Name = "lblComplanyName2";
            this.lblComplanyName2.Size = new System.Drawing.Size(196, 24);
            this.lblComplanyName2.TabIndex = 3;
            this.lblComplanyName2.Text = "RESOURCES HR";
            // 
            // lblComplanyName1
            // 
            this.lblComplanyName1.AutoSize = true;
            this.lblComplanyName1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplanyName1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblComplanyName1.Location = new System.Drawing.Point(598, 14);
            this.lblComplanyName1.Name = "lblComplanyName1";
            this.lblComplanyName1.Size = new System.Drawing.Size(135, 24);
            this.lblComplanyName1.TabIndex = 2;
            this.lblComplanyName1.Text = "UlTIMATE";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::HrmsProject.Properties.Resources.pic1;
            this.pbLogo.Location = new System.Drawing.Point(735, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(53, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pbWelcome
            // 
            this.pbWelcome.Image = global::HrmsProject.Properties.Resources.pic__2_;
            this.pbWelcome.Location = new System.Drawing.Point(0, 0);
            this.pbWelcome.Name = "pbWelcome";
            this.pbWelcome.Size = new System.Drawing.Size(388, 449);
            this.pbWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWelcome.TabIndex = 0;
            this.pbWelcome.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 451);
            this.Controls.Add(this.pnlLogin);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Resources HR: Login Form";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegisterGuide;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLoginGuide;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblComplanyName2;
        private System.Windows.Forms.Label lblComplanyName1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbWelcome;
    }
}

