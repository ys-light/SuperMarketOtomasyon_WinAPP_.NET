using MarketOtomasyonu.controller;
using MarketOtomasyonu.enumaration;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            User result = controller.login(txt_kullaniciAdi.Text, txt_sifre.Text);

            if (result!= null && result.status == LoginStatus.basarili && result.yetki=="admin")
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
            else if(result != null && result.status == LoginStatus.basarili && result.yetki == "kasiyer")
            {
                KasiyerPanel kasiyerPanel = new KasiyerPanel();
                kasiyerPanel.Show();
                this.Hide();
            }
            else if (result != null && result.status == LoginStatus.basarisiz)
            {
                MessageBox.Show("KullanıcıAdı veya Şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik parametre hatası!","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            SifreDegistirme sd = new SifreDegistirme();
            sd.Show();
            this.Hide();

        }
    }
}
