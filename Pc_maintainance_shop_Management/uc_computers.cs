using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pc_maintainance_shop_Management
{
    public partial class uc_computers : UserControl
    {
        connection conn = new connection();
        public uc_computers()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_computerno.Text == "")
                {
                    MessageBox.Show("Please enter computer no.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_computerno.Focus();
                }
                else if (txt_computerbrand.Text == "")
                {
                    MessageBox.Show("Please enter computer brand", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_computerbrand.Focus();
                }
                else if (txt_computermodel.Text == "")
                {
                    MessageBox.Show("Please enter computer model", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_computermodel.Focus();
                }
                else if (txt_computercolor.Text == "")
                {
                    MessageBox.Show("Please enter computer color", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_computercolor.Focus();
                }
                else if (txt_ownersname.Text == "")
                {
                    MessageBox.Show("Please enter owner's name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ownersname.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);
                    con.Open();
                    string str = "Insert Into db_computers (computerno,computerbrand,computermodel,computercolor,date,ownersname)Values " +
                        "('" + txt_computerno.Text + "','" + txt_computerbrand.Text + "','" + txt_computermodel.Text + "','" + txt_computercolor.Text + "','" + dtp_date.Text + "','" + txt_ownersname.Text + "')";




                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(computerno) From db_computers";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();
                    if (da.Read())
                    {
                        MessageBox.Show("computer information inserted successfully", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void showdata()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);
                con.Open();
                string str = " Select * From db_computers";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                db_computersDataGridView.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txt_computerno.Clear();
            txt_computerbrand.Clear();
            txt_computermodel.Clear();
            txt_computercolor.Clear();
            txt_ownersname.Clear();
            dtp_date.Text = "";
        }

        private void uc_computers_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_computerno.Text == "")
                {
                    MessageBox.Show("Please enter computer no.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_computerno.Focus();
                }
                else if (txt_computerbrand.Text == "")
                {
                    MessageBox.Show("Please enter computer brand", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_computerbrand.Focus();
                }
                else if (txt_computermodel.Text == "")
                {
                    MessageBox.Show("Please enter computer model", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_computermodel.Focus();
                }
                else if (txt_computercolor.Text == "")
                {
                    MessageBox.Show("Please enter computer color", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_computercolor.Focus();
                }
                else if (txt_ownersname.Text == "")
                {
                    MessageBox.Show("Please enter owner's name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ownersname.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);
                    con.Open();
                    string str = "Update db_computers Set computerbrand = '" + txt_computerbrand.Text + "', computermodel = '" + txt_computermodel.Text + "', computercolor = '" + txt_computercolor.Text + "', date = '" + dtp_date.Text + "', ownersname = '" + txt_ownersname.Text + "' Where computerno = '" + txt_computerno.Text + "' ";


                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(computerno) From db_computers";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();
                    if (da.Read())
                    {
                        MessageBox.Show("computer information updated successfully", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string str = "Delete From db_computers Where computerno = '" + txt_computerno.Text + "' ";


                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "Select max(computerno) From db_computers";
                SqlCommand cmd2 = new SqlCommand(str1, con);
                SqlDataReader da = cmd2.ExecuteReader();
                if (da.Read())
                {
                    MessageBox.Show("computer information deleted successfully", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void db_computersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_computersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_computers);

        }

        private void txt_computerno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
