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
    public partial class VERİ_TÜRLERİ : Form
    {
        public VERİ_TÜRLERİ()
        {
            InitializeComponent();
        }

        private void VERİ_TÜRLERİ_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            listBox1.Items.Clear();
            listBox1.Items.Add("Bir Konu Seciniz.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            
            listBox1.Items.Clear();
            listBox1.Items.Add("İnt sayısal verileri girmek icin kullanılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("int sayı=5;");
            listBox1.Items.Add("textBox1.Text=sayı.ToString();");
            int sayı = 5;
            textBox1.Text = sayı.ToString();
            listBox1.Items.Add("Program calısır.");
            listBox1.Items.Add("İnt dışında hicbir veri girilemez girilirse program calısmaz ");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("int metin=ahmet; X");
            listBox1.Items.Add("textBox1.Text=metin.ToString();  X");
            listBox1.Items.Add("Program Calısmaz.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            listBox1.Items.Clear();
            listBox1.Items.Add("String metinsel verileri girmek icin kullanılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("String ad=Metin ;");
            listBox1.Items.Add("textBox1.Text=ad.ToString();");
            String ad = "metin";
            textBox1.Text = ad.ToString();
            listBox1.Items.Add("Program calısır.");
            listBox1.Items.Add("String dışında hicbir veri girilemez girilirse program calısmaz ");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("String sayı=5; X");
            listBox1.Items.Add("textBox1.Text=metin.ToString();  X");
            listBox1.Items.Add("Program Calısmaz.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            listBox1.Items.Clear();
            listBox1.Items.Add("Double ondalıklı sayıları girmek icin kullanılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("Double sayı=3.14;");
            listBox1.Items.Add("textBox1.Text=sayı.ToString();");
            Double sayı = 3.14;
            textBox1.Text = sayı.ToString();
            listBox1.Items.Add("Program calısır.");
            listBox1.Items.Add("Double dışında hicbir veri girilemez girilirse program calısmaz ");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("Double metin=ahmet; X");
            listBox1.Items.Add("textBox1.Text=metin.ToString();  X");
            listBox1.Items.Add("Program Calısmaz.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            listBox1.Items.Clear();
            listBox1.Items.Add("Char tek bir harf girmek icin kullanılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("Char harf='a';");
            listBox1.Items.Add("textBox1.Text=harf.ToString();");
            Char harf = 'a';
            textBox1.Text = harf.ToString();
            listBox1.Items.Add("Program calısır.");
            listBox1.Items.Add("Char dışında hicbir veri girilemez girilirse program calısmaz ");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("");
            listBox1.Items.Add("char sayı=5; X");
            listBox1.Items.Add("textBox1.Text=sayı.ToString();  X");
            listBox1.Items.Add("Program Calısmaz.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
