using MarketOtomasyonu.controller;
using MarketOtomasyonu.enumaration;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace MarketOtomasyonu
{
    public partial class SifreDegistirme : Form
    {
        int code;

        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            List<LoginTable> loginTableList = controller.getLoginTable();
            
            grpBox_mailAlani.Enabled = false;
            grpbox_sifreDegistirmeAlani.Enabled = false;

            foreach (LoginTable lt in loginTableList)
            {
                cmbBox_guvenlikSorusu.Items.Add(lt.guvenlikSorusu.ToString());
            }
            cmbBox_guvenlikSorusu.SelectedIndex = 0;

        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            LoginStatus result = controller.doAuthentication(txtBox_kullaniciAdi.Text.Trim().ToLower(), cmbBox_guvenlikSorusu.SelectedItem.ToString(), txtBox_sorununCevabi.Text.ToLower());

            if (result == LoginStatus.basarili)
            {
                grpBox_mailAlani.Enabled = true;
            }
            else if(result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Girdiğiniz bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void btn_dogrulamaKodunuGonder_Click(object sender, EventArgs e)
        {

            Controller controller = new Controller();
            string emailAdres = controller.checkEmailAddress(txtBox_kullaniciAdi.Text);

            if (emailAdres == txt_eMail.Text)
            {
                Random rnd = new Random();
                code = rnd.Next(111111, 999999);

                MailAddress mailGonderen = new MailAddress("tuncay.albayrak.250@gmail.com", "Tuncay Albayrak - Admin");
                MailAddress mailAlan = new MailAddress(txt_eMail.Text, txtBox_kullaniciAdi.Text);
                MailMessage mesaj = new MailMessage();

                mesaj.To.Add(mailAlan);
                mesaj.From = mailGonderen;
                mesaj.Subject = "Şifre Değiştirme";
                mesaj.Body = "Şifrenizi değiştirmek için doğrulama kodunuz: " + code;

                var smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential("tuncay.albayrak.250@gmail.com", "kgkuqbztocyqrmxw");
                smtp.Port = 587;
                smtp.Send(mesaj);

                MessageBox.Show("Doğrulama kodu gönderildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hesabınıza bağlı mail adresini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private void btn_dogrulamaKodunuOnayla_Click(object sender, EventArgs e)
        {
            if (txt_dogrulamaKodu.Text==code.ToString())
            {
                grpbox_sifreDegistirmeAlani.Enabled = true;
            }
            else
            {
                MessageBox.Show("Doğrulama kodunuz yanlıştır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_sifreyiYenile_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            if (txt_yeniSifre.Text == txtBox_yeniSifreTekrari.Text)
            {
                LoginStatus result = controller.changePassword(txtBox_kullaniciAdi.Text ,txt_yeniSifre.Text);

                if (result == LoginStatus.basarili)
                {
                    MessageBox.Show("Şifreniz başarıyla değiştirilmiştir.", "Bilgilendirme", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gerekli alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_geriGel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
