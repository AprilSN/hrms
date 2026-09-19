using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterationForm registrationForm = new RegisterationForm();
            registrationForm.Show();
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            string userEmail = tbEmail.Text;
            string userPassword = tbPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adaptor = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `user_position` FROM `user_info_table` WHERE `user_email` = @email and `user_password` = @password;",databaseConnection.getConnection());

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value =userEmail;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = userPassword;

            if(userEmail.Equals("") || userPassword.Equals(""))
            {
                MessageBox.Show("Please Fill the Login Form Completely.", "Login Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                adaptor.SelectCommand = command;

                adaptor.Fill(table);

                if (table.Rows.Count > 0)
                {
                    string role = "";
                    try
                    {
                        databaseConnection.openConnection();
                        switch (role = command.ExecuteScalar().ToString())
                        {
                            case "Administrator":
                                this.Hide();
                                AdminForm adminForm = new AdminForm();
                                adminForm.Show();
                                break;
                            case "Manager":
                                this.Hide();
                                ManagerForm managerForm = new ManagerForm();
                                managerForm.Show();
                                break;
                            default:
                                this.Hide();
                                InquirerForm inquirerForm = new InquirerForm();
                                inquirerForm.Show();
                                break;

                        }
                        databaseConnection.closeConnection();
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Email or Password." + Environment.NewLine + "please Try Again!", "Login Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    tbEmail.Clear();
                    tbPassword.Clear();
                }
            }
        }

        private void lblRegister_MouseEnter(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.SeaShell;
        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            lblRegister.ForeColor = SystemColors.ControlDarkDark;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.MistyRose;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.SeaShell;
        }
    }
};
