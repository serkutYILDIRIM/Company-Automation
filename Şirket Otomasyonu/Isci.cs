using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şirket_Otomasyonu
{
    class Isci : SirketKisi
    {
        private string gorev;
        public string Gorev
        {
            get { return gorev; }
            set { gorev = value; }
        }
    }
}
