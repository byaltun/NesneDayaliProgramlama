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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjecyOne
{
    public partial class OgrenciListele : Form
    {
        public OgrenciListele()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {

            ogrencilistele();
               
        }
        static string conString = "Server=LAPTOP-U5UALCJD\\BURAK;Database=idareDB;User ID = sa; Password=1234;";

        SqlConnection baglanti = new SqlConnection(conString);
        public void ogrencilistele()
        {
            baglanti.Open();
            string kayit = "SELECT * from ogrenciTbls";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string kayit = "insert into OgrenciTbls(adsoyad,ogrenciNo,dTarihi,kTarihi,bolum) values (@p1,@p2,@p3,@p4,@p5)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ogrencilistele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string kayit = "update OgrenciTbls set adsoyad=@p2,ogrenciNo=@p3,dTarihi=@p4,kTarihi=@p5,bolum=@p6 where id=@p1";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ogrencilistele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "delete from OgrenciTbls where id=@p1";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                ogrencilistele();
            }
            catch (Exception)
            {
                MessageBox.Show("Silmeye çalıştığınız veri Ders tablosunda kullanılıyor.");
            }
        }
    }
}
