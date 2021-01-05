namespace tapabd_rumahsakit
{
    partial class FormDPAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDPAdmin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpenyakitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namalorong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noruangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddokterfkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idruanganfkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbRSDataSetfix = new tapabd_rumahsakit.dbRSDataSetfix();
            this.identitasPasienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.identitasPasienTableAdapter = new tapabd_rumahsakit.dbRSDataSetfixTableAdapters.identitasPasienTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIDPasien = new System.Windows.Forms.TextBox();
            this.tbNamaPasien = new System.Windows.Forms.TextBox();
            this.tbTTL = new System.Windows.Forms.TextBox();
            this.tbNoHP = new System.Windows.Forms.TextBox();
            this.cbIDDokter = new System.Windows.Forms.ComboBox();
            this.cbIDruangan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbJK = new System.Windows.Forms.ComboBox();
            this.tbAlamat = new System.Windows.Forms.RichTextBox();
            this.tbRpenyakit = new System.Windows.Forms.RichTextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbLorong = new System.Windows.Forms.ComboBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataTable2TableAdapter = new tapabd_rumahsakit.dbRSDataSetfixTableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSetfix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.identitasPasienBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpasienDataGridViewTextBoxColumn,
            this.namapasienDataGridViewTextBoxColumn,
            this.jeniskelaminDataGridViewTextBoxColumn,
            this.ttlDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.nohpDataGridViewTextBoxColumn,
            this.rpenyakitDataGridViewTextBoxColumn,
            this.namaDokter,
            this.namalorong,
            this.noruangan,
            this.iddokterfkDataGridViewTextBoxColumn,
            this.idruanganfkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1234, 257);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idpasienDataGridViewTextBoxColumn
            // 
            this.idpasienDataGridViewTextBoxColumn.DataPropertyName = "id_pasien";
            this.idpasienDataGridViewTextBoxColumn.HeaderText = "ID Pasien";
            this.idpasienDataGridViewTextBoxColumn.Name = "idpasienDataGridViewTextBoxColumn";
            // 
            // namapasienDataGridViewTextBoxColumn
            // 
            this.namapasienDataGridViewTextBoxColumn.DataPropertyName = "namapasien";
            this.namapasienDataGridViewTextBoxColumn.HeaderText = "Nama Pasien";
            this.namapasienDataGridViewTextBoxColumn.Name = "namapasienDataGridViewTextBoxColumn";
            // 
            // jeniskelaminDataGridViewTextBoxColumn
            // 
            this.jeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jeniskelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.Name = "jeniskelaminDataGridViewTextBoxColumn";
            // 
            // ttlDataGridViewTextBoxColumn
            // 
            this.ttlDataGridViewTextBoxColumn.DataPropertyName = "ttl";
            this.ttlDataGridViewTextBoxColumn.HeaderText = "TTL";
            this.ttlDataGridViewTextBoxColumn.Name = "ttlDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // nohpDataGridViewTextBoxColumn
            // 
            this.nohpDataGridViewTextBoxColumn.DataPropertyName = "nohp";
            this.nohpDataGridViewTextBoxColumn.HeaderText = "NoHP";
            this.nohpDataGridViewTextBoxColumn.Name = "nohpDataGridViewTextBoxColumn";
            // 
            // rpenyakitDataGridViewTextBoxColumn
            // 
            this.rpenyakitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rpenyakitDataGridViewTextBoxColumn.DataPropertyName = "rpenyakit";
            this.rpenyakitDataGridViewTextBoxColumn.HeaderText = "Riwayat Penyakit";
            this.rpenyakitDataGridViewTextBoxColumn.Name = "rpenyakitDataGridViewTextBoxColumn";
            // 
            // namaDokter
            // 
            this.namaDokter.DataPropertyName = "namaDokter";
            this.namaDokter.HeaderText = "Nama Dokter";
            this.namaDokter.Name = "namaDokter";
            // 
            // namalorong
            // 
            this.namalorong.DataPropertyName = "namalorong";
            this.namalorong.HeaderText = "Nama Lorong";
            this.namalorong.Name = "namalorong";
            // 
            // noruangan
            // 
            this.noruangan.DataPropertyName = "noruangan";
            this.noruangan.HeaderText = "No Ruangan";
            this.noruangan.Name = "noruangan";
            // 
            // iddokterfkDataGridViewTextBoxColumn
            // 
            this.iddokterfkDataGridViewTextBoxColumn.DataPropertyName = "id_dokterfk";
            this.iddokterfkDataGridViewTextBoxColumn.HeaderText = "ID Dokter";
            this.iddokterfkDataGridViewTextBoxColumn.Name = "iddokterfkDataGridViewTextBoxColumn";
            // 
            // idruanganfkDataGridViewTextBoxColumn
            // 
            this.idruanganfkDataGridViewTextBoxColumn.DataPropertyName = "id_ruanganfk";
            this.idruanganfkDataGridViewTextBoxColumn.HeaderText = "ID Ruangan";
            this.idruanganfkDataGridViewTextBoxColumn.Name = "idruanganfkDataGridViewTextBoxColumn";
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.dbRSDataSetfix;
            // 
            // dbRSDataSetfix
            // 
            this.dbRSDataSetfix.DataSetName = "dbRSDataSetfix";
            this.dbRSDataSetfix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // identitasPasienBindingSource
            // 
            this.identitasPasienBindingSource.DataMember = "identitasPasien";
            this.identitasPasienBindingSource.DataSource = this.dbRSDataSetfix;
            // 
            // identitasPasienTableAdapter
            // 
            this.identitasPasienTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Pasien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Pasien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jenis Kelamin";
            // 
            // tbIDPasien
            // 
            this.tbIDPasien.Location = new System.Drawing.Point(78, 53);
            this.tbIDPasien.Name = "tbIDPasien";
            this.tbIDPasien.Size = new System.Drawing.Size(149, 20);
            this.tbIDPasien.TabIndex = 4;
            // 
            // tbNamaPasien
            // 
            this.tbNamaPasien.Location = new System.Drawing.Point(78, 97);
            this.tbNamaPasien.Name = "tbNamaPasien";
            this.tbNamaPasien.Size = new System.Drawing.Size(149, 20);
            this.tbNamaPasien.TabIndex = 5;
            // 
            // tbTTL
            // 
            this.tbTTL.Location = new System.Drawing.Point(78, 181);
            this.tbTTL.Name = "tbTTL";
            this.tbTTL.Size = new System.Drawing.Size(149, 20);
            this.tbTTL.TabIndex = 7;
            // 
            // tbNoHP
            // 
            this.tbNoHP.Location = new System.Drawing.Point(353, 53);
            this.tbNoHP.Name = "tbNoHP";
            this.tbNoHP.Size = new System.Drawing.Size(149, 20);
            this.tbNoHP.TabIndex = 9;
            // 
            // cbIDDokter
            // 
            this.cbIDDokter.FormattingEnabled = true;
            this.cbIDDokter.Location = new System.Drawing.Point(353, 185);
            this.cbIDDokter.Name = "cbIDDokter";
            this.cbIDDokter.Size = new System.Drawing.Size(149, 21);
            this.cbIDDokter.TabIndex = 11;
            // 
            // cbIDruangan
            // 
            this.cbIDruangan.FormattingEnabled = true;
            this.cbIDruangan.Location = new System.Drawing.Point(353, 263);
            this.cbIDruangan.Name = "cbIDruangan";
            this.cbIDruangan.Size = new System.Drawing.Size(149, 21);
            this.cbIDruangan.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-27, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "TTL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alamat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "No HP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Riwayat Penyakit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID Dokter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ruangan";
            // 
            // cbJK
            // 
            this.cbJK.FormattingEnabled = true;
            this.cbJK.Location = new System.Drawing.Point(78, 141);
            this.cbJK.Name = "cbJK";
            this.cbJK.Size = new System.Drawing.Size(149, 21);
            this.cbJK.TabIndex = 19;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(78, 228);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(149, 61);
            this.tbAlamat.TabIndex = 20;
            this.tbAlamat.Text = "";
            // 
            // tbRpenyakit
            // 
            this.tbRpenyakit.Location = new System.Drawing.Point(353, 96);
            this.tbRpenyakit.Name = "tbRpenyakit";
            this.tbRpenyakit.Size = new System.Drawing.Size(149, 61);
            this.tbRpenyakit.TabIndex = 21;
            this.tbRpenyakit.Text = "";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(78, 311);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 22;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(159, 311);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbLorong);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbIDPasien);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbRpenyakit);
            this.groupBox1.Controls.Add(this.tbNamaPasien);
            this.groupBox1.Controls.Add(this.tbAlamat);
            this.groupBox1.Controls.Add(this.tbTTL);
            this.groupBox1.Controls.Add(this.cbJK);
            this.groupBox1.Controls.Add(this.tbNoHP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbIDDokter);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbIDruangan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 364);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data Pasien";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Lorong";
            // 
            // cbLorong
            // 
            this.cbLorong.FormattingEnabled = true;
            this.cbLorong.Location = new System.Drawing.Point(353, 225);
            this.cbLorong.Name = "cbLorong";
            this.cbLorong.Size = new System.Drawing.Size(149, 21);
            this.cbLorong.TabIndex = 27;
            this.cbLorong.SelectedIndexChanged += new System.EventHandler(this.cbLorong_SelectedIndexChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(240, 311);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 26;
            this.btnDel.Text = "Hapus";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "TTL";
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // FormDPAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1247, 717);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDPAdmin";
            this.Text = "Form Data Pasien Admin";
            this.Load += new System.EventHandler(this.FormDPAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSetfix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.identitasPasienBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbRSDataSetfix dbRSDataSetfix;
        private System.Windows.Forms.BindingSource identitasPasienBindingSource;
        private dbRSDataSetfixTableAdapters.identitasPasienTableAdapter identitasPasienTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIDPasien;
        private System.Windows.Forms.TextBox tbNamaPasien;
        private System.Windows.Forms.TextBox tbTTL;
        private System.Windows.Forms.TextBox tbNoHP;
        private System.Windows.Forms.ComboBox cbIDDokter;
        private System.Windows.Forms.ComboBox cbIDruangan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbJK;
        private System.Windows.Forms.RichTextBox tbAlamat;
        private System.Windows.Forms.RichTextBox tbRpenyakit;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private dbRSDataSetfixTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpenyakitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namalorong;
        private System.Windows.Forms.DataGridViewTextBoxColumn noruangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokterfkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idruanganfkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbLorong;
    }
}