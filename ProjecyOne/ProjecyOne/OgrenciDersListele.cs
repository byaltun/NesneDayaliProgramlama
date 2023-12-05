﻿using System;
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
    public partial class OgrenciDersListele : Form
    {
        public OgrenciDersListele()
        {
            InitializeComponent();
        }

        private void OgrenciDers_Load(object sender, EventArgs e)
        {
            ogrenciderslistele();

        }

        static string conString = "Server=LAPTOP-U5UALCJD\\BURAK;Database=idareDB;User ID = sa; Password=1234;";

        SqlConnection baglanti = new SqlConnection(conString);
        idarecontext db = new idarecontext();
        public void ogrenciderslistele()
        {
            var ders = (from x in db.Derstbls
                         select new
                         {
                             x.id,
                             x.adsoyad,
                         }).ToList();

            var ogrenci = (from x in db.ogrenciTbls
                         select new
                         {
                             x.id,
                             x.adsoyad,
                         }).ToList();

            baglanti.Open();
            string kayit = "SELECT * from OgrenciDersTbls";
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
            string kayit = "insert into OgrenciDersTbls(DersId_id,OgrenciId_id) values (@p1,@p2)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ogrenciderslistele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string kayit = "delete from OgrenciDersTbls where id=@p1";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ogrenciderslistele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string kayit = "update OgrenciDersTbls set DersId_id=@p2,OgrenciId_id=@p3 where id=@p1";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ogrenciderslistele();
        }
    }
}
