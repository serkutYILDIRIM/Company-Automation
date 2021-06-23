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
    public partial class StajyerGoruntule : Form
    {
        StajyerIslemler st = new StajyerIslemler();
        public StajyerGoruntule()
        {
            InitializeComponent();
        }

        private void StajyerGoruntule_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridStajyer.DataSource = st.Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
