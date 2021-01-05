namespace tapabd_rumahsakit
{
    partial class FormLorong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLorong));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idlorongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namalorongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lantaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lorongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbRSDataSetfix = new tapabd_rumahsakit.dbRSDataSetfix();
            this.lorongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbRSDataSet = new tapabd_rumahsakit.dbRSDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.cbLantai = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.tbNamaLorong = new System.Windows.Forms.TextBox();
            this.tbIDLorong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lorongTableAdapter = new tapabd_rumahsakit.dbRSDataSetTableAdapters.LorongTableAdapter();
            this.lorongTableAdapter1 = new tapabd_rumahsakit.dbRSDataSetfixTableAdapters.LorongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSetfix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlorongDataGridViewTextBoxColumn,
            this.namalorongDataGridViewTextBoxColumn,
            this.lantaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lorongBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(83, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idlorongDataGridViewTextBoxColumn
            // 
            this.idlorongDataGridViewTextBoxColumn.DataPropertyName = "id_lorong";
            this.idlorongDataGridViewTextBoxColumn.HeaderText = "ID Lorong";
            this.idlorongDataGridViewTextBoxColumn.Name = "idlorongDataGridViewTextBoxColumn";
            // 
            // namalorongDataGridViewTextBoxColumn
            // 
            this.namalorongDataGridViewTextBoxColumn.DataPropertyName = "namalorong";
            this.namalorongDataGridViewTextBoxColumn.HeaderText = "Nama Lorong";
            this.namalorongDataGridViewTextBoxColumn.Name = "namalorongDataGridViewTextBoxColumn";
            // 
            // lantaiDataGridViewTextBoxColumn
            // 
            this.lantaiDataGridViewTextBoxColumn.DataPropertyName = "lantai";
            this.lantaiDataGridViewTextBoxColumn.HeaderText = "lantai";
            this.lantaiDataGridViewTextBoxColumn.Name = "lantaiDataGridViewTextBoxColumn";
            // 
            // lorongBindingSource1
            // 
            this.lorongBindingSource1.DataMember = "Lorong";
            this.lorongBindingSource1.DataSource = this.dbRSDataSetfix;
            // 
            // dbRSDataSetfix
            // 
            this.dbRSDataSetfix.DataSetName = "dbRSDataSetfix";
            this.dbRSDataSetfix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lorongBindingSource
            // 
            this.lorongBindingSource.DataMember = "Lorong";
            this.lorongBindingSource.DataSource = this.dbRSDataSet;
            // 
            // dbRSDataSet
            // 
            this.dbRSDataSet.DataSetName = "dbRSDataSet";
            this.dbRSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.cbLantai);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.tbNamaLorong);
            this.groupBox1.Controls.Add(this.tbIDLorong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(458, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data Lorong";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(166, 190);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cbLantai
            // 
            this.cbLantai.FormattingEnabled = true;
            this.cbLantai.Location = new System.Drawing.Point(81, 99);
            this.cbLantai.Name = "cbLantai";
            this.cbLantai.Size = new System.Drawing.Size(160, 21);
            this.cbLantai.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(247, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(85, 190);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(6, 190);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tbNamaLorong
            // 
            this.tbNamaLorong.Location = new System.Drawing.Point(81, 135);
            this.tbNamaLorong.Name = "tbNamaLorong";
            this.tbNamaLorong.Size = new System.Drawing.Size(160, 20);
            this.tbNamaLorong.TabIndex = 5;
            // 
            // tbIDLorong
            // 
            this.tbIDLorong.Location = new System.Drawing.Point(81, 58);
            this.tbIDLorong.Name = "tbIDLorong";
            this.tbIDLorong.Size = new System.Drawing.Size(160, 20);
            this.tbIDLorong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lantai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Lorong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // lorongTableAdapter
            // 
            this.lorongTableAdapter.ClearBeforeFill = true;
            // 
            // lorongTableAdapter1
            // 
            this.lorongTableAdapter1.ClearBeforeFill = true;
            // 
            // FormLorong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLorong";
            this.Text = "Form Lorong";
            this.Load += new System.EventHandler(this.FormLorong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSetfix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lorongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRSDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNamaLorong;
        private System.Windows.Forms.TextBox tbIDLorong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSimpan;
        private dbRSDataSet dbRSDataSet;
        private System.Windows.Forms.BindingSource lorongBindingSource;
        private dbRSDataSetTableAdapters.LorongTableAdapter lorongTableAdapter;
        private System.Windows.Forms.ComboBox cbLantai;
        private System.Windows.Forms.Button btnDel;
        private dbRSDataSetfix dbRSDataSetfix;
        private System.Windows.Forms.BindingSource lorongBindingSource1;
        private dbRSDataSetfixTableAdapters.LorongTableAdapter lorongTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlorongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namalorongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lantaiDataGridViewTextBoxColumn;
    }
}