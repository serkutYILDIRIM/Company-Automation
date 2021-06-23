using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Şirket_Otomasyonu
{
    class GuvenlikPersonelIslemler
    {
        SqlConnection con;
        SqlCommand cmd;
        public GuvenlikPersonelIslemler()
        {
            Baglan();
        }
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=SirketOtomasyonu;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<GuvenlikPersonel> Listele()
        {

            try
            {
                List<GuvenlikPersonel> guvenlikPersonelListesi = new List<GuvenlikPersonel>();
                cmd.CommandText = "Select *From guvenlik";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    GuvenlikPersonel gv = new GuvenlikPersonel();
                    gv.PersonelId = Convert.ToInt32(reader[0].ToString());
                    gv.TcNo = Convert.ToInt32(reader[1].ToString());
                    gv.DogumTarihi = reader[2].ToString();
                    gv.Ad = reader[3].ToString();
                    gv.Soyad = reader[4].ToString();
                    gv.Cinsiyet = reader[5].ToString();
                    gv.Adres = reader[6].ToString();
                    gv.Maas = Convert.ToInt32(reader[7].ToString());
                    gv.CalismaYili = Convert.ToInt32(reader[8].ToString());
                    gv.SigortaNO = Convert.ToInt32(reader[9].ToString());
                    gv.Bolum = reader[10].ToString();
                    gv.SilahliMi = reader[11].ToString();
                    guvenlikPersonelListesi.Add(gv);
                }

                return guvenlikPersonelListesi;
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
        public void Ekle(GuvenlikPersonel g)
        {
            try
            {
                cmd.CommandText = "Insert Into guvenlik (id,tcNo,dogumTarihi,ad,soyad,cinsiyet,adres,maas,calismaYili,sigortaNo,bolum,silahliMi) Values (" + g.PersonelId + ",'" + g.TcNo + "','" + g.DogumTarihi + "','" + g.Ad + "','" + g.Soyad + "','" + g.Cinsiyet + "','" + g.Adres + "','" + g.Maas + "','" + g.CalismaYili + "','" + g.SigortaNO + "','" + g.Bolum + "','" + g.SilahliMi + "')";

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
        public void Guncelle(GuvenlikPersonel eskiGuvenlikPersonel, GuvenlikPersonel yeniGuvenlikPersonel)
        {
            try
            {
                cmd.CommandText = "Update guvenlik SET silahliMi='" + yeniGuvenlikPersonel.SilahliMi + "',tcNo='" + yeniGuvenlikPersonel.TcNo + "',dogumTarihi='" + yeniGuvenlikPersonel.DogumTarihi + "',ad='" + yeniGuvenlikPersonel.Ad + "',soyad='" + yeniGuvenlikPersonel.Soyad + "',cinsiyet='" + yeniGuvenlikPersonel.Cinsiyet + "',adres='" + yeniGuvenlikPersonel.Adres + "',maas='" + yeniGuvenlikPersonel.Maas + "',calismaYili='" + yeniGuvenlikPersonel.CalismaYili + "',sigortaNo='" + yeniGuvenlikPersonel.SigortaNO + "',bolum='" + yeniGuvenlikPersonel.Bolum + "' Where id=" + eskiGuvenlikPersonel.PersonelId + "";
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
        public void Sil(GuvenlikPersonel g)
        {
            try
            {
                cmd.CommandText = "Delete From guvenlik Where id=" + g.PersonelId + "";
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