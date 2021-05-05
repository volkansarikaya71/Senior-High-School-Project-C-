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
    public partial class METOT_CAGIRMA : Form
    {
        public METOT_CAGIRMA()
        {
            InitializeComponent();
        }
        int alan(int kk, int uk)
        {
            int sonuc;
            sonuc = uk * kk;
            return sonuc;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            METOTLAR METOTLAR = new METOTLAR();
            METOTLAR.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void METOT_CAGIRMA_Load(object sender, EventArgs e)
        {

            listBox1.Items.Add("Tanımlanan metotları adları kullanılarak çağrılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("public METOT_CAGIRMA()");
       listBox1.Items.Add("{");
       listBox1.Items.Add("InitializeComponent();");
       listBox1.Items.Add("}");
       listBox1.Items.Add("int alan(int Kısakenar,int uzunkenar)");
      listBox1.Items.Add("{");
         listBox1.Items.Add("int sonuc;");
         listBox1.Items.Add("sonuc=uzunkenar*Kısakenar;");
        listBox1.Items.Add("return sonuc;");
       listBox1.Items.Add(" }");
            listBox1.Items.Add("private void button1_Click(object sender, EventArgs e)");
            listBox1.Items.Add(" {");
            listBox1.Items.Add("int Kısakenar,uzunkenar,islem;");
           listBox1.Items.Add(" Kısakenar=int.Parse(textBox1.Text);");
           listBox1.Items.Add(" uzunkenar=int.Parse(textBox2.Text);");
           listBox1.Items.Add(" islem=alan(Kısakenar,uzunkenar);");
           listBox1.Items.Add(" textBox3.Text=(islem.ToString());");
            listBox1.Items.Add(" }");
            listBox1.Items.Add("");
            listBox1.Items.Add("Program kısa ve uzun kenar değerleri kullanıcı tarafından girilen ");
            listBox1.Items.Add("bir dikdörtgenin alanını hesaplamaktadır.Tanımlanan alan adlı metoda ");
            listBox1.Items.Add("kısa ve uzun kenar değerleri gönderilmekte, metot içerisinde gerekli ");
            listBox1.Items.Add("hesaplamalar yapılıp sonuç değeri return ifadesiyle geri döndürülmektedir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Aşağıda görüldüğü gibi alan adlı metot,farklı şekillerde çağrılırsa ");
            listBox1.Items.Add("farklı hatalarla karşılaşabilir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("alan; //derleme zamanı hatası, parantez yok");
            listBox1.Items.Add("");
            listBox1.Items.Add("alan(); //derleme zamanı hatası, yetersiz bağımsız değişken");
            listBox1.Items.Add("");
            listBox1.Items.Add("alan(kisa_kenar); //derleme zamanı hatası, yetersiz bağımsız değişken");
            listBox1.Items.Add("");
            listBox1.Items.Add("alan(“kisa_kenar”,”uzun_kenar”); //derleme zamanı hatası, yanlış türler");
            listBox1.Items.Add("");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kk, uk, islem;
            kk = int.Parse(textBox1.Text);
            uk = int.Parse(textBox2.Text);
            islem = alan(kk, uk);
            textBox3.Text = (islem.ToString());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
