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
    public partial class DÖNGÜ_YAPILARI : Form
    {
        public DÖNGÜ_YAPILARI()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void DÖNGÜ_YAPILARI_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Bileşik Atama Operatörleri");
            listBox1.Items.Add("Aritmetiksel operatörlerle (+,-, /, *) atama operatörünün (=) birleştirilmesi ile oluşan operatörlerdir.");
            listBox1.Items.Add("toplam=toplam+60 // toplam değişkenine 60 ilave ettik.");
            listBox1.Items.Add("Yukarıdaki ifade çalışıyor olmakla birlikte deneyimli bir programcıa sla böyle ifadeler kullanmamaktadır.");
            listBox1.Items.Add("o ifade yerine toplam+=60 yazılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("İŞLEM           BASİT ATAMA             BİRLEŞİK ATAMA");
            listBox1.Items.Add("Toplama         değer = değer + sayı    değer += sayı");
            listBox1.Items.Add("Çıkarma         değer = değer - sayı    değer -= sayı");
            listBox1.Items.Add("Çarpma          değer = değer * sayı    değer *= sayı");
            listBox1.Items.Add("Bölme           değer = değer / sayı    değer /= sayı");
            listBox1.Items.Add("Kalanı Bulma    değer = değer % sayı    değer %= sayı");
            listBox1.Items.Add("1 arttırma      değer = değer + 1       değer ++");
            listBox1.Items.Add("1 azaltma       değer = değer - 1       değer --");
            listBox1.Items.Add("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(" Bir koşula bağlı olarak (koşul sonucu true olduğu sürece) bir takım kodlamaları tekrar tekrar çalıştırmak ");
            listBox1.Items.Add("için kullanılan döngüsel yapıdır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("while(kosul)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("kodlamalar;");
            listBox1.Items.Add("Denetim değişkeni güncellemesi(sayaç);// bu kod yazılmazsa sonuz döngü olusur program hic kapanmaz.;");
            listBox1.Items.Add("}");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("Klavyeden girilen sayıya kadar tüm tek sayıları yazan programı kodlayın");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayi;");
            listBox1.Items.Add("sayi=int.Parse(textBox1.Text);");
            listBox1.Items.Add("for(sayi%2==1)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("while(sayi!=0");
            listBox1.Items.Add("{");
            listBox1.Items.Add("listBox1.Items.Add(sayi.ToString());");
            listBox1.Items.Add("sayi-=2;");
            listBox1.Items.Add("}");
            listBox1.Items.Add("}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Tıpkı while gibi bir döngü yapısıdır.while döngüsünden en belirgin farkı,döngünün başlama, bitiş ve denetim değişkeni güncellemesinin");
            listBox1.Items.Add("döngü başında yapılmasıdır.Bu nedenlede döngünün başlangıç ve bitiş değeri belli ise genelde bu döngü kullanılmaktadır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("for(başlangıç değeri; bitiş değeri(koşul); denetim değişkeni güncellemesi)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("kodlamalar;");
            listBox1.Items.Add("}");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("Klavyeden girilen sayıya kadar tüm çift sayıları yazan programı kodlayın");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayi;");
            listBox1.Items.Add("sayi=int.Parse=(textBox1.Text);");
            listBox1.Items.Add("if(sayi%2==0)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("for(int s1;sayi>=s1;sayi-=2)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("listBox2.Items.Add(sayi.ToString());");
            listBox1.Items.Add("}");
            listBox1.Items.Add("}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("While ve for ifadelerinin her ikisinde de koşul (boolean ifade)döngünün hemen başında sorgulanmaktadır. Dolayısıyla belirtilen koşul,true değerini üretmezse döngüdeki kodlar işletilmeyecektir.");
            listBox1.Items.Add("Oysa do ifadesinde durum farklıdır.do ifadesinde koşul (boolean ifade)döngünün sonunda verilmektedir. Bu durum döngünün en az bir defa mutlaka işletileceği anlamına gelmektedir.");
            listBox1.Items.Add("do");
            listBox1.Items.Add("{");
            listBox1.Items.Add("kodlamalar;");
            listBox1.Items.Add("}");
            listBox1.Items.Add("while(kosul-boolen ifade)");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("klavyeden girilen sayının katlarını yazdılan programı kodlayın");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayi,sayi2;");

            listBox1.Items.Add("sayi=int.Parse(textBox1.Text);");
            listBox1.Items.Add("sayi2=sayi;");
            listBox1.Items.Add("do");
            listBox1.Items.Add("{");
            listBox1.Items.Add("listBox2.Items.Add(sayi.ToString());");
            listBox1.Items.Add("sayi *=sayi");
            listBox1.Items.Add("}");
            listBox1.Items.Add("while(sayi >= sayi2)");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("BREAK");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayi;");
            listBox1.Items.Add("sayi=int.Parse(textBox1.Text);");
            listBox1.Items.Add("for(int s1=100;sayi<=s1;sayi++)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("if(sayi%3==0)Break; //sayı 3 kalansız bölündüğünde program kapanır.");
            listBox1.Items.Add("}");
            listBox1.Items.Add("listBox2.Items.Add(sayi.ToString());");
            listBox1.Items.Add("");
            listBox1.Items.Add("Continue");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayi;");
            listBox1.Items.Add("sayi=int.Parse(textBox1.Text);");
            listBox1.Items.Add("for(int s1=100;sayi<=s1;sayi++)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("if(sayi%3==0)Break; //sayı 3 kalansız bölündüğünde program kapanmaz.program devam eder");
            listBox1.Items.Add("textBox2.Text=(sayi.ToString())");
            listBox1.Items.Add("}");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int sayi;
            sayi = int.Parse(textBox1.Text);
            if (sayi % 2 == 1)
            {
                while (sayi >= 0)
                {
                    listBox2.Items.Add(sayi.ToString());
                    sayi -= 2;
                }
            }
            else
            {
                sayi--;
                while (sayi >= 0)
                {
                    listBox2.Items.Add(sayi.ToString());
                    sayi -= 2;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int sayi;
            sayi = int.Parse(textBox1.Text);
            if (sayi % 2 == 0)
            {
                for (int s1 = 0; sayi >= s1; sayi -= 2)
                {
                    listBox2.Items.Add(sayi.ToString());
                    
                }
            }
            else
            {
                sayi--;
                for (int s1 = 0; sayi >= s1; sayi -= 2)
                {
                    listBox2.Items.Add(sayi.ToString());
                   
                }
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int sayi, sayi2;

            sayi = int.Parse(textBox1.Text);
            sayi2 = sayi;
            do
            {
                listBox2.Items.Add(sayi.ToString());
                sayi = sayi * sayi;
            }
            while (sayi >= sayi2);
        }


        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            int sayi;
            sayi = int.Parse(textBox1.Text);
            for (int s1 = 100; sayi <= s1; sayi++)
            {
                if (sayi % 3 == 0) break;

            }
            listBox2.Items.Add("Break metodu" + sayi.ToString());

            for (int s1 = 100; sayi <= s1; sayi++)
            {
                if (sayi % 3 == 0) 
                {
                    listBox2.Items.Add("Continue metodu" + sayi.ToString());
                }
               
                
            }




        }
    }
}
    

