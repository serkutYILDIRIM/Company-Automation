namespace Şirket_Otomasyonu
{
    partial class IsciGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsciGoruntule));
            this.buttonXMLAl = new System.Windows.Forms.Button();
            this.groupBoxIsDetay = new System.Windows.Forms.GroupBox();
            this.gridIsci = new System.Windows.Forms.DataGridView();
            this.groupBoxIsDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIsci)).BeginInit();
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
            // groupBoxIsDetay
            // 
            this.groupBoxIsDetay.Controls.Add(this.buttonXMLAl);
            this.groupBoxIsDetay.Controls.Add(this.gridIsci);
            this.groupBoxIsDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetay.Location = new System.Drawing.Point(23, 9);
            this.groupBoxIsDetay.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Name = "groupBoxIsDetay";
            this.groupBoxIsDetay.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Size = new System.Drawing.Size(1581, 529);
            this.groupBoxIsDetay.TabIndex = 20;
            this.groupBoxIsDetay.TabStop = false;
            this.groupBoxIsDetay.Text = "İşçi";
            // 
            // gridIsci
            // 
            this.gridIsci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIsci.Location = new System.Drawing.Point(0, 100);
            this.gridIsci.Margin = new System.Windows.Forms.Padding(4);
            this.gridIsci.Name = "gridIsci";
            this.gridIsci.Size = new System.Drawing.Size(1560, 351);
            this.gridIsci.TabIndex = 7;
            // 
            // IsciGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1627, 547);
            this.Controls.Add(this.groupBoxIsDetay);
            this.Name = "IsciGoruntule";
            this.Text = "IsciGoruntule";
            this.Load += new System.EventHandler(this.IsciGoruntule_Load);
            this.groupBoxIsDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridIsci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXMLAl;
        private System.Windows.Forms.GroupBox groupBoxIsDetay;
        private System.Windows.Forms.DataGridView gridIsci;
    }
}