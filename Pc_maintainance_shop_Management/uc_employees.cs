using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pc_maintainance_shop_Management
{
    public partial class uc_employees : UserControl
    {
        connection conn = new connection();
        public uc_employees()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ename.Text == "")
                {
                    MessageBox.Show("Please enter employee name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ename.Focus();

                }
                else if (txt_erole.Text == "")
                {
                    MessageBox.Show("Please enter employee role.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_erole.Focus();
                }
                else if (txt_eadress.Text == "")
                {
                    MessageBox.Show("Please enter employee adress.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_eadress.Focus();
                }
                else if (cmb_egender.Text == "")
                {
                    MessageBox.Show("Please enter employee gender.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_egender.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);
                    con.Open();
                    string str = "Insert Into db_employee (ename,egender,eroll,eadress)Values ('" + txt_ename.Text + "','" + cmb_egender.Text + "','" + txt_erole.Text + "','" + txt_eadress.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(ename) From db_employee";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();
                    if (da.Read())
                    {
                        MessageBox.Show("Employee information inserted successfully", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        showdata();
                    }
                    else
                    {
                        MessageBox.Show("Insertion is unsuccessful", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txt_ename.Clear();
            txt_erole.Clear();
            txt_eadress.Clear();
            cmb_egender.Text = "";

        }

        private void showdata()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);
                con.Open();
                string str = " Select * From db_employee";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                db_employeeDataGridView.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ename.Text == "")
                {
                    MessageBox.Show("Please enter employee name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ename.Focus();

                }
                else if (txt_erole.Text == "")
                {
                    MessageBox.Show("Please enter employee role.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_erole.Focus();
                }
                else if (txt_eadress.Text == "")
                {
                    MessageBox.Show("Please enter employee adress.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_eadress.Focus();
                }
                else if (cmb_egender.Text == "")
                {
                    MessageBox.Show("Please enter employee gender.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_egender.Focus();
                }

                else
                {
                    SqlConnection con = new SqlConnection(conn.db);
                    con.Open();
                    string str = "Update db_employee Set egender = '" + cmb_egender.Text + "', eroll = '" + txt_erole.Text + "', eadress = '" + txt_eadress.Text + "' Where ename = '" + txt_ename.Text + "' ";


                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(ename) From db_employee";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();
                    if (da.Read())
                    {
                        MessageBox.Show("Employee information updated successfully", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        showdata();
                    }
                    else
                    {
                        MessageBox.Show("Update is unsuccessful", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(conn.db);
                con.Open();
                string str = "Delete From db_employee Where ename = '" + txt_ename.Text + "' ";


                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "Select max(ename) From db_employee";
                SqlCommand cmd2 = new SqlCommand(str1, con);
                SqlDataReader da = cmd2.ExecuteReader();
                if (da.Read())
                {
                    MessageBox.Show("Employee information deleted successfully", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    showdata();
                }
                else
                {
                    MessageBox.Show("Deleting unsuccessful", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void db_employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_employee);

        }

        private void uc_employees_Load(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
