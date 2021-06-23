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
    public partial class IsciForm : Form
    {
        IsciIslemler ic = new IsciIslemler();
        public IsciForm()
        {
            InitializeComponent();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridIsci.DataSource = ic.Listele();
        }

        private void IsciForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Isci yeniIsci = new Isci();

            yeniIsci.PersonelId = Convert.ToInt32(textBoxPersonelID.Text);
            yeniIsci.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniIsci.DogumTarihi = textBoxDogumTarihi.Text;
            yeniIsci.Ad = textBoxAd.Text;
            yeniIsci.Soyad = textBoxSoyad.Text;
            yeniIsci.Cinsiyet = textBoxCinsiyet.Text;
            yeniIsci.Adres = textBoxAdres.Text;
            yeniIsci.Maas = Convert.ToInt32(textBoxMaas.Text);
            yeniIsci.CalismaYili = Convert.ToInt32(textBoxCalismaYili.Text);
            yeniIsci.SigortaNO = Convert.ToInt32(textBoxSigortaNo.Text);
            yeniIsci.Bolum = textBoxBolum.Text;
            yeniIsci.Gorev = textBoxGorev.Text;
            ic.Ekle(yeniIsci);
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Isci eskiIsci = new Isci();
            eskiIsci = (Isci)gridIsci.CurrentRow.DataBoundItem;
            Isci yeniIsci = new Isci();

            yeniIsci.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniIsci.DogumTarihi = textBoxDogumTarihi.Text;
            yeniIsci.Ad = textBoxAd.Text;
            yeniIsci.Soyad = textBoxSoyad.Text;
            yeniIsci.Cinsiyet = textBoxCinsiyet.Text;
            yeniIsci.Adres = textBoxAdres.Text;
            yeniIsci.Maas = Convert.ToInt32(textBoxMaas.Text);
            yeniIsci.CalismaYili = Convert.ToInt32(textBoxCalismaYili.Text);
            yeniIsci.SigortaNO = Convert.ToInt32(textBoxSigortaNo.Text);
            yeniIsci.Bolum = textBoxBolum.Text;
            yeniIsci.Gorev = textBoxGorev.Text;

            ic.Guncelle(eskiIsci, yeniIsci);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Isci silinecekIsci = new Isci();
            silinecekIsci = (Isci)gridIsci.CurrentRow.DataBoundItem;
            ic.Sil(silinecekIsci);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridIsci_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPersonelID.Text = gridIsci.CurrentRow.Cells[5].Value.ToString();
            textBoxTcNo.Text = gridIsci.CurrentRow.Cells[6].Value.ToString();
            textBoxDogumTarihi.Text = gridIsci.CurrentRow.Cells[7].Value.ToString();
            textBoxAd.Text = gridIsci.CurrentRow.Cells[8].Value.ToString();
            textBoxSoyad.Text = gridIsci.CurrentRow.Cells[9].Value.ToString();
            textBoxCinsiyet.Text = gridIsci.CurrentRow.Cells[10].Value.ToString();
            textBoxAdres.Text = gridIsci.CurrentRow.Cells[11].Value.ToString();
            textBoxMaas.Text = gridIsci.CurrentRow.Cells[1].Value.ToString();
            textBoxCalismaYili.Text = gridIsci.CurrentRow.Cells[3].Value.ToString();
            textBoxSigortaNo.Text = gridIsci.CurrentRow.Cells[2].Value.ToString();
            textBoxBolum.Text = gridIsci.CurrentRow.Cells[4].Value.ToString();
            textBoxGorev.Text = gridIsci.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
