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
        double stock,hasil;
        private void Form3_Load(object sender, EventArgs e)
        {
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
            stock = Int16.Parse(dGView1.CurrentRow.Cells["Stock"].FormattedValue.ToString());
        }
        private void reload_Click(object sender, EventArgs e)
        {
            try
            {
                query = "SELECT * FROM database_Obat";
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                dGView1.DataSource = dt;
            }
            finally
            {
                conn.Close();
            }
        }
        private void pengurangan(object sender, EventArgs e)
        {
            try
            {
                hasil = stock - Convert.ToDouble(jml.Text);
                query = "UPDATE Database_Obat SET Stock ='" + hasil.ToString() + "' WHERE Kode_Obat = " + kd_obat.Text;
                cmd.Connection = conn;
                cmd.CommandText = query;
                MessageBox.Show("Data Berhasil Disimpan !");
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //displaying error message
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void simpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (kd_trns.Text != "" && nm_obat.Text != "" && harga.Text != "" && jml.Text != "" && tgl_trns.Text != "" && total.Text != "")
                {
                    conn.Open();
                    query = "INSERT INTO Histori (Kode_Transaksi,Nama_Obat,Harga,Jumlah,tgl_Transaksi,Total) VALUES('" + kd_trns.Text + "','" + nm_obat.Text + "','" + harga.Text + "','" + jml.Text + "','" + tgl_trns.Text + "','" + total.Text + "')";
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    MessageBox.Show("Data Berhasil Disimpan !");
                    cmd.ExecuteNonQuery();
                    pengurangan(sender, e);
                    reload_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("SQL QUERY ERROR");
                }
            }
            catch (Exception ex)//catch exeption
            {
                //displaying error message
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
        }

        private void harga_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void total_MouseHover(object sender, EventArgs e)
        {
        }

        private void G(object sender, EventArgs e)
        {

        }

        private void get_Click(object sender, EventArgs e)
        {
            double tot = Convert.ToDouble(harga.Text) * Convert.ToDouble(jml.Text);
            total.Text = Convert.ToString(tot);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu M = new menu();
            this.Close();
            M.Show();
        }
    }
}
