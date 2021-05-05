using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace Volkan_SARIKAYA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void değişkenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox1.Items.Add("Değişken adlarında (büyük ve küçük), rakam ve alt çizgi( _ )karakteri kullanılabilir, boşluk içermez.");
            listBox1.Items.Add("Türkçe karakterler kullanılabilir ama önerilmez (ç,ğ,ş,ö,ü,ı,i vb.).");
            listBox1.Items.Add("Değişken adı, bir harf ile (Altçizgi harf olarak kabul edilir.) başlamak zorundadır, rakamlarla başlayamaz.");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("1. int sayı; ");
            listBox1.Items.Add("1. string soy_ad ;");
            listBox1.Items.Add("");
            listBox1.Items.Add("2. ınt sayı ;           X");
            listBox1.Items.Add("2. string soy ad ;          X");
            listBox1.Items.Add("");
            listBox1.Items.Add("1.ci örnekler dogru 2.ci örnekler yanlıstır");
        
        
        }

        private void veriTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Bir Konu Secin");

        }

        private void intToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("İnt sayısal verileri girmek icin kullanılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayı=5;");
            listBox1.Items.Add("textBox1.Text=sayı.ToString();");
            int sayı = 5;
            textBox1.Text = sayı.ToString();
            listBox1.Items.Add("Program calısır.");
            listBox1.Items.Add("İnt dışında hicbir veri girilemez girilirse program calısmaz ");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("int metin=ahmet; X");
            listBox1.Items.Add("textBox1.Text=metin.ToString();  X");
            listBox1.Items.Add("Program Calısmaz.");
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("String metinsel verileri girmek icin kullanılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("String ad=Metin ;");
            listBox1.Items.Add("textBox1.Text=ad.ToString();");
            String ad ="metin";
            textBox1.Text = ad.ToString();
            listBox1.Items.Add("Program calısır.");
            listBox1.Items.Add("String dışında hicbir veri girilemez girilirse program calısmaz ");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("String sayı=5; X");
            listBox1.Items.Add("textBox1.Text=metin.ToString();  X");
            listBox1.Items.Add("Program Calısmaz.");
        }

        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Double ondalıklı sayıları girmek icin kullanılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("Double sayı=3.14;");
            listBox1.Items.Add("textBox1.Text=sayı.ToString();");
            Double sayı = 3.14;
            textBox1.Text = sayı.ToString();
            listBox1.Items.Add("Program calısır.");
            listBox1.Items.Add("Double dışında hicbir veri girilemez girilirse program calısmaz ");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("Double metin=ahmet; X");
            listBox1.Items.Add("textBox1.Text=metin.ToString();  X");
            listBox1.Items.Add("Program Calısmaz.");
        }

        private void charToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Char tek bir harf girmek icin kullanılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("Char harf='a';");
            listBox1.Items.Add("textBox1.Text=harf.ToString();");
            Char harf ='a';
            textBox1.Text = harf.ToString();
            listBox1.Items.Add("Program calısır.");
            listBox1.Items.Add("Char dışında hicbir veri girilemez girilirse program calısmaz ");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("char sayı=5; X");
            listBox1.Items.Add("textBox1.Text=sayı.ToString();  X");
            listBox1.Items.Add("Program Calısmaz.");
        }

        private void operatörlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Bir Konu Secin");
        }

        private void aritmetikselOperatörlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Programlama dilinde bilinen dört işlemin aritmetik işleçlerini destekler:");
            listBox1.Items.Add("Toplama(+)");
            listBox1.Items.Add("Cıkarma(-)");
            listBox1.Items.Add("Çarpma(*)");
            listBox1.Items.Add("Bölme(/)");
        }

        private void toplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, sonuc;
            sayı1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("", "", "", 400, 400));
            sayı2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("", "", "", 400, 400));
            sonuc = sayı1 + sayı2;
            textBox1.Text ="2 sayının toplamı="+sonuc.ToString();
        }

        private void cıkarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, sonuc;
            sayı1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("", "", "", 400, 400));
            sayı2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("", "", "", 400, 400));
            sonuc = sayı1 - sayı2;
            textBox1.Text = "sonuc=" + sonuc.ToString();
        }

        private void carpmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, sonuc;
            sayı1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("", "", "", 400, 400));
            sayı2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("", "", "", 400, 400));
            sonuc = sayı1 * sayı2;
            textBox1.Text = "2 sayının carpımı=" + sonuc.ToString();
        }

        private void bölmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int sayı1, sayı2, sonuc;
            sayı1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("", "", "", 400, 400));
            sayı2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("", "", "", 400, 400));
            sonuc = sayı1 / sayı2;
            textBox1.Text = "2 sayının bölümü=" + sonuc.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("İstediğiniz bir konuyu Seçin");
            axWindowsMediaPlayer1.URL = "C:\\Documents and Settings\\Administrator\\Belgelerim\\Visual Studio 2008\\Projects\\Volkan SARIKAYA\\Volkan SARIKAYA\\bin\\Debug\\Gamze.mp3";
            axWindowsMediaPlayer1.URL = "C:\\Documents and Settings\\Administrator\\Belgelerim\\Visual Studio 2008\\Projects\\Volkan SARIKAYA\\Volkan SARIKAYA\\bin\\Debug\\Deniz.mp3";
        }

        private void isleclerVeTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



    }
}
//listBox1.Items.Add(""); 