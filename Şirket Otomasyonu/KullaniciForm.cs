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
    public partial class KullaniciForm : Form
    {
        public KullaniciForm()
        {
            InitializeComponent();
        }
        private void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridKullanici.DataSource = KullaniciIslemler.NesneKullaniciIslemler().Listele();
        }

        Login lgn = (Login)Application.OpenForms["Login"];
        private void KullaniciForm_Load(object sender, EventArgs e)
        {
            Listele();
            if (lgn.intyetki == 3)
            {
                buttonEkle.Visible = false;
                buttonGuncelle.Visible = false;
                buttonSil.Visible = false;
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkle kl = new KullaniciEkle();
            kl.ShowDialog();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Kullanici eskiKullanici = new Kullanici();
            eskiKullanici = (Kullanici)gridKullanici.CurrentRow.DataBoundItem;
            Kullanici yeniKullanici = new Kullanici();

            yeniKullanici.Kullanıcıadı = textBoxKullaniciAdi.Text;
            yeniKullanici.Şifre = textBoxSifre.Text;
            yeniKullanici.Yetki = Convert.ToInt32(textBoxYetki.Text); ;

            KullaniciIslemler.NesneKullaniciIslemler().Guncelle(eskiKullanici, yeniKullanici);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Kullanici silinecekKullanici = new Kullanici();
            silinecekKullanici = (Kullanici)gridKullanici.CurrentRow.DataBoundItem;
            KullaniciIslemler.NesneKullaniciIslemler().Sil(silinecekKullanici);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridKullanici_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxSiraNo.Text = gridKullanici.CurrentRow.Cells[3].Value.ToString();
            textBoxKullaniciAdi.Text = gridKullanici.CurrentRow.Cells[0].Value.ToString();
            textBoxSifre.Text = gridKullanici.CurrentRow.Cells[1].Value.ToString();
            textBoxYetki.Text = gridKullanici.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
