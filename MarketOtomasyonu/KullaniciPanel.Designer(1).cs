namespace MarketOtomasyonu
{
    partial class KullaniciPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpBox_kullanici = new System.Windows.Forms.GroupBox();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.combo_bolge = new System.Windows.Forms.ComboBox();
            this.combo_gunvelikSorusu = new System.Windows.Forms.ComboBox();
            this.combo_yetki = new System.Windows.Forms.ComboBox();
            this.txt_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBox_kullanici.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // grpBox_kullanici
            // 
            this.grpBox_kullanici.Controls.Add(this.btn_kayitSil);
            this.grpBox_kullanici.Controls.Add(this.btn_kayitGuncelle);
            this.grpBox_kullanici.Controls.Add(this.btn_geri);
            this.grpBox_kullanici.Controls.Add(this.btn_kayitEkle);
            this.grpBox_kullanici.Controls.Add(this.combo_bolge);
            this.grpBox_kullanici.Controls.Add(this.combo_gunvelikSorusu);
            this.grpBox_kullanici.Controls.Add(this.combo_yetki);
            this.grpBox_kullanici.Controls.Add(this.txt_guvenlikCevabi);
            this.grpBox_kullanici.Controls.Add(this.txt_email);
            this.grpBox_kullanici.Controls.Add(this.label7);
            this.grpBox_kullanici.Controls.Add(this.txt_sifre);
            this.grpBox_kullanici.Controls.Add(this.label4);
            this.grpBox_kullanici.Controls.Add(this.label6);
            this.grpBox_kullanici.Controls.Add(this.txt_id);
            this.grpBox_kullanici.Controls.Add(this.txt_kullaniciAdi);
            this.grpBox_kullanici.Controls.Add(this.label5);
            this.grpBox_kullanici.Controls.Add(this.label3);
            this.grpBox_kullanici.Controls.Add(this.label8);
            this.grpBox_kullanici.Controls.Add(this.label2);
            this.grpBox_kullanici.Controls.Add(this.label1);
            this.grpBox_kullanici.Location = new System.Drawing.Point(16, 343);
            this.grpBox_kullanici.Margin = new System.Windows.Forms.Padding(4);
            this.grpBox_kullanici.Name = "grpBox_kullanici";
            this.grpBox_kullanici.Padding = new System.Windows.Forms.Padding(4);
            this.grpBox_kullanici.Size = new System.Drawing.Size(1035, 331);
            this.grpBox_kullanici.TabIndex = 1;
            this.grpBox_kullanici.TabStop = false;
            this.grpBox_kullanici.Text = "Kullanıcı Paneli";
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.Location = new System.Drawing.Point(385, 259);
            this.btn_kayitSil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(289, 28);
            this.btn_kayitSil.TabIndex = 10;
            this.btn_kayitSil.Text = "Kayıt Sil";
            this.btn_kayitSil.UseVisualStyleBackColor = true;
            this.btn_kayitSil.Click += new System.EventHandler(this.btn_kayitSil_Click);
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(530, 223);
            this.btn_kayitGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(306, 28);
            this.btn_kayitGuncelle.TabIndex = 9;
            this.btn_kayitGuncelle.Text = "Kayıt Güncelle";
            this.btn_kayitGuncelle.UseVisualStyleBackColor = true;
            this.btn_kayitGuncelle.Click += new System.EventHandler(this.btn_kayitGuncelle_Click);
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.Location = new System.Drawing.Point(219, 223);
            this.btn_kayitEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(303, 28);
            this.btn_kayitEkle.TabIndex = 8;
            this.btn_kayitEkle.Text = "Kayıt Ekle";
            this.btn_kayitEkle.UseVisualStyleBackColor = true;
            this.btn_kayitEkle.Click += new System.EventHandler(this.btn_kayitEkle_Click);
            // 
            // combo_bolge
            // 
            this.combo_bolge.FormattingEnabled = true;
            this.combo_bolge.Location = new System.Drawing.Point(721, 31);
            this.combo_bolge.Margin = new System.Windows.Forms.Padding(4);
            this.combo_bolge.Name = "combo_bolge";
            this.combo_bolge.Size = new System.Drawing.Size(255, 24);
            this.combo_bolge.TabIndex = 4;
            // 
            // combo_gunvelikSorusu
            // 
            this.combo_gunvelikSorusu.FormattingEnabled = true;
            this.combo_gunvelikSorusu.Location = new System.Drawing.Point(721, 116);
            this.combo_gunvelikSorusu.Margin = new System.Windows.Forms.Padding(4);
            this.combo_gunvelikSorusu.Name = "combo_gunvelikSorusu";
            this.combo_gunvelikSorusu.Size = new System.Drawing.Size(255, 24);
            this.combo_gunvelikSorusu.TabIndex = 6;
            // 
            // combo_yetki
            // 
            this.combo_yetki.FormattingEnabled = true;
            this.combo_yetki.Location = new System.Drawing.Point(173, 155);
            this.combo_yetki.Margin = new System.Windows.Forms.Padding(4);
            this.combo_yetki.Name = "combo_yetki";
            this.combo_yetki.Size = new System.Drawing.Size(271, 24);
            this.combo_yetki.TabIndex = 3;
            // 
            // txt_guvenlikCevabi
            // 
            this.txt_guvenlikCevabi.Location = new System.Drawing.Point(721, 163);
            this.txt_guvenlikCevabi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guvenlikCevabi.Name = "txt_guvenlikCevabi";
            this.txt_guvenlikCevabi.Size = new System.Drawing.Size(255, 22);
            this.txt_guvenlikCevabi.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(721, 73);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(255, 22);
            this.txt_email.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(535, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Güvenlik Cevabı:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(173, 112);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(271, 22);
            this.txt_sifre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(535, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bölge:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(535, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Güvenlik Sorusu:";
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(173, 67);
            this.txt_kullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(271, 22);
            this.txt_kullaniciAdi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(535, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yetki:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(34, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(173, 28);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(271, 22);
            this.txt_id.TabIndex = 0;
            // 
            // btn_geri
            // 
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(37, 273);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(4);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(78, 38);
            this.btn_geri.TabIndex = 11;
            this.btn_geri.Text = "<<<<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // KullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 689);
            this.Controls.Add(this.grpBox_kullanici);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciPanel";
            this.Load += new System.EventHandler(this.KullaniciPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBox_kullanici.ResumeLayout(false);
            this.grpBox_kullanici.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpBox_kullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_yetki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_bolge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_gunvelikSorusu;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.TextBox txt_guvenlikCevabi;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_geri;
    }
}