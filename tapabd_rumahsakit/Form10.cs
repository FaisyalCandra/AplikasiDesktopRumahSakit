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
    public partial class FormLDataPasien : Form
    {
        public FormLDataPasien()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable("dataDokter");
        private void FormLDataPasien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbRSDataSetfix.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.dbRSDataSetfix.DataTable2);
            try
            {
               
                string strKoneksi = "Data Source=localhost;Initial Catalog=dbRS;User ID=sa;password=faisyal123";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                if (koneksi.State == ConnectionState.Closed)
                {
                    koneksi.Open();
                }
                
                string str2 = "SELECT identitasPasien.id_pasien, identitasPasien.namapasien, identitasPasien.jeniskelamin, identitasPasien.ttl, identitasPasien.alamat, identitasPasien.nohp, identitasPasien.rpenyakit, identitasPasien.id_dokterfk, identitasPasien.id_ruanganfk, dataDokter.namaDokter, ruangan.noruangan, Lorong.namalorong, ruangan.ketBooking FROM identitasPasien INNER JOIN dataDokter ON identitasPasien.id_dokterfk = dataDokter.id_dokter INNER JOIN ruangan ON identitasPasien.id_ruanganfk = ruangan.id_ruangan INNER JOIN Lorong ON ruangan.id_lorongfk = Lorong.id_lorong";


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
                dv.RowFilter = string.Format("namapasien like '%{0}%'", tbSearch.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
        }
    }
}
