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
    public partial class FormDataDokter : Form
    {
        KoneksiSQL conn = new KoneksiIN();
        int i;
        public FormDataDokter()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enabel()
        {
            cbJK.Items.Add("Laki-laki");
            cbJK.Items.Add("Perempuan");
            tbIDDokter.Enabled = true;
            tbNamaDokter.Enabled = true;
            cbJK.Enabled = true;
            tbNohp.Enabled = true;
            tbSpesialis.Enabled = true;
            tbJP.Enabled = true;
        }

        private void kosongkan()
        {
            tbIDDokter.Text = "";
            tbNamaDokter.Text = "";
            tbNohp.Text = "";
            tbSpesialis.Text = "";
            tbJP.Text = "";
            tbIDDokter.Enabled = true;
            tbNamaDokter.Enabled = true;
            cbJK.Enabled = true;
            tbNohp.Enabled = true;
            tbSpesialis.Enabled = true;
            tbJP.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string str = "";
            string id = tbIDDokter.Text.ToString();
            string namadokter = tbNamaDokter.Text.ToString();
            string jk = cbJK.Text.ToString();
            string nohp = tbNohp.Text.ToString();
            string spesialis = tbSpesialis.Text.ToString();
            string jp = tbJP.Text.ToString();

            string strKoneksi = conn.goKoneksi();
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            if (btnSimpan.Text == "Simpan")
                str = "insert into dataDokter (id_dokter,namaDokter,JenisKelamin,NoHP,Spesialis,jadwal) values (@aa,@bb,@cc,@dd,@ee,@ff)";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("aa", Convert.ToInt32(id)));
            cmd.Parameters.Add(new SqlParameter("bb", namadokter));
            cmd.Parameters.Add(new SqlParameter("cc", jk));
            cmd.Parameters.Add(new SqlParameter("dd", nohp));
            cmd.Parameters.Add(new SqlParameter("ee", spesialis));
            cmd.Parameters.Add(new SqlParameter("ff", jp));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            this.dataDokterTableAdapter1.Fill(this.dbRSDataSetfix.dataDokter);
            dataGridView1.Refresh();
            kosongkan();
            

        }

        private void FormCreateDokter_Load(object sender, EventArgs e)
        {
            enabel();
            // TODO: This line of code loads data into the 'dbRSDataSetfix.dataDokter' table. You can move, or remove it, as needed.
            this.dataDokterTableAdapter1.Fill(this.dbRSDataSetfix.dataDokter);
            
            

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string str = "";
            string id = tbIDDokter.Text.ToString();
            string namadokter = tbNamaDokter.Text.ToString();
            string jk = cbJK.Text.ToString();
            string nohp = tbNohp.Text.ToString();
            string spesialis = tbSpesialis.Text.ToString();
            string jp = tbJP.Text.ToString();

            string strKoneksi = conn.goKoneksi();
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            if (btnEdit.Text == "Edit")
                str = "update dataDokter set namaDokter=@bb, JenisKelamin=@cc, NoHP=@dd, Spesialis=@ee, jadwal=@ff WHERE id_dokter=@aa";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("aa", Convert.ToInt32(id)));
            cmd.Parameters.Add(new SqlParameter("bb", namadokter));
            cmd.Parameters.Add(new SqlParameter("cc", jk));
            cmd.Parameters.Add(new SqlParameter("dd", nohp));
            cmd.Parameters.Add(new SqlParameter("ee", spesialis));
            cmd.Parameters.Add(new SqlParameter("ff", jp));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            this.dataDokterTableAdapter1.Fill(this.dbRSDataSetfix.dataDokter);
            dataGridView1.Refresh();
            kosongkan();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string str = "";
            string strKoneksi = conn.goKoneksi();
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            str = "Delete FROM dataDokter WHERE id_dokter ='"+i+"'";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            this.dataDokterTableAdapter1.Fill(this.dbRSDataSetfix.dataDokter);
            dataGridView1.Refresh();
            kosongkan();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tbIDDokter.Enabled = false;
            cbJK.Enabled = false;
            i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbIDDokter.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNamaDokter.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbJK.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbNohp.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbSpesialis.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbJP.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
