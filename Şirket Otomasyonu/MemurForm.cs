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
    public partial class MemurForm : Form
    {
        MemurIslemler mr = new MemurIslemler();
        public MemurForm()
        {
            InitializeComponent();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridMemur.DataSource = mr.Listele();
        }

        private void MemurForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Memur yeniMemur = new Memur();

            yeniMemur.PersonelId = Convert.ToInt32(textBoxPersonelID.Text);
            yeniMemur.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniMemur.DogumTarihi = textBoxDogumTarihi.Text;
            yeniMemur.Ad = textBoxAd.Text;
            yeniMemur.Soyad = textBoxSoyad.Text;
            yeniMemur.Cinsiyet = textBoxCinsiyet.Text;
            yeniMemur.Adres = textBoxAdres.Text;
            yeniMemur.Maas = Convert.ToInt32(textBoxMaas.Text);
            yeniMemur.CalismaYili = Convert.ToInt32(textBoxCalismaYili.Text);
            yeniMemur.SigortaNO = Convert.ToInt32(textBoxSigortaNo.Text);
            yeniMemur.Bolum = textBoxBolum.Text;
            yeniMemur.Unvan = textBoxUnvan.Text;
            mr.Ekle(yeniMemur);
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Memur eskiMemur = new Memur();
            eskiMemur = (Memur)gridMemur.CurrentRow.DataBoundItem;
            Memur yeniMemur = new Memur();

            yeniMemur.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniMemur.DogumTarihi = textBoxDogumTarihi.Text;
            yeniMemur.Ad = textBoxAd.Text;
            yeniMemur.Soyad = textBoxSoyad.Text;
            yeniMemur.Cinsiyet = textBoxCinsiyet.Text;
            yeniMemur.Adres = textBoxAdres.Text;
            yeniMemur.Maas = Convert.ToInt32(textBoxMaas.Text);
            yeniMemur.CalismaYili = Convert.ToInt32(textBoxCalismaYili.Text);
            yeniMemur.SigortaNO = Convert.ToInt32(textBoxSigortaNo.Text);
            yeniMemur.Bolum = textBoxBolum.Text;
            yeniMemur.Unvan = textBoxUnvan.Text;

            mr.Guncelle(eskiMemur, yeniMemur);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Memur silinecekMemur = new Memur();
            silinecekMemur = (Memur)gridMemur.CurrentRow.DataBoundItem;
            mr.Sil(silinecekMemur);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridMemur_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPersonelID.Text = gridMemur.CurrentRow.Cells[5].Value.ToString();
            textBoxTcNo.Text = gridMemur.CurrentRow.Cells[6].Value.ToString();
            textBoxDogumTarihi.Text = gridMemur.CurrentRow.Cells[7].Value.ToString();
            textBoxAd.Text = gridMemur.CurrentRow.Cells[8].Value.ToString();
            textBoxSoyad.Text = gridMemur.CurrentRow.Cells[9].Value.ToString();
            textBoxCinsiyet.Text = gridMemur.CurrentRow.Cells[10].Value.ToString();
            textBoxAdres.Text = gridMemur.CurrentRow.Cells[11].Value.ToString();
            textBoxMaas.Text = gridMemur.CurrentRow.Cells[1].Value.ToString();
            textBoxCalismaYili.Text = gridMemur.CurrentRow.Cells[3].Value.ToString();
            textBoxSigortaNo.Text = gridMemur.CurrentRow.Cells[2].Value.ToString();
            textBoxBolum.Text = gridMemur.CurrentRow.Cells[4].Value.ToString();
            textBoxUnvan.Text = gridMemur.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
