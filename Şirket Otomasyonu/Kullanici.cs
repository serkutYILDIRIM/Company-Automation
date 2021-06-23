using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şirket_Otomasyonu
{
    class Kullanici
    {
        private int sirano;
        private string kullaniciadi;
        private string sifre;
        private int yetki;
        public string Kullanıcıadı
        {
            get { return kullaniciadi; }
            set { kullaniciadi = value; }
        }
        public string Şifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
        public int Yetki
        {
            get { return yetki; }
            set { yetki = value; }
        }
        public int Sirano
        {
            get { return sirano; }
            set { sirano = value; }
        }
    }
}
