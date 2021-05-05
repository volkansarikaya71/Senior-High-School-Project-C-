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
    public partial class ŞART_İFADELERİ : Form
    {
        public ŞART_İFADELERİ()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void ŞART_İFADELERİ_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("ŞART İFADELERİ");
            listBox1.Items.Add("");
            listBox1.Items.Add("Şart ifadeleri programın akışını yönlendiren güçlü bir yapıdır.Gündelik hayatta çıkan pek çok seçenekten bir tanesi ");
            listBox1.Items.Add("seçilmek zorunda olunduğunda iyi düşünüp ondan sonra karar verilir.Farklı yazım şekillerine rağmen programlama dili ");
            listBox1.Items.Add("içinde farklı seçenekler denen uygununu seçmek için kullanılan yapılardır.");
            listBox1.Items.Add("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Türkçe karşılığını “Eğer” olarak nitelen dirilebilecek if ifadesi, en fazla iki seçenekli durumlar için kullanılan");
            listBox1.Items.Add("bir yapıdır.Koşulun sonucuna bağlı olarak iki farklı kod bloku arasında seçim yapmak istenildiğinde kullanılacak yapıdır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("if(kosul)// kosul dogruysa True");
            listBox1.Items.Add("ifade 1// ifade 1 isletirecek.");
            listBox1.Items.Add("else// kosul yanlıssa False");
            listBox1.Items.Add("ifade 2// ifade 2 isletirecek.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("klavyeden girilen sayının tek mi cift mi oldugu bulan program");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayi1;");
            listBox1.Items.Add("sayi1=int.Parse(textBox1.Text);");
            listBox1.Items.Add("if(sayi1%2==0)");
            listBox1.Items.Add("textBox2.Text=(“sayi Çift”);");
            listBox1.Items.Add("else");
            listBox1.Items.Add("textBox2.Text=(“sayı Tek”);");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Bir programda tek bir if bloku kullanıla bileceği gibi bir if ifadesinin içinde başka bir if ifadesi ");
            listBox1.Items.Add("de kullanılabilir.Bu kullanımda sınır yoktur. Gerektikçe iç içe if ifadelerinin sayısı artabilir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("klavyeden bir fiyat giriyor.bu fiyat 0-200 arasında ise 100 de 20 sini bulup sayıdan cıkarıyor.201-400 arasında");
            listBox1.Items.Add("ise 100 de 40 ını bulup sayıdan cıkarıyor.401-600 arasında ise 100 de 60 ın bulup sayıdan cıkarıyor.");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayi,sonuc=0,sonuc2=0,sonuc3=0;");
            listBox1.Items.Add("sayi=int.Parse(textBox1.Text);");
            listBox1.Items.Add("if(sayi>=0 && sayi<=200)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("sonuc=sayi*20;");
            listBox1.Items.Add("sonuc2=sonuc/100;");
            listBox1.Items.Add("sonuc3=sayi-sonuc2;");
            listBox1.Items.Add("textBox2.Text(sonuc3.ToString());");
            listBox1.Items.Add("}");
            listBox1.Items.Add("else");
            listBox1.Items.Add("{");
            listBox1.Items.Add("if(sayi>=201 && sayi<=400)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("sonuc=sayi*40;");
            listBox1.Items.Add("sonuc2=sonuc/100;");
            listBox1.Items.Add("sonuc3=sayi-sonuc2;");
            listBox1.Items.Add("textBox2.Text(sonuc3.ToString());");
            listBox1.Items.Add("}");
            listBox1.Items.Add("if(sayi>=401 && sayi<=600)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("sonuc=sayi*60;");
            listBox1.Items.Add("sonuc2=sonuc/100;");
            listBox1.Items.Add("sonuc3=sayi-sonuc2;");
            listBox1.Items.Add("textBox2.Text(sonuc3.ToString());");
            listBox1.Items.Add("}");
            listBox1.Items.Add("else");
            listBox1.Items.Add("{");
            listBox1.Items.Add("textBox2.Text(“indirim yok”+sayi);");
            listBox1.Items.Add("}");
            listBox1.Items.Add("}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("İkiden fazla koşulun olduğu durumlarda kullanılan yapıdır.Böylece boolean deyimleri");
            listBox1.Items.Add("içlerinden bir tanesi true değerini üretene kadar basamaklandırıla bilir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("if (koşul-1)");
            listBox1.Items.Add("Kodlamalar");
            listBox1.Items.Add("else if (koşul-2)");
            listBox1.Items.Add("Kodlamalar");
            listBox1.Items.Add("else if (koşul-3)");
            listBox1.Items.Add("Kodlamalar");
            listBox1.Items.Add("else");
            listBox1.Items.Add("Kodlamalar");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("klavyeden 1 tane sınav notu giriyor.Sınav notu 0-24 arasında ise 0 yazsın.25-44 arasında ise 1 yazsın.");
            listBox1.Items.Add("45-54 arasında ise 2 yazsın.55-69 arasında ise 3 yazsın.70-84 arasında ise 4 yazsın.85-100 arasında ise 5 yazsın.");
            listBox1.Items.Add("");
            listBox1.Items.Add("int not;");
            listBox1.Items.Add("not=int.Parse(textBox1.Text);");
            listBox1.Items.Add("if(not>=0 && not<=24)");
            listBox1.Items.Add("textBox2.Text=(0.ToString());");
            listBox1.Items.Add("else if(not>=25 && not<=44)");
            listBox1.Items.Add("textBox2.Text=(1.ToString());");
            listBox1.Items.Add("else if(not>=45 && not<=54)");
            listBox1.Items.Add("textBox2.Text=(2.ToString());");
            listBox1.Items.Add("else if(not>=55 && not<=69)");
            listBox1.Items.Add("textBox2.Text=(3.ToString());");
            listBox1.Items.Add("else if(not>=70 && not<=84)");
            listBox1.Items.Add("textBox2.Text=(4.ToString());");
            listBox1.Items.Add("else if(not>=85 && not<=100)");
            listBox1.Items.Add("textBox2.Text=(5.ToString());");
            listBox1.Items.Add("else");
            listBox1.Items.Add("textBox2.Text=(“hatalı sayı girisi 0-100 arasında sayı giriniz”);");
            listBox1.Items.Add("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Else–if ifadesinin program içerisinde ikiden fazla koşul var ise kullanılan bir yapı olduğunu daha önce söylenmişti.Bununla beraber else–if yapısında koşul,sürekli olarak elde edilen değer yeni değerlerle ");
            listBox1.Items.Add("kıyaslanmaktadır.Switch ifadesinde ise elde edilen değer yeni değerlerle kıyaslanmak yerine eşleştiği değere göre kodları işletmektedir. Bu durum aynı zamanda programın okunabilirliğine de katkı yapmaktadır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("switch(kontrol-ifadesi)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("case durum-ifadesi 1:");
            listBox1.Items.Add("kodlamalar");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("case durum-ifadesi 2:");
            listBox1.Items.Add("kodlamalar");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("default:");
            listBox1.Items.Add("kodlamalar");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("}");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("klavyeden 1-12 arasında sayı giriyor.girilen sayıya göre ayları gösteren program(örnek 1 yazınca ocak yazcak)");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayi;");
            listBox1.Items.Add("sayi=int.Parse(textBox1.Text);");
            listBox1.Items.Add("switch(sayi)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("case 1:");
            listBox1.Items.Add("textBox2.Text=(“Ocak”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("case 2:");
            listBox1.Items.Add("textBox2.Text=(“Subat”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("case 3:");
            listBox1.Items.Add("textBox2.Text=(“Mart”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("case 4:");
            listBox1.Items.Add("textBox2.Text=(“Nisan”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("case 5:");
            listBox1.Items.Add("textBox2.Text=(“Mayıs”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("case 6:");
            listBox1.Items.Add("textBox2.Text=(“Haziran”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("case 7:");
            listBox1.Items.Add("textBox2.Text=(“Temmuz”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("case 8:");
            listBox1.Items.Add("textBox2.Text=(“Ağustos”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("case 9:");
            listBox1.Items.Add("textBox2.Text=(“Eylül”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("case 10:");
            listBox1.Items.Add("textBox2.Text=(“Ekim”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("case 11:");
            listBox1.Items.Add("textBox2.Text=(“Kasım”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("case 12:");
            listBox1.Items.Add("textBox2.Text=(“Aralık”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("default:");
            listBox1.Items.Add("textBox2.text=(“Hatalı giris.1-12 arasında sayı giriniz.”)");
            listBox1.Items.Add("break;");
            listBox1.Items.Add("}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = int.Parse(textBox1.Text);
            if (sayi1 % 2 == 0)
                textBox2.Text = ("sayi Çift");
            else
                textBox2.Text = ("sayi Tek");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi, sonuc = 0, sonuc2 = 0,sonuc3=0;
            sayi = int.Parse(textBox1.Text);
            if (sayi >= 0 && sayi <= 200)
            {
                sonuc = sayi * 20;
                sonuc2 = sonuc / 100;
                sonuc3 = sayi - sonuc2;
                textBox2.Text = (sonuc3.ToString());
            }
            else
            {
                if (sayi >= 201 && sayi <= 400)
                {
                    sonuc = sayi * 40;
                    sonuc2 = sonuc / 100;
                    sonuc3 = sayi - sonuc2;
                    textBox2.Text = (sonuc3.ToString());
                }
                if (sayi >= 401 && sayi <= 600)
                {
                    sonuc = sayi * 60;
                    sonuc2 = sonuc / 100;
                    sonuc3 = sayi - sonuc2;
                    textBox2.Text = (sonuc3.ToString());
                }
                else

                    textBox2.Text = ("indirim yok"+sayi);

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int not;
            not=int.Parse(textBox1.Text);
            if(not>=0 && not<=24)
            textBox2.Text=(0.ToString());
            else if(not>=25 && not<=44)
                textBox2.Text = (1.ToString());
            else if(not>=45 && not<=54)
                textBox2.Text = (2.ToString());
            else if(not>=55 && not<=69)
                textBox2.Text = (3.ToString());
            else if(not>=70 && not<=84)
                textBox2.Text = (4.ToString());
            else if(not>=85 && not<=100)
                textBox2.Text = (5.ToString());
            else
            textBox2.Text=("hatalı sayı girisi 0-100 arasında sayı giriniz");
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi=int.Parse(textBox1.Text);
            switch (sayi)
            {
                case 1:
                    textBox2.Text = ("Ocak");
                    break;
                case 2:
                    textBox2.Text = ("Subat");
                    break;
                case 3:
                    textBox2.Text = ("Mart");
                    break;
                case 4:
                    textBox2.Text = ("Nisan");
                    break;
                case 5:
                    textBox2.Text = ("Mayıs");
                    break;
                case 6:
                    textBox2.Text = ("Haziran");
                    break;
                case 7:
                    textBox2.Text = ("Temmuz");
                    break;
                case 8:
                    textBox2.Text = ("Agustos");
                    break;
                case 9:
                    textBox2.Text = ("Eylül");
                    break;
                case 10:
                    textBox2.Text = ("Ekim");
                    break;
                case 11:
                    textBox2.Text = ("Kasım");
                    break;
                case 12:
                    textBox2.Text = ("Aralık");
                    break;

                default:
                    textBox2.Text = ("Hatalı giris.1-12 arasında sayı giriniz.");
                    break;
            }
        }
    }
}
