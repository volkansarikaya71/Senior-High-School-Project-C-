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
    public partial class İSLECLER_VE_TÜRLERİ : Form
    {
        public İSLECLER_VE_TÜRLERİ()
        {
            InitializeComponent();
        }

        private void İSLECLER_VE_TÜRLERİ_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Tüm işleçler tüm veri türlerine uygulanamaz. ");
            listBox1.Items.Add("Bir değer üzerinde kullanılabilecek işleçler, değerin türüne bağlıdır.");
            listBox1.Items.Add("Örneğin,char, int, long, float, double, yada decimal veri türlerinde tüm aritmetik işleçleri kullanılabilir.");
            listBox1.Items.Add("string türü çıkarma işlecini desteklemediğinden aşağıdaki ifadeler derlenemez");
            listBox1.Items.Add("MessageBox.Show(“İstanbul”-“Ankara” X);");
            listBox1.Items.Add("String türünde + oparatörünü kullanca sayıları toplamaz yan yana yazar.");
            listBox1.Items.Add("Örneğin MessageBox.Show(“80”+“70”); (150)yazmaz.(8070)yazar.");
            listBox1.Items.Add("---------------------------------------------------------------------------------------");
            listBox1.Items.Add("Yüzde işareti ile gösterilen kalan ya da mod işleci.");
            listBox1.Items.Add(" x % y ifadesinin sonucu x’in y’ye bölünmesi sonucunda kalan değerdir. ");
            listBox1.Items.Add("Örneğin,9’un 2’ye bölünmesi sonucubölüm4, kalanda 1 olduğundan, 9%2 sonucu 1’dir.");
       
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

        private void button1_Click(object sender, EventArgs e)
        {
            String sayi1, sayi2, Sonuc;
            sayi1 = (textBox2.Text);
            sayi2 = (textBox3.Text);
            Sonuc = sayi1 + sayi2;
            textBox1.Text=(Sonuc.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, Sonuc;
            sayi1 = int.Parse(textBox2.Text);
            sayi2 = int.Parse(textBox3.Text);
            Sonuc = sayi1 % sayi2;
            textBox1.Text = (Sonuc.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Sayısal türleri metne dönüştürmek için kullanılır.");
            listBox1.Items.Add("int i = 123;");
            listBox1.Items.Add("string a = i.ToString();");
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
