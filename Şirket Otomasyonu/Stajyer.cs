using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şirket_Otomasyonu
{
    class Stajyer : Kisi
    {
        private string calistigiBolum;
        private string uniBolum;
        public string CalistigiBolum
        {
            get { return calistigiBolum; }
            set { calistigiBolum = value; }
        }
        public string UniBolum
        {
            get { return uniBolum; }
            set { uniBolum = value; }
        }
    }
}
