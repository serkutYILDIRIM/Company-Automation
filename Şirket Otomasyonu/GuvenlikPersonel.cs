using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şirket_Otomasyonu
{
    class GuvenlikPersonel : SirketKisi
    {
        private string silahliMi;
        public string SilahliMi
        {
            get { return silahliMi; }
            set { silahliMi = value; }
        }
    }
}
