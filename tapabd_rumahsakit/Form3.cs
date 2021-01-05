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
    public partial class FormLorong : Form
    {
        int i;
        public FormLorong()
        {
            InitializeComponent();
        }

        private void FormLorong_Load(object sender, EventArgs e)
        {
            enabel();
            // TODO: This line of code loads data into the 'dbRSDataSetfix.Lorong' table. You can move, or remove it, as needed.
            this.lorongTableAdapter1.Fill(this.dbRSDataSetfix.Lorong);
            
            

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string str = "";
            string id = tbIDLorong.Text.ToString();
            string namalorong = tbNamaLorong.Text.ToString();
            string lantai = cbLantai.Text.ToString();
            

            string strKoneksi = "Data Source=localhost;Initial Catalog=dbRS;User ID=sa;password=faisyal123";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            if (btnSimpan.Text == "Simpan")
                str = "insert into Lorong (id_lorong,namalorong,lantai) values (@aa,@bb,@cc)";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("aa", Convert.ToInt32(id)));
            cmd.Parameters.Add(new SqlParameter("bb", namalorong));
            cmd.Parameters.Add(new SqlParameter("cc", lantai));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            this.lorongTableAdapter1.Fill(this.dbRSDataSetfix.Lorong);
            dataGridView1.Refresh();
            kosongkan();
        }

        private void enabel()
        {
            cbLantai.Items.Add("1");
            cbLantai.Items.Add("2");
            cbLantai.Items.Add("3");
            tbIDLorong.Enabled = true;
            tbNamaLorong.Enabled = true;
            cbLantai.Enabled = true;
        }

        private void kosongkan()
        {
            tbIDLorong.Text = "";
            tbNamaLorong.Text = "";
            tbIDLorong.Enabled = true;
            tbNamaLorong.Enabled = true;
            cbLantai.Enabled = true;
          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string str = "";
            string id = tbIDLorong.Text.ToString();
            string namalorong = tbNamaLorong.Text.ToString();
            string lantai = cbLantai.Text.ToString();


            string strKoneksi = "Data Source=localhost;Initial Catalog=dbRS;User ID=sa;password=faisyal123";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            if (btnSimpan.Text == "Simpan")
                str = "update Lorong set namalorong=@bb,lantai=@cc WHERE id_lorong=@aa";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("aa", Convert.ToInt32(id)));
            cmd.Parameters.Add(new SqlParameter("bb", namalorong));
            cmd.Parameters.Add(new SqlParameter("cc", lantai));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            this.lorongTableAdapter1.Fill(this.dbRSDataSetfix.Lorong);
            dataGridView1.Refresh();
            kosongkan();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            string str = "";
            string strKoneksi = "Data Source=localhost;Initial Catalog=dbRS;User ID=sa;password=faisyal123";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            str = "Delete FROM Lorong WHERE id_lorong ='" + i + "'";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            this.lorongTableAdapter1.Fill(this.dbRSDataSetfix.Lorong);
            dataGridView1.Refresh();
            kosongkan();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDLorong.Enabled = false;
            i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbIDLorong.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNamaLorong.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbLantai.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
