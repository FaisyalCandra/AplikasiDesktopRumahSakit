namespace tapabd_rumahsakit
{
    partial class FormJDokterAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJDokterAdmin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jadwalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spesialisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDokterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbRSDataSetfix = new tapabd_rumahsakit.dbRSDataSetfix();
            this.dataDokterTableAdapter = new tapabd_rumahsakit.dbRSDataSetfixTableAdapters.dataDokterTableAdapter();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDokterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSetfix)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jadwalDataGridViewTextBoxColumn,
            this.namaDokterDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.noHPDataGridViewTextBoxColumn,
            this.spesialisDataGridViewTextBoxColumn,
            this.iddokterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataDokterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // jadwalDataGridViewTextBoxColumn
            // 
            this.jadwalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jadwalDataGridViewTextBoxColumn.DataPropertyName = "jadwal";
            this.jadwalDataGridViewTextBoxColumn.HeaderText = "Jadwal Dokter";
            this.jadwalDataGridViewTextBoxColumn.Name = "jadwalDataGridViewTextBoxColumn";
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
            // iddokterDataGridViewTextBoxColumn
            // 
            this.iddokterDataGridViewTextBoxColumn.DataPropertyName = "id_dokter";
            this.iddokterDataGridViewTextBoxColumn.HeaderText = "ID Dokter";
            this.iddokterDataGridViewTextBoxColumn.Name = "iddokterDataGridViewTextBoxColumn";
            // 
            // dataDokterBindingSource
            // 
            this.dataDokterBindingSource.DataMember = "dataDokter";
            this.dataDokterBindingSource.DataSource = this.dbRSDataSetfix;
            // 
            // dbRSDataSetfix
            // 
            this.dbRSDataSetfix.DataSetName = "dbRSDataSetfix";
            this.dbRSDataSetfix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataDokterTableAdapter
            // 
            this.dataDokterTableAdapter.ClearBeforeFill = true;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Location = new System.Drawing.Point(216, 36);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(293, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // FormJDokterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormJDokterAdmin";
            this.Text = "Form Jadwal Dokter";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDokterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSetfix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbRSDataSetfix dbRSDataSetfix;
        private System.Windows.Forms.BindingSource dataDokterBindingSource;
        private dbRSDataSetfixTableAdapters.dataDokterTableAdapter dataDokterTableAdapter;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn jadwalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spesialisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}