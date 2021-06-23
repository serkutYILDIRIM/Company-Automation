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
    public partial class MuhendisForm : Form
    {
        MuhendisIslemler mh = new MuhendisIslemler();
        public MuhendisForm()
        {
            InitializeComponent();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridMuhendis.DataSource = mh.Listele();
        }

        private void MuhendisForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Muhendis yeniMuhendis = new Muhendis();

            yeniMuhendis.PersonelId = Convert.ToInt32(textBoxPersonelID.Text);
            yeniMuhendis.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniMuhendis.DogumTarihi = textBoxDogumTarihi.Text;
            yeniMuhendis.Ad = textBoxAd.Text;
            yeniMuhendis.Soyad = textBoxSoyad.Text;
            yeniMuhendis.Cinsiyet = textBoxCinsiyet.Text;
            yeniMuhendis.Adres = textBoxAdres.Text;
            yeniMuhendis.Maas = Convert.ToInt32(textBoxMaas.Text);
            yeniMuhendis.CalismaYili = Convert.ToInt32(textBoxCalismaYili.Text);
            yeniMuhendis.SigortaNO = Convert.ToInt32(textBoxSigortaNo.Text);
            yeniMuhendis.Bolum = textBoxBolum.Text;
            yeniMuhendis.Alan = textBoxAlan.Text;
            mh.Ekle(yeniMuhendis);
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Muhendis eskiMuhendis = new Muhendis();
            eskiMuhendis = (Muhendis)gridMuhendis.CurrentRow.DataBoundItem;
            Muhendis yeniMuhendis = new Muhendis();

            yeniMuhendis.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniMuhendis.DogumTarihi = textBoxDogumTarihi.Text;
            yeniMuhendis.Ad = textBoxAd.Text;
            yeniMuhendis.Soyad = textBoxSoyad.Text;
            yeniMuhendis.Cinsiyet = textBoxCinsiyet.Text;
            yeniMuhendis.Adres = textBoxAdres.Text;
            yeniMuhendis.Maas = Convert.ToInt32(textBoxMaas.Text);
            yeniMuhendis.CalismaYili = Convert.ToInt32(textBoxCalismaYili.Text);
            yeniMuhendis.SigortaNO = Convert.ToInt32(textBoxSigortaNo.Text);
            yeniMuhendis.Bolum = textBoxBolum.Text;
            yeniMuhendis.Alan = textBoxAlan.Text;

            mh.Guncelle(eskiMuhendis, yeniMuhendis);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Muhendis silinecekMuhendis = new Muhendis();
            silinecekMuhendis = (Muhendis)gridMuhendis.CurrentRow.DataBoundItem;
            mh.Sil(silinecekMuhendis);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridMuhendis_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPersonelID.Text = gridMuhendis.CurrentRow.Cells[5].Value.ToString();
            textBoxTcNo.Text = gridMuhendis.CurrentRow.Cells[6].Value.ToString();
            textBoxDogumTarihi.Text = gridMuhendis.CurrentRow.Cells[7].Value.ToString();
            textBoxAd.Text = gridMuhendis.CurrentRow.Cells[8].Value.ToString();
            textBoxSoyad.Text = gridMuhendis.CurrentRow.Cells[9].Value.ToString();
            textBoxCinsiyet.Text = gridMuhendis.CurrentRow.Cells[10].Value.ToString();
            textBoxAdres.Text = gridMuhendis.CurrentRow.Cells[11].Value.ToString();
            textBoxMaas.Text = gridMuhendis.CurrentRow.Cells[1].Value.ToString();
            textBoxCalismaYili.Text = gridMuhendis.CurrentRow.Cells[3].Value.ToString();
            textBoxSigortaNo.Text = gridMuhendis.CurrentRow.Cells[2].Value.ToString();
            textBoxBolum.Text = gridMuhendis.CurrentRow.Cells[4].Value.ToString();
            textBoxAlan.Text = gridMuhendis.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
