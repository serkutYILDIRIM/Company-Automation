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
    public partial class GuvenlikPersonelGoruntule : Form
    {
        GuvenlikPersonelIslemler gv = new GuvenlikPersonelIslemler();
        public GuvenlikPersonelGoruntule()
        {
            InitializeComponent();
        }

        private void GuvenlikPersonelGoruntule_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridGuvenlikPersonel.DataSource = gv.Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
