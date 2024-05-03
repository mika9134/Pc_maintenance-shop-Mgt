using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pc_maintainance_shop_Management
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_computers_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_computers.Height;
            SidePanel.Top = btn_computers.Top;
            uc_computers1.BringToFront();
        }

        private void btn_stocks_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_stocks.Height;
            SidePanel.Top = btn_stocks.Top;
            uc_stocks1.BringToFront();
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_employees.Height;
            SidePanel.Top = btn_employees.Top;
            uc_employees1.BringToFront();
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_billing.Height;
            SidePanel.Top = btn_billing.Top;
            uc_billing1.BringToFront();
        }

        private void btn_analytics_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_analytics.Height;
            SidePanel.Top = btn_analytics.Top;
            uc_analytics1.BringToFront();
        }
    }
}
