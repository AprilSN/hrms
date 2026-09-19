using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsProject
{
    public partial class RegisterationForm : Form
    {
        public RegisterationForm()
        {
            InitializeComponent();
        }



        private void btnHaveAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            string userName = tbName.Text;
            string userPhone = tbPhone.Text;
            string userEmail = tbEmail.Text;
            string userAddress = tbAddress.Text;
            string userPassword = tbPassword.Text;
            string userConfirmation = tbConfirmation.Text;
            string userPosition;
            if (rbtnManager.Checked == true)
            {
                userPosition = "Manager";
            }
            else if (rbtnAdmin.Checked == true)
            {
                userPosition = "Administrator";
            }
            else
            {
                userPosition = "Inquirer";
            }
            
            MySqlCommand command = new MySqlCommand("INSERT INTO `user_info_table`(`user_name`,`user_phone`,`user_email`,`user_address`,`user_password`,`user_confirmation`,`user_position`) VALUES (@name,@phone,@email,@address,@password,@confirm,@position);", databaseConnection.getConnection());

            command.Parameters.AddWithValue("@name", userName);
            command.Parameters.AddWithValue("@phone", userPhone);
            command.Parameters.AddWithValue("@email", userEmail);
            command.Parameters.AddWithValue("@address", userAddress);
            command.Parameters.AddWithValue("@password", userPassword);
            command.Parameters.AddWithValue("@confirm", userConfirmation);
            command.Parameters.AddWithValue("@position", userPosition);

            databaseConnection.openConnection();

            Regex regex = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            
            if (!CheckTextBoxesValues())
            {
                if (tbPassword.Text.Equals(tbConfirmation.Text) && cbAgreement.Checked == true)
                {
                    if (checkUserEmail())
                    {
                        MessageBox.Show("Fail Registration." + Environment.NewLine + "Email Address already exists.", "Duplicate Email", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        tbEmail.Clear();
                    }
                    else
                    {
                        if (!regex.IsMatch(tbEmail.Text))
                        {
                            MessageBox.Show("Please Enter Valid Email Address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbEmail.Clear();
                        }
                        else
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("User Registration Successful!" + Environment.NewLine + "Account Created for User Role as " + userPosition + ".", "Account Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("System Error!!!", "Registration Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            }

                            databaseConnection.closeConnection();

                            this.Hide();
                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                        }
                    }
                }
                else
                {
                    if (cbAgreement.Checked == false)
                    {
                        MessageBox.Show("Please Check the Agreement before registration", "User Agreement", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Your Password does not match with Confirmation." + Environment.NewLine + "Please Enter the same passwords.", "Password not Match", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        tbPassword.Clear();
                        tbConfirmation.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill the Registration Form Completely.", "Incomplete User Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private Boolean CheckTextBoxesValues()
        {
            string userName = tbName.Text;
            string userPhone = tbPhone.Text;
            string userEmail = tbEmail.Text;
            string userAddress = tbAddress.Text;
            string userPassword = tbPassword.Text;
            string userConfirmation = tbConfirmation.Text;

            if (userName.Equals("") || userPhone.Equals("") || userEmail.Equals("") || userAddress.Equals("") || userPassword.Equals("") || userConfirmation.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkUserEmail()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            string userEmail = tbEmail.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adaptor = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user_info_table` WHERE `user_email` = @email;", databaseConnection.getConnection());

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userEmail;
            //command.Parameters.Add("@password", MySqlDbType.VarChar).Value = userPassword;

            adaptor.SelectCommand = command;

            adaptor.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void rbtnManager_MouseEnter(object sender, EventArgs e)
        {
            rbtnManager.ForeColor = Color.SeaShell;
        }

        private void rbtnManager_MouseLeave(object sender, EventArgs e)
        {
            rbtnManager.ForeColor = SystemColors.ControlDarkDark;
        }

        private void rbtnAdmin_MouseEnter(object sender, EventArgs e)
        {
            rbtnAdmin.ForeColor = Color.SeaShell;
        }

        private void rbtnAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            //nothing
        }

        private void rbtnAdmin_MouseLeave(object sender, EventArgs e)
        {
            rbtnAdmin.ForeColor = SystemColors.ControlDarkDark;
        }

        private void rbtnInquirer_MouseEnter(object sender, EventArgs e)
        {
            rbtnInquirer.ForeColor = Color.SeaShell;
        }

        private void rbtnInquirer_MouseLeave(object sender, EventArgs e)
        {
            rbtnInquirer.ForeColor = SystemColors.ControlDarkDark;
        }

        private void cbAgreement_MouseEnter(object sender, EventArgs e)
        {
            cbAgreement.ForeColor = Color.SeaShell;
        }

        private void cbAgreement_MouseLeave(object sender, EventArgs e)
        {
            cbAgreement.ForeColor = SystemColors.ControlDarkDark;
        }

        private void btnHaveAccount_MouseEnter(object sender, EventArgs e)
        {
            btnHaveAccount.BackColor = Color.MistyRose;
        }

        private void btnHaveAccount_MouseLeave(object sender, EventArgs e)
        {
            btnHaveAccount.BackColor = Color.SeaShell;
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.MistyRose;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.SeaShell;
        }
    }
}
