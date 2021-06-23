using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şirket_Otomasyonu
{
    class SirketKisi : Kisi
    {
        private int maas;
        private int calismaYili;
        private int sigortaNo;
        private string bolum;
        public int Maas
        {
            get { return maas; }
            set { maas = value; }
        }
        public int SigortaNO
        {
            get { return sigortaNo; }
            set { sigortaNo = value; }
        }
        public int CalismaYili
        {
            get { return calismaYili; }
            set { calismaYili = value; }
        }
        public string Bolum
        {
            get { return bolum; }
            set { bolum = value; }
        }
    }
}
