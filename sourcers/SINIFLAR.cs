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
    public partial class SINIFLAR : Form
    {
        public SINIFLAR()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void SINIFLAR_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("SINIF(CLASS)");
            listBox1.Items.Add("Nesne tabanlı programlamada gereken nesneleri sınıflar yardımıyla oluşturmaktır.");
            listBox1.Items.Add("Sınıfları, nesneleri oluşturmak için önceden oluşturulmuş bir kalıp veya ilk ");
            listBox1.Items.Add("örnek(prototip)olarakda düşünülebilir. Örneğin,kâğıtüzerine detayları çizilmiş ");
            listBox1.Items.Add("bir ev planını kullanarak aynı evden pek çok örnek ev oluşturulabilir.İşte ");
            listBox1.Items.Add("burada kâğıt üzerindeki bu plan sınıftır. Bu plana bakılarak yapılan ev ise ");
            listBox1.Items.Add("sınıftan oluşturulan nesne örneğidir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("SINIF TANIMLAMA");
            listBox1.Items.Add("");
            listBox1.Items.Add("class islem ");
            listBox1.Items.Add("{");
            listBox1.Items.Add("public metot()");
            listBox1.Items.Add("{");
            listBox1.Items.Add("kodlar");
            listBox1.Items.Add("}");
            listBox1.Items.Add("}");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("2 ci sayıyı birinciden den cıkaran program ");
            listBox1.Items.Add("");
            listBox1.Items.Add("class islem ");
            listBox1.Items.Add("{");
            listBox1.Items.Add("public void CIKARMA(int sayi,int sayi2)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("sayi=sayi-sayi2;");
            listBox1.Items.Add("MessageBox.Show(sayi.ToString());");
            listBox1.Items.Add("}");
            listBox1.Items.Add("}");
            listBox1.Items.Add("islem yeni=new islem()");
            listBox1.Items.Add("yeni.kare(int.Parse(textBox1.Text),(int.Parse(textBox1.Text)));");
            listBox1.Items.Add("");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox1.Items.Add("KURUCULAR");
            listBox1.Items.Add("");
            listBox1.Items.Add("Class İslem");
            listBox1.Items.Add("{");
            listBox1.Items.Add("public kale(int sayi=2)");
            listBox1.Items.Add("//void olmadıgı icin her kare ile baslayan sınıfının degeri 2 ile baslayacaktır.");
            listBox1.Items.Add("}");
            listBox1.Items.Add("");


        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox1.Items.Add("AŞIRI YÜKLENMİS KURUCU");
            listBox1.Items.Add("");
            listBox1.Items.Add("iki adet aynı isimde sınıf girilmesine aşırı yüklenmiş sınıf denir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("class islem");
            listBox1.Items.Add("{");
            listBox1.Items.Add("public static void CARPIM()");
            listBox1.Items.Add("{");
            listBox1.Items.Add("int sayı1, sayı2;");
            listBox1.Items.Add("sayı1 = sayı1 * sayı2;");
            listBox1.Items.Add("textBox3.Text = (sayı1.ToString());");
            listBox1.Items.Add("}");
            listBox1.Items.Add("public static void CARPIM(int sayı1,int sayı2)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("sayı1 = sayı1 * sayı2;");
            listBox1.Items.Add("MessageBox.Shoe (sayı1.ToString());");
            listBox1.Items.Add("}");
            listBox1.Items.Add("}");
            listBox1.Items.Add("private void button1_Click(object sender, EventArgs e)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("int sayı1, sayı2;");
            listBox1.Items.Add("sayı1 = int.Parse(textBox1.Text);");
            listBox1.Items.Add("sayı2 = int.Parse(textBox2.Text);");
            listBox1.Items.Add("yeni.CARPIM(int.Parse(textBox1.Text))(int.Parse(textBox2.Text)));");
            listBox1.Items.Add("yeni.CARPIM(sayı1,sayı2);");
            listBox1.Items.Add("}");
            listBox1.Items.Add("");



        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox1.Items.Add("STATİC");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("klaveyeden girilen 2 sayının birbirine bölen program (ÖRNEGIN 6/3=2)");
            listBox1.Items.Add("");
            listBox1.Items.Add("class islem");
            listBox1.Items.Add("{");
            listBox1.Items.Add("pubric static void CARPIM(int sayı)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("sayı=sayı/2");
            listBox1.Items.Add("MessageBox.Show  (sayı.ToString());");
            listBox1.Items.Add("}");
            listBox1.Items.Add("}");
            listBox1.Items.Add("private void button1_Click(object sender, EventArgs e)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("//islem yeni=new islem staticte bunu tanımlaya gerek yok.");
            listBox1.Items.Add("islem.CARPIM(int.Parse(textBox1.Text),(int.Parse(textBox2.Text)));");
            listBox1.Items.Add("}");

        }

        private void button4_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox1.Items.Add("CONST");
            listBox1.Items.Add("");
            listBox1.Items.Add("Bir alanın hem statik olduğunu hem de değerinin hiçbir zaman değiştirilmeyeceği");
         listBox1.Items.Add("const (constant : sabit)anahtar sözcüğü ile belirtilir.");
         listBox1.Items.Add("");
         listBox1.Items.Add("ÖRNEK");
         listBox1.Items.Add("");
         listBox1.Items.Add("public const double PI = 3.14159;");
         listBox1.Items.Add("");
        
        

    }
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("ANONİM SINIFLAR");
            listBox1.Items.Add("Sınıf adı kullanmadan sadece new anahtar sözcüğünün devamında küme parantezleri ");
            listBox1.Items.Add("içerisinde alan tanımlaması yaparak oluşturulan sınıflara anonim sınıflar denir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("var ogrenci = new { Ad = 'Volkan', Yas = 17};");
            listBox1.Items.Add("textbox1.Text=(ogrenci)"); 
            listBox1.Items.Add("");
            listBox1.Items.Add("");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ÖRNEKLER_2 ÖRNEKLER_2 = new ÖRNEKLER_2();
            ÖRNEKLER_2.Show();
            this.Close();
        }
    }
}
