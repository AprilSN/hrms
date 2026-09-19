using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class InquirerForm : Form
    {
        public List<EmployeeModel> employeeModels { get; set; }
        public InquirerForm()
        {
            employeeModels = GetEmployee();
            InitializeComponent();
        }

        private List<EmployeeModel> GetEmployee()
        {
            var listEmployee = new List<EmployeeModel>();
            listEmployee.Add(new EmployeeModel()
            {
                Employee_ID = 123,
                Employee_First_Name = "Alex",
                Employee_Last_Name = "Marco",
                Date_Of_Birth = "1/12/1990",
                Employee_NRC_Code = "12/SaKhaNa(N)019967",
                Employee_Gender = "Male",
                Employee_Address = "No(20), 12th Street, NYA.",
                Employee_Email = "alexjmarco20@gmail.com",
                Employee_Contact = "4259875898",
                Employee_Start_Date = "12/12/2008",
                Employee_Position = "Managing Director",
                Employee_Department = "Management",
                Employee_Salary = 1000000
            });
            listEmployee.Add(new EmployeeModel()
            {
                Employee_ID = 456,
                Employee_First_Name = "Alex",
                Employee_Last_Name = "Marco",
                Date_Of_Birth = "1/12/1990",
                Employee_NRC_Code = "12/SaKhaNa(N)019967",
                Employee_Gender = "Male",
                Employee_Address = "No(20), 12th Street, NYA.",
                Employee_Email = "alexjmarco20@gmail.com",
                Employee_Contact = "4259875898",
                Employee_Start_Date = "12/12/2008",
                Employee_Position = "Managing Director",
                Employee_Department = "Management",
                Employee_Salary = 1000000
            });
            listEmployee.Add(new EmployeeModel()
            {
                Employee_ID = 789,
                Employee_First_Name = "Alex",
                Employee_Last_Name = "Marco",
                Date_Of_Birth = "1/12/1990",
                Employee_NRC_Code = "12/SaKhaNa(N)019967",
                Employee_Gender = "Male",
                Employee_Address = "No(20), 12th Street, NYA.",
                Employee_Email = "alexjmarco20@gmail.com",
                Employee_Contact = "4259875898",
                Employee_Start_Date = "12/12/2008",
                Employee_Position = "Managing Director",
                Employee_Department = "Management",
                Employee_Salary = 1000000
            });
            return listEmployee;
        }

        private void InquirerForm_Load(object sender, EventArgs e)
        {
            var employee = this.employeeModels;
            dgvEmployeeList.DataSource = employee;
            GetEmployeeID();
        }

        private void GetEmployeeID()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adaptor = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `employee_self_id` FROM `employee_info_table`;", databaseConnection.getConnection());

            adaptor.SelectCommand = command;

            adaptor.Fill(table);

            if (table.Rows.Count > 0)
            {
                databaseConnection.openConnection();
                var reader = command.ExecuteReader();
                ArrayList Authors = new ArrayList();

                while (reader.Read())
                {
                    Authors.Add(new AddValue
                        (reader.GetInt32(0)));

                }
                databaseConnection.closeConnection();

                for (int i = 0; i < Authors.Count; i++)
                {
                    cbEmployeeID.Items.Add(Authors[i]);
                }
            }
            else
            {
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.MistyRose;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.SeaShell;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.MistyRose;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.SeaShell;
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.MistyRose;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.SeaShell;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.MistyRose;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.SeaShell;
        }

        private void btnQuit_MouseEnter(object sender, EventArgs e)
        {
            btnQuit.BackColor = Color.MistyRose;
        }

        private void btnQuit_MouseLeave(object sender, EventArgs e)
        {
            btnQuit.BackColor = Color.SeaShell;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
