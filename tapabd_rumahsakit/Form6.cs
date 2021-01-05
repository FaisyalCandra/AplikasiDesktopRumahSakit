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

namespace tapabd_rumahsakit
{
    public partial class FormRegis : Form
    {
        public FormRegis()
        {
            InitializeComponent();
            enabel();
        }
        KoneksiSQL conn = new KoneksiIN();

        string nama;
        string user;
        string role;
        string pass;
        private void btnRegis_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                 user = tbUser.Text.ToString();
                 nama = tbNama.Text.ToString();
                 role = cbRole.Text.ToString();
                 pass = tbPass.Text.ToString();

                string strKoneksi = conn.goKoneksi();
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();
                str = "insert into roleLogin (Username,Password,Nama,Role) values (@aa,@bb,@cc,@dd)";

                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("aa", user));
                cmd.Parameters.Add(new SqlParameter("bb", pass));
                cmd.Parameters.Add(new SqlParameter("cc", nama));
                cmd.Parameters.Add(new SqlParameter("dd", role));
                cmd.ExecuteNonQuery();

                MessageBox.Show("terdaftar");
                FormLogin fl = new FormLogin();
                fl.Show();
                this.Hide();
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void enabel()
        {
            cbRole.Items.Add("admin");
            cbRole.Items.Add("pasien");
            tbNama.Enabled = true;
            tbUser.Enabled = true;
            tbPass.Enabled = true;
            cbRole.Enabled = true;  
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Hide();
        }
    }
}
