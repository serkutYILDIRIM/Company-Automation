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
    public partial class MemurGoruntule : Form
    {
        MemurIslemler mr = new MemurIslemler();
        public MemurGoruntule()
        {
            InitializeComponent();
        }

        private void MemurGoruntule_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridMemur.DataSource = mr.Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
