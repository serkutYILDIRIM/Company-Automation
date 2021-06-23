using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Şirket_Otomasyonu
{
    class StajyerIslemler
    {
        SqlConnection con;
        SqlCommand cmd;
        public StajyerIslemler()
        {
            Baglan();
        }
        public void Baglan()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=SirketOtomasyonu;Integrated Security=SSPI;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<Stajyer> Listele()
        {

            try
            {
                List<Stajyer> stajyerListesi = new List<Stajyer>();
                cmd.CommandText = "Select *From stajyer";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Stajyer st = new Stajyer();
                    st.PersonelId = Convert.ToInt32(reader[0].ToString());
                    st.TcNo = Convert.ToInt32(reader[1].ToString());
                    st.DogumTarihi = reader[2].ToString();
                    st.Ad = reader[3].ToString();
                    st.Soyad = reader[4].ToString();
                    st.Cinsiyet = reader[5].ToString();
                    st.Adres = reader[6].ToString();
                    st.CalistigiBolum = reader[7].ToString();
                    st.UniBolum = reader[8].ToString();
                    stajyerListesi.Add(st);
                }

                return stajyerListesi;
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
        public void Ekle(Stajyer s)
        {
            try
            {
                cmd.CommandText = "Insert Into stajyer (id,tcNo,dogumTarihi,ad,soyad,cinsiyet,adres,calistigiBolum,uniBolum) Values (" + s.PersonelId + ",'" + s.TcNo + "','" + s.DogumTarihi + "','" + s.Ad + "','" + s.Soyad + "','" + s.Cinsiyet + "','" + s.Adres + "','" + s.CalistigiBolum + "','" + s.UniBolum + "')";

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
        public void Guncelle(Stajyer eskiStajyer, Stajyer yeniStajyer)
        {
            try
            {
                cmd.CommandText = "Update stajyer SET uniBolum='" + yeniStajyer.UniBolum + "',tcNo='" + yeniStajyer.TcNo + "',dogumTarihi='" + yeniStajyer.DogumTarihi + "',ad='" + yeniStajyer.Ad + "',soyad='" + yeniStajyer.Soyad + "',cinsiyet='" + yeniStajyer.Cinsiyet + "',adres='" + yeniStajyer.Adres + "',calistigiBolum='" + yeniStajyer.CalistigiBolum + "' Where id=" + eskiStajyer.PersonelId + "";
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
        public void Sil(Stajyer s)
        {
            try
            {
                cmd.CommandText = "Delete From stajyer Where id=" + s.PersonelId + "";
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
