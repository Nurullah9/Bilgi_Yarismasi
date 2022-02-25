using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {


        public SoundPlayer _ses_yaris;
        public SoundPlayer _baris;
        public SoundPlayer _alkis;
        public SoundPlayer _yanlis;
        public SoundPlayer _dogru;
        public Form1()
        {

            _ses_yaris = new SoundPlayer("ses_yaris.wav");
            _baris = new SoundPlayer("Baris.wav");
            _alkis = new SoundPlayer("alkis.wav");
            _yanlis = new SoundPlayer("y.wav");
            _dogru = new SoundPlayer("d.wav");

            InitializeComponent();
            richTextBox1.Text = "Başlamak için Başla butonuna tıklayın.";
            s_sayac.Text = "0";
            d_sayac.Text = "0";
            y_sayac.Text = "0";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";

            dogru_pic.Visible = false;
            yanlıs_pic.Visible = false;
            btn_sonraki.Text = "Başla";
           

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;

      

      

        private void s_sayac_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            btn_sonraki.Enabled = true;

            gizli_lab_2.Text = button3.Text;

            if (gizli_lab_1.Text == gizli_lab_2.Text)
            {
                dogru++;
                d_sayac.Text = dogru.ToString();
                dogru_pic.Visible = true;
                _dogru.Play();
            }
            else

            {
                yanlis++;
                y_sayac.Text = yanlis.ToString();
                yanlıs_pic.Visible = true;
                _yanlis.Play();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            btn_sonraki.Enabled = true;

            gizli_lab_2.Text = button2.Text;

            if (gizli_lab_1.Text == gizli_lab_2.Text)
            {
                dogru++;
                d_sayac.Text = dogru.ToString();
                dogru_pic.Visible = true;
                _dogru.Play();
            }
            else

            {
                yanlis++;
                y_sayac.Text = yanlis.ToString();
                yanlıs_pic.Visible = true;
                    _yanlis.Play();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            btn_sonraki.Enabled = true;

            gizli_lab_2.Text = button2.Text;

            if (gizli_lab_1.Text == gizli_lab_2.Text)
            {
                dogru++;
                d_sayac.Text = dogru.ToString();
                dogru_pic.Visible = true;
                _dogru.Play();
            }
            else

            {
                yanlis++;
                y_sayac.Text = yanlis.ToString();
                yanlıs_pic.Visible = true;
                _yanlis.Play();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            btn_sonraki.Enabled = true;


            gizli_lab_2.Text = button1.Text;

            if (gizli_lab_1.Text == gizli_lab_2.Text)
            {
                dogru++;
                d_sayac.Text = dogru.ToString();
                dogru_pic.Visible = true;
                _dogru.Play();
            }
            else

            {
                yanlis++;
                y_sayac.Text = yanlis.ToString();
                yanlıs_pic.Visible = true;
                _yanlis.Play();
            }
        }

       

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            btn_sonraki.Enabled = false;

            btn_sonraki.Text = "Sonraki";
            soruno++;
            s_sayac.Text = soruno.ToString();

            dogru_pic.Visible = false;
            yanlıs_pic.Visible = false;
            s_sayac.Focus();

            if (soruno == 1)

            {
                _ses_yaris.Play();
                richTextBox1.Text = "1TB kaç GB dir?";
                richTextBox1.Enabled = false;
                button1.Text = "128 GB";
                button2.Text = "1000 GB";
                button3.Text = "1024 GB";
                button4.Text = "1048 GB";

                gizli_lab_1.Text = "1024 GB";
                //   s_sayac.Focus();




            }

            if (soruno == 2)
            {
                _ses_yaris.Play();
                richTextBox1.Text = "Dünyaya en yakın gezegen hangisidir?";

                button1.Text = "Merkür";
                button2.Text = "Ay";
                button3.Text = "Neptün";
                button4.Text = "Mars";


                gizli_lab_1.Text = "Mars";
                //s_sayac.Focus();

            }

            if (soruno == 3)

            {
                _ses_yaris.Play();
                richTextBox1.Text = "Bilgisayarda hangi işlem birimi olmasa da bilgisayar çalışmaya devam eder?";
                button1.Text = "GPU";
                button2.Text = "CPU";
                button3.Text = "RAM";
                button4.Text = "HDD";

                gizli_lab_1.Text = "GPU";
                //  s_sayac.Focus();
            }

            if (soruno == 4)

            {
                _ses_yaris.Play();

                richTextBox1.Text = "Dünyanın şimdiye kadar en çok oynanılan açık dünya online oyunu hangisidir?";
                button1.Text = "Call of Duty";
                button2.Text = "Minecraft";
                button3.Text = "Fortnite";
                button4.Text = "Grand Theft Auto V";


                gizli_lab_1.Text = "Minecraft";

            }
            if (soruno == 5)

            {
                _ses_yaris.Play();
                richTextBox1.Text = "Aşağdaki yazılım türlerinden hangisi bir süreliğine tanıtım amaçlı kullanılabilen, süre bitiminde lisans hakları satın alma koşulu ile kullanılabilen yazılım türüdür?";
                button1.Text = "Demo Yazılım";
                button2.Text = "Lisanslı yazılım";
                button3.Text = "Freeware yazılım";
                button4.Text = "Korsan yazılım";

                gizli_lab_1.Text = "Demo Yazılım";
            }
            if (soruno == 6)

            {
                _ses_yaris.Stop();
                _baris.Play();
                richTextBox1.Text = "Şuan duyduğunuz şarkı kime aittir?";
                button1.Text = "Cem Karaca";
                button2.Text = "Mazhar Alanson";
                button3.Text = "Barış Akarsu";
                button4.Text = "Barış Manço";

                gizli_lab_1.Text = "Barış Manço";
            }
            if (soruno == 7)

            {
                _baris.Stop();
                _ses_yaris.Play();
                richTextBox1.Text = "Dünyanın tanınan ilk bilgisayar programcısı kimdir?";
                button1.Text = "Ada Lovelace";
                button2.Text = "Charles Babbage";
                button3.Text = "Herman Hollerith";
                button4.Text = "Konrad Zuse";
                gizli_lab_1.Text = "Ada Lovelace";
            }
            if (soruno == 8)

            {
                _ses_yaris.Play();
                richTextBox1.Text = "NASA tarafında 25 Aralık 2021 tarihinde fırlatılan ve şimdiyekadarki en kapsamlı uzay teleskopunun ismi nedir?";
                button1.Text = "Kepler";
                button2.Text = "Hubble";
                button3.Text = "James Webb";
                button4.Text = "Starship";
                gizli_lab_1.Text = "James Webb";
                btn_sonraki.Text = "Bitir";
            }
            if (soruno == 9)

            {
                _ses_yaris.Stop();
                _alkis.Play();
                pictureBox1.Visible = true;
                s_sayac.Visible = false;
                label5.Visible = false;
                dogru_pic.Visible = false;
                yanlıs_pic.Visible = false;
                btn_sonraki.Visible = false;

            }
        }
    }
}
