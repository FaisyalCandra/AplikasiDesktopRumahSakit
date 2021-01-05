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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string str1 = "";
                string user = tbUser.Text.ToString();
                string pass = tbPass.Text.ToString();

                string strKoneksi = "Data Source=localhost;Initial Catalog=dbRS;User ID=sa;password=faisyal123";
                str1 = "Select * from roleLogin WHERE Username = '" + tbUser.Text + "' and Password = '" + tbPass.Text + "'";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();

                SqlCommand cmd = new SqlCommand(str1, koneksi);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int p = 0; p < dt.Rows.Count; p++)
                    {
                        if (dt.Rows[p]["Role"].ToString() == "admin")
                        {
                            MessageBox.Show("Login Berhasil sebagai admin");
                            FormAdmin fa = new FormAdmin();
                            fa.Show();
                            this.Hide();
                        }
                        else if (dt.Rows[p]["Role"].ToString() == "pasien")
                        {
                            MessageBox.Show("Login berhasil sebagai pasien");
                            FormUser fu = new FormUser();
                            fu.Show();
                            this.Hide();
                        }
                    }
                }
                koneksi.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            FormRegis fr = new FormRegis();
            fr.Show();
            this.Hide();
        }
    }
}
