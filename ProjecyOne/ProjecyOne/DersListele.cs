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
    public partial class DersListele : Form
    {
        public DersListele()
        {
            InitializeComponent();
        }

        private void Ders_Load(object sender, EventArgs e)
        {

            derslistele();

        }
        static string conString = "Server=LAPTOP-U5UALCJD\\BURAK;Database=idareDB;User ID = sa; Password=1234;";

        SqlConnection baglanti = new SqlConnection(conString);
        public void derslistele()
        {
            var yonetim = (from x in db.OkulYonetimtbls
                         select new
                         {
                             x.id,
                             x.adsoyad
                         }).ToList();

            baglanti.Open();
            string kayit = "SELECT * from DersTbls";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        idarecontext db = new idarecontext();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string kayit = "insert into DersTbls(adsoyad,kredisi,OkulYonetimID_id) values (@p1,@p2,@p3)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            derslistele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string kayit = "update DersTbls set adsoyad=@p2,kredisi=@p3,OkulYonetimID_id=@p4 where id=@p1";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            derslistele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "delete from DersTbls where id=@p1";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                derslistele();
            }
            catch (Exception)
            {
                MessageBox.Show("Silmeye çalıştığınız veri Öğrenci Ders tablosunda kullanılıyor.");
            }
        }
    }
}

