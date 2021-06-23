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
    public partial class IdariPersonelForm : Form
    {
        IdariPersonelIslemler ip = new IdariPersonelIslemler();
        public IdariPersonelForm()
        {
            InitializeComponent();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridIdariPersonel.DataSource = ip.Listele();
        }

        private void IdariPersonelForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            IdariPersonel yeniIdariPersonel = new IdariPersonel();

            yeniIdariPersonel.PersonelId = Convert.ToInt32(textBoxPersonelID.Text);
            yeniIdariPersonel.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniIdariPersonel.DogumTarihi = textBoxDogumTarihi.Text;
            yeniIdariPersonel.Ad = textBoxAd.Text;
            yeniIdariPersonel.Soyad = textBoxSoyad.Text;
            yeniIdariPersonel.Cinsiyet = textBoxCinsiyet.Text;
            yeniIdariPersonel.Adres = textBoxAdres.Text;
            yeniIdariPersonel.Maas = Convert.ToInt32(textBoxMaas.Text);
            yeniIdariPersonel.CalismaYili = Convert.ToInt32(textBoxCalismaYili.Text);
            yeniIdariPersonel.SigortaNO = Convert.ToInt32(textBoxSigortaNo.Text);
            yeniIdariPersonel.Bolum = textBoxBolum.Text;
            yeniIdariPersonel.Yetki = textBoxYetki.Text;
            ip.Ekle(yeniIdariPersonel);
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            IdariPersonel eskiIdariPersonel = new IdariPersonel();
            eskiIdariPersonel = (IdariPersonel)gridIdariPersonel.CurrentRow.DataBoundItem;
            IdariPersonel yeniIdariPersonel = new IdariPersonel();

            yeniIdariPersonel.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniIdariPersonel.DogumTarihi = textBoxDogumTarihi.Text;
            yeniIdariPersonel.Ad = textBoxAd.Text;
            yeniIdariPersonel.Soyad = textBoxSoyad.Text;
            yeniIdariPersonel.Cinsiyet = textBoxCinsiyet.Text;
            yeniIdariPersonel.Adres = textBoxAdres.Text;
            yeniIdariPersonel.Maas = Convert.ToInt32(textBoxMaas.Text);
            yeniIdariPersonel.CalismaYili = Convert.ToInt32(textBoxCalismaYili.Text);
            yeniIdariPersonel.SigortaNO = Convert.ToInt32(textBoxSigortaNo.Text);
            yeniIdariPersonel.Bolum = textBoxBolum.Text;
            yeniIdariPersonel.Yetki = textBoxYetki.Text;

            ip.Guncelle(eskiIdariPersonel, yeniIdariPersonel);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            IdariPersonel silinecekIdariPersonel = new IdariPersonel();
            silinecekIdariPersonel = (IdariPersonel)gridIdariPersonel.CurrentRow.DataBoundItem;
            ip.Sil(silinecekIdariPersonel);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridIdariPersonel_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPersonelID.Text = gridIdariPersonel.CurrentRow.Cells[5].Value.ToString();
            textBoxTcNo.Text = gridIdariPersonel.CurrentRow.Cells[6].Value.ToString();
            textBoxDogumTarihi.Text = gridIdariPersonel.CurrentRow.Cells[7].Value.ToString();
            textBoxAd.Text = gridIdariPersonel.CurrentRow.Cells[8].Value.ToString();
            textBoxSoyad.Text = gridIdariPersonel.CurrentRow.Cells[9].Value.ToString();
            textBoxCinsiyet.Text = gridIdariPersonel.CurrentRow.Cells[10].Value.ToString();
            textBoxAdres.Text = gridIdariPersonel.CurrentRow.Cells[11].Value.ToString();
            textBoxMaas.Text = gridIdariPersonel.CurrentRow.Cells[1].Value.ToString();
            textBoxCalismaYili.Text = gridIdariPersonel.CurrentRow.Cells[3].Value.ToString();
            textBoxSigortaNo.Text = gridIdariPersonel.CurrentRow.Cells[2].Value.ToString();
            textBoxBolum.Text = gridIdariPersonel.CurrentRow.Cells[4].Value.ToString();
            textBoxYetki.Text = gridIdariPersonel.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
