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
    public partial class karantina : Form
    {
        public karantina()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string query;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void karantina_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=asus-pc;Initial Catalog=tugas_bsr;Integrated Security=True;";
            conn.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reload_Click(object sender, EventArgs e)
        {
            try
            {
                //create a query for retrieving data in the database.
                query = "SELECT * FROM Database_Obat WHERE Kode_Obat = " + kd_obt.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            menu M = new menu();
            this.Close();
            M.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //create a query for retrieving data in the database.
                query = "SELECT * FROM Database_Obat";
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

        private void admin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
