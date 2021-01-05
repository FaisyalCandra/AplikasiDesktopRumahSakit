using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tapabd_rumahsakit
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void createDataDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataDokter fcd = new FormDataDokter();
            fcd.MdiParent = this;
            fcd.Show();
        }

        private void createLorongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLorong fl = new FormLorong();
            fl.MdiParent = this;
            fl.Show();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRuangan fr = new FormRuangan();
            fr.MdiParent = this;
            fr.Show();
        }

        private void createDataPasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDPAdmin fdpa = new FormDPAdmin();
            fdpa.MdiParent = this;
            fdpa.Show();
        }

        private void jadwalDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJDokterAdmin fjda = new FormJDokterAdmin();
            fjda.MdiParent = this;
            fjda.Show();
        }

        private void listDataPasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLDataPasien fldp = new FormLDataPasien();
            fldp.MdiParent = this;
            fldp.Show();
        }
    }
}
