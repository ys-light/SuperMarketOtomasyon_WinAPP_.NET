namespace MarketOtomasyonu
{
    partial class UrunPanel
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
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.txt_ciro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_barkodKod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_qrkod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_urunPanel = new System.Windows.Forms.GroupBox();
            this.datetime_olusturulmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.datetime_guncellenmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.combo_urunIsım = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_urunPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.Location = new System.Drawing.Point(385, 289);
            this.btn_kayitSil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(289, 28);
            this.btn_kayitSil.TabIndex = 11;
            this.btn_kayitSil.Text = "Ürün Sil";
            this.btn_kayitSil.UseVisualStyleBackColor = true;
            this.btn_kayitSil.Click += new System.EventHandler(this.btn_kayitSil_Click);
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(530, 253);
            this.btn_kayitGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(306, 28);
            this.btn_kayitGuncelle.TabIndex = 10;
            this.btn_kayitGuncelle.Text = "Ürün Güncelle";
            this.btn_kayitGuncelle.UseVisualStyleBackColor = true;
            this.btn_kayitGuncelle.Click += new System.EventHandler(this.btn_kayitGuncelle_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(37, 273);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(4);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(78, 38);
            this.btn_geri.TabIndex = 12;
            this.btn_geri.Text = "<<<<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.Location = new System.Drawing.Point(219, 253);
            this.btn_kayitEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(303, 28);
            this.btn_kayitEkle.TabIndex = 9;
            this.btn_kayitEkle.Text = "Ürün Ekle";
            this.btn_kayitEkle.UseVisualStyleBackColor = true;
            this.btn_kayitEkle.Click += new System.EventHandler(this.btn_kayitEkle_Click);
            // 
            // txt_ciro
            // 
            this.txt_ciro.Location = new System.Drawing.Point(721, 73);
            this.txt_ciro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ciro.Name = "txt_ciro";
            this.txt_ciro.Size = new System.Drawing.Size(255, 22);
            this.txt_ciro.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(535, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Güncellenme Tarihi:";
            // 
            // txt_barkodKod
            // 
            this.txt_barkodKod.Location = new System.Drawing.Point(173, 112);
            this.txt_barkodKod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_barkodKod.Name = "txt_barkodKod";
            this.txt_barkodKod.Size = new System.Drawing.Size(271, 22);
            this.txt_barkodKod.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(535, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Oluşturulma Tarihi:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(173, 28);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(271, 22);
            this.txt_id.TabIndex = 0;
            // 
            // txt_qrkod
            // 
            this.txt_qrkod.Location = new System.Drawing.Point(173, 67);
            this.txt_qrkod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qrkod.Name = "txt_qrkod";
            this.txt_qrkod.Size = new System.Drawing.Size(271, 22);
            this.txt_qrkod.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(535, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ciro:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 286);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün İsmi:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barkod Kod:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QR Kod:";
            // 
            // grp_urunPanel
            // 
            this.grp_urunPanel.Controls.Add(this.combo_urunIsım);
            this.grp_urunPanel.Controls.Add(this.datetime_guncellenmeTarihi);
            this.grp_urunPanel.Controls.Add(this.datetime_olusturulmaTarihi);
            this.grp_urunPanel.Controls.Add(this.btn_kayitSil);
            this.grp_urunPanel.Controls.Add(this.btn_kayitGuncelle);
            this.grp_urunPanel.Controls.Add(this.btn_geri);
            this.grp_urunPanel.Controls.Add(this.btn_kayitEkle);
            this.grp_urunPanel.Controls.Add(this.txt_fiyat);
            this.grp_urunPanel.Controls.Add(this.txt_ciro);
            this.grp_urunPanel.Controls.Add(this.label7);
            this.grp_urunPanel.Controls.Add(this.txt_kilo);
            this.grp_urunPanel.Controls.Add(this.txt_barkodKod);
            this.grp_urunPanel.Controls.Add(this.label6);
            this.grp_urunPanel.Controls.Add(this.txt_id);
            this.grp_urunPanel.Controls.Add(this.txt_qrkod);
            this.grp_urunPanel.Controls.Add(this.label4);
            this.grp_urunPanel.Controls.Add(this.label9);
            this.grp_urunPanel.Controls.Add(this.label5);
            this.grp_urunPanel.Controls.Add(this.label3);
            this.grp_urunPanel.Controls.Add(this.label8);
            this.grp_urunPanel.Controls.Add(this.label2);
            this.grp_urunPanel.Controls.Add(this.label1);
            this.grp_urunPanel.Location = new System.Drawing.Point(6, 320);
            this.grp_urunPanel.Margin = new System.Windows.Forms.Padding(4);
            this.grp_urunPanel.Name = "grp_urunPanel";
            this.grp_urunPanel.Padding = new System.Windows.Forms.Padding(4);
            this.grp_urunPanel.Size = new System.Drawing.Size(1035, 331);
            this.grp_urunPanel.TabIndex = 3;
            this.grp_urunPanel.TabStop = false;
            this.grp_urunPanel.Text = "Ürün Paneli";
            // 
            // datetime_olusturulmaTarihi
            // 
            this.datetime_olusturulmaTarihi.Location = new System.Drawing.Point(721, 116);
            this.datetime_olusturulmaTarihi.Name = "datetime_olusturulmaTarihi";
            this.datetime_olusturulmaTarihi.Size = new System.Drawing.Size(255, 22);
            this.datetime_olusturulmaTarihi.TabIndex = 7;
            // 
            // datetime_guncellenmeTarihi
            // 
            this.datetime_guncellenmeTarihi.Location = new System.Drawing.Point(721, 159);
            this.datetime_guncellenmeTarihi.Name = "datetime_guncellenmeTarihi";
            this.datetime_guncellenmeTarihi.Size = new System.Drawing.Size(255, 22);
            this.datetime_guncellenmeTarihi.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(34, 196);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kilo:";
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(173, 191);
            this.txt_kilo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(271, 22);
            this.txt_kilo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(535, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fiyat:";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(721, 28);
            this.txt_fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(255, 22);
            this.txt_fiyat.TabIndex = 5;
            // 
            // combo_urunIsım
            // 
            this.combo_urunIsım.FormattingEnabled = true;
            this.combo_urunIsım.Location = new System.Drawing.Point(173, 153);
            this.combo_urunIsım.Name = "combo_urunIsım";
            this.combo_urunIsım.Size = new System.Drawing.Size(271, 24);
            this.combo_urunIsım.TabIndex = 3;
            // 
            // UrunPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 662);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grp_urunPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UrunPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunPanel";
            this.Load += new System.EventHandler(this.UrunPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_urunPanel.ResumeLayout(false);
            this.grp_urunPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.TextBox txt_ciro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_barkodKod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_qrkod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_urunPanel;
        private System.Windows.Forms.DateTimePicker datetime_guncellenmeTarihi;
        private System.Windows.Forms.DateTimePicker datetime_olusturulmaTarihi;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combo_urunIsım;
    }
}