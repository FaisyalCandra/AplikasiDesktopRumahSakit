namespace tapabd_rumahsakit
{
    partial class FormRuangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRuangan));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idruanganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namalorong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lantai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noruanganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_lorong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbRSDataSetfix = new tapabd_rumahsakit.dbRSDataSetfix();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbRSDataSet = new tapabd_rumahsakit.dbRSDataSet();
            this.ruanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruanganTableAdapter = new tapabd_rumahsakit.dbRSDataSetTableAdapters.ruanganTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDlorong = new System.Windows.Forms.Label();
            this.cbKetbook = new System.Windows.Forms.ComboBox();
            this.cbIDLorong = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.tbNoRuangan = new System.Windows.Forms.TextBox();
            this.tbIDRuangan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lorongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lorongTableAdapter = new tapabd_rumahsakit.dbRSDataSetTableAdapters.LorongTableAdapter();
            this.dataTable1TableAdapter = new tapabd_rumahsakit.dbRSDataSetTableAdapters.DataTable1TableAdapter();
            this.dataTable1TableAdapter1 = new tapabd_rumahsakit.dbRSDataSetfixTableAdapters.DataTable1TableAdapter();
            this.lorongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lorongTableAdapter1 = new tapabd_rumahsakit.dbRSDataSetfixTableAdapters.LorongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSetfix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruanganBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lorongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorongBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idruanganDataGridViewTextBoxColumn,
            this.namalorong,
            this.lantai,
            this.noruanganDataGridViewTextBoxColumn,
            this.ketBookingDataGridViewTextBoxColumn,
            this.id_lorong});
            this.dataGridView1.DataSource = this.dataTable1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(24, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idruanganDataGridViewTextBoxColumn
            // 
            this.idruanganDataGridViewTextBoxColumn.DataPropertyName = "id_ruangan";
            this.idruanganDataGridViewTextBoxColumn.HeaderText = "ID Ruangan";
            this.idruanganDataGridViewTextBoxColumn.Name = "idruanganDataGridViewTextBoxColumn";
            // 
            // namalorong
            // 
            this.namalorong.DataPropertyName = "namalorong";
            this.namalorong.HeaderText = "Nama Lorong";
            this.namalorong.Name = "namalorong";
            // 
            // lantai
            // 
            this.lantai.DataPropertyName = "lantai";
            this.lantai.HeaderText = "Lantai";
            this.lantai.Name = "lantai";
            // 
            // noruanganDataGridViewTextBoxColumn
            // 
            this.noruanganDataGridViewTextBoxColumn.DataPropertyName = "noruangan";
            this.noruanganDataGridViewTextBoxColumn.HeaderText = "No Ruangan";
            this.noruanganDataGridViewTextBoxColumn.Name = "noruanganDataGridViewTextBoxColumn";
            // 
            // ketBookingDataGridViewTextBoxColumn
            // 
            this.ketBookingDataGridViewTextBoxColumn.DataPropertyName = "ketBooking";
            this.ketBookingDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.ketBookingDataGridViewTextBoxColumn.Name = "ketBookingDataGridViewTextBoxColumn";
            // 
            // id_lorong
            // 
            this.id_lorong.DataPropertyName = "id_lorong";
            this.id_lorong.HeaderText = "id_lorong";
            this.id_lorong.Name = "id_lorong";
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dbRSDataSetfix;
            // 
            // dbRSDataSetfix
            // 
            this.dbRSDataSetfix.DataSetName = "dbRSDataSetfix";
            this.dbRSDataSetfix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dbRSDataSet;
            // 
            // dbRSDataSet
            // 
            this.dbRSDataSet.DataSetName = "dbRSDataSet";
            this.dbRSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ruanganBindingSource
            // 
            this.ruanganBindingSource.DataMember = "ruangan";
            this.ruanganBindingSource.DataSource = this.dbRSDataSet;
            // 
            // ruanganTableAdapter
            // 
            this.ruanganTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.lblIDlorong);
            this.groupBox1.Controls.Add(this.cbKetbook);
            this.groupBox1.Controls.Add(this.cbIDLorong);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.tbNoRuangan);
            this.groupBox1.Controls.Add(this.tbIDRuangan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(679, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data Ruangan";
            // 
            // lblIDlorong
            // 
            this.lblIDlorong.AutoSize = true;
            this.lblIDlorong.Location = new System.Drawing.Point(277, 198);
            this.lblIDlorong.Name = "lblIDlorong";
            this.lblIDlorong.Size = new System.Drawing.Size(0, 13);
            this.lblIDlorong.TabIndex = 14;
            // 
            // cbKetbook
            // 
            this.cbKetbook.FormattingEnabled = true;
            this.cbKetbook.Location = new System.Drawing.Point(111, 149);
            this.cbKetbook.Name = "cbKetbook";
            this.cbKetbook.Size = new System.Drawing.Size(159, 21);
            this.cbKetbook.TabIndex = 13;
            // 
            // cbIDLorong
            // 
            this.cbIDLorong.FormattingEnabled = true;
            this.cbIDLorong.Location = new System.Drawing.Point(111, 191);
            this.cbIDLorong.Name = "cbIDLorong";
            this.cbIDLorong.Size = new System.Drawing.Size(159, 21);
            this.cbIDLorong.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(175, 257);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 10;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(94, 257);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(13, 257);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tbNoRuangan
            // 
            this.tbNoRuangan.Location = new System.Drawing.Point(111, 94);
            this.tbNoRuangan.Name = "tbNoRuangan";
            this.tbNoRuangan.Size = new System.Drawing.Size(159, 20);
            this.tbNoRuangan.TabIndex = 5;
            // 
            // tbIDRuangan
            // 
            this.tbIDRuangan.Location = new System.Drawing.Point(111, 52);
            this.tbIDRuangan.Name = "tbIDRuangan";
            this.tbIDRuangan.Size = new System.Drawing.Size(159, 20);
            this.tbIDRuangan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Lorong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Keterangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No Ruangan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // lorongBindingSource
            // 
            this.lorongBindingSource.DataMember = "Lorong";
            this.lorongBindingSource.DataSource = this.dbRSDataSet;
            // 
            // lorongTableAdapter
            // 
            this.lorongTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // lorongBindingSource1
            // 
            this.lorongBindingSource1.DataMember = "Lorong";
            this.lorongBindingSource1.DataSource = this.dbRSDataSetfix;
            // 
            // lorongTableAdapter1
            // 
            this.lorongTableAdapter1.ClearBeforeFill = true;
            // 
            // FormRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRuangan";
            this.Text = "Form Ruangan";
            this.Load += new System.EventHandler(this.FormRuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSetfix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruanganBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lorongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorongBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbRSDataSet dbRSDataSet;
        private System.Windows.Forms.BindingSource ruanganBindingSource;
        private dbRSDataSetTableAdapters.ruanganTableAdapter ruanganTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox tbNoRuangan;
        private System.Windows.Forms.TextBox tbIDRuangan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIDLorong;
        private System.Windows.Forms.ComboBox cbKetbook;
        private System.Windows.Forms.BindingSource lorongBindingSource;
        private dbRSDataSetTableAdapters.LorongTableAdapter lorongTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private dbRSDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private dbRSDataSetfix dbRSDataSetfix;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private dbRSDataSetfixTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idruanganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namalorong;
        private System.Windows.Forms.DataGridViewTextBoxColumn lantai;
        private System.Windows.Forms.DataGridViewTextBoxColumn noruanganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lorong;
        private System.Windows.Forms.BindingSource lorongBindingSource1;
        private dbRSDataSetfixTableAdapters.LorongTableAdapter lorongTableAdapter1;
        private System.Windows.Forms.Label lblIDlorong;
    }
}