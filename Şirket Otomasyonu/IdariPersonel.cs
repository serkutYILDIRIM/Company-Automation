using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şirket_Otomasyonu
{
    class IdariPersonel : SirketKisi
    {
        private string yetki;
        public string Yetki
        {
            get { return yetki; }
            set { yetki = value; }
        }
    }
}
