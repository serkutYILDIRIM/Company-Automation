using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şirket_Otomasyonu
{
    class Kisi
    {
       private int personelId;
       private int tcNo;
       private string dogumTarihi;
       private string ad;
       private string soyad;
       private string cinsiyet;
       private string adres;
        
        public int PersonelId
        {
            get { return personelId; }
            set { personelId = value; }
        }
        public int TcNo
        {
            get { return tcNo; }
            set { tcNo = value; }
        }
        public string DogumTarihi
        {
            get { return dogumTarihi; }
            set { dogumTarihi = value; }
        }
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
    }
}
