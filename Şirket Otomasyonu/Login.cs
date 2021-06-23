using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace Şirket_Otomasyonu
{
    public partial class Login : Form
    {
        public string yetki;
        public int intyetki;
        public string Kullanici;
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            login();

        }
        public void login()
        {
            string user = txtKullaniciAdi.Text;
            string pass = txtSifre.Text;
            SqlConnection cnn;
            cnn = new SqlConnection(@"Data Source=DESKTOP-2PT82S1\;Initial Catalog=SirketOtomasyonu;Integrated Security=SSPI;");


            cnn.Open();
            SqlCommand cmd = new SqlCommand("select kullaniciadi, sifre, yetki from login", cnn);
            cmd.Connection = cnn;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (System.Text.RegularExpressions.Regex.IsMatch(txtKullaniciAdi.Text, @"\ "))//textboxa girilen şifrede boşluk olup olmadıgını 
            {                                                                             //kontrol ediyor
                
                MessageBox.Show("Kullanıcı Adında boşluk girmeyin");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtSifre.Text, @"\ "))
            {

                MessageBox.Show("Şifrede boşluk girmeyin");
            }
            else
            {


                while (dr.Read())
                {
                    Kullanici = (dr["kullaniciadi"].ToString().Trim());
                    string Sifre = (dr["sifre"].ToString().Trim());
                    yetki = (dr["yetki"].ToString());
                    if (user == Kullanici && pass == Sifre)
                    {
                        intyetki = Int32.Parse(yetki);

                        MessageBox.Show("Hoşgeldin" + " " + txtKullaniciAdi.Text);

                        AnaSayfa a1 = new AnaSayfa();

                        a1.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
