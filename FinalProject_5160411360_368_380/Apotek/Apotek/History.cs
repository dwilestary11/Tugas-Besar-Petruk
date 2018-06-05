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

namespace Apotek
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string query;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu M = new menu();
            this.Close();
            M.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=asus-pc;Initial Catalog=tugas_bsr;Integrated Security=True;";
            conn.Open();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            try
            {
                //create a query for retrieving data in the database.
                query = "SELECT * FROM Histori";
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                dGView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //create a query for retrieving data in the database.
                query = "SELECT * FROM Histori WHERE Kode_Transaksi = " + kd_trns.Text;
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                dGView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
