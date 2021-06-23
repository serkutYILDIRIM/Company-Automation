using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şirket_Otomasyonu
{
    class Muhendis : SirketKisi
    {
        private string alan;
        public string Alan
        {
            get { return alan; }
            set { alan = value; }
        }
    }
}
