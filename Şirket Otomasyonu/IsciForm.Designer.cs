namespace Şirket_Otomasyonu
{
    partial class IsciForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsciForm));
            this.gridIsci = new System.Windows.Forms.DataGridView();
            this.groupBoxIsDetay = new System.Windows.Forms.GroupBox();
            this.groupBoxIsDetayEkleDuzenle = new System.Windows.Forms.GroupBox();
            this.buttonXMLAl = new System.Windows.Forms.Button();
            this.textBoxGorev = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBolum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSigortaNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCalismaYili = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMaas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxTcNo = new System.Windows.Forms.TextBox();
            this.textBoxPersonelID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCinsiyet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxDogumTarihi = new System.Windows.Forms.TextBox();
            this.labelDetay2 = new System.Windows.Forms.Label();
            this.labelDetay1 = new System.Windows.Forms.Label();
            this.labelIsSiraNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridIsci)).BeginInit();
            this.groupBoxIsDetay.SuspendLayout();
            this.groupBoxIsDetayEkleDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridIsci
            // 
            this.gridIsci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIsci.Location = new System.Drawing.Point(35, 302);
            this.gridIsci.Margin = new System.Windows.Forms.Padding(4);
            this.gridIsci.Name = "gridIsci";
            this.gridIsci.Size = new System.Drawing.Size(1680, 183);
            this.gridIsci.TabIndex = 7;
            this.gridIsci.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIsci_CellEnter);
            // 
            // groupBoxIsDetay
            // 
            this.groupBoxIsDetay.Controls.Add(this.gridIsci);
            this.groupBoxIsDetay.Controls.Add(this.groupBoxIsDetayEkleDuzenle);
            this.groupBoxIsDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetay.Location = new System.Drawing.Point(23, 9);
            this.groupBoxIsDetay.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Name = "groupBoxIsDetay";
            this.groupBoxIsDetay.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Size = new System.Drawing.Size(1715, 525);
            this.groupBoxIsDetay.TabIndex = 19;
            this.groupBoxIsDetay.TabStop = false;
            this.groupBoxIsDetay.Text = "İşçi";
            // 
            // groupBoxIsDetayEkleDuzenle
            // 
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonXMLAl);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxGorev);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label9);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxBolum);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label8);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxSigortaNo);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label7);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxCalismaYili);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label6);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxMaas);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label5);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxAd);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxTcNo);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxPersonelID);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label4);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonGuncelle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxAdres);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label3);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxCinsiyet);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label2);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label1);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonSil);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonEkle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxSoyad);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxDogumTarihi);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelDetay2);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelDetay1);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelIsSiraNo);
            this.groupBoxIsDetayEkleDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetayEkleDuzenle.Location = new System.Drawing.Point(24, 31);
            this.groupBoxIsDetayEkleDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetayEkleDuzenle.Name = "groupBoxIsDetayEkleDuzenle";
            this.groupBoxIsDetayEkleDuzenle.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetayEkleDuzenle.Size = new System.Drawing.Size(1683, 277);
            this.groupBoxIsDetayEkleDuzenle.TabIndex = 0;
            this.groupBoxIsDetayEkleDuzenle.TabStop = false;
            this.groupBoxIsDetayEkleDuzenle.Text = "İşçi Ekle ve Düzenle";
            // 
            // buttonXMLAl
            // 
            this.buttonXMLAl.BackColor = System.Drawing.Color.Gold;
            this.buttonXMLAl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXMLAl.BackgroundImage")));
            this.buttonXMLAl.Location = new System.Drawing.Point(896, 169);
            this.buttonXMLAl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXMLAl.Name = "buttonXMLAl";
            this.buttonXMLAl.Size = new System.Drawing.Size(163, 82);
            this.buttonXMLAl.TabIndex = 19;
            this.buttonXMLAl.UseVisualStyleBackColor = false;
            this.buttonXMLAl.Click += new System.EventHandler(this.buttonXMLAl_Click);
            // 
            // textBoxGorev
            // 
            this.textBoxGorev.Location = new System.Drawing.Point(936, 109);
            this.textBoxGorev.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGorev.Name = "textBoxGorev";
            this.textBoxGorev.Size = new System.Drawing.Size(132, 23);
            this.textBoxGorev.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(831, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "gorev";
            // 
            // textBoxBolum
            // 
            this.textBoxBolum.Location = new System.Drawing.Point(936, 64);
            this.textBoxBolum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBolum.Name = "textBoxBolum";
            this.textBoxBolum.Size = new System.Drawing.Size(132, 23);
            this.textBoxBolum.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(831, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Bölüm";
            // 
            // textBoxSigortaNo
            // 
            this.textBoxSigortaNo.Location = new System.Drawing.Point(649, 109);
            this.textBoxSigortaNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSigortaNo.Name = "textBoxSigortaNo";
            this.textBoxSigortaNo.Size = new System.Drawing.Size(132, 23);
            this.textBoxSigortaNo.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Sigorta No";
            // 
            // textBoxCalismaYili
            // 
            this.textBoxCalismaYili.Location = new System.Drawing.Point(401, 109);
            this.textBoxCalismaYili.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCalismaYili.Name = "textBoxCalismaYili";
            this.textBoxCalismaYili.Size = new System.Drawing.Size(132, 23);
            this.textBoxCalismaYili.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Calisma Yılı";
            // 
            // textBoxMaas
            // 
            this.textBoxMaas.Location = new System.Drawing.Point(121, 109);
            this.textBoxMaas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaas.Name = "textBoxMaas";
            this.textBoxMaas.Size = new System.Drawing.Size(132, 23);
            this.textBoxMaas.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Maas";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(401, 27);
            this.textBoxAd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(132, 23);
            this.textBoxAd.TabIndex = 28;
            // 
            // textBoxTcNo
            // 
            this.textBoxTcNo.Location = new System.Drawing.Point(121, 36);
            this.textBoxTcNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTcNo.Name = "textBoxTcNo";
            this.textBoxTcNo.Size = new System.Drawing.Size(132, 23);
            this.textBoxTcNo.TabIndex = 27;
            // 
            // textBoxPersonelID
            // 
            this.textBoxPersonelID.Location = new System.Drawing.Point(936, 24);
            this.textBoxPersonelID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPersonelID.Name = "textBoxPersonelID";
            this.textBoxPersonelID.Size = new System.Drawing.Size(132, 23);
            this.textBoxPersonelID.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(831, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "İşçi No";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Gold;
            this.buttonGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuncelle.BackgroundImage")));
            this.buttonGuncelle.Location = new System.Drawing.Point(427, 169);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(163, 82);
            this.buttonGuncelle.TabIndex = 24;
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(649, 64);
            this.textBoxAdres.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(132, 23);
            this.textBoxAdres.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Adres";
            // 
            // textBoxCinsiyet
            // 
            this.textBoxCinsiyet.Location = new System.Drawing.Point(649, 27);
            this.textBoxCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCinsiyet.Name = "textBoxCinsiyet";
            this.textBoxCinsiyet.Size = new System.Drawing.Size(132, 23);
            this.textBoxCinsiyet.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cinsiyet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad";
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Gold;
            this.buttonSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSil.BackgroundImage")));
            this.buttonSil.Location = new System.Drawing.Point(649, 169);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(163, 82);
            this.buttonSil.TabIndex = 8;
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Gold;
            this.buttonEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEkle.BackgroundImage")));
            this.buttonEkle.Location = new System.Drawing.Point(197, 169);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(163, 82);
            this.buttonEkle.TabIndex = 6;
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(401, 64);
            this.textBoxSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(132, 23);
            this.textBoxSoyad.TabIndex = 7;
            // 
            // textBoxDogumTarihi
            // 
            this.textBoxDogumTarihi.Location = new System.Drawing.Point(121, 67);
            this.textBoxDogumTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDogumTarihi.Name = "textBoxDogumTarihi";
            this.textBoxDogumTarihi.Size = new System.Drawing.Size(132, 23);
            this.textBoxDogumTarihi.TabIndex = 6;
            // 
            // labelDetay2
            // 
            this.labelDetay2.AutoSize = true;
            this.labelDetay2.Location = new System.Drawing.Point(312, 64);
            this.labelDetay2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetay2.Name = "labelDetay2";
            this.labelDetay2.Size = new System.Drawing.Size(48, 17);
            this.labelDetay2.TabIndex = 2;
            this.labelDetay2.Text = "Soyad";
            // 
            // labelDetay1
            // 
            this.labelDetay1.AutoSize = true;
            this.labelDetay1.Location = new System.Drawing.Point(8, 70);
            this.labelDetay1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetay1.Name = "labelDetay1";
            this.labelDetay1.Size = new System.Drawing.Size(93, 17);
            this.labelDetay1.TabIndex = 1;
            this.labelDetay1.Text = "Dogum Tarihi";
            // 
            // labelIsSiraNo
            // 
            this.labelIsSiraNo.AutoSize = true;
            this.labelIsSiraNo.Location = new System.Drawing.Point(20, 36);
            this.labelIsSiraNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIsSiraNo.Name = "labelIsSiraNo";
            this.labelIsSiraNo.Size = new System.Drawing.Size(42, 17);
            this.labelIsSiraNo.TabIndex = 0;
            this.labelIsSiraNo.Text = "TcNo";
            // 
            // IsciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1751, 547);
            this.Controls.Add(this.groupBoxIsDetay);
            this.Name = "IsciForm";
            this.Text = "IsciForm";
            this.Load += new System.EventHandler(this.IsciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridIsci)).EndInit();
            this.groupBoxIsDetay.ResumeLayout(false);
            this.groupBoxIsDetayEkleDuzenle.ResumeLayout(false);
            this.groupBoxIsDetayEkleDuzenle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridIsci;
        private System.Windows.Forms.GroupBox groupBoxIsDetay;
        private System.Windows.Forms.GroupBox groupBoxIsDetayEkleDuzenle;
        private System.Windows.Forms.TextBox textBoxGorev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBolum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSigortaNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCalismaYili;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMaas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxTcNo;
        private System.Windows.Forms.TextBox textBoxPersonelID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCinsiyet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxDogumTarihi;
        private System.Windows.Forms.Label labelDetay2;
        private System.Windows.Forms.Label labelDetay1;
        private System.Windows.Forms.Label labelIsSiraNo;
        private System.Windows.Forms.Button buttonXMLAl;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonEkle;
    }
}