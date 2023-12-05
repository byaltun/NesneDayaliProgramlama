namespace ProjecyOne
{
    partial class Ogrenci
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
            this.lblIsimSoyisim = new System.Windows.Forms.Label();
            this.textBoxIsimSoyisim = new System.Windows.Forms.TextBox();
            this.lblBolum = new System.Windows.Forms.Label();
            this.textBoxBolum = new System.Windows.Forms.TextBox();
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.textBoxOgrNo = new System.Windows.Forms.TextBox();
            this.lblKTarihi = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.textBoxKTarihi = new System.Windows.Forms.TextBox();
            this.textBoxDTarihi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIsimSoyisim
            // 
            this.lblIsimSoyisim.AutoSize = true;
            this.lblIsimSoyisim.Location = new System.Drawing.Point(51, 108);
            this.lblIsimSoyisim.Name = "lblIsimSoyisim";
            this.lblIsimSoyisim.Size = new System.Drawing.Size(82, 16);
            this.lblIsimSoyisim.TabIndex = 0;
            this.lblIsimSoyisim.Text = "İsim Soyisim";
            // 
            // textBoxIsimSoyisim
            // 
            this.textBoxIsimSoyisim.Location = new System.Drawing.Point(193, 102);
            this.textBoxIsimSoyisim.Name = "textBoxIsimSoyisim";
            this.textBoxIsimSoyisim.Size = new System.Drawing.Size(100, 22);
            this.textBoxIsimSoyisim.TabIndex = 1;
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Location = new System.Drawing.Point(51, 151);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(45, 16);
            this.lblBolum.TabIndex = 2;
            this.lblBolum.Text = "Bölüm";
            // 
            // textBoxBolum
            // 
            this.textBoxBolum.Location = new System.Drawing.Point(193, 148);
            this.textBoxBolum.Name = "textBoxBolum";
            this.textBoxBolum.Size = new System.Drawing.Size(100, 22);
            this.textBoxBolum.TabIndex = 3;
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.Location = new System.Drawing.Point(416, 154);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(72, 16);
            this.lblOgrenciNo.TabIndex = 4;
            this.lblOgrenciNo.Text = "ÖğrenciNo";
            // 
            // textBoxOgrNo
            // 
            this.textBoxOgrNo.Location = new System.Drawing.Point(580, 154);
            this.textBoxOgrNo.Name = "textBoxOgrNo";
            this.textBoxOgrNo.Size = new System.Drawing.Size(100, 22);
            this.textBoxOgrNo.TabIndex = 5;
            // 
            // lblKTarihi
            // 
            this.lblKTarihi.AutoSize = true;
            this.lblKTarihi.Location = new System.Drawing.Point(415, 60);
            this.lblKTarihi.Name = "lblKTarihi";
            this.lblKTarihi.Size = new System.Drawing.Size(73, 16);
            this.lblKTarihi.TabIndex = 6;
            this.lblKTarihi.Text = "Kayıt Tarihi";
            this.lblKTarihi.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(415, 108);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(88, 16);
            this.lblDogumTarihi.TabIndex = 7;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // textBoxKTarihi
            // 
            this.textBoxKTarihi.Location = new System.Drawing.Point(580, 54);
            this.textBoxKTarihi.Name = "textBoxKTarihi";
            this.textBoxKTarihi.Size = new System.Drawing.Size(100, 22);
            this.textBoxKTarihi.TabIndex = 8;
            // 
            // textBoxDTarihi
            // 
            this.textBoxDTarihi.Location = new System.Drawing.Point(580, 108);
            this.textBoxDTarihi.Name = "textBoxDTarihi";
            this.textBoxDTarihi.Size = new System.Drawing.Size(100, 22);
            this.textBoxDTarihi.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 264);
            this.dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(193, 54);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 12;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(134, 203);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(352, 203);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(580, 203);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 521);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxDTarihi);
            this.Controls.Add(this.textBoxKTarihi);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblKTarihi);
            this.Controls.Add(this.textBoxOgrNo);
            this.Controls.Add(this.lblOgrenciNo);
            this.Controls.Add(this.textBoxBolum);
            this.Controls.Add(this.lblBolum);
            this.Controls.Add(this.textBoxIsimSoyisim);
            this.Controls.Add(this.lblIsimSoyisim);
            this.Name = "Ogrenci";
            this.Text = "Ogrenci";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsimSoyisim;
        private System.Windows.Forms.TextBox textBoxIsimSoyisim;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.TextBox textBoxBolum;
        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.TextBox textBoxOgrNo;
        private System.Windows.Forms.Label lblKTarihi;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.TextBox textBoxKTarihi;
        private System.Windows.Forms.TextBox textBoxDTarihi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}