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
    public partial class ManagerForm : Form
    {
        public List<PaymentModel> paymentModels { get; set; }
        public ManagerForm()
        {
            paymentModels = GetPayment();
            InitializeComponent();
        }

        private List<PaymentModel> GetPayment()
        {
            var listPayment = new List<PaymentModel>();
            listPayment.Add(new PaymentModel()
            {
                Employee_ID = 123,
                Employee_Salary = 1000000,
                Employee_Bonus = 20000,
                Employee_Deduction = 10000,
                Total_Payment = 1010000,
                Payment_Date = "3/1/2020"
            });
            listPayment.Add(new PaymentModel()
            {
                Employee_ID = 456,
                Employee_Salary = 1000000,
                Employee_Bonus = 30000,
                Employee_Deduction = 15000,
                Total_Payment = 1015000,
                Payment_Date = "3/2/2020"
            });
            listPayment.Add(new PaymentModel()
            {
                Employee_ID = 789,
                Employee_Salary = 1000000,
                Employee_Bonus = 20000,
                Employee_Deduction = 15000,
                Total_Payment = 1005000,
                Payment_Date = "3/2/2020"
            });
            return listPayment;
        }
        
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            var payment = this.paymentModels;
            dgvPaymentHistory.DataSource = payment;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeePayment employeePayment = new EmployeePayment();
            employeePayment.Show();
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
