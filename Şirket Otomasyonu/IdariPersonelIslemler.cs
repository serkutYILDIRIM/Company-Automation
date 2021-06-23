using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Şirket_Otomasyonu
{
    class IdariPersonelIslemler
    {
        SqlConnection con;
        SqlCommand cmd;
        public IdariPersonelIslemler()
        {
            Baglan();
        }
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=SirketOtomasyonu;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<IdariPersonel> Listele()
        {

            try
            {
                List<IdariPersonel> idariPersonelListesi = new List<IdariPersonel>();
                cmd.CommandText = "Select *From idariPersonel";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IdariPersonel ip = new IdariPersonel();
                    ip.PersonelId = Convert.ToInt32(reader[0].ToString());
                    ip.TcNo = Convert.ToInt32(reader[1].ToString());
                    ip.DogumTarihi = reader[2].ToString();
                    ip.Ad = reader[3].ToString();
                    ip.Soyad = reader[4].ToString();
                    ip.Cinsiyet = reader[5].ToString();
                    ip.Adres = reader[6].ToString();
                    ip.Maas = Convert.ToInt32(reader[7].ToString());
                    ip.CalismaYili = Convert.ToInt32(reader[8].ToString());
                    ip.SigortaNO = Convert.ToInt32(reader[9].ToString());
                    ip.Bolum = reader[10].ToString();
                    ip.Yetki = reader[11].ToString();
                    idariPersonelListesi.Add(ip);
                }

                return idariPersonelListesi;
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
        public void Ekle(IdariPersonel i)
        {
            try
            {
                cmd.CommandText = "Insert Into idariPersonel (id,tcNo,dogumTarihi,ad,soyad,cinsiyet,adres,maas,calismaYili,sigortaNo,bolum,yetki) Values (" + i.PersonelId + ",'" + i.TcNo + "','" + i.DogumTarihi + "','" + i.Ad + "','" + i.Soyad + "','" + i.Cinsiyet + "','" + i.Adres + "','" + i.Maas + "','" + i.CalismaYili + "','" + i.SigortaNO + "','" + i.Bolum + "','" + i.Yetki + "')";

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
        public void Guncelle(IdariPersonel eskiIdariPersonel, IdariPersonel yeniIdariPersonel)
        {
            try
            {
                cmd.CommandText = "Update idariPersonel SET yetki='" + yeniIdariPersonel.Yetki + "',tcNo='" + yeniIdariPersonel.TcNo + "',dogumTarihi='" + yeniIdariPersonel.DogumTarihi + "',ad='" + yeniIdariPersonel.Ad + "',soyad='" + yeniIdariPersonel.Soyad + "',cinsiyet='" + yeniIdariPersonel.Cinsiyet + "',adres='" + yeniIdariPersonel.Adres + "',maas='" + yeniIdariPersonel.Maas + "',calismaYili='" + yeniIdariPersonel.CalismaYili + "',sigortaNo='" + yeniIdariPersonel.SigortaNO + "',bolum='" + yeniIdariPersonel.Bolum + "' Where id=" + eskiIdariPersonel.PersonelId + "";
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
        public void Sil(IdariPersonel i)
        {
            try
            {
                cmd.CommandText = "Delete From idariPersonel Where id=" + i.PersonelId + "";
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
