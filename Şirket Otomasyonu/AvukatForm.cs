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
    public partial class AvukatForm : Form
    {
        AvukatIslemler av = new AvukatIslemler();
        public AvukatForm()
        {
            InitializeComponent();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridAvukat.DataSource = av.Listele();
        }

        private void AvukatForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Avukat yeniAvukat = new Avukat();

            yeniAvukat.PersonelId = Convert.ToInt32(textBoxPersonelID.Text);
            yeniAvukat.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniAvukat.DogumTarihi = textBoxDogumTarihi.Text;
            yeniAvukat.Ad = textBoxAd.Text;
            yeniAvukat.Soyad = textBoxSoyad.Text;
            yeniAvukat.Cinsiyet = textBoxCinsiyet.Text;
            yeniAvukat.Adres = textBoxAdres.Text;
            yeniAvukat.Maas = Convert.ToInt32(textBoxMaas.Text);
            yeniAvukat.CalismaYili = Convert.ToInt32(textBoxCalismaYili.Text);
            yeniAvukat.SigortaNO = Convert.ToInt32(textBoxSigortaNo.Text);
            yeniAvukat.Bolum = textBoxBolum.Text;
            yeniAvukat.DavaBolumu = textBoxDavaBolum.Text;
            av.Ekle(yeniAvukat);
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Avukat eskiAvukat = new Avukat();
            eskiAvukat = (Avukat)gridAvukat.CurrentRow.DataBoundItem;
            Avukat yeniAvukat = new Avukat();

            yeniAvukat.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniAvukat.DogumTarihi = textBoxDogumTarihi.Text;
            yeniAvukat.Ad = textBoxAd.Text;
            yeniAvukat.Soyad = textBoxSoyad.Text;
            yeniAvukat.Cinsiyet = textBoxCinsiyet.Text;
            yeniAvukat.Adres = textBoxAdres.Text;
            yeniAvukat.Maas = Convert.ToInt32(textBoxMaas.Text);
            yeniAvukat.CalismaYili = Convert.ToInt32(textBoxCalismaYili.Text);
            yeniAvukat.SigortaNO = Convert.ToInt32(textBoxSigortaNo.Text);
            yeniAvukat.Bolum = textBoxBolum.Text;
            yeniAvukat.DavaBolumu = textBoxDavaBolum.Text;

            av.Guncelle(eskiAvukat, yeniAvukat);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Avukat silinecekAvukat = new Avukat();
            silinecekAvukat = (Avukat)gridAvukat.CurrentRow.DataBoundItem;
            av.Sil(silinecekAvukat);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridAvukat_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPersonelID.Text = gridAvukat.CurrentRow.Cells[5].Value.ToString();
            textBoxTcNo.Text = gridAvukat.CurrentRow.Cells[6].Value.ToString();
            textBoxDogumTarihi.Text = gridAvukat.CurrentRow.Cells[7].Value.ToString();
            textBoxAd.Text = gridAvukat.CurrentRow.Cells[8].Value.ToString();
            textBoxSoyad.Text = gridAvukat.CurrentRow.Cells[9].Value.ToString();
            textBoxCinsiyet.Text = gridAvukat.CurrentRow.Cells[10].Value.ToString();
            textBoxAdres.Text = gridAvukat.CurrentRow.Cells[11].Value.ToString();
            textBoxMaas.Text = gridAvukat.CurrentRow.Cells[1].Value.ToString();
            textBoxCalismaYili.Text = gridAvukat.CurrentRow.Cells[3].Value.ToString();
            textBoxSigortaNo.Text = gridAvukat.CurrentRow.Cells[2].Value.ToString();
            textBoxBolum.Text = gridAvukat.CurrentRow.Cells[4].Value.ToString();
            textBoxDavaBolum.Text = gridAvukat.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
