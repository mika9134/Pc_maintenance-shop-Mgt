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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_2_Click(object sender, EventArgs e)
        {
            try
            {

                if(txtbox_admin.Text == "admin" && txtbox_password.Text == "admin")
                {
                    this.Hide();
                    frm_home fh = new frm_home();
                    fh.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Details", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbox_admin.Focus();
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
               
            
            if (checkBox1.Checked == true)
            {
                txtbox_password.UseSystemPasswordChar = false;

            }
            
            
                
            
        }

        private void txtbox_password_TextChanged(object sender, EventArgs e)
        {
            txtbox_password.UseSystemPasswordChar = true;
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            txtbox_admin.Focus();
        }
    }
}
