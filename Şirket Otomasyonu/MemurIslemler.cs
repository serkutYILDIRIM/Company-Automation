using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Şirket_Otomasyonu
{
    class MemurIslemler
    {
        SqlConnection con;
        SqlCommand cmd;
        public MemurIslemler()
        {
            Baglan();
        }
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=SirketOtomasyonu;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<Memur> Listele()
        {

            try
            {
                List<Memur> memurListesi = new List<Memur>();
                cmd.CommandText = "Select *From memur";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Memur mr = new Memur();
                    mr.PersonelId = Convert.ToInt32(reader[0].ToString());
                    mr.TcNo = Convert.ToInt32(reader[1].ToString());
                    mr.DogumTarihi = reader[2].ToString();
                    mr.Ad = reader[3].ToString();
                    mr.Soyad = reader[4].ToString();
                    mr.Cinsiyet = reader[5].ToString();
                    mr.Adres = reader[6].ToString();
                    mr.Maas = Convert.ToInt32(reader[7].ToString());
                    mr.CalismaYili = Convert.ToInt32(reader[8].ToString());
                    mr.SigortaNO = Convert.ToInt32(reader[9].ToString());
                    mr.Bolum = reader[10].ToString();
                    mr.Unvan = reader[11].ToString();
                    memurListesi.Add(mr);
                }

                return memurListesi;
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
        public void Ekle(Memur m)
        {
            try
            {
                cmd.CommandText = "Insert Into memur (id,tcNo,dogumTarihi,ad,soyad,cinsiyet,adres,maas,calismaYili,sigortaNo,bolum,unvan) Values (" + m.PersonelId + ",'" + m.TcNo + "','" + m.DogumTarihi + "','" + m.Ad + "','" + m.Soyad + "','" + m.Cinsiyet + "','" + m.Adres + "','" + m.Maas + "','" + m.CalismaYili + "','" + m.SigortaNO + "','" + m.Bolum + "','" + m.Unvan + "')";

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
        public void Guncelle(Memur eskiMemur, Memur yeniMemur)
        {
            try
            {
                cmd.CommandText = "Update memur SET unvan='" + yeniMemur.Unvan + "',tcNo='" + yeniMemur.TcNo + "',dogumTarihi='" + yeniMemur.DogumTarihi + "',ad='" + yeniMemur.Ad + "',soyad='" + yeniMemur.Soyad + "',cinsiyet='" + yeniMemur.Cinsiyet + "',adres='" + yeniMemur.Adres + "',maas='" + yeniMemur.Maas + "',calismaYili='" + yeniMemur.CalismaYili + "',sigortaNo='" + yeniMemur.SigortaNO + "',bolum='" + yeniMemur.Bolum + "' Where id=" + eskiMemur.PersonelId + "";
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
        public void Sil(Memur m)
        {
            try
            {
                cmd.CommandText = "Delete From memur Where id=" + m.PersonelId + "";
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
