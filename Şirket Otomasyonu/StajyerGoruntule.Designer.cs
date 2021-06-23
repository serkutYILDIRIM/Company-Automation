namespace Şirket_Otomasyonu
{
    partial class StajyerGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StajyerGoruntule));
            this.buttonXMLAl = new System.Windows.Forms.Button();
            this.gridStajyer = new System.Windows.Forms.DataGridView();
            this.groupBoxIsDetay = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridStajyer)).BeginInit();
            this.groupBoxIsDetay.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonXMLAl
            // 
            this.buttonXMLAl.BackColor = System.Drawing.Color.Gold;
            this.buttonXMLAl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXMLAl.BackgroundImage")));
            this.buttonXMLAl.Location = new System.Drawing.Point(13, 27);
            this.buttonXMLAl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXMLAl.Name = "buttonXMLAl";
            this.buttonXMLAl.Size = new System.Drawing.Size(144, 62);
            this.buttonXMLAl.TabIndex = 19;
            this.buttonXMLAl.UseVisualStyleBackColor = false;
            this.buttonXMLAl.Click += new System.EventHandler(this.buttonXMLAl_Click);
            // 
            // gridStajyer
            // 
            this.gridStajyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStajyer.Location = new System.Drawing.Point(8, 100);
            this.gridStajyer.Margin = new System.Windows.Forms.Padding(4);
            this.gridStajyer.Name = "gridStajyer";
            this.gridStajyer.Size = new System.Drawing.Size(1313, 402);
            this.gridStajyer.TabIndex = 7;
            // 
            // groupBoxIsDetay
            // 
            this.groupBoxIsDetay.Controls.Add(this.buttonXMLAl);
            this.groupBoxIsDetay.Controls.Add(this.gridStajyer);
            this.groupBoxIsDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetay.Location = new System.Drawing.Point(0, 13);
            this.groupBoxIsDetay.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Name = "groupBoxIsDetay";
            this.groupBoxIsDetay.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIsDetay.Size = new System.Drawing.Size(1335, 525);
            this.groupBoxIsDetay.TabIndex = 20;
            this.groupBoxIsDetay.TabStop = false;
            this.groupBoxIsDetay.Text = "Stajyer";
            // 
            // StajyerGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1338, 547);
            this.Controls.Add(this.groupBoxIsDetay);
            this.Name = "StajyerGoruntule";
            this.Text = "StajyerGoruntule";
            this.Load += new System.EventHandler(this.StajyerGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStajyer)).EndInit();
            this.groupBoxIsDetay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXMLAl;
        private System.Windows.Forms.DataGridView gridStajyer;
        private System.Windows.Forms.GroupBox groupBoxIsDetay;
    }
}