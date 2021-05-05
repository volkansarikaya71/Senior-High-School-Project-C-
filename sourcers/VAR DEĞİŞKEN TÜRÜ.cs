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
    public partial class VAR_DEĞİŞKEN_TÜRÜ : Form
    {
        public VAR_DEĞİŞKEN_TÜRÜ()
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

        private void VAR_DEĞİŞKEN_TÜRÜ_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Program dilinde değişken tanımlanırken değişkenin adını  ve veri türünün belirtirmesi gerekirdiği görmüstür.");
            listBox1.Items.Add("int sayı;");
            listBox1.Items.Add("Baslangıs degeri bile atayabiliriz.");
            listBox1.Items.Add("int sayı=10;");
            listBox1.Items.Add("hatta bir islemde yaptıra biliriz.");
            listBox1.Items.Add("int sayı=fark*10; ");
            listBox1.Items.Add("Bir değişkene atanan değerin, değişken ile aynı veri türünde olması gerektiği bilgisi hatırlanmalıdır.");
            listBox1.Items.Add("var fiyat = 100;");
            listBox1.Items.Add("var soyad= “Volkan”;");
            listBox1.Items.Add("fiyat ve soyad değişkenleri,kapalı türde değişkenler olarak adlandırılır.");
            listBox1.Items.Add("“var”anahtar sözcüğü, derleyicinin değişkenlerin türünü, değişkene başlangıç değeri atamak için kullanılan ifadeden ");
            listBox1.Items.Add("çıkarmasını sağlar. Bu tarz bir kullanımda, değişkene mutlaka başlangıç değeri atanması gerekir.");
            listBox1.Items.Add("var fiyat;  X");
            listBox1.Items.Add("Yukardaki gibi kullanılırsa hata verir.");
            listBox1.Items.Add("fiyat değişkeni int türünde bir değişkendir ve float, doubleya da string değerler atanamaz");
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sayi1 = 100;
                var ad="Volkan";
                textBox1.Text=(sayi1.ToString());
                textBox3.Text = (ad.ToString());
              
                
        }
    }
}
