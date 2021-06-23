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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void muhendisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuhendisForm mh = new MuhendisForm();
            mh.ShowDialog();
        }

        private void İşcilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsciForm ic = new IsciForm();
            ic.ShowDialog();
        }

        private void MemurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemurForm mr = new MemurForm();
            mr.ShowDialog();
        }

        private void avukatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvukatForm av = new AvukatForm();
            av.ShowDialog();
        }

        private void idariPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdariPersonelForm ip = new IdariPersonelForm();
            ip.ShowDialog();
        }

        private void güvenlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuvenlikPersonelForm gv = new GuvenlikPersonelForm();
            gv.ShowDialog();
        }

        private void stajyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StajyerForm st = new StajyerForm();
            st.ShowDialog();
        }

        Login lgn = (Login)Application.OpenForms["Login"];
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            if (lgn.intyetki == 1)//üye
            {
                kullanıcıİşlemleriToolStripMenuItem.Visible = false;
                PersonellerToolStripMenuItem.Visible = false;
                personelleriGörüntüleToolStripMenuItem.Visible = false;
            }
            if (lgn.intyetki == 2)//moderatör
            {
                kullanıcıİşlemleriToolStripMenuItem.Visible = false;
                PersonellerToolStripMenuItem.Visible = false;
            }
            if (lgn.intyetki == 3)//admin kullanıcıları görüntüleyebilir ama crud yapamaz
            {
                personelleriGörüntüleToolStripMenuItem.Visible = false;
            }
        }
        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ekleSilDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciForm kl = new KullaniciForm();
            kl.ShowDialog();
        }

        private void mühendisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuhendisGoruntule mh = new MuhendisGoruntule();
            mh.ShowDialog();
        }

        private void işçiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsciGoruntule ic = new IsciGoruntule();
            ic.ShowDialog();
        }

        private void memurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MemurGoruntule mr = new MemurGoruntule();
            mr.ShowDialog();
        }

        private void avukatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AvukatGoruntule av = new AvukatGoruntule();
            av.ShowDialog();
        }

        private void idariPersonelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IdariPersonelGoruntule id = new IdariPersonelGoruntule();
            id.ShowDialog();
        }

        private void güvenlikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GuvenlikPersonelGoruntule gv = new GuvenlikPersonelGoruntule();
            gv.ShowDialog();
        }

        private void stajyerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StajyerGoruntule st = new StajyerGoruntule();
            st.ShowDialog();
        }

        private void TanitimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tanıtım tn = new Tanıtım();
            tn.ShowDialog();
        }

        private void internetSitesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Site st = new Site();
            st.ShowDialog();
        }
    }
}
