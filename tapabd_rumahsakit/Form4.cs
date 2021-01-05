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
    public partial class FormRuangan : Form
    {
        public FormRuangan()
        {
            InitializeComponent();
        }

        private void FormRuangan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbRSDataSetfix.Lorong' table. You can move, or remove it, as needed.
            this.lorongTableAdapter1.Fill(this.dbRSDataSetfix.Lorong);
            // TODO: This line of code loads data into the 'dbRSDataSetfix.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter1.Fill(this.dbRSDataSetfix.DataTable1);
            // TODO: This line of code loads data into the 'dbRSDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dbRSDataSet.DataTable1);
            // TODO: This line of code loads data into the 'dbRSDataSet.Lorong' table. You can move, or remove it, as needed.
            this.lorongTableAdapter.Fill(this.dbRSDataSet.Lorong);
            enabel();
            // TODO: This line of code loads data into the 'dbRSDataSet.ruangan' table. You can move, or remove it, as needed.
            this.ruanganTableAdapter.Fill(this.dbRSDataSet.ruangan);


        }
        int getIDlorong(string namaLorong)
        {
            int q = 0;
            string str2 = "";
            string strKoneksi = "Data Source=localhost;Initial Catalog=dbRS;User ID=sa;password=faisyal123";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            str2 = "select id_lorong FROM Lorong WHERE namalorong='" + namaLorong + "'";
            SqlCommand cmd = new SqlCommand(str2, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                q = dr.GetInt32(0);
            }
            koneksi.Close();
            return q;
        }

        
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string str = "";
            string id = tbIDRuangan.Text.ToString();
            string noruangan = tbNoRuangan.Text.ToString();
            string ketbook = cbKetbook.Text.ToString();
            int lorong = getIDlorong(cbIDLorong.SelectedItem.ToString());


            string strKoneksi = "Data Source=localhost;Initial Catalog=dbRS;User ID=sa;password=faisyal123";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            if (btnSimpan.Text == "Simpan")
                str = "insert into ruangan (id_ruangan,noruangan,ketBooking,id_lorongfk) values (@aa,@bb,@cc,@dd)";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("aa", Convert.ToInt32(id)));
            cmd.Parameters.Add(new SqlParameter("bb", noruangan));
            cmd.Parameters.Add(new SqlParameter("cc", ketbook));
            cmd.Parameters.Add(new SqlParameter("dd", lorong));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            this.dataTable1TableAdapter1.Fill(this.dbRSDataSetfix.DataTable1);
            dataGridView1.Refresh();
            kosongkan();
        }

        int i;
        //public class ComboboxItem
        //{
        //    public string Text { get; set; }
        //    public object Value { get; set; }

        //    public override string ToString()
        //    {
        //        return Text;
        //    }
        //}
        private void enabel()
        {
            cbKetbook.Items.Add("Terisi");
            cbKetbook.Items.Add("Kosong");
            tbIDRuangan.Enabled = true;
            tbNoRuangan.Enabled = true;
            cbKetbook.Enabled = true;
            cbIDLorong.Enabled = true;
            string str = "";
            string str2 = "";
            string strKoneksi = "Data Source=localhost;Initial Catalog=dbRS;User ID=sa;password=faisyal123";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            str2 = "select id_lorong FROM Lorong WHERE namalorong='" + cbIDLorong + "'";
            str = "select namalorong FROM Lorong ";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {               
                cbIDLorong.Items.Add(dr[0]);
            }
            koneksi.Close();


            //using(SqlConnection conn = new SqlConnection(strKoneksi))
            //{
            //    try
            //    {
            //        str = "select namalorong, id_lorong from Lorong";
            //        SqlDataAdapter da = new SqlDataAdapter(str, conn);
            //        conn.Open();
            //        DataSet ds = new DataSet();
            //        da.Fill(ds, "Lorong");
            //        cbIDLorong.DisplayMember = "namalorong";
            //        cbIDLorong.ValueMember = "id_lorong";
            //        cbIDLorong.DataSource = ds.Tables["Lorong"];
            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show("Error");
            //    }


            //    conn.Close();
            //}
        }

        private void kosongkan()
        {
            tbIDRuangan.Text = "";
            tbNoRuangan.Text = "";
            tbIDRuangan.Enabled = true;
            tbNoRuangan.Enabled = true;
            cbKetbook.Enabled = true;
            cbIDLorong.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string str = "";
            string id = tbIDRuangan.Text.ToString();
            string noruangan = tbNoRuangan.Text.ToString();
            string ketbook = cbKetbook.Text.ToString();
            int lorong = getIDlorong(cbIDLorong.SelectedItem.ToString());
            string strKoneksi = "Data Source=localhost;Initial Catalog=dbRS;User ID=sa;password=faisyal123";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            if (btnSimpan.Text == "Simpan")
                str = "update ruangan set noruangan=@bb,ketBooking=@cc,id_lorongfk=@dd WHERE id_ruangan=@aa";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("aa", Convert.ToInt32(id)));
            cmd.Parameters.Add(new SqlParameter("bb", noruangan));
            cmd.Parameters.Add(new SqlParameter("cc", ketbook));
            cmd.Parameters.Add(new SqlParameter("dd", lorong));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            this.ruanganTableAdapter.Fill(this.dbRSDataSet.ruangan);
            this.dataTable1TableAdapter1.Fill(this.dbRSDataSetfix.DataTable1);
            dataGridView1.Refresh();
            kosongkan();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string str = "";
            string strKoneksi = "Data Source=localhost;Initial Catalog=dbRS;User ID=sa;password=faisyal123";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            str = "Delete FROM ruangan WHERE id_ruangan ='" + i + "'";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            this.ruanganTableAdapter.Fill(this.dbRSDataSet.ruangan);
            this.dataTable1TableAdapter1.Fill(this.dbRSDataSetfix.DataTable1);
            dataGridView1.Refresh();
            kosongkan();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDRuangan.Enabled = false;
            i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbIDRuangan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNoRuangan.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbKetbook.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbIDLorong.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
