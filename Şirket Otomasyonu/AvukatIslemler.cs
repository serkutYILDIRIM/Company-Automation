using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Şirket_Otomasyonu
{
    class AvukatIslemler
    {
        SqlConnection con;
        SqlCommand cmd;
        public AvukatIslemler()
        {
            Baglan();
        }
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=SirketOtomasyonu;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<Avukat> Listele()
        {

            try
            {
                List<Avukat> avukatListesi = new List<Avukat>();
                cmd.CommandText = "Select *From avukat";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Avukat av = new Avukat();
                    av.PersonelId = Convert.ToInt32(reader[0].ToString());
                    av.TcNo = Convert.ToInt32(reader[1].ToString());
                    av.DogumTarihi = reader[2].ToString();
                    av.Ad = reader[3].ToString();
                    av.Soyad = reader[4].ToString();
                    av.Cinsiyet = reader[5].ToString();
                    av.Adres = reader[6].ToString();
                    av.Maas = Convert.ToInt32(reader[7].ToString());
                    av.CalismaYili = Convert.ToInt32(reader[8].ToString());
                    av.SigortaNO = Convert.ToInt32(reader[9].ToString());
                    av.Bolum = reader[10].ToString();
                    av.DavaBolumu = reader[11].ToString();
                    avukatListesi.Add(av);
                }

                return avukatListesi;
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
        public void Ekle(Avukat a)
        {
            try
            {
                cmd.CommandText = "Insert Into avukat (id,tcNo,dogumTarihi,ad,soyad,cinsiyet,adres,maas,calismaYili,sigortaNo,bolum,davaBolumu) Values (" + a.PersonelId + ",'" + a.TcNo + "','" + a.DogumTarihi + "','" + a.Ad + "','" + a.Soyad + "','" + a.Cinsiyet + "','" + a.Adres + "','" + a.Maas + "','" + a.CalismaYili + "','" + a.SigortaNO + "','" + a.Bolum + "','" + a.DavaBolumu + "')";

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
        public void Guncelle(Avukat eskiAvukat, Avukat yeniAvukat)
        {
            try
            {
                cmd.CommandText = "Update avukat SET davaBolumu='" + yeniAvukat.DavaBolumu + "',tcNo='" + yeniAvukat.TcNo + "',dogumTarihi='" + yeniAvukat.DogumTarihi + "',ad='" + yeniAvukat.Ad + "',soyad='" + yeniAvukat.Soyad + "',cinsiyet='" + yeniAvukat.Cinsiyet + "',adres='" + yeniAvukat.Adres + "',maas='" + yeniAvukat.Maas + "',calismaYili='" + yeniAvukat.CalismaYili + "',sigortaNo='" + yeniAvukat.SigortaNO + "',bolum='" + yeniAvukat.Bolum + "' Where id=" + eskiAvukat.PersonelId + "";
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
        public void Sil(Avukat a)
        {
            try
            {
                cmd.CommandText = "Delete From avukat Where id=" + a.PersonelId + "";
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
