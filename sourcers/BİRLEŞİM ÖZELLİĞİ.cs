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
    public partial class BİRLEŞİM_ÖZELLİĞİ : Form
    {
        public BİRLEŞİM_ÖZELLİĞİ()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OPARATÖRLER SS = new OPARATÖRLER();
            SS.Show();
            this.Close();
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

        private void BİRLEŞİM_ÖZELLİĞİ_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Programlamada çarpma işlemi, bölme işlemi ve mod hesaplama(%)işlemleri kendi aralarında");
            listBox1.Items.Add("eşit önceliklere sahip olmakla birlikte toplama ve çıkarma işlemlerine göre önceliklidir.");
            listBox1.Items.Add("Toplama ve çıkarma işlemleri de kendi aralarında eşit önceliklere sahiptir");
            listBox1.Items.Add("Parantezler ise çarpma, bölme, toplama ve çıkarma işlemlerine göre önceliklidir.");
            listBox1.Items.Add("Ozaman daha önce yapılmasi istenen işlemler parantez içerisine alınmalıdır.");
            listBox1.Items.Add("7 * 2 + 5–3 * 2 / 6 = ?");
                listBox1.Items.Add("7*2=14 + 5 - 3*2=6 6/6=1");
                listBox1.Items.Add("14+5-1");
                listBox1.Items.Add("Cevap=18");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sonuc;
            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);
            sayi3 = int.Parse(textBox3.Text);
            sayi4 = int.Parse(textBox4.Text);
            sayi5 = int.Parse(textBox6.Text);
            sayi6 = int.Parse(textBox7.Text);
            sonuc = sayi1 * sayi2 + sayi3 - sayi4 * sayi5 / sayi6;
            textBox5.Text=(sonuc.ToString());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
