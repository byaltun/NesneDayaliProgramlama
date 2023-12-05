namespace ProjecyOne
{
    partial class Yonetim
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYTipi = new System.Windows.Forms.TextBox();
            this.textBoxGorev = new System.Windows.Forms.TextBox();
            this.lblYonetimT = new System.Windows.Forms.Label();
            this.lblGorev = new System.Windows.Forms.Label();
            this.textBoxIsimSoyisim = new System.Windows.Forms.TextBox();
            this.lblIsimSoyisim = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(227, 63);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 20;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxYTipi
            // 
            this.textBoxYTipi.Location = new System.Drawing.Point(614, 117);
            this.textBoxYTipi.Name = "textBoxYTipi";
            this.textBoxYTipi.Size = new System.Drawing.Size(100, 22);
            this.textBoxYTipi.TabIndex = 18;
            this.textBoxYTipi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxGorev
            // 
            this.textBoxGorev.Location = new System.Drawing.Point(614, 63);
            this.textBoxGorev.Name = "textBoxGorev";
            this.textBoxGorev.Size = new System.Drawing.Size(100, 22);
            this.textBoxGorev.TabIndex = 17;
            this.textBoxGorev.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblYonetimT
            // 
            this.lblYonetimT.AutoSize = true;
            this.lblYonetimT.Location = new System.Drawing.Point(449, 117);
            this.lblYonetimT.Name = "lblYonetimT";
            this.lblYonetimT.Size = new System.Drawing.Size(82, 16);
            this.lblYonetimT.TabIndex = 16;
            this.lblYonetimT.Text = "Yönetim Tipi";
            this.lblYonetimT.Click += new System.EventHandler(this.lblDogumTarihi_Click);
            // 
            // lblGorev
            // 
            this.lblGorev.AutoSize = true;
            this.lblGorev.Location = new System.Drawing.Point(449, 69);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(44, 16);
            this.lblGorev.TabIndex = 15;
            this.lblGorev.Text = "Görev";
            this.lblGorev.Click += new System.EventHandler(this.lblKTarihi_Click);
            // 
            // textBoxIsimSoyisim
            // 
            this.textBoxIsimSoyisim.Location = new System.Drawing.Point(227, 111);
            this.textBoxIsimSoyisim.Name = "textBoxIsimSoyisim";
            this.textBoxIsimSoyisim.Size = new System.Drawing.Size(100, 22);
            this.textBoxIsimSoyisim.TabIndex = 14;
            this.textBoxIsimSoyisim.TextChanged += new System.EventHandler(this.textBoxOgrenci_TextChanged);
            // 
            // lblIsimSoyisim
            // 
            this.lblIsimSoyisim.AutoSize = true;
            this.lblIsimSoyisim.Location = new System.Drawing.Point(85, 117);
            this.lblIsimSoyisim.Name = "lblIsimSoyisim";
            this.lblIsimSoyisim.Size = new System.Drawing.Size(82, 16);
            this.lblIsimSoyisim.TabIndex = 13;
            this.lblIsimSoyisim.Text = "İsim Soyisim";
            this.lblIsimSoyisim.Click += new System.EventHandler(this.lblIsim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 315);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(617, 162);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 24;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(389, 162);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(171, 162);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // Yonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 538);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxYTipi);
            this.Controls.Add(this.textBoxGorev);
            this.Controls.Add(this.lblYonetimT);
            this.Controls.Add(this.lblGorev);
            this.Controls.Add(this.textBoxIsimSoyisim);
            this.Controls.Add(this.lblIsimSoyisim);
            this.Name = "Yonetim";
            this.Text = "Yonetim";
            this.Load += new System.EventHandler(this.Yonetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYTipi;
        private System.Windows.Forms.TextBox textBoxGorev;
        private System.Windows.Forms.Label lblYonetimT;
        private System.Windows.Forms.Label lblGorev;
        private System.Windows.Forms.TextBox textBoxIsimSoyisim;
        private System.Windows.Forms.Label lblIsimSoyisim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}