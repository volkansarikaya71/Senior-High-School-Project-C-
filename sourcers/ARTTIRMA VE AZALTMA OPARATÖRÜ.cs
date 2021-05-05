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
    public partial class ARTTIRMA_VE_AZALTMA_OPARATÖRÜ : Form
    {
        public ARTTIRMA_VE_AZALTMA_OPARATÖRÜ()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OPARATÖRLER OPARATÖRLER = new OPARATÖRLER();
            OPARATÖRLER.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void ARTTIRMA_VE_AZALTMA_OPARATÖRÜ_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bir değişkene 1 eklemek istenirse + isleci kullanılabilir.");
            listBox1.Items.Add("sayac=sayac+1;");
            listBox1.Items.Add("Bir değişkeni 1 arttırmak icin ++ isleci kullanıbilir.");
            listBox1.Items.Add("sayac++;");
            listBox1.Items.Add("Bir değişkene 1 eksiltmek istenirse - isleci kullanılabilir.");
            listBox1.Items.Add("sayac=sayac-1;");
            listBox1.Items.Add("Bir değişkeni 1 azaltmak icin -- isleci kullanıbilir.");
            listBox1.Items.Add("sayac--;");
            listBox1.Items.Add("Bu işleçler, değişkenden önce ve sonra kullanılabilir");
            listBox1.Items.Add("sayac++; //sonek artırma");
            listBox1.Items.Add("++sayac; //önek artırma");
            listBox1.Items.Add("sayac--; //sonek azaltma");
            listBox1.Items.Add("--sayac; //önek azaltma");
            listBox1.Items.Add("İşleçlerin değişkenden önce ve sonra kullanılması sonucu değiştirmez.");
            listBox1.Items.Add("Her durumda değişkenin değeri 1 artırılır ya da 1 azaltılır ama işlem öncelik sırasından kaynaklanan farklılıklar doğabilir.");
            listBox1.Items.Add("int a;");
            listBox1.Items.Add("a = 20;");
            listBox1.Items.Add("MessageBox.Show(a++);//a nın son degeri 21 olmasına karsı ekrana 20 yazar");
            listBox1.Items.Add("a = 20;");
            listBox1.Items.Add("MessageBox.Show(++a);//a nın son degeri 21 dir ve ekrana 21 yazar");
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = int.Parse(textBox1.Text);
            sayi1++;
            textBox2.Text=(sayi1.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = int.Parse(textBox1.Text);
            ++sayi1;
            textBox2.Text = (sayi1.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = int.Parse(textBox1.Text);
            sayi1--;
            textBox2.Text = (sayi1.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = int.Parse(textBox1.Text);
            --sayi1;
            textBox2.Text = (sayi1.ToString());
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
