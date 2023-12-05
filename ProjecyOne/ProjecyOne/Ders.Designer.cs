namespace ProjecyOne
{
    partial class Ders
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKredi = new System.Windows.Forms.TextBox();
            this.lblOkulYID = new System.Windows.Forms.Label();
            this.lblKredi = new System.Windows.Forms.Label();
            this.textBoxOgrenci = new System.Windows.Forms.TextBox();
            this.lblIsimSoyisim = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.comboBoxYTipi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 315);
            this.dataGridView1.TabIndex = 30;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(220, 37);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID";
            // 
            // textBoxKredi
            // 
            this.textBoxKredi.Location = new System.Drawing.Point(607, 37);
            this.textBoxKredi.Name = "textBoxKredi";
            this.textBoxKredi.Size = new System.Drawing.Size(100, 22);
            this.textBoxKredi.TabIndex = 26;
            // 
            // lblOkulYID
            // 
            this.lblOkulYID.AutoSize = true;
            this.lblOkulYID.Location = new System.Drawing.Point(442, 91);
            this.lblOkulYID.Name = "lblOkulYID";
            this.lblOkulYID.Size = new System.Drawing.Size(82, 16);
            this.lblOkulYID.TabIndex = 25;
            this.lblOkulYID.Text = "Yönetim Tipi";
            // 
            // lblKredi
            // 
            this.lblKredi.AutoSize = true;
            this.lblKredi.Location = new System.Drawing.Point(442, 43);
            this.lblKredi.Name = "lblKredi";
            this.lblKredi.Size = new System.Drawing.Size(38, 16);
            this.lblKredi.TabIndex = 24;
            this.lblKredi.Text = "Kredi";
            // 
            // textBoxOgrenci
            // 
            this.textBoxOgrenci.Location = new System.Drawing.Point(220, 85);
            this.textBoxOgrenci.Name = "textBoxOgrenci";
            this.textBoxOgrenci.Size = new System.Drawing.Size(100, 22);
            this.textBoxOgrenci.TabIndex = 23;
            // 
            // lblIsimSoyisim
            // 
            this.lblIsimSoyisim.AutoSize = true;
            this.lblIsimSoyisim.Location = new System.Drawing.Point(78, 91);
            this.lblIsimSoyisim.Name = "lblIsimSoyisim";
            this.lblIsimSoyisim.Size = new System.Drawing.Size(24, 16);
            this.lblIsimSoyisim.TabIndex = 22;
            this.lblIsimSoyisim.Text = "Ad";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(614, 136);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(386, 136);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(168, 136);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 31;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // comboBoxYTipi
            // 
            this.comboBoxYTipi.FormattingEnabled = true;
            this.comboBoxYTipi.Location = new System.Drawing.Point(607, 91);
            this.comboBoxYTipi.Name = "comboBoxYTipi";
            this.comboBoxYTipi.Size = new System.Drawing.Size(121, 24);
            this.comboBoxYTipi.TabIndex = 34;
            // 
            // Ders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 529);
            this.Controls.Add(this.comboBoxYTipi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKredi);
            this.Controls.Add(this.lblOkulYID);
            this.Controls.Add(this.lblKredi);
            this.Controls.Add(this.textBoxOgrenci);
            this.Controls.Add(this.lblIsimSoyisim);
            this.Name = "Ders";
            this.Text = "Ders";
            this.Load += new System.EventHandler(this.Ders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKredi;
        private System.Windows.Forms.Label lblOkulYID;
        private System.Windows.Forms.Label lblKredi;
        private System.Windows.Forms.TextBox textBoxOgrenci;
        private System.Windows.Forms.Label lblIsimSoyisim;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox comboBoxYTipi;
    }
}