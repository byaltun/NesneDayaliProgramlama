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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenciform=new Ogrenci();
            this.Hide();
            ogrenciform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yonetim yonetimform =new Yonetim();
            this.Hide();
            yonetimform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ders dersform = new Ders();
            this.Hide();
            dersform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrenciDers ogrencidform = new OgrenciDers();
            this.Hide();
            ogrencidform.Show();
        }
    }
}
