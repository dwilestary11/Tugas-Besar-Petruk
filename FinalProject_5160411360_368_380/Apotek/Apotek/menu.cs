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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        public menu(string message)
        {
            InitializeComponent();
            admin.Text= message;
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string query;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void menu_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=asus-pc;Initial Catalog=tugas_bsr;Integrated Security=True;";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kd_obt.Text = dGView1.CurrentRow.Cells["Kode_Obat"].FormattedValue.ToString();
            nm_obt.Text = dGView1.CurrentRow.Cells["Nama_Obat"].FormattedValue.ToString();
            pnykt.Text = dGView1.CurrentRow.Cells["Penyakit"].FormattedValue.ToString();
            Stock.Text = dGView1.CurrentRow.Cells["Stock"].FormattedValue.ToString();
            kdluarsa.Value = DateTime.Parse(dGView1.CurrentRow.Cells["Kadaluarsa"].FormattedValue.ToString());
            Harga.Text = dGView1.CurrentRow.Cells["Harga"].FormattedValue.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            admin.Clear();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (kd_obt.Text != "" && nm_obt.Text != "" && pnykt.Text != "" && kdluarsa.Text != "" && Stock.Text != "" && Harga.Text != "")
                {
                    conn.Open();
                    query = "DELETE FROM Database_Obat WHERE Kode_Obat = " + dGView1.CurrentRow.Cells["Kode_Obat"].FormattedValue;
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    MessageBox.Show("Data Berhasil Dihapus !");
                    cmd.ExecuteNonQuery();
                    reload_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("SQL QUERY ERROR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message ); 
            }
            finally
            { 
                conn.Close();
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                if (kd_obt.Text != "" && nm_obt.Text != "" && pnykt.Text != "" && kdluarsa.Text != "" && Stock.Text != "" && Harga.Text != "")
                {
                    query = "INSERT INTO Database_Obat (Kode_Obat,Nama_Obat,Penyakit,Stock,Kadaluarsa,Harga)VALUES('" + kd_obt.Text + "','" + nm_obt.Text + "','" + pnykt.Text + "','" + Stock.Text + "','" + kdluarsa.Value.Date.ToString("yyyyMMdd") + "','" + Harga.Text + "')";
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    MessageBox.Show("Data Berhasil Disimpan !");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    reload_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("SQL QUERY ERROR");
                }
            }
            catch(Exception ex)//catch exeption
            {
                //displaying error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
 
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (kd_obt.Text != "" && nm_obt.Text != "" && pnykt.Text != "" && kdluarsa.Text != "" && Stock.Text != "" && Harga.Text != "")
                {
                    query = "UPDATE Database_Obat SET Nama_Obat='" + nm_obt.Text + "',Penyakit='" + pnykt.Text + "',Stock='" + Stock.Text + "' ,Harga='" + Harga.Text + "' ,Kadaluarsa='" + kdluarsa.Value.Date.ToString("yyyyMMdd") + "' WHERE Kode_Obat = " + kd_obt.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    MessageBox.Show("Data has been updated in the SQL database");
                    //try
                    //{
                    conn.Open();
                    //}
                    //catch
                    //{
                    //    conn.Close();
                    //}
                    cmd.ExecuteNonQuery();
                    reload_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("SQL QUERY ERROR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void reload_Click(object sender, EventArgs e)
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
                dGView1.Columns["Kode_Obat"].Visible = false;
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaksi Tr = new Transaksi();
            this.Hide();
            Tr.Show();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void karantinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            karantina Kr = new karantina();
            this.Hide();
            Kr.Show();
        }

        private void historyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            History H = new History();
            this.Hide();
            H.Show();
        }
    }
}
