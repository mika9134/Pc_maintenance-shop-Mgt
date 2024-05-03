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
    public partial class uc_analytics : UserControl
    {
        connection conn = new connection();
        public uc_analytics()
        {
            InitializeComponent();
        }

        private void uc_analytics_Load(object sender, EventArgs e)
        {
            totalcomputers();
            totalhardware();
            totalemployee();
          
        }

  

        public void totalhardware()
        {
            SqlConnection con = new SqlConnection(conn.db);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count (serialno) from db_stock";
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            
            lbl_hardware.Text = rows_count.ToString();
            con.Close();
        }

        public void totalemployee()
        {
            SqlConnection con = new SqlConnection(conn.db);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count (ename) from db_employee";
            Int32 rows_count1 = Convert.ToInt32(cmd.ExecuteScalar());
           
            lbl_employees.Text = rows_count1.ToString();
            con.Close();

        }

        public void totalcomputers()
        {
            SqlConnection con = new SqlConnection(conn.db);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count (computerno) from db_computers";
            Int32 rows_count2 = Convert.ToInt32(cmd.ExecuteScalar());
            
            lbl_computers.Text = rows_count2.ToString();
            con.Close();
        }
        
        private void lbl_computers_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            totalcomputers();
            totalhardware();
            totalemployee();
           
        }
    }
}
