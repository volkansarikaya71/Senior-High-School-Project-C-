using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Volkan_SARIKAYA
{
    public partial class HATA_AYIKLAMA : Form
    {
        public HATA_AYIKLAMA()
        {
            InitializeComponent();
        }

        private void HATA_AYIKLAMA_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("HATA AYIKLAMA");
            listBox1.Items.Add("");
            listBox1.Items.Add("Program kodları ' try' bölümüne yazılır.Herhangi bir hata oluşması durumunda 'cath' bloğundaki komutlar devreye girer.");
            listBox1.Items.Add("'Finally' bloğu isteğe bağlıdır, ve her durumda çalışır.Aynı proğramda birden fazla hatayı yakalamak istiyorsak 'cath'");
            listBox1.Items.Add("bloğunun sayısını arttırmak yeterli olacaktır.Kullanılan hata türleri şunlardır:");
            listBox1.Items.Add("");
            listBox1.Items.Add("FORMAT EXCEPTION:");
            listBox1.Items.Add("Sayısal veri türüne sahip bir değişkene sözel bir ifade girilmesi durumunda ortaya çıkan hata türüdür.");
            listBox1.Items.Add("string 1; , int isimler; vb...");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayi='metin'");
            listBox1.Items.Add("textBox1.Text=(sayi.ToSting());");
            listBox1.Items.Add("");
            listBox1.Items.Add("OVER FLOW EXCEPTION:");
            listBox1.Items.Add("Veri türünün alabileceği veri aralığı dışında değer girilmesi durumunda ortağa çıkan hata türüdür.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("byte sayi=266;//byre alabileceği değerler 0-255 arasındadır.");
            listBox1.Items.Add("textBox1.Text=(sayi.ToSting());");
            listBox1.Items.Add("");
            listBox1.Items.Add("ARGUMENT EXCEPTION:");
            listBox1.Items.Add("Sayısal veri türüne sahip bir değişkene null deger atanması durumunda ortağa çıkan hata türüdür.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayi=null;");
            listBox1.Items.Add("textBox1.Text=(sayi.ToSting());");
            listBox1.Items.Add("");
            listBox1.Items.Add("DİVİDEBY ZERO EXCEPTION:");
            listBox1.Items.Add("Bir sayının 0'ra bölünmesi durumunda ortağa çıkan hata türüdür.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayi=10;");
            listBox1.Items.Add("sayi=sayi/0;");
            listBox1.Items.Add("textBox1.Text=(sayi.ToSting());");
            listBox1.Items.Add("");
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label1.Text=("1 SAYİ GİRİNİZ");
            label2.Text = ("1 METİN GİRİNİZ");
            label4.Text = ("*");

            textBox1.Text = (34.ToString());
            textBox2.Text = ("Fatma");

            textBox3.Text = ("FORMAT EXCEPTION");


        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label1.Text = ("SAYİ GİRİNİZ(0-255)");
            label2.Text = ("SAYİ GİRİNİZ(0-255 farklı)");
            label4.Text = ("*");

            textBox1.Text = (34.ToString());
            textBox2.Text = (655.ToString());

            textBox3.Text = ("OVER FLOW EXCEPTION");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label1.Text = (" SAYİ GİRİNİZ");
            label2.Text = (" SAYİ GİRİNİZ");
            label4.Text = ("*");

            textBox1.Text = ("NULL");
            textBox2.Text = (655.ToString());

            textBox3.Text = ("ARGUMENT EXCEPTION");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label1.Text = (" SAYİ GİRİNİZ");
            label2.Text = (" SAYİ GİRİNİZ");
            label4.Text = ("/");

            textBox1.Text = (10.ToString());
            textBox2.Text = (0.ToString());

            textBox3.Text = ("DİVİDEBY ZERO EXCEPTION");
        }
    }
}
