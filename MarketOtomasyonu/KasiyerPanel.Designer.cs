namespace MarketOtomasyonu
{
    partial class KasiyerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerPanel));
            this.btn_et = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_sut = new System.Windows.Forms.Button();
            this.btn_baklagil = new System.Windows.Forms.Button();
            this.btn_meyveSebze = new System.Windows.Forms.Button();
            this.btn_cikisYap = new System.Windows.Forms.Button();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_et
            // 
            this.btn_et.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_et.ImageKey = "et.ico";
            this.btn_et.ImageList = this.ımageList1;
            this.btn_et.Location = new System.Drawing.Point(44, 53);
            this.btn_et.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_et.Name = "btn_et";
            this.btn_et.Size = new System.Drawing.Size(193, 182);
            this.btn_et.TabIndex = 0;
            this.btn_et.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "bakliyat.ico");
            this.ımageList1.Images.SetKeyName(1, "et.ico");
            this.ımageList1.Images.SetKeyName(2, "meyveSebze.ico");
            this.ımageList1.Images.SetKeyName(3, "süt.ico");
            // 
            // btn_sut
            // 
            this.btn_sut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sut.ImageKey = "süt.ico";
            this.btn_sut.ImageList = this.ımageList1;
            this.btn_sut.Location = new System.Drawing.Point(292, 53);
            this.btn_sut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sut.Name = "btn_sut";
            this.btn_sut.Size = new System.Drawing.Size(193, 182);
            this.btn_sut.TabIndex = 1;
            this.btn_sut.UseVisualStyleBackColor = true;
            // 
            // btn_baklagil
            // 
            this.btn_baklagil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_baklagil.ImageKey = "bakliyat.ico";
            this.btn_baklagil.ImageList = this.ımageList1;
            this.btn_baklagil.Location = new System.Drawing.Point(44, 287);
            this.btn_baklagil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_baklagil.Name = "btn_baklagil";
            this.btn_baklagil.Size = new System.Drawing.Size(193, 182);
            this.btn_baklagil.TabIndex = 2;
            this.btn_baklagil.UseVisualStyleBackColor = true;
            // 
            // btn_meyveSebze
            // 
            this.btn_meyveSebze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_meyveSebze.ImageKey = "meyveSebze.ico";
            this.btn_meyveSebze.ImageList = this.ımageList1;
            this.btn_meyveSebze.Location = new System.Drawing.Point(292, 287);
            this.btn_meyveSebze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_meyveSebze.Name = "btn_meyveSebze";
            this.btn_meyveSebze.Size = new System.Drawing.Size(193, 182);
            this.btn_meyveSebze.TabIndex = 3;
            this.btn_meyveSebze.UseVisualStyleBackColor = true;
            this.btn_meyveSebze.Click += new System.EventHandler(this.btn_meyveSebze_Click);
            // 
            // btn_cikisYap
            // 
            this.btn_cikisYap.Location = new System.Drawing.Point(169, 495);
            this.btn_cikisYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cikisYap.Name = "btn_cikisYap";
            this.btn_cikisYap.Size = new System.Drawing.Size(193, 28);
            this.btn_cikisYap.TabIndex = 4;
            this.btn_cikisYap.Text = "Çıkış Yap";
            this.btn_cikisYap.UseVisualStyleBackColor = true;
            this.btn_cikisYap.Click += new System.EventHandler(this.btn_cikisYap_Click);
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(405, 10);
            this.lbl_saat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(0, 13);
            this.lbl_saat.TabIndex = 5;
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dakika.Location = new System.Drawing.Point(431, 10);
            this.lbl_dakika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(0, 13);
            this.lbl_dakika.TabIndex = 5;
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saniye.Location = new System.Drawing.Point(456, 10);
            this.lbl_saniye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(0, 13);
            this.lbl_saniye.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KasiyerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 550);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.btn_cikisYap);
            this.Controls.Add(this.btn_sut);
            this.Controls.Add(this.btn_meyveSebze);
            this.Controls.Add(this.btn_baklagil);
            this.Controls.Add(this.btn_et);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KasiyerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KasiyerPanel";
            this.Load += new System.EventHandler(this.KasiyerPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_et;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_sut;
        private System.Windows.Forms.Button btn_baklagil;
        private System.Windows.Forms.Button btn_meyveSebze;
        private System.Windows.Forms.Button btn_cikisYap;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Timer timer1;
    }
}