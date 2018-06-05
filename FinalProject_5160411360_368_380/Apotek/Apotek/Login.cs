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

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=asus-pc;Initial Catalog=tugas_bsr;Integrated Security=True"); // making connection   
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Tolong lengkapi username atau passwordnya !");
                username.Focus();
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM login WHERE username='" + username.Text + "' AND password='" + password.Text + "'", conn);  
                conn.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["username"].ToString() == username.Text && dr["password"].ToString() == password.Text)
                        {
                            MessageBox.Show("Login Berhasil ! Selamat Datang Administrator !");
                            menu m = new menu(username.Text);
                            m.Show();
                            this.Hide();
                            conn.Close();
                        }
                        
                    }
                }
                else
                {
                   MessageBox.Show("Maaf Anda bukan bagian Admin !!!");
                   username.Clear();
                   password.Clear();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}