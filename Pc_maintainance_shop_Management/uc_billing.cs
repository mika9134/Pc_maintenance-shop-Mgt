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
    public partial class uc_billing : UserControl
    {
        connection conn = new connection();
        double totalprice;
        public uc_billing()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_billno.Text == "")
                {
                    MessageBox.Show("Please enter bill number.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_billno.Focus();
                }
                else if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please enter part name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partname.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please enter part price.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }
                else if (txt_partquantity.Text == "")
                {
                    MessageBox.Show("Please enter part quantity.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partquantity.Focus();
                }

                else
                {
                    SqlConnection con = new SqlConnection(conn.db);
                    con.Open();
                    string str = "Insert Into db_billcard (billno,partname,partprice,partquantity,totalprice)Values ('" + txt_billno.Text + "','" + txt_partname.Text + "','" + txt_partprice.Text + "','" + txt_partquantity.Text + "','" + txt_totalprice.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(billno) From db_billcard";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();
                    if (da.Read())
                    {
                       
                        clearAll();
                        showdata();
                        billcalculation();
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

        private void billcalculation()
        {
            txt_totalprice.Text = totalprice.ToString();
        }

        private void showdata()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);
                con.Open();
                string str = " Select * From db_billcard";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                db_billcardDataGridView.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txt_partname.Clear();
            txt_partprice.Clear();
            txt_partquantity.Clear();
            txt_partname.Focus();
        }
        private void clearAll()
        {
            txt_partname.Clear();
            txt_partprice.Clear();
            txt_partquantity.Clear();
            txt_totalprice.Clear();
            txt_partname.Focus();
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);
                con.Open();
                string str = "Delete From db_billcard Where billno = '" + txt_billno.Text + "' ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "Select max(billno) From db_billcard";
                SqlCommand cmd2 = new SqlCommand(str1, con);
                SqlDataReader da = cmd2.ExecuteReader();
                if (da.Read())
                {

                    clear();
                    showdata();
                    billcalculation();
                }
                else
                {
                    MessageBox.Show("Deletion is unsuccessful", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
         
        }

        private void db_billcardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_billcardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_billcard);

        }

        private void btn_calculatebill_Click(object sender, EventArgs e)
        {
            billcalculation();

            try
            {
                if (txt_billno.Text == "")
                {
                    MessageBox.Show("Please enter bill number.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_billno.Focus();
                }
                else {
                    SqlConnection con = new SqlConnection(conn.db);
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT SUM(totalprice) FROM db_billcard Where billno = '" + txt_billno.Text + "' ";
                    Int32 grand_total = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    txt_grandtotal.Text = grand_total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_savebill_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_billno.Text == "")
                {
                    MessageBox.Show("Please enter bill number.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_billno.Focus();
                }
                else if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please enter part name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partname.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please enter part price.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }
                else if (txt_partquantity.Text == "")
                {
                    MessageBox.Show("Please enter part quantity.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partquantity.Focus();
                }

                else
                {
                    SqlConnection con = new SqlConnection(conn.db);
                    con.Open();
                   
                    
                    string str = "Insert Into db_bill (billno,partname,partprice,partquantity,totalprice)Values ('" + txt_billno.Text + "','" + txt_partname.Text + "','" + txt_partprice.Text + "','" + txt_partquantity.Text + "','" + txt_totalprice.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(billno) From db_bill";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();
                    if (da.Read())
                    {
                        MessageBox.Show("Bill saved successfully", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        showdata();
                        billcalculation();
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

        private void txt_partquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txt_partquantity.Text == "")
                {
                    txt_totalprice.Clear();
                }
                else if(txt_partname.Text == "")
                {
                    MessageBox.Show("Please enter part name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_partname.Focus();
                }
                else
                {
                    
                    totalprice = Convert.ToDouble(txt_partprice.Text) * Convert.ToDouble(txt_partquantity.Text);
                    txt_totalprice.Text = totalprice.ToString();
                  

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_totalprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_removeall_Click(object sender, EventArgs e)
        {


            try
            {
                SqlConnection con = new SqlConnection(conn.db);
                con.Open();
                string str = "Delete From db_billcard";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "Select max(billno) From db_billcard";
                SqlCommand cmd2 = new SqlCommand(str1, con);
                SqlDataReader da = cmd2.ExecuteReader();
                if (da.Read())
                {

                    clear();
                    showdata();
                    billcalculation();
                }
                else
                {
                    MessageBox.Show("Deletion is unsuccessful", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); 

        }



    }

        private void uc_billing_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void txt_grandtotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
