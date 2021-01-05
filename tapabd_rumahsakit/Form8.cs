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
    public partial class FormDPAdmin : Form
    {
        int i;
        public FormDPAdmin()
        {
            InitializeComponent();
            
        }
        KoneksiSQL conn = new KoneksiIN();
        
        private void FormDPAdmin_Load(object sender, EventArgs e)
        {
            enabel();
            // TODO: This line of code loads data into the 'dbRSDataSetfix.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.dbRSDataSetfix.DataTable2);
            
            // TODO: This line of code loads data into the 'dbRSDataSetfix.identitasPasien' table. You can move, or remove it, as needed.
            this.identitasPasienTableAdapter.Fill(this.dbRSDataSetfix.identitasPasien);
 
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string str = "";
            string id = tbIDPasien.Text.ToString();
            string namapasien = tbNamaPasien.Text.ToString();
            string jk = cbJK.Text.ToString();
            string ttl = tbTTL.Text.ToString();
            string alamat = tbAlamat.Text.ToString();
            string nohp = tbNoHP.Text.ToString();
            string rp = tbRpenyakit.Text.ToString();
            int iddokter = getIDDokter(cbIDDokter.SelectedItem.ToString());
            int idruangan = getIDRuangan(cbIDruangan.SelectedItem.ToString());


            string strKoneksi = conn.goKoneksi();
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            if (btnSimpan.Text == "Simpan")
                str = "insert into identitasPasien (id_pasien, namapasien, jeniskelamin, ttl, alamat, nohp, rpenyakit, id_dokterfk, id_ruanganfk) values (@aa,@bb,@cc,@dd,@ee,@ff,@gg,@hh,@ii)";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("aa", Convert.ToInt32(id)));
            cmd.Parameters.Add(new SqlParameter("bb", namapasien));
            cmd.Parameters.Add(new SqlParameter("cc", jk));
            cmd.Parameters.Add(new SqlParameter("dd", ttl));
            cmd.Parameters.Add(new SqlParameter("ee", alamat));
            cmd.Parameters.Add(new SqlParameter("ff", nohp));
            cmd.Parameters.Add(new SqlParameter("gg", rp));
            cmd.Parameters.Add(new SqlParameter("hh", iddokter));
            cmd.Parameters.Add(new SqlParameter("ii", idruangan));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            this.identitasPasienTableAdapter.Fill(this.dbRSDataSetfix.identitasPasien);
            this.dataTable2TableAdapter.Fill(this.dbRSDataSetfix.DataTable2);
            dataGridView1.Refresh();
            kosongkan();
        }
        //Overloading
        double getIDDokter(double spesialis)
        {
            double q = 0;
            string str = "";
            string strKoneksi = conn.goKoneksi();
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            str = "select id_dokter FROM dataDokter WHERE Spesialis='" + spesialis + "'";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                q = dr.GetInt32(0);
            }
            koneksi.Close();
            return q;
        }
        //Overloading
        int getIDDokter(string namadokter)
        {
            int q = 0;
            string str = "";
            string strKoneksi = conn.goKoneksi(); // membuat koneksi goKoneksi object
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            str = "select id_dokter FROM dataDokter WHERE namaDokter='" + namadokter + "'";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                q = dr.GetInt32(0);
            }
            koneksi.Close();
            return q;
        }

        

        int getIDRuangan(string noruangan)
        {
            int q = 0;
            string str = "";
            string strKoneksi = conn.goKoneksi();
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            str = "select id_ruangan FROM ruangan WHERE noruangan='" + noruangan + "'";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                q = dr.GetInt32(0);
            }
            koneksi.Close();
            return q;
        }

        int getidLorong(string namalorong)
        {
            int q = 0;
            string str = "";
            string strKoneksi = conn.goKoneksi();
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            str = "select id_lorong FROM Lorong WHERE namalorong='" + namalorong + "'";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                q = dr.GetInt32(0);
            }
            koneksi.Close();
            return q;
        }

        private void enabel()
        {
            cbIDruangan.Text = "";
            cbJK.Items.Add("Laki-laki");
            cbJK.Items.Add("Perempuan");
            tbIDPasien.Enabled = true;
            tbNamaPasien.Enabled = true;
            cbJK.Enabled = true;
            tbTTL.Enabled = true;
            tbAlamat.Enabled = true;
            tbNoHP.Enabled = true;
            tbRpenyakit.Enabled = true;
            cbIDDokter.Enabled = true;
            cbIDruangan.Enabled = true;

            string str1 = "";
            string str2 = "";
            string str3 = "";
            string strKoneksi = conn.goKoneksi();
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            str2 = "select noruangan FROM ruangan";
            str1 = "select namaDokter FROM dataDokter";
            str3 = "select namalorong FROM Lorong";
            SqlCommand cmd1 = new SqlCommand(str1, koneksi);
            SqlCommand cmd2 = new SqlCommand(str2, koneksi);
            SqlCommand cmd3 = new SqlCommand(str3, koneksi);
            SqlDataReader dr = cmd1.ExecuteReader();
            
            while (dr.Read())
            {
                cbIDDokter.Items.Add(dr[0]);
            }
            koneksi.Close();
            //koneksi.Open();
            //SqlDataReader dr2 = cmd2.ExecuteReader();
            //while (dr2.Read())
            //{
            //    cbIDruangan.Items.Add(dr2[0]);
            //}
            //koneksi.Close();
            koneksi.Open();
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cbLorong.Items.Add(dr3[0]);
            }
            koneksi.Close();
        }

        private void kosongkan()
        {
            tbIDPasien.Text = "";
            tbNamaPasien.Text = "";
            tbTTL.Text = "";
            tbAlamat.Text = "";
            tbNoHP.Text = "";
            tbRpenyakit.Text = "";
            tbIDPasien.Enabled = true;
            tbNamaPasien.Enabled = true;
            cbJK.Enabled = true;
            tbTTL.Enabled = true;
            tbAlamat.Enabled = true;
            tbNoHP.Enabled = true;
            tbRpenyakit.Enabled = true;
            cbIDDokter.Enabled = true;
            cbIDruangan.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string str = "";
            string id = tbIDPasien.Text.ToString();
            string namapasien = tbNamaPasien.Text.ToString();
            string jk = cbJK.Text.ToString();
            string ttl = tbTTL.Text.ToString();
            string alamat = tbAlamat.Text.ToString();
            string nohp = tbNoHP.Text.ToString();
            string rp = tbRpenyakit.Text.ToString();
            int iddokter = getIDDokter(cbIDDokter.SelectedItem.ToString());
            int idruangan = getIDRuangan(cbIDruangan.SelectedItem.ToString());


            string strKoneksi = conn.goKoneksi();
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            if (btnSimpan.Text == "Simpan")
                str = "update identitasPasien set namapasien=@bb,jeniskelamin=@cc,ttl=@dd,alamat=@ee,nohp=@ff,rpenyakit=@gg,id_dokterfk=@hh,id_ruanganfk=@ii WHERE id_pasien=@aa";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("aa", Convert.ToInt32(id)));
            cmd.Parameters.Add(new SqlParameter("bb", namapasien));
            cmd.Parameters.Add(new SqlParameter("cc", jk));
            cmd.Parameters.Add(new SqlParameter("dd", ttl));
            cmd.Parameters.Add(new SqlParameter("ee", alamat));
            cmd.Parameters.Add(new SqlParameter("ff", nohp));
            cmd.Parameters.Add(new SqlParameter("gg", rp));
            cmd.Parameters.Add(new SqlParameter("hh", iddokter));
            cmd.Parameters.Add(new SqlParameter("ii", idruangan));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            this.identitasPasienTableAdapter.Fill(this.dbRSDataSetfix.identitasPasien);
            this.dataTable2TableAdapter.Fill(this.dbRSDataSetfix.DataTable2);
            dataGridView1.Refresh();
            kosongkan();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDPasien.Enabled = false;
            i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbIDPasien.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNamaPasien.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbJK.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbTTL.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbAlamat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbNoHP.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbRpenyakit.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbIDDokter.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbIDruangan.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            cbLorong.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string str = "";
            string strKoneksi = conn.goKoneksi();
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            str = "Delete FROM identitasPasien WHERE id_pasien ='" + i + "'";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            this.dataTable2TableAdapter.Fill(this.dbRSDataSetfix.DataTable2);
            dataGridView1.Refresh();
            kosongkan();
        }

        private void cbLorong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIDruangan.Items.Clear();
            int cmboLorong = getidLorong(cbLorong.SelectedItem.ToString());
            string str = "";

            string strKoneksi = conn.goKoneksi();
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            str = "select noruangan FROM ruangan WHERE id_lorongfk='" + cmboLorong + "'";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbIDruangan.Items.Add(dr[0]);
            }
            koneksi.Close();
            


        }
    }
}
