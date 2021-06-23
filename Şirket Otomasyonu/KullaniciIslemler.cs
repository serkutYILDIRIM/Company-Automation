using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Şirket_Otomasyonu
{
    class KullaniciIslemler
    {
        private static KullaniciIslemler nesneKullaniciIslemler = new KullaniciIslemler();

        private KullaniciIslemler()
        {
            Baglan();
        }

        public static KullaniciIslemler NesneKullaniciIslemler()
        {
            return nesneKullaniciIslemler;
        }
        SqlConnection con;
        SqlCommand cmd;
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=SirketOtomasyonu;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<Kullanici> Listele()
        {
            try
            {
                List<Kullanici> kullaniciListesi = new List<Kullanici>();
                cmd.CommandText = "Select * From login";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kullanici kl = new Kullanici();
                    kl.Sirano = Convert.ToInt32(reader[0].ToString());
                    kl.Kullanıcıadı = reader[1].ToString();
                    kl.Şifre = reader[2].ToString();
                    kl.Yetki = Convert.ToInt32(reader[3].ToString());
                    kullaniciListesi.Add(kl);
                }

                return kullaniciListesi;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        public void Guncelle(Kullanici eskiKullanici, Kullanici yeniKullanici)
        {
            try
            {
                cmd.CommandText = "Update login SET kullaniciadi='" + yeniKullanici.Kullanıcıadı + "',sifre='" + yeniKullanici.Şifre + "',yetki='" + yeniKullanici.Yetki + "' Where sirano=" + eskiKullanici.Sirano + "";
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

        }
        public void Sil(Kullanici k)
        {
            try
            {
                cmd.CommandText = "Delete From login Where sirano=" + k.Sirano + "";
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}
