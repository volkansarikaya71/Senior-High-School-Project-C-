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
    public partial class İSLEM_ÖNCELİĞİ : Form
    {
        public İSLEM_ÖNCELİĞİ()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OPARATÖRLER SS = new OPARATÖRLER();
            SS.Show();
            this.Close();
        }

        private void İSLEM_ÖNCELİĞİ_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("6+5*2");
            listBox1.Items.Add("6+5=11 11*2=22 Bu islem yanlıstır. X");
            listBox1.Items.Add("İlk carpma islemi yapılır ondan sonra toplama.");
            listBox1.Items.Add("5*2=10 10+6=16 islemin sonucu 16 dır ");
            listBox1.Items.Add("");
            listBox1.Items.Add("En Yüksek");
            listBox1.Items.Add("()");
            listBox1.Items.Add("!");
            listBox1.Items.Add("*, /, %");
            listBox1.Items.Add("+,-");
            listBox1.Items.Add("<, >");
            listBox1.Items.Add("= =, !=");
            listBox1.Items.Add("&&");
            listBox1.Items.Add("||");
            listBox1.Items.Add("En Düşük");
            listBox1.Items.Add("");
            listBox1.Items.Add("İşlem öncelik sırası yukarıdaki tabloda en yüksekten en düşüğe doğru sıralanmıştır.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2,sayi3,sonuc;
            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);
            sayi3 = int.Parse(textBox3.Text);
            sonuc = sayi1 + sayi2 * sayi3;
            textBox4.Text = (sonuc.ToString());
        }
    }
}
//listBox1.Items.Add("");