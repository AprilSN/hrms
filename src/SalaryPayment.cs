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
    public partial class SalaryPayment : Form
    {
        public SalaryPayment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbDeduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPay_MouseEnter(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.MistyRose;
        }

        private void btnPay_MouseLeave(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.SeaShell;
        }

        private void btnCalculate_MouseEnter(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.MistyRose;
        }

        private void btnCalculate_MouseLeave(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.SeaShell;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.MistyRose;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.SeaShell;
        }
    }
}
