using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsProject
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            cbNRCRegionNo.SelectedIndex = 0;
            cbNRCRegion.SelectedIndex = 0;
            cbPosition.SelectedIndex = 0;
            cbDepartment.SelectedIndex = 0;
            cbSalary.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNRCCode_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDateClick_Click(object sender, EventArgs e)
        {
            tbStartDate.Text = DateTime.Now.ToShortDateString();
        }

        private void rbtnMale_MouseEnter(object sender, EventArgs e)
        {
            rbtnMale.ForeColor = Color.Chocolate;
        }

        private void rbtnMale_MouseLeave(object sender, EventArgs e)
        {
            rbtnMale.ForeColor = SystemColors.ControlDarkDark;
        }

        private void rbtnFemale_MouseEnter(object sender, EventArgs e)
        {
            rbtnFemale.ForeColor = Color.Chocolate;
        }

        private void rbtnFemale_MouseLeave(object sender, EventArgs e)
        {
            rbtnFemale.ForeColor = SystemColors.ControlDarkDark;
        }

        private void btnDateClick_MouseEnter(object sender, EventArgs e)
        {
            btnDateClick.BackColor = Color.MistyRose;
        }

        private void btnDateClick_MouseLeave(object sender, EventArgs e)
        {
            btnDateClick.BackColor = Color.SeaShell;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.MistyRose;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.SeaShell;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.MistyRose;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.SeaShell;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            
            string employeeID = tbEmployeeID.Text;
            string employeeFName = tbFirstName.Text;
            string employeeLName = tbLastName.Text;
            DateTime employeeDOB = dtpDOB.Value;
            int employeeAge = DateTime.Today.Year - dtpDOB.Value.Year;
            string nrcNo = cbNRCRegionNo.Items[cbNRCRegionNo.SelectedIndex].ToString();
            string nrcRegion = cbNRCRegion.Items[cbNRCRegion.SelectedIndex].ToString();
            string nrcCode = tbNRCCode.Text;
            string employeeNRC =$"{nrcNo}{nrcRegion}(N){nrcCode}";
            string employeeGender;
            if (rbtnMale.Checked == true)
            {
                employeeGender = "Male";
            }
            else
            {
                employeeGender = "Female";
            }
            string employeeAddress = tbAddress.Text;
            string employeeEmail = tbEmail.Text;
            string employeeContact = tbContact.Text;
            string startDate = DateTime.Now.ToShortDateString();
            DateTime employeeStartDate = Convert.ToDateTime(startDate);
            string employeePosition = cbPosition.Items[cbPosition.SelectedIndex].ToString();
            string employeeDepartment = cbDepartment.Items[cbDepartment.SelectedIndex].ToString();
            CultureInfo cultures = new CultureInfo("en-US");
            string eSalary = cbSalary.Items[cbSalary.SelectedIndex].ToString();
            decimal employeeSalary = Convert.ToDecimal(eSalary,cultures);

            if (!CheckTextBoxesValues())
            {
                if (!checkEmployeeID())
                {
                    int minimumAge = 20;
                    int maximumAge = 60;
                    int nrcLength = 6;
                    if (employeeAge > minimumAge && employeeAge < maximumAge)
                    {
                        int inputNRCLength = tbNRCCode.Text.Length;
                        if (inputNRCLength == nrcLength)
                        {
                            Regex regex = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                            if (!regex.IsMatch(tbEmail.Text))
                            {
                                MessageBox.Show("Please Enter Valid Email Address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tbEmail.Clear();
                            }
                            else
                            {
                                if (checkEmployeeEmail())
                                {
                                    MessageBox.Show("Fail Registration." + Environment.NewLine + "Email Address already exists.", "Duplicate Email", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                    tbEmail.Clear();
                                }
                                else
                                {
                                    MySqlCommand command = new MySqlCommand("INSERT INTO `hrms_employee_database`.`employee_info_table` (`employee_self_id`, `employee_first_name`, `employee_last_name`, `employee_date_of_birth`, `employee_age`, `employee_nrc_code`, `employee_gender`, `employee_address`, `employee_email`, `employee_contact`, `employee_start_date`, `employee_position`, `employee_department`, `employee_salary`) VALUES(@id,@fname,@lname,@dob,@age,@nrc,@gender,@address,@email,@phone,@start,@position,@department,@salary);", databaseConnection.getConnection());

                                    //(@id, @fname, @lname, @dob, @age, @nrc, @gender, @address, @email, @phone, @start, @position, @department, @salary

                                    command.Parameters.AddWithValue("@id", employeeID);
                                    command.Parameters.AddWithValue("@fname", employeeFName);
                                    command.Parameters.AddWithValue("@lname", employeeLName);
                                    command.Parameters.AddWithValue("@dob", employeeDOB);
                                    command.Parameters.AddWithValue("@age", employeeAge);
                                    command.Parameters.AddWithValue("@nrc", employeeNRC);
                                    command.Parameters.AddWithValue("@gender", employeeGender);
                                    command.Parameters.AddWithValue("@address", employeeAddress);
                                    command.Parameters.AddWithValue("@email", employeeEmail);
                                    command.Parameters.AddWithValue("@phone", employeeContact);
                                    command.Parameters.AddWithValue("@start", employeeStartDate);
                                    command.Parameters.AddWithValue("@position", employeePosition);
                                    command.Parameters.AddWithValue("@department", employeeDepartment);
                                    command.Parameters.AddWithValue("@salary", employeeSalary);

                                    databaseConnection.openConnection();
                                    if (command.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("Adding Employee Successful!" + Environment.NewLine + "Employee Added for the Department: " + employeeDepartment + " as Position: " + employeePosition + ".", "Add Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("System Error!!!", "Add Employee Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                    }

                                    databaseConnection.closeConnection();

                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Entered NRC Code is not valid.", "Invalid NRC Code", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Meaningless Data in Date of Birth Section.", "Invalid Birthday", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Fail Registration." + Environment.NewLine + "Employee ID cannot be Dublicate.", "Duplicate ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    tbEmail.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Fill the Form Completely.", "Incomplete Employee Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private Boolean CheckTextBoxesValues()
        {
            string employeeID = tbEmployeeID.Text;
            string employeeFName = tbFirstName.Text;
            string employeeLName = tbLastName.Text;
            string employeeNRC = tbNRCCode.Text;
            string employeeAddress = tbAddress.Text;
            string employeeEmail = tbEmail.Text;
            string employeeContact = tbContact.Text;

            if (employeeID.Equals("") || employeeFName.Equals("") || employeeLName.Equals("") || employeeNRC.Equals("") || employeeAddress.Equals("") || employeeEmail.Equals("") || employeeContact.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean checkEmployeeEmail()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            string employeeEmail = tbEmail.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adaptor = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee_info_table` WHERE `employee_email` = @email;", databaseConnection.getConnection());

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = employeeEmail;
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
        public Boolean checkEmployeeID()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            string employeeID = tbEmployeeID.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adaptor = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee_info_table` WHERE `employee_self_id` = @id;", databaseConnection.getConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = employeeID;
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
    }
}
