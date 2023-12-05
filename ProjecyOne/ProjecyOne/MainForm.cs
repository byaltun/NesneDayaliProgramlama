using ProjecyOne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecyOne
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Dosya Sekmesine Tıklandı.";
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ders Sekmesine Tıklandı.";
        }

        private void ögrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text="Öğrenci Sekmesine Tıklandı.";
        }

        private void yönetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Yönetim Sekmesine Tıklandı.";
        }

        private void öğrenciDersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Öğrenci Ders Sekmesine Tıklandı.";
        }

        private void dersListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var derslistele = new DersListele();
            derslistele.Show();
        }

        private void dersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ders kısmına girildi.";
            var dersgiris = new Ders();
            dersgiris.Show();
        }

        private void öğrenciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Öğrenci kısmına girildi.";
            var ogrencigiris = new Ogrenci();
            ogrencigiris.Show();
        }

        private void yönetimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Yönetim kısmına girildi.";
            var yonetimgiris = new Yonetim();
            yonetimgiris.Show();
        }

        private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Öğrenci Ders kısmına girildi.";
            var ogrencidersgiris = new OgrenciDers();
            ogrencidersgiris.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void öğrenciListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ogrencilistelegiris = new OgrenciListele();
            ogrencilistelegiris.Show();

            toolStripStatusLabel1.Text = "Öğrenci Listele kısmına girildi.";
        }

        private void yönetimListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yonetimlistelegiris=new YonetimListele();
            yonetimlistelegiris.Show();
            toolStripStatusLabel1.Text = "Yönetim Listele kısmına girildi.";
        }

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ogrenciderslistelegiris= new OgrenciListele();
            ogrenciderslistelegiris.Show();
            toolStripStatusLabel1.Text = "Öğrenci Ders Listele kısmına girildi.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
