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
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string query;
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugas_bsrDataSet1.Database_Obat' table. You can move, or remove it, as needed.
            //this.database_ObatTableAdapter.Fill(this.tugas_bsrDataSet1.Database_Obat);
            conn.ConnectionString = "Data Source=asus-pc;Initial Catalog=tugas_bsr;Integrated Security=True;";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dGView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kd_obat.Text = dGView1.CurrentRow.Cells["Kode_Obat"].FormattedValue.ToString();
            nm_obat.Text = dGView1.CurrentRow.Cells["Nama_Obat"].FormattedValue.ToString();
            harga.Text = dGView1.CurrentRow.Cells["Harga"].FormattedValue.ToString();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM Database_Obat";
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            dGView1.DataSource = dt;
            dGView1.Columns["Kode_Obat"].Visible = false;
        }
    }
}
