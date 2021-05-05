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
    public partial class MANTIKSAL_OPERATORLER : Form
    {
        public MANTIKSAL_OPERATORLER()
        {
            InitializeComponent();
        }
        
        private void MANTIKSAL_OPERATORLER_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Mantıksal operatörler programlama dünyasında daha çok karşılaştırma amacıyla kullanılan operatörlerdir. ");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("Bir öğrencinin ortalaması 58 olsun.Öğrencinin ortalaması 45’ten büyük mü?Cevap: Evet(Doğru)");
            listBox1.Items.Add("Bir öğrencinin ortalaması 36 olsun.Öğrencinin ortalaması 45’ten büyük mü?Cevap: Hayır(Yanlış)");
            listBox1.Items.Add("");
            listBox1.Items.Add("Boolean Operatörleri");
            listBox1.Items.Add("");
            listBox1.Items.Add("Boolean operatörler sonucu doğru yada yanlış olan hesaplamayı gerçekleştiren operatörlerdir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("bool sonuc; // değişken atadık.");
            listBox1.Items.Add("sonuc=false; // değişkene deger verdik.");
            listBox1.Items.Add("MessegaBox.Show(sonuc.ToString());//degeri ekrana yazdırdık");
            listBox1.Items.Add("");
            listBox1.Items.Add("Eşitlik ve İlişkisel Operatörle");
            listBox1.Items.Add("");
            listBox1.Items.Add("OPERATÖR        ANLAMI      ÖRNEK       PUAN 90");
            listBox1.Items.Add("==              EŞİT EŞİT   puan==77    False(77 eşit 90 mı?)    ");
            listBox1.Items.Add("!=              EŞİT DEĞİL  puan!=77    True(77 farklı90 mı?)    ");
            listBox1.Items.Add("<               KÜÇÜK       puan<77     True(77küçük 90 mı?)");
            listBox1.Items.Add(">               BÜYÜK       puan>77     False (77 büyük 90mı?)");
            listBox1.Items.Add("<=              KÜÇÜK EŞİT  puan<=77    True(77 küçük veya eşit 90 mı?)");
            listBox1.Items.Add(">=              BÜYÜK EŞİT  puan>=77    False(77 büyük veya eşit 90 mı?)");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("2 degerde True ise True değeri üretilir.");
            listBox1.Items.Add("2 degerden biri False ise False değeri üretilir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("Bir öğrencinin bir dersin sınavından alabileceği puan 0 ile 100 arasında olmalıdır.");
            listBox1.Items.Add("puan >= 0 && puan<=100");
            listBox1.Items.Add("");
            listBox1.Items.Add("Bool gecermi;");
            listBox1.Items.Add("int puan=70;");
            listBox1.Items.Add("gecermi=(puan>=0)&&(puan<=100);");
            listBox1.Items.Add("MessageBox.Show(gecermi)");
            listBox1.Items.Add("True");
            listBox1.Items.Add("");
            listBox1.Items.Add("Bool gecermi;");
            listBox1.Items.Add("int puan=150;");
            listBox1.Items.Add("gecermi=(puan>=0)&&(puan<=100);");
            listBox1.Items.Add("MessageBox.Show(gecermi)");
            listBox1.Items.Add("False");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("2 degerden birisi True ise True değeri üretilir.");
            listBox1.Items.Add("2 degerde False ise False değeri üretilir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("Bir öğrencinin bir dersin sınavından alabileceği puan 0 ile 100 arasında olmalıdır.");
            listBox1.Items.Add("puan <= 0 && puan>=100");
            listBox1.Items.Add("");
            listBox1.Items.Add("Bool gecermi;");
            listBox1.Items.Add("int puan=70;");
            listBox1.Items.Add("gecermi=(puan<=0)&&(puan>=100);");
            listBox1.Items.Add("MessageBox.Show(gecermi)");
            listBox1.Items.Add("True");
            listBox1.Items.Add("");
            listBox1.Items.Add("Bool gecermi;");
            listBox1.Items.Add("int puan=150;");
            listBox1.Items.Add("gecermi=(puan<=0)&&(puan>=100);");
            listBox1.Items.Add("MessageBox.Show(gecermi)");
            listBox1.Items.Add("True");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("işlem yaparken bilgisayarın rastgele bir yerden başlaması aynı verilerden oluşan aritmetiksel ");
      listBox1.Items.Add("veya mantıksal işlemlerin dahi farklı olmasına sebep olacaktır. Bu nedenle matematikten bilinen");
          listBox1.Items.Add("“işlem önceliği”kavramı burada da geçerlidir.");
          listBox1.Items.Add("islem = 3 + 5 * 9");
                  listBox1.Items.Add("Birinci Sonuç ==> islem= 48");
                  listBox1.Items.Add("İkinci Sonuç ==> islem= 72");
                          listBox1.Items.Add("ilk 5*9=45 sonra 45+3=48 sonuc 48 dir.");
                              listBox1.Items.Add("KATEGORİ              OPERATÖR        AÇIKLAMA");
                                  listBox1.Items.Add("BİRİNCİL              ()      Parentez");
                                  listBox1.Items.Add("BİRİNCİL              ++      Arttırma");
                                  listBox1.Items.Add("BİRİNCİL              --      Azaltma");
                                    listBox1.Items.Add("ÇARPIMSAL          *       Çarpma  ");
                                    listBox1.Items.Add("ÇARPIMSAL           /       Bölme  ");
                                    listBox1.Items.Add("ÇARPIMSAL           %       Kalan Bulma ");
                                    listBox1.Items.Add("TOPLUMSAL           +       Toplama");
                                    listBox1.Items.Add("TOPLUMSAL           -       Çıkarma");
                                    listBox1.Items.Add("KARŞILASTIRMA       <       Küçük");
                                    listBox1.Items.Add("KARŞILASTIRMA       >       Büyük");
                                    listBox1.Items.Add("KARŞILASTIRMA       <=      Küçük Eşit");
                                    listBox1.Items.Add("KARŞILASTIRMA       >=      Büyük Eşit");
                                    listBox1.Items.Add("Eşitlik             ==      Eşit Eşit");
                                    listBox1.Items.Add("Eşitlik             !=      Eşit Değil");
                                    listBox1.Items.Add("Koşullu Mantıksal   &&      Ve Operatörü");
                                    listBox1.Items.Add("Koşullu Mantıksal   ||      veya Operatörü");
                     

                  }

        private void button4_Click(object sender, EventArgs e)
        {
            
            int s1, s2, s3, s4;
            s1 = int.Parse(textBox1.Text);
            s2 = int.Parse(textBox2.Text);
            s3 = int.Parse(textBox3.Text);
            s4 = int.Parse(textBox4.Text);
            if (s1 <= s2 && s4 >= s3)
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, s4;
            s1 = int.Parse(textBox1.Text);
            s2 = int.Parse(textBox2.Text);
            s3 = int.Parse(textBox3.Text);
            s4 = int.Parse(textBox4.Text);
            if (s1 <= s2 || s4 >= s3)
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
}
