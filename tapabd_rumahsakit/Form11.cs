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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable("dataDokter");
        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbRSDataSetfix.dataDokter' table. You can move, or remove it, as needed.
            this.dataDokterTableAdapter.Fill(this.dbRSDataSetfix.dataDokter);
            try
            {

                string strKoneksi = "Data Source=localhost;Initial Catalog=dbRS;User ID=sa;password=faisyal123";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                if (koneksi.State == ConnectionState.Closed)
                {
                    koneksi.Open();
                }

                string str2 = "Select jadwal, namaDokter, JenisKelamin, NoHP, Spesialis FROM dataDokter";


                SqlDataAdapter da = new SqlDataAdapter(str2, koneksi);

                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand cmd = new SqlCommand(str2, koneksi);
                SqlDataReader dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("jadwal like '%{0}%'", tbSearch.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
            
        }
    }
}
