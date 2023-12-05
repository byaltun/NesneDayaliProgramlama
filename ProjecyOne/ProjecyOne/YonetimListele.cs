using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecyOne
{
    public partial class YonetimListele : Form
    {
        public YonetimListele()
        {
            InitializeComponent();
        }

        private void lblIsim_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDogumTarihi_Click(object sender, EventArgs e)
        {

        }

        private void lblKTarihi_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOgrenci_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Yonetim_Load(object sender, EventArgs e)
        {
            yonetimlistele();

        }
        static string conString = "Server=LAPTOP-U5UALCJD\\BURAK;Database=idareDB;User ID = sa; Password=1234;";

        SqlConnection baglanti = new SqlConnection(conString);
        public void yonetimlistele()
        {
            baglanti.Open();
            string kayit = "SELECT * from OkulYonetimtbls";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string kayit = "insert into OkulYonetimtbls(adsoyad,gorev,YonetimTip) values (@p1,@p2,@p3)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            yonetimlistele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string kayit = "update OkulYonetimtbls set adsoyad=@p2,gorev=@p3,YonetimTip=@p4 where id=@p1";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            yonetimlistele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "delete from OkulYonetimtbls where id=@p1";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                yonetimlistele();
            }
            catch (Exception)
            {
                MessageBox.Show("Silmeye çalıştığınız veri Ders tablosunda kullanılıyor.");
            }
        }
    }
}