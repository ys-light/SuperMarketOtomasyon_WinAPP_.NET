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
    public partial class KullaniciPanel : Form
    {

        Controller controller = new Controller();

        public KullaniciPanel()
        {
            InitializeComponent();
        }

        private void KullaniciPanel_Load(object sender, EventArgs e)
        {
            defaulDegerleriDoldur();
            tumKullanicilariDoldur();
        }

        private void defaulDegerleriDoldur()
        {
            combo_yetki.Items.Add("kasiyer");
            combo_yetki.Items.Add("admin");
            combo_yetki.SelectedIndex = 0;
            //----------------------------------
            combo_bolge.Items.Add("Adalar");
            combo_bolge.Items.Add("Arnavutköy");
            combo_bolge.Items.Add("Ataşehir");
            combo_bolge.Items.Add("Bakırköy");
            combo_bolge.Items.Add("Beykoz");
            combo_bolge.Items.Add("Beyoğlu");
            combo_bolge.SelectedIndex = 0;
            //----------------------------------
            combo_gunvelikSorusu.Items.Add("En sevdiğin hayvan");
            combo_gunvelikSorusu.Items.Add("En sevdiğin araba markası");
            combo_gunvelikSorusu.Items.Add("Birinci sınıf öğretmeninin adı nedir");
            combo_gunvelikSorusu.Items.Add("İlk telefonunuzun modeli nedir");
            combo_gunvelikSorusu.Items.Add("Annenizin kızlık soyadı nedir");
            combo_gunvelikSorusu.Items.Add("Hangi şehirde doğdunuz");
            combo_gunvelikSorusu.SelectedIndex = 0;
        }

        private void tumKullanicilariDoldur()
        {
            Controller controller = new Controller();

            List<User> userList = controller.tumKullanicilariGetir();
            dataGridView1.DataSource = userList;
        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = combo_yetki.SelectedItem.ToString();
            user.bolge = combo_bolge.SelectedItem.ToString();
            user.emailAdres = txt_email.Text;
            user.guvenlikSorusu = combo_gunvelikSorusu.SelectedItem.ToString();
            user.guvenlikCevabi = txt_guvenlikCevabi.Text;

            

            LoginStatus sonuc = controller.kullaniciEkle(user);
            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt Eklendi :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Gerekli alanların hepsini doldurun !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            combo_yetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            combo_bolge.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            combo_gunvelikSorusu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_guvenlikCevabi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id = int.Parse(txt_id.Text);
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = combo_yetki.SelectedItem.ToString();
            user.bolge = combo_bolge.SelectedItem.ToString();
            user.emailAdres = txt_email.Text;
            user.guvenlikSorusu = combo_gunvelikSorusu.SelectedItem.ToString();
            user.guvenlikCevabi = txt_guvenlikCevabi.Text;
            LoginStatus sonuc = controller.kullaniciGuncelle(user);

            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt Güncellendi :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();
            }
            else
            {
                MessageBox.Show("Kayıt güncellenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                LoginStatus sonuc = controller.kullaniciSil(int.Parse(txt_id.Text));
                if (sonuc == LoginStatus.basarili)
                {
                    MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.tumKullanicilariGetir();

                }
                else if (sonuc == LoginStatus.basarisiz)
                {
                    MessageBox.Show("Kayıt Silinirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz kaydın id değerini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz kaydın id değerini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }
    }
}
