namespace tapabd_rumahsakit
{
    partial class FormLDataPasien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLDataPasien));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapasienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpenyakitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namalorongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noruanganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddokterfkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idruanganfkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbRSDataSetfix = new tapabd_rumahsakit.dbRSDataSetfix();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dataTable2TableAdapter = new tapabd_rumahsakit.dbRSDataSetfixTableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSetfix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
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
            this.namaDokterDataGridViewTextBoxColumn,
            this.namalorongDataGridViewTextBoxColumn,
            this.noruanganDataGridViewTextBoxColumn,
            this.iddokterfkDataGridViewTextBoxColumn,
            this.idruanganfkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1238, 316);
            this.dataGridView1.TabIndex = 1;
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
            this.rpenyakitDataGridViewTextBoxColumn.DataPropertyName = "rpenyakit";
            this.rpenyakitDataGridViewTextBoxColumn.HeaderText = "Riwayat Penyakit";
            this.rpenyakitDataGridViewTextBoxColumn.Name = "rpenyakitDataGridViewTextBoxColumn";
            // 
            // namaDokterDataGridViewTextBoxColumn
            // 
            this.namaDokterDataGridViewTextBoxColumn.DataPropertyName = "namaDokter";
            this.namaDokterDataGridViewTextBoxColumn.HeaderText = "Nama Dokter";
            this.namaDokterDataGridViewTextBoxColumn.Name = "namaDokterDataGridViewTextBoxColumn";
            // 
            // namalorongDataGridViewTextBoxColumn
            // 
            this.namalorongDataGridViewTextBoxColumn.DataPropertyName = "namalorong";
            this.namalorongDataGridViewTextBoxColumn.HeaderText = "Nama Lorong";
            this.namalorongDataGridViewTextBoxColumn.Name = "namalorongDataGridViewTextBoxColumn";
            // 
            // noruanganDataGridViewTextBoxColumn
            // 
            this.noruanganDataGridViewTextBoxColumn.DataPropertyName = "noruangan";
            this.noruanganDataGridViewTextBoxColumn.HeaderText = "No Ruangan";
            this.noruanganDataGridViewTextBoxColumn.Name = "noruanganDataGridViewTextBoxColumn";
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
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(456, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(264, 20);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // FormLDataPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1250, 450);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormLDataPasien";
            this.Text = "Form List Data Pasien";
            this.Load += new System.EventHandler(this.FormLDataPasien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSetfix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearch;
        private dbRSDataSetfix dbRSDataSetfix;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private dbRSDataSetfixTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapasienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpenyakitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namalorongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noruanganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokterfkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idruanganfkDataGridViewTextBoxColumn;
    }
}