namespace tapabd_rumahsakit
{
    partial class FormDataDokter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataDokter));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbJK = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbJP = new System.Windows.Forms.RichTextBox();
            this.tbSpesialis = new System.Windows.Forms.TextBox();
            this.tbNohp = new System.Windows.Forms.TextBox();
            this.tbNamaDokter = new System.Windows.Forms.TextBox();
            this.tbIDDokter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataDokterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbRSDataSet = new tapabd_rumahsakit.dbRSDataSet();
            this.dataDokterTableAdapter = new tapabd_rumahsakit.dbRSDataSetTableAdapters.dataDokterTableAdapter();
            this.iddokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spesialisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadwalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDokterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbRSDataSetfix = new tapabd_rumahsakit.dbRSDataSetfix();
            this.dataDokterTableAdapter1 = new tapabd_rumahsakit.dbRSDataSetfixTableAdapters.dataDokterTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDokterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDokterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSetfix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.cbJK);
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.tbJP);
            this.groupBox1.Controls.Add(this.tbSpesialis);
            this.groupBox1.Controls.Add(this.tbNohp);
            this.groupBox1.Controls.Add(this.tbNamaDokter);
            this.groupBox1.Controls.Add(this.tbIDDokter);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(705, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 388);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data Dokter";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(168, 345);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(87, 345);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbJK
            // 
            this.cbJK.FormattingEnabled = true;
            this.cbJK.Location = new System.Drawing.Point(128, 145);
            this.cbJK.Name = "cbJK";
            this.cbJK.Size = new System.Drawing.Size(167, 21);
            this.cbJK.TabIndex = 14;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(6, 345);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbJP
            // 
            this.tbJP.Location = new System.Drawing.Point(128, 253);
            this.tbJP.Name = "tbJP";
            this.tbJP.Size = new System.Drawing.Size(167, 62);
            this.tbJP.TabIndex = 11;
            this.tbJP.Text = "";
            // 
            // tbSpesialis
            // 
            this.tbSpesialis.Location = new System.Drawing.Point(128, 217);
            this.tbSpesialis.Name = "tbSpesialis";
            this.tbSpesialis.Size = new System.Drawing.Size(167, 20);
            this.tbSpesialis.TabIndex = 10;
            // 
            // tbNohp
            // 
            this.tbNohp.Location = new System.Drawing.Point(128, 181);
            this.tbNohp.Name = "tbNohp";
            this.tbNohp.Size = new System.Drawing.Size(167, 20);
            this.tbNohp.TabIndex = 9;
            // 
            // tbNamaDokter
            // 
            this.tbNamaDokter.Location = new System.Drawing.Point(128, 106);
            this.tbNamaDokter.Name = "tbNamaDokter";
            this.tbNamaDokter.Size = new System.Drawing.Size(167, 20);
            this.tbNamaDokter.TabIndex = 7;
            // 
            // tbIDDokter
            // 
            this.tbIDDokter.Location = new System.Drawing.Point(128, 68);
            this.tbIDDokter.Name = "tbIDDokter";
            this.tbIDDokter.Size = new System.Drawing.Size(167, 20);
            this.tbIDDokter.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jadwal Praktek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Spesialis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Dokter";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddokterDataGridViewTextBoxColumn,
            this.namaDokterDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.noHPDataGridViewTextBoxColumn,
            this.spesialisDataGridViewTextBoxColumn,
            this.jadwalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataDokterBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 331);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dataDokterBindingSource
            // 
            this.dataDokterBindingSource.DataMember = "dataDokter";
            this.dataDokterBindingSource.DataSource = this.dbRSDataSet;
            // 
            // dbRSDataSet
            // 
            this.dbRSDataSet.DataSetName = "dbRSDataSet";
            this.dbRSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataDokterTableAdapter
            // 
            this.dataDokterTableAdapter.ClearBeforeFill = true;
            // 
            // iddokterDataGridViewTextBoxColumn
            // 
            this.iddokterDataGridViewTextBoxColumn.DataPropertyName = "id_dokter";
            this.iddokterDataGridViewTextBoxColumn.HeaderText = "ID Dokter";
            this.iddokterDataGridViewTextBoxColumn.Name = "iddokterDataGridViewTextBoxColumn";
            // 
            // namaDokterDataGridViewTextBoxColumn
            // 
            this.namaDokterDataGridViewTextBoxColumn.DataPropertyName = "namaDokter";
            this.namaDokterDataGridViewTextBoxColumn.HeaderText = "Nama Dokter";
            this.namaDokterDataGridViewTextBoxColumn.Name = "namaDokterDataGridViewTextBoxColumn";
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "JenisKelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            // 
            // noHPDataGridViewTextBoxColumn
            // 
            this.noHPDataGridViewTextBoxColumn.DataPropertyName = "NoHP";
            this.noHPDataGridViewTextBoxColumn.HeaderText = "No HP";
            this.noHPDataGridViewTextBoxColumn.Name = "noHPDataGridViewTextBoxColumn";
            // 
            // spesialisDataGridViewTextBoxColumn
            // 
            this.spesialisDataGridViewTextBoxColumn.DataPropertyName = "Spesialis";
            this.spesialisDataGridViewTextBoxColumn.HeaderText = "Spesialis";
            this.spesialisDataGridViewTextBoxColumn.Name = "spesialisDataGridViewTextBoxColumn";
            // 
            // jadwalDataGridViewTextBoxColumn
            // 
            this.jadwalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jadwalDataGridViewTextBoxColumn.DataPropertyName = "jadwal";
            this.jadwalDataGridViewTextBoxColumn.HeaderText = "Jadwal Praktek";
            this.jadwalDataGridViewTextBoxColumn.Name = "jadwalDataGridViewTextBoxColumn";
            // 
            // dataDokterBindingSource1
            // 
            this.dataDokterBindingSource1.DataMember = "dataDokter";
            this.dataDokterBindingSource1.DataSource = this.dbRSDataSetfix;
            // 
            // dbRSDataSetfix
            // 
            this.dbRSDataSetfix.DataSetName = "dbRSDataSetfix";
            this.dbRSDataSetfix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataDokterTableAdapter1
            // 
            this.dataDokterTableAdapter1.ClearBeforeFill = true;
            // 
            // FormDataDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDataDokter";
            this.Text = "Data Dokter Baru";
            this.Load += new System.EventHandler(this.FormCreateDokter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDokterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDokterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSetfix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox tbJP;
        private System.Windows.Forms.TextBox tbSpesialis;
        private System.Windows.Forms.TextBox tbNohp;
        private System.Windows.Forms.TextBox tbNamaDokter;
        private System.Windows.Forms.TextBox tbIDDokter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbJK;
        private dbRSDataSet dbRSDataSet;
        private System.Windows.Forms.BindingSource dataDokterBindingSource;
        private dbRSDataSetTableAdapters.dataDokterTableAdapter dataDokterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spesialisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jadwalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private dbRSDataSetfix dbRSDataSetfix;
        private System.Windows.Forms.BindingSource dataDokterBindingSource1;
        private dbRSDataSetfixTableAdapters.dataDokterTableAdapter dataDokterTableAdapter1;
    }
}