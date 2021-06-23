using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Şirket_Otomasyonu
{
    class MuhendisIslemler
    {
        SqlConnection con;
        SqlCommand cmd;
        public MuhendisIslemler()
        {
            Baglan();
        }
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=SirketOtomasyonu;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<Muhendis> Listele()
        {

            try
            {
                List<Muhendis> muhendisListesi = new List<Muhendis>();
                cmd.CommandText = "Select *From muhendis";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Muhendis mh = new Muhendis();
                    mh.PersonelId = Convert.ToInt32(reader[0].ToString());
                    mh.TcNo = Convert.ToInt32(reader[1].ToString());
                    mh.DogumTarihi = reader[2].ToString();
                    mh.Ad = reader[3].ToString();
                    mh.Soyad = reader[4].ToString();
                    mh.Cinsiyet = reader[5].ToString();
                    mh.Adres = reader[6].ToString();
                    mh.Maas = Convert.ToInt32(reader[7].ToString());
                    mh.CalismaYili = Convert.ToInt32(reader[8].ToString());
                    mh.SigortaNO = Convert.ToInt32(reader[9].ToString());
                    mh.Bolum = reader[10].ToString();
                    mh.Alan = reader[11].ToString();
                    muhendisListesi.Add(mh);
                }

                return muhendisListesi;
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
        public void Ekle(Muhendis m)
        {
            try
            {
                cmd.CommandText = "Insert Into muhendis (id,tcNo,dogumTarihi,ad,soyad,cinsiyet,adres,maas,calismaYili,sigortaNo,bolum,alan) Values ("+ m.PersonelId + ",'" + m.TcNo + "','" + m.DogumTarihi + "','" + m.Ad + "','" + m.Soyad + "','" + m.Cinsiyet + "','" + m.Adres + "','" + m.Maas + "','" + m.CalismaYili + "','" + m.SigortaNO + "','" + m.Bolum + "','" + m.Alan + "')";

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
        public void Guncelle(Muhendis eskiMuhendis, Muhendis yeniMuhendis)
        {
            try
            {
                cmd.CommandText = "Update muhendis SET alan='" + yeniMuhendis.Alan + "',tcNo='" + yeniMuhendis.TcNo + "',dogumTarihi='" + yeniMuhendis.DogumTarihi + "',ad='" + yeniMuhendis.Ad + "',soyad='" + yeniMuhendis.Soyad + "',cinsiyet='" + yeniMuhendis.Cinsiyet + "',adres='" + yeniMuhendis.Adres + "',maas='" + yeniMuhendis.Maas + "',calismaYili='" + yeniMuhendis.CalismaYili + "',sigortaNo='" + yeniMuhendis.SigortaNO + "',bolum='" + yeniMuhendis.Bolum + "' Where id=" + eskiMuhendis.PersonelId + "";
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
        public void Sil(Muhendis m)
        {
            try
            {
                cmd.CommandText = "Delete From muhendis Where id=" + m.PersonelId + "";
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
