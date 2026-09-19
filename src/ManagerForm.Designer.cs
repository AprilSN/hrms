namespace HrmsProject
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.pnlManager = new System.Windows.Forms.Panel();
            this.lblComplanyName2 = new System.Windows.Forms.Label();
            this.lblComplanyName1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.dgvPaymentHistory = new System.Windows.Forms.DataGridView();
            this.lblPaymentHistory = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbManager = new System.Windows.Forms.PictureBox();
            this.pnlManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManager
            // 
            this.pnlManager.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlManager.Controls.Add(this.lblManager);
            this.pnlManager.Controls.Add(this.lblPaymentHistory);
            this.pnlManager.Controls.Add(this.dgvPaymentHistory);
            this.pnlManager.Controls.Add(this.btnQuit);
            this.pnlManager.Controls.Add(this.btnPay);
            this.pnlManager.Controls.Add(this.lblComplanyName2);
            this.pnlManager.Controls.Add(this.lblComplanyName1);
            this.pnlManager.Controls.Add(this.pbLogo);
            this.pnlManager.Controls.Add(this.pbManager);
            this.pnlManager.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlManager.Location = new System.Drawing.Point(0, -1);
            this.pnlManager.Name = "pnlManager";
            this.pnlManager.Size = new System.Drawing.Size(800, 451);
            this.pnlManager.TabIndex = 0;
            // 
            // lblComplanyName2
            // 
            this.lblComplanyName2.AutoSize = true;
            this.lblComplanyName2.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplanyName2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblComplanyName2.Location = new System.Drawing.Point(537, 39);
            this.lblComplanyName2.Name = "lblComplanyName2";
            this.lblComplanyName2.Size = new System.Drawing.Size(196, 24);
            this.lblComplanyName2.TabIndex = 28;
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
            this.lblComplanyName1.TabIndex = 27;
            this.lblComplanyName1.Text = "UlTIMATE";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.SeaShell;
            this.btnPay.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPay.Location = new System.Drawing.Point(12, 415);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(109, 23);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "PAY SALARY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            this.btnPay.MouseEnter += new System.EventHandler(this.btnPay_MouseEnter);
            this.btnPay.MouseLeave += new System.EventHandler(this.btnPay_MouseLeave);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.SeaShell;
            this.btnQuit.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQuit.Location = new System.Drawing.Point(713, 415);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 34;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.MouseEnter += new System.EventHandler(this.btnQuit_MouseEnter);
            this.btnQuit.MouseLeave += new System.EventHandler(this.btnQuit_MouseLeave);
            // 
            // dgvPaymentHistory
            // 
            this.dgvPaymentHistory.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentHistory.Location = new System.Drawing.Point(77, 94);
            this.dgvPaymentHistory.Name = "dgvPaymentHistory";
            this.dgvPaymentHistory.Size = new System.Drawing.Size(643, 318);
            this.dgvPaymentHistory.TabIndex = 35;
            // 
            // lblPaymentHistory
            // 
            this.lblPaymentHistory.AutoSize = true;
            this.lblPaymentHistory.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentHistory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPaymentHistory.Location = new System.Drawing.Point(233, 66);
            this.lblPaymentHistory.Name = "lblPaymentHistory";
            this.lblPaymentHistory.Size = new System.Drawing.Size(340, 25);
            this.lblPaymentHistory.TabIndex = 36;
            this.lblPaymentHistory.Text = "Payment Transections History";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblManager.Location = new System.Drawing.Point(69, 22);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(168, 31);
            this.lblManager.TabIndex = 37;
            this.lblManager.Text = "MANAGER";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(735, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(53, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 26;
            this.pbLogo.TabStop = false;
            // 
            // pbManager
            // 
            this.pbManager.Image = global::HrmsProject.Properties.Resources.pic13;
            this.pbManager.Location = new System.Drawing.Point(12, 13);
            this.pbManager.Name = "pbManager";
            this.pbManager.Size = new System.Drawing.Size(55, 50);
            this.pbManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbManager.TabIndex = 0;
            this.pbManager.TabStop = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlManager);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Resources HR: Manager Form";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.pnlManager.ResumeLayout(false);
            this.pnlManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManager;
        private System.Windows.Forms.PictureBox pbManager;
        private System.Windows.Forms.Label lblComplanyName2;
        private System.Windows.Forms.Label lblComplanyName1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblPaymentHistory;
        private System.Windows.Forms.DataGridView dgvPaymentHistory;
        private System.Windows.Forms.Label lblManager;
    }
}