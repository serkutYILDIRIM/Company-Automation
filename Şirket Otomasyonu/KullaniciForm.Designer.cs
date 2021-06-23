namespace Şirket_Otomasyonu
{
    partial class KullaniciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciForm));
            this.groupBoxIsDetay = new System.Windows.Forms.GroupBox();
            this.gridKullanici = new System.Windows.Forms.DataGridView();
            this.groupBoxIsDetayEkleDuzenle = new System.Windows.Forms.GroupBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonXMLAl = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxYetki = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSiraNo = new System.Windows.Forms.TextBox();
            this.groupBoxIsDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).BeginInit();
            this.groupBoxIsDetayEkleDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIsDetay
            // 
            this.groupBoxIsDetay.Controls.Add(this.gridKullanici);
            this.groupBoxIsDetay.Controls.Add(this.groupBoxIsDetayEkleDuzenle);
            this.groupBoxIsDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetay.Location = new System.Drawing.Point(65, 27);
            this.groupBoxIsDetay.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Name = "groupBoxIsDetay";
            this.groupBoxIsDetay.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Size = new System.Drawing.Size(1041, 399);
            this.groupBoxIsDetay.TabIndex = 22;
            this.groupBoxIsDetay.TabStop = false;
            this.groupBoxIsDetay.Text = "Kullanıcılar";
            // 
            // gridKullanici
            // 
            this.gridKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKullanici.Location = new System.Drawing.Point(24, 158);
            this.gridKullanici.Margin = new System.Windows.Forms.Padding(4);
            this.gridKullanici.Name = "gridKullanici";
            this.gridKullanici.Size = new System.Drawing.Size(1009, 233);
            this.gridKullanici.TabIndex = 7;
            this.gridKullanici.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKullanici_CellEnter);
            // 
            // groupBoxIsDetayEkleDuzenle
            // 
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonGuncelle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonSil);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonXMLAl);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonEkle);
            this.groupBoxIsDetayEkleDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetayEkleDuzenle.Location = new System.Drawing.Point(24, 31);
            this.groupBoxIsDetayEkleDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetayEkleDuzenle.Name = "groupBoxIsDetayEkleDuzenle";
            this.groupBoxIsDetayEkleDuzenle.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetayEkleDuzenle.Size = new System.Drawing.Size(1009, 119);
            this.groupBoxIsDetayEkleDuzenle.TabIndex = 0;
            this.groupBoxIsDetayEkleDuzenle.TabStop = false;
            this.groupBoxIsDetayEkleDuzenle.Text = "Kullanıcıları Ekle ve Düzenle";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Orange;
            this.buttonGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuncelle.BackgroundImage")));
            this.buttonGuncelle.Location = new System.Drawing.Point(284, 35);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(135, 66);
            this.buttonGuncelle.TabIndex = 26;
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Orange;
            this.buttonSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSil.BackgroundImage")));
            this.buttonSil.Location = new System.Drawing.Point(471, 35);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(130, 66);
            this.buttonSil.TabIndex = 8;
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonXMLAl
            // 
            this.buttonXMLAl.BackColor = System.Drawing.Color.Orange;
            this.buttonXMLAl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXMLAl.BackgroundImage")));
            this.buttonXMLAl.Location = new System.Drawing.Point(666, 35);
            this.buttonXMLAl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXMLAl.Name = "buttonXMLAl";
            this.buttonXMLAl.Size = new System.Drawing.Size(135, 66);
            this.buttonXMLAl.TabIndex = 23;
            this.buttonXMLAl.UseVisualStyleBackColor = false;
            this.buttonXMLAl.Click += new System.EventHandler(this.buttonXMLAl_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Orange;
            this.buttonEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEkle.BackgroundImage")));
            this.buttonEkle.Location = new System.Drawing.Point(80, 35);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(135, 66);
            this.buttonEkle.TabIndex = 6;
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxYetki
            // 
            this.textBoxYetki.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxYetki.Location = new System.Drawing.Point(1155, 471);
            this.textBoxYetki.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYetki.Name = "textBoxYetki";
            this.textBoxYetki.Size = new System.Drawing.Size(132, 22);
            this.textBoxYetki.TabIndex = 5;
            this.textBoxYetki.Visible = false;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(1155, 471);
            this.textBoxSifre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(132, 22);
            this.textBoxSifre.TabIndex = 7;
            this.textBoxSifre.Visible = false;
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(1155, 471);
            this.textBoxKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(132, 22);
            this.textBoxKullaniciAdi.TabIndex = 6;
            this.textBoxKullaniciAdi.Visible = false;
            // 
            // textBoxSiraNo
            // 
            this.textBoxSiraNo.Location = new System.Drawing.Point(1155, 471);
            this.textBoxSiraNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSiraNo.Name = "textBoxSiraNo";
            this.textBoxSiraNo.Size = new System.Drawing.Size(132, 22);
            this.textBoxSiraNo.TabIndex = 3;
            this.textBoxSiraNo.Visible = false;
            // 
            // KullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1170, 439);
            this.Controls.Add(this.groupBoxIsDetay);
            this.Controls.Add(this.textBoxYetki);
            this.Controls.Add(this.textBoxSiraNo);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Name = "KullaniciForm";
            this.Text = "Kullanici";
            this.Load += new System.EventHandler(this.KullaniciForm_Load);
            this.groupBoxIsDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).EndInit();
            this.groupBoxIsDetayEkleDuzenle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIsDetay;
        private System.Windows.Forms.DataGridView gridKullanici;
        private System.Windows.Forms.GroupBox groupBoxIsDetayEkleDuzenle;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.TextBox textBoxYetki;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSiraNo;
        private System.Windows.Forms.Button buttonXMLAl;
    }
}