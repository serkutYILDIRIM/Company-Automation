namespace Şirket_Otomasyonu
{
    partial class AvukatGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvukatGoruntule));
            this.buttonXMLAl = new System.Windows.Forms.Button();
            this.gridAvukat = new System.Windows.Forms.DataGridView();
            this.groupBoxIsDetay = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAvukat)).BeginInit();
            this.groupBoxIsDetay.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonXMLAl
            // 
            this.buttonXMLAl.BackColor = System.Drawing.Color.Gold;
            this.buttonXMLAl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXMLAl.BackgroundImage")));
            this.buttonXMLAl.Location = new System.Drawing.Point(8, 27);
            this.buttonXMLAl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXMLAl.Name = "buttonXMLAl";
            this.buttonXMLAl.Size = new System.Drawing.Size(144, 62);
            this.buttonXMLAl.TabIndex = 19;
            this.buttonXMLAl.UseVisualStyleBackColor = false;
            this.buttonXMLAl.Click += new System.EventHandler(this.buttonXMLAl_Click);
            // 
            // gridAvukat
            // 
            this.gridAvukat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAvukat.Location = new System.Drawing.Point(0, 97);
            this.gridAvukat.Margin = new System.Windows.Forms.Padding(4);
            this.gridAvukat.Name = "gridAvukat";
            this.gridAvukat.Size = new System.Drawing.Size(1560, 341);
            this.gridAvukat.TabIndex = 7;
            // 
            // groupBoxIsDetay
            // 
            this.groupBoxIsDetay.Controls.Add(this.buttonXMLAl);
            this.groupBoxIsDetay.Controls.Add(this.gridAvukat);
            this.groupBoxIsDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetay.Location = new System.Drawing.Point(23, 9);
            this.groupBoxIsDetay.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Name = "groupBoxIsDetay";
            this.groupBoxIsDetay.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Size = new System.Drawing.Size(1581, 529);
            this.groupBoxIsDetay.TabIndex = 20;
            this.groupBoxIsDetay.TabStop = false;
            this.groupBoxIsDetay.Text = "Avukat";
            // 
            // AvukatGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1627, 547);
            this.Controls.Add(this.groupBoxIsDetay);
            this.Name = "AvukatGoruntule";
            this.Text = "AvukatGoruntule";
            this.Load += new System.EventHandler(this.AvukatGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAvukat)).EndInit();
            this.groupBoxIsDetay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXMLAl;
        private System.Windows.Forms.DataGridView gridAvukat;
        private System.Windows.Forms.GroupBox groupBoxIsDetay;
    }
}