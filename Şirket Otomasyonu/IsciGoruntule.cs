using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şirket_Otomasyonu
{
    public partial class IsciGoruntule : Form
    {
        IsciIslemler ic = new IsciIslemler();
        public IsciGoruntule()
        {
            InitializeComponent();
        }

        private void IsciGoruntule_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridIsci.DataSource = ic.Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
