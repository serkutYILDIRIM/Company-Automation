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
    public partial class StajyerForm : Form
    {
        StajyerIslemler st = new StajyerIslemler();
        public StajyerForm()
        {
            InitializeComponent();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            gridStajyer.DataSource = st.Listele();
        }

        private void StajyerForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Stajyer yeniStajyer = new Stajyer();

            yeniStajyer.PersonelId = Convert.ToInt32(textBoxPersonelID.Text);
            yeniStajyer.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniStajyer.DogumTarihi = textBoxDogumTarihi.Text;
            yeniStajyer.Ad = textBoxAd.Text;
            yeniStajyer.Soyad = textBoxSoyad.Text;
            yeniStajyer.Cinsiyet = textBoxCinsiyet.Text;
            yeniStajyer.Adres = textBoxAdres.Text;
            yeniStajyer.CalistigiBolum = textBoxCalistigiBolum.Text;
            yeniStajyer.UniBolum = textBoxUniBolum.Text;
            st.Ekle(yeniStajyer);
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Stajyer eskiStajyer = new Stajyer();
            eskiStajyer = (Stajyer)gridStajyer.CurrentRow.DataBoundItem;
            Stajyer yeniStajyer = new Stajyer();

            yeniStajyer.TcNo = Convert.ToInt32(textBoxTcNo.Text);
            yeniStajyer.DogumTarihi = textBoxDogumTarihi.Text;
            yeniStajyer.Ad = textBoxAd.Text;
            yeniStajyer.Soyad = textBoxSoyad.Text;
            yeniStajyer.Cinsiyet = textBoxCinsiyet.Text;
            yeniStajyer.Adres = textBoxAdres.Text;
            yeniStajyer.CalistigiBolum = textBoxCalistigiBolum.Text;
            yeniStajyer.UniBolum = textBoxUniBolum.Text;

            st.Guncelle(eskiStajyer, yeniStajyer);
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Stajyer silinecekStajyer = new Stajyer();
            silinecekStajyer = (Stajyer)gridStajyer.CurrentRow.DataBoundItem;
            st.Sil(silinecekStajyer);
            Listele();
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridStajyer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPersonelID.Text = gridStajyer.CurrentRow.Cells[2].Value.ToString();
            textBoxTcNo.Text = gridStajyer.CurrentRow.Cells[3].Value.ToString();
            textBoxDogumTarihi.Text = gridStajyer.CurrentRow.Cells[4].Value.ToString();
            textBoxAd.Text = gridStajyer.CurrentRow.Cells[5].Value.ToString();
            textBoxSoyad.Text = gridStajyer.CurrentRow.Cells[6].Value.ToString();
            textBoxCinsiyet.Text = gridStajyer.CurrentRow.Cells[7].Value.ToString();
            textBoxAdres.Text = gridStajyer.CurrentRow.Cells[8].Value.ToString();
            textBoxCalistigiBolum.Text = gridStajyer.CurrentRow.Cells[0].Value.ToString();
            textBoxUniBolum.Text = gridStajyer.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
