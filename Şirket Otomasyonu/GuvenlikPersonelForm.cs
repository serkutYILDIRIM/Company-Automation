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
    public partial class GuvenlikPersonelForm : Form
    {
        GuvenlikPersonelIslemler gv = new GuvenlikPersonelIslemler();
        public GuvenlikPersonelForm()
        {
            InitializeComponent();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridGuvenlikPersonel.DataSource = gv.Listele();
        }

        private void GuvenlikPersonelForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            GuvenlikPersonel yeniGuvenlikPersonel = new GuvenlikPersonel();

            yeniGuvenlikPersonel.PersonelId = Convert.ToInt32(textBoxPersonelID.Text);
            yeniGuvenlikPersonel.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniGuvenlikPersonel.DogumTarihi = textBoxDogumTarihi.Text;
            yeniGuvenlikPersonel.Ad = textBoxAd.Text;
            yeniGuvenlikPersonel.Soyad = textBoxSoyad.Text;
            yeniGuvenlikPersonel.Cinsiyet = textBoxCinsiyet.Text;
            yeniGuvenlikPersonel.Adres = textBoxAdres.Text;
            yeniGuvenlikPersonel.Maas = Convert.ToInt32(textBoxMaas.Text);
            yeniGuvenlikPersonel.CalismaYili = Convert.ToInt32(textBoxCalismaYili.Text);
            yeniGuvenlikPersonel.SigortaNO = Convert.ToInt32(textBoxSigortaNo.Text);
            yeniGuvenlikPersonel.Bolum = textBoxBolum.Text;
            yeniGuvenlikPersonel.SilahliMi = textBoxSilahliMi.Text;
            gv.Ekle(yeniGuvenlikPersonel);
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            GuvenlikPersonel eskiGuvenlikPersonel = new GuvenlikPersonel();
            eskiGuvenlikPersonel = (GuvenlikPersonel)gridGuvenlikPersonel.CurrentRow.DataBoundItem;
            GuvenlikPersonel yeniGuvenlikPersonel = new GuvenlikPersonel();

            yeniGuvenlikPersonel.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniGuvenlikPersonel.DogumTarihi = textBoxDogumTarihi.Text;
            yeniGuvenlikPersonel.Ad = textBoxAd.Text;
            yeniGuvenlikPersonel.Soyad = textBoxSoyad.Text;
            yeniGuvenlikPersonel.Cinsiyet = textBoxCinsiyet.Text;
            yeniGuvenlikPersonel.Adres = textBoxAdres.Text;
            yeniGuvenlikPersonel.Maas = Convert.ToInt32(textBoxMaas.Text);
            yeniGuvenlikPersonel.CalismaYili = Convert.ToInt32(textBoxCalismaYili.Text);
            yeniGuvenlikPersonel.SigortaNO = Convert.ToInt32(textBoxSigortaNo.Text);
            yeniGuvenlikPersonel.Bolum = textBoxBolum.Text;
            yeniGuvenlikPersonel.SilahliMi = textBoxSilahliMi.Text;

            gv.Guncelle(eskiGuvenlikPersonel, yeniGuvenlikPersonel);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            GuvenlikPersonel silinecekGuvenlikPersonel = new GuvenlikPersonel();
            silinecekGuvenlikPersonel = (GuvenlikPersonel)gridGuvenlikPersonel.CurrentRow.DataBoundItem;
            gv.Sil(silinecekGuvenlikPersonel);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridGuvenlikPersonel_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPersonelID.Text = gridGuvenlikPersonel.CurrentRow.Cells[5].Value.ToString();
            textBoxTcNo.Text = gridGuvenlikPersonel.CurrentRow.Cells[6].Value.ToString();
            textBoxDogumTarihi.Text = gridGuvenlikPersonel.CurrentRow.Cells[7].Value.ToString();
            textBoxAd.Text = gridGuvenlikPersonel.CurrentRow.Cells[8].Value.ToString();
            textBoxSoyad.Text = gridGuvenlikPersonel.CurrentRow.Cells[9].Value.ToString();
            textBoxCinsiyet.Text = gridGuvenlikPersonel.CurrentRow.Cells[10].Value.ToString();
            textBoxAdres.Text = gridGuvenlikPersonel.CurrentRow.Cells[11].Value.ToString();
            textBoxMaas.Text = gridGuvenlikPersonel.CurrentRow.Cells[1].Value.ToString();
            textBoxCalismaYili.Text = gridGuvenlikPersonel.CurrentRow.Cells[3].Value.ToString();
            textBoxSigortaNo.Text = gridGuvenlikPersonel.CurrentRow.Cells[2].Value.ToString();
            textBoxBolum.Text = gridGuvenlikPersonel.CurrentRow.Cells[4].Value.ToString();
            textBoxSilahliMi.Text = gridGuvenlikPersonel.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
