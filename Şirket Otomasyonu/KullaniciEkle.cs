using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Şirket_Otomasyonu
{
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-2PT82S1\;Initial Catalog=SirketOtomasyonu;Integrated Security=SSPI;";
            cnn = new SqlConnection(connetionString);

            cnn.Open();

            SqlCommand cmd = new SqlCommand("select yetkiadi, yetkiderecesi from yetkiler", cnn);

            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                comboBoxYetki.Items.Add(sdr["yetkiadi"]);

            }

            cnn.Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            string kullanıcıadı = textBoxKullaniciAdi.Text;
            string şifre = textBoxSifre.Text;
            string yetki = comboBoxYetki.SelectedItem.ToString();
            string yetkiadi = "";
            string yetkiderecesi = "";
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxKullaniciAdi.Text, @"\ "))//textboxa girilen şifrede boşluk olup olmadıgını 
            {                                                                             //kontrol ediyor

                MessageBox.Show("Kullanıcı Adında boşluk girmeyin");
            }
           else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxSifre.Text, @"\ "))//textboxa girilen şifrede boşluk olup olmadıgını 
            {                                                                             //kontrol ediyor

                MessageBox.Show("Şifrede boşluk girmeyin");
            }
            else
            {


                SqlConnection cnn;
                SqlConnection cnnn;
                cnn = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=SirketOtomasyonu;Integrated Security=SSPI;");
                cnnn = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=SirketOtomasyonu;Integrated Security=SSPI;");
                //2 bağlantı kullanmamızın sebebi 1 tane kullanınca tek bağlantı üzerinden işlem yapmaya çalıştığımız için
                //if blogunun içindeki kısımda bağlantı acık hatası veriyor.
                cnn.Open();
                SqlCommand sc2 = new SqlCommand("Select yetkiadi, yetkiderecesi from yetkiler ", cnn);
                sc2.Connection = cnn;
                SqlDataReader sdr = sc2.ExecuteReader();
                while (sdr.Read())
                {
                    yetkiadi = sdr["yetkiadi"].ToString();
                    yetkiderecesi = sdr["yetkiderecesi"].ToString();
                    if (yetki == yetkiadi)

                    // EĞER SEÇTİĞİM YETKİ ADINDAKİ METİN YETKİLER TABLOMDAKİ

                    // YETKİ ADINA EŞİTSE KULLANICILAR TABLOMA KULLANICI ADINI

                    //ŞİFREYİ VE YETKİYİ KAYDET
                    {
                        SqlCommand sc = new SqlCommand("INSERT INTO login(kullaniciadi, sifre, yetki) Values(@kullaniciadipar, @sifrepar, @yetkipar)", cnnn);
                        sc.Parameters.AddWithValue("@kullaniciadipar", kullanıcıadı);
                        sc.Parameters.AddWithValue("@sifrepar", şifre);
                        sc.Parameters.AddWithValue("@yetkipar", yetkiderecesi);

                        cnnn.Open();
                        sc.ExecuteNonQuery();
                        MessageBox.Show("kayıt başarılı");
                        cnnn.Close();
                    }
                }

                cnn.Close();
            }
        }
    }
}
