using AForge.Video;
using AForge.Video.DirectShow;
using MarketOtomasyonu.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MarketOtomasyonu
{
    public partial class MeyveSebzePanel : Form
    {

        int sayi1, sayi2, islemTipi;

        public MeyveSebzePanel()
        {
            InitializeComponent();
            textBox_islem.Text = "0";
        }


        FilterInfoCollection fic;
        VideoCaptureDevice vcd;


        private void MeyveSebzePanel_Load(object sender, EventArgs e)
        {
            //timer1.Start();

            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo camera in fic)
            {
                cmbBox_kameraSec.Items.Add(camera.Name);
            }

        }

        private void secilenTus(object sender, EventArgs e)
        {
            if (textBox_islem.Text=="0")
            {
                textBox_islem.Text="";
            }
            textBox_islem.Text += ((Button)sender).Text;
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (islemTipi==1)
            {
                sayi2 = int.Parse(textBox_islem.Text);
                textBox_islem.Text = (sayi1 + sayi2).ToString();
            }
            else if (islemTipi==2)
            {
                sayi2 = int.Parse(textBox_islem.Text);
                textBox_islem.Text = (sayi1 - sayi2).ToString();
            }
            else if (islemTipi == 3)
            {
                sayi2 = int.Parse(textBox_islem.Text);
                textBox_islem.Text = (sayi1 * sayi2).ToString();
            }
            else if (islemTipi==4)
            {
                sayi2 = int.Parse(textBox_islem.Text);
                textBox_islem.Text = (sayi1 / sayi2).ToString();
            }
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            islemTipi = 2;  // 2 = Eksi
            sayi1 = int.Parse(textBox_islem.Text);
            textBox_islem.Text = "0";
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            islemTipi = 3;  // 3 = Çarpı
            sayi1 = int.Parse(textBox_islem.Text);
            textBox_islem.Text = "0";
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            islemTipi = 4;  // 4 = Bölü
            sayi1 = int.Parse(textBox_islem.Text);
            textBox_islem.Text = "0";
        }

        private void btn_geriGel_Click(object sender, EventArgs e)
        {

            if (textBox_islem.Text.Length != 0)
            {
                textBox_islem.Text = textBox_islem.Text.Substring(0, textBox_islem.Text.Length - 1);
            }
            else
            {
                textBox_islem.Text = "0";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lbl_saat.Text = DateTime.Now.Hour.ToString();
            //lbl_dakika.Text = DateTime.Now.Minute.ToString();
            //lbl_saniye.Text = DateTime.Now.Second.ToString();

            if (pctBox_kamera.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pctBox_kamera.Image);

                if (result != null)
                {
                    textBox1.Text = result.ToString();
                    timer1.Stop();
                }
            }


        }

        private void btn_kameraAc_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[cmbBox_kameraSec.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame1;
            vcd.Start();
            timer1.Start();
        }

        private void Vcd_NewFrame1(object sender, NewFrameEventArgs eventArgs)
        {
            pctBox_kamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_kameraKapat_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            pctBox_kamera.Image = Image.FromFile(@"C:\\Users\\TUNCAY\\Desktop\\market\\resimler\\camera.ico");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controller.Controller controller = new controller.Controller();
            Urun tUrun = controller.urunuGetir(textBox1.Text);
            lbl_urunAdi.Text = tUrun.urunIsim.ToString();
            textBox_islem.Text = tUrun.fiyat.ToString();
            lbl_urunFiyat.Text = tUrun.fiyat.ToString();
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = "barkod.wav";
            ses.Play();
        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            KasiyerPanel kasiyerPanel = new KasiyerPanel();
            kasiyerPanel.Show();
            this.Hide();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            textBox_islem.Text = "0";
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            islemTipi = 1;  // 1 = Artı
            sayi1 = int.Parse(textBox_islem.Text);
            textBox_islem.Text = "0";
        }
    }
}
