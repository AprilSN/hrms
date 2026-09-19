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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnManageUser_MouseEnter(object sender, EventArgs e)
        {
            btnManageUser.BackColor = Color.MistyRose;
        }

        private void btnManageUser_MouseLeave(object sender, EventArgs e)
        {
            btnManageUser.BackColor = Color.SeaShell;
        }

        private void btnManageEmployee_MouseEnter(object sender, EventArgs e)
        {
            btnManageEmployee.BackColor = Color.MistyRose;
        }

        private void btnManageEmployee_MouseLeave(object sender, EventArgs e)
        {
            btnManageEmployee.BackColor = Color.SeaShell;
        }

        private void btnMonitorProgress_MouseEnter(object sender, EventArgs e)
        {
            btnMonitorProgress.BackColor = Color.MistyRose;
        }

        private void btnMonitorProgress_MouseLeave(object sender, EventArgs e)
        {
            btnMonitorProgress.BackColor = Color.SeaShell;
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