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
    public partial class EmployeePayment : Form
    {
        public List<EmployeeModel> employeeModels { get; set; }
        public EmployeePayment()
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


        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void EmployeePayment_Load(object sender, EventArgs e)
        {
            var employee = this.employeeModels;
            dgvEmployeeList.DataSource = employee;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            SalaryPayment salaryPayment = new SalaryPayment();
            salaryPayment.Show();
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.MistyRose;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.SeaShell;
        }

        private void btnPay_MouseEnter(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.MistyRose;
        }

        private void btnPay_MouseLeave(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.SeaShell;
        }

        private void btnQuit_MouseEnter(object sender, EventArgs e)
        {
            btnQuit.BackColor = Color.MistyRose;
        }

        private void btnQuit_MouseLeave(object sender, EventArgs e)
        {
            btnQuit.BackColor = Color.SeaShell;
        }
    }
}
