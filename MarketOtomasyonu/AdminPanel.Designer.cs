namespace MarketOtomasyonu
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_urun = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kullanici.ImageKey = "users.ico";
            this.btn_kullanici.ImageList = this.ımageList1;
            this.btn_kullanici.Location = new System.Drawing.Point(44, 55);
            this.btn_kullanici.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(156, 151);
            this.btn_kullanici.TabIndex = 0;
            this.btn_kullanici.UseVisualStyleBackColor = true;
            this.btn_kullanici.Click += new System.EventHandler(this.btn_kullanici_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Hopstarter-Sleek-Xp-Basic-User-Group.ico");
            this.ımageList1.Images.SetKeyName(1, "iconfinder_Shipping8_62597.ico");
            this.ımageList1.Images.SetKeyName(2, "cikis.ico");
            this.ımageList1.Images.SetKeyName(3, "cancel.ico");
            this.ımageList1.Images.SetKeyName(4, "products.ico");
            this.ımageList1.Images.SetKeyName(5, "users.ico");
            // 
            // btn_urun
            // 
            this.btn_urun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_urun.ImageKey = "products.ico";
            this.btn_urun.ImageList = this.ımageList1;
            this.btn_urun.Location = new System.Drawing.Point(247, 55);
            this.btn_urun.Margin = new System.Windows.Forms.Padding(4);
            this.btn_urun.Name = "btn_urun";
            this.btn_urun.Size = new System.Drawing.Size(156, 151);
            this.btn_urun.TabIndex = 0;
            this.btn_urun.UseVisualStyleBackColor = true;
            this.btn_urun.Click += new System.EventHandler(this.btn_urun_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.ImageKey = "cancel.ico";
            this.btn_cikis.ImageList = this.ımageList1;
            this.btn_cikis.Location = new System.Drawing.Point(143, 240);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(156, 151);
            this.btn_cikis.TabIndex = 0;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saniye.Location = new System.Drawing.Point(380, 22);
            this.lbl_saniye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(0, 13);
            this.lbl_saniye.TabIndex = 6;
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dakika.Location = new System.Drawing.Point(355, 22);
            this.lbl_dakika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(0, 13);
            this.lbl_dakika.TabIndex = 7;
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(329, 22);
            this.lbl_saat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(0, 13);
            this.lbl_saat.TabIndex = 8;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 425);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.btn_urun);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_kullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kullanici;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_urun;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saat;
    }
}