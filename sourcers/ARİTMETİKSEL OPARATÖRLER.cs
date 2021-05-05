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
    public partial class ARİTMETİKSEL_OPARATÖRLER : Form
    {
        public ARİTMETİKSEL_OPARATÖRLER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = int.Parse(textBox2.Text);
            sayi2 = int.Parse(textBox1.Text);
            sonuc = sayi1 + sayi2;
            textBox3.Text=(sonuc.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = int.Parse(textBox2.Text);
            sayi2 = int.Parse(textBox1.Text);
            sonuc = sayi1 - sayi2;
            textBox3.Text = (sonuc.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = int.Parse(textBox2.Text);
            sayi2 = int.Parse(textBox1.Text);
            sonuc = sayi1 * sayi2;
            textBox3.Text = (sonuc.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = int.Parse(textBox2.Text);
            sayi2 = int.Parse(textBox1.Text);
            sonuc = sayi1 / sayi2;
            textBox3.Text = (sonuc.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OPARATÖRLER OPARATÖRLER = new OPARATÖRLER();
            OPARATÖRLER.Show();
            this.Close();
        }

        private void ARİTMETİKSEL_OPARATÖRLER_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Programlama dilinde bilinen dört işlemin aritmetik işleçlerini destekler:");
            listBox1.Items.Add("Toplama(+)");
            listBox1.Items.Add("Cıkarma(-)");
            listBox1.Items.Add("Çarpma(*)");
            listBox1.Items.Add("Bölme(/)");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
