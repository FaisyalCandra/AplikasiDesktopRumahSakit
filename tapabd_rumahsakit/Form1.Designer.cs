namespace tapabd_rumahsakit
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataPassienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDataPasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDataDokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalDokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLorongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDataPasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPassienToolStripMenuItem,
            this.dataDokterToolStripMenuItem,
            this.ruanganToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataPassienToolStripMenuItem
            // 
            this.dataPassienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDataPasienToolStripMenuItem,
            this.listDataPasienToolStripMenuItem});
            this.dataPassienToolStripMenuItem.Name = "dataPassienToolStripMenuItem";
            this.dataPassienToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dataPassienToolStripMenuItem.Text = "Data Pasien";
            // 
            // createDataPasienToolStripMenuItem
            // 
            this.createDataPasienToolStripMenuItem.Name = "createDataPasienToolStripMenuItem";
            this.createDataPasienToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createDataPasienToolStripMenuItem.Text = "Data Pasien Baru";
            this.createDataPasienToolStripMenuItem.Click += new System.EventHandler(this.createDataPasienToolStripMenuItem_Click);
            // 
            // dataDokterToolStripMenuItem
            // 
            this.dataDokterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDataDokterToolStripMenuItem,
            this.jadwalDokterToolStripMenuItem});
            this.dataDokterToolStripMenuItem.Name = "dataDokterToolStripMenuItem";
            this.dataDokterToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.dataDokterToolStripMenuItem.Text = "Data Dokter";
            // 
            // createDataDokterToolStripMenuItem
            // 
            this.createDataDokterToolStripMenuItem.Name = "createDataDokterToolStripMenuItem";
            this.createDataDokterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createDataDokterToolStripMenuItem.Text = "Data Dokter Baru";
            this.createDataDokterToolStripMenuItem.Click += new System.EventHandler(this.createDataDokterToolStripMenuItem_Click);
            // 
            // jadwalDokterToolStripMenuItem
            // 
            this.jadwalDokterToolStripMenuItem.Name = "jadwalDokterToolStripMenuItem";
            this.jadwalDokterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jadwalDokterToolStripMenuItem.Text = "Jadwal Dokter";
            this.jadwalDokterToolStripMenuItem.Click += new System.EventHandler(this.jadwalDokterToolStripMenuItem_Click);
            // 
            // ruanganToolStripMenuItem
            // 
            this.ruanganToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createLorongToolStripMenuItem,
            this.cToolStripMenuItem});
            this.ruanganToolStripMenuItem.Name = "ruanganToolStripMenuItem";
            this.ruanganToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ruanganToolStripMenuItem.Text = "Ruangan";
            // 
            // createLorongToolStripMenuItem
            // 
            this.createLorongToolStripMenuItem.Name = "createLorongToolStripMenuItem";
            this.createLorongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createLorongToolStripMenuItem.Text = "Lorong";
            this.createLorongToolStripMenuItem.Click += new System.EventHandler(this.createLorongToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem.Text = "Ruangan";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // listDataPasienToolStripMenuItem
            // 
            this.listDataPasienToolStripMenuItem.Name = "listDataPasienToolStripMenuItem";
            this.listDataPasienToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listDataPasienToolStripMenuItem.Text = "List Data Pasien";
            this.listDataPasienToolStripMenuItem.Click += new System.EventHandler(this.listDataPasienToolStripMenuItem_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdmin";
            this.Text = "Form Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataPassienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDataPasienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataDokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDataDokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jadwalDokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLorongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDataPasienToolStripMenuItem;
    }
}

