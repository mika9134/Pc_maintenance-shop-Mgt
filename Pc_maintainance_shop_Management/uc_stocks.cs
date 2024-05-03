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
    public partial class uc_stocks : UserControl
    {
        connection conn = new connection();
        public uc_stocks()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please enter part name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partname.Focus();

                }
                else if (txt_partquantity.Text == "")
                {
                    MessageBox.Show("Please enter part quantity.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partquantity.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please enter part price.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }
                else if (txt_serialnumber.Text == "")
                {
                    MessageBox.Show("Please enter part serial number.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_serialnumber.Focus();
                }

                else
                {
                    SqlConnection con = new SqlConnection(conn.db);
                    con.Open();
                    string str = "Insert Into db_stock (partname,partquantity,partprice,serialno)Values ('" + txt_partname.Text + "','" + txt_partquantity.Text + "','" + txt_partprice.Text + "','" + txt_serialnumber.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                  
                    String str1 = "Select max(partname) From db_stock";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();
                    if (da.Read())
                    {
                        MessageBox.Show("Stock information inserted successfully", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
           
                SqlConnection con = new SqlConnection(conn.db);
                con.Open();
                string str = " Select * From db_stock";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                db_stockDataGridView.DataSource = dt;
                con.Close();


           
        }

        private void clear()
        {
            throw new NotImplementedException();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please enter part name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partname.Focus();

                }
                else if (txt_partquantity.Text == "")
                {
                    MessageBox.Show("Please enter part quantity.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partquantity.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please enter part price.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }
                else if (txt_serialnumber.Text == "")
                {
                    MessageBox.Show("Please enter part serial number.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_serialnumber.Focus();
                }

                else
                {
                    SqlConnection con = new SqlConnection(conn.db);
                    con.Open();
                    string str = "Update db_stock Set partquantity = '" + txt_partquantity.Text + "', partprice = '" + txt_partprice.Text + "', serialno = '" + txt_serialnumber.Text + "' Where partname = '" + txt_partname.Text + "' ";


                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(partname) From db_stock";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();
                    if (da.Read())
                    {
                        MessageBox.Show("Stock information updated successfully", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string str = "Delete From db_stock Where partname = '" + txt_partname.Text + "' ";


                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "Select max(partname) From db_stock";
                SqlCommand cmd2 = new SqlCommand(str1, con);
                SqlDataReader da = cmd2.ExecuteReader();
                if (da.Read())
                {
                    MessageBox.Show("Stock information deleted successfully", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void db_stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_stock);

        }

        private void uc_stocks_Load(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
