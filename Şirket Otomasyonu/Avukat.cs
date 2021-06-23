using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şirket_Otomasyonu
{
    class Avukat : SirketKisi
    {
        private string davaBolumu;
        public string DavaBolumu
        {
            get { return davaBolumu; }
            set { davaBolumu = value; }
        }
    }
}
