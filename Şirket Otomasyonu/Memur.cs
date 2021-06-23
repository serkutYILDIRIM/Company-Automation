using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şirket_Otomasyonu
{
    class Memur : SirketKisi
    {
        private string unvan;
        public string Unvan
        {
            get { return unvan; }
            set { unvan = value; }
        }
    }
}
