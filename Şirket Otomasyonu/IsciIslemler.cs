using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Şirket_Otomasyonu
{
    class IsciIslemler
    {
        SqlConnection con;
        SqlCommand cmd;
        public IsciIslemler()
        {
            Baglan();
        }
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=SirketOtomasyonu;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<Isci> Listele()
        {

            try
            {
                List<Isci> IsciListesi = new List<Isci>();
                cmd.CommandText = "Select *From isci";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Isci ic = new Isci();
                    ic.PersonelId = Convert.ToInt32(reader[0].ToString());
                    ic.TcNo = Convert.ToInt32(reader[1].ToString());
                    ic.DogumTarihi = reader[2].ToString();
                    ic.Ad = reader[3].ToString();
                    ic.Soyad = reader[4].ToString();
                    ic.Cinsiyet = reader[5].ToString();
                    ic.Adres = reader[6].ToString();
                    ic.Maas = Convert.ToInt32(reader[7].ToString());
                    ic.CalismaYili = Convert.ToInt32(reader[8].ToString());
                    ic.SigortaNO = Convert.ToInt32(reader[9].ToString());
                    ic.Bolum = reader[10].ToString();
                    ic.Gorev = reader[11].ToString();
                    IsciListesi.Add(ic);
                }

                return IsciListesi;
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
        public void Ekle(Isci i)
        {
            try
            {
                cmd.CommandText = "Insert Into isci (id,tcNo,dogumTarihi,ad,soyad,cinsiyet,adres,maas,calismaYili,sigortaNo,bolum,gorev) Values (" + i.PersonelId + ",'" + i.TcNo + "','" + i.DogumTarihi + "','" + i.Ad + "','" + i.Soyad + "','" + i.Cinsiyet + "','" + i.Adres + "','" + i.Maas + "','" + i.CalismaYili + "','" + i.SigortaNO + "','" + i.Bolum + "','" + i.Gorev + "')";

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
        public void Guncelle(Isci eskiIsci, Isci yeniIsci)
        {
            try
            {
                cmd.CommandText = "Update isci SET gorev='" + yeniIsci.Gorev + "',tcNo='" + yeniIsci.TcNo + "',dogumTarihi='" + yeniIsci.DogumTarihi + "',ad='" + yeniIsci.Ad + "',soyad='" + yeniIsci.Soyad + "',cinsiyet='" + yeniIsci.Cinsiyet + "',adres='" + yeniIsci.Adres + "',maas='" + yeniIsci.Maas + "',calismaYili='" + yeniIsci.CalismaYili + "',sigortaNo='" + yeniIsci.SigortaNO + "',bolum='" + yeniIsci.Bolum + "' Where id=" + eskiIsci.PersonelId + "";
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
        public void Sil(Isci i)
        {
            try
            {
                cmd.CommandText = "Delete From isci Where id=" + i.PersonelId + "";
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
