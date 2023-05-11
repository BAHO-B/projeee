using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataModel
    {
        private readonly string connectionString;

        SqlConnection con;
        SqlDataReader reader;
        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            connectionString = ConnectionStrings.ConStr;
        }

        public bool YetkiliGiris(string kullaniciAdi, string sifre)
        {
            bool girisBasarili = false;

            try
            {
                con.Open();
                string query = "SELECT * FROM YETKİLİBİLGİLERİ WHERE kullanıcıadı=@kullaniciAdi AND şifre=@sifre";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    girisBasarili = true;
                }
            }
            catch
            {
                girisBasarili = false;
            }
            finally
            {
                con.Close();
            }

            return girisBasarili;
        }

        public bool OgrenciGiris(string kullaniciAdi, string sifre)
        {
            bool girisBasarili = false;
            SqlDataReader reader;

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * FROM ÖĞRENCİBİLGİLERİ WHERE kullanıcıadı=@kullaniciAdi AND şifre=@sifre";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    girisBasarili = true;
                }
            }
            catch
            {
                girisBasarili = false;
            }
            finally
            {
                con.Close();
            }

            return girisBasarili;
        }

        public bool OgrenciKayit(string adsoyad, string kullaniciadi, string email, string sifre)
        {
            bool kayitBasarili = false;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open(); string query = "INSERT INTO ÖĞRENCİBİLGİLERİ (öğrenciadsoyad, kullanıcıadı, email, şifre) VALUES (@adsoyad, @kullaniciadi, @email, @sifre)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@adsoyad", adsoyad);
                cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    kayitBasarili = true;
                }
            }
            catch
            {
                kayitBasarili = false;
            }
            finally
            {
                conn.Close();
            }
            return kayitBasarili;
        }

        public void KitapListele(out SqlDataReader reader)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KİTAPBİLGİLERİ", con);
            con.Open();
            reader = cmd.ExecuteReader();
        }

        public void KitapSil(int id)
        {
            SqlConnection con2 = new SqlConnection(connectionString);
            try
            {
                con2.Open();
                string query = "DELETE FROM TBLKİTAPBİLGİLERİ WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, con2);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con2.Close();
            }
        }

        public bool KitapEkle(string kitapAdi, string kategori, string yazar, string sayfaSayisi)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO KİTAPBİLGİLERİ (kitapadı, kategorisi, yazarı, sayfasayısı) VALUES (@kitapadi, @kategori, @yazar, @sayfasayisi)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@kitapadi", kitapAdi);
                cmd.Parameters.AddWithValue("@kategori", kategori);
                cmd.Parameters.AddWithValue("@yazar", yazar);
                cmd.Parameters.AddWithValue("@sayfasayisi", sayfaSayisi);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public void KitapGetir(int id, out string kitapadi, out string kategori, out string yazar, out string sayfasayisi)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KİTAPBİLGİLERİ WHERE id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                kitapadi = reader["kitapadı"].ToString();
                kategori = reader["kategorisi"].ToString();
                yazar = reader["yazarı"].ToString();
                sayfasayisi = reader["sayfasayısı"].ToString();
            }
            else
            {
                kitapadi = kategori = yazar = sayfasayisi = string.Empty;
            }
            reader.Close();
            con.Close();
        }
        public bool KitapGüncelle(int id, string kitapAdi, string kategori, string yazar, string sayfaSayisi)
        {
            bool basarili = false;
            try
            {
                con.Open();
                string query = "UPDATE KİTAPBİLGİLERİ SET kitapadı=@kitapAdi, kategorisi=@kategori, yazarı=@yazar, sayfasayısı=@sayfaSayisi WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@kitapAdi", kitapAdi);
                cmd.Parameters.AddWithValue("@kategori", kategori);
                cmd.Parameters.AddWithValue("@yazar", yazar);
                cmd.Parameters.AddWithValue("@sayfaSayisi", sayfaSayisi);
                int x = cmd.ExecuteNonQuery();
                basarili = (x > 0);
            }
            catch
            {
                basarili = false;
            }
            finally
            {
                con.Close();
            }
            return basarili;
        }
    }
}
