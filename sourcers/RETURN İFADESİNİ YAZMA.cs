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
    public partial class RETURN_İFADESİNİ_YAZMA : Form
    {
        public RETURN_İFADESİNİ_YAZMA()
        {
            InitializeComponent();
        }
        int ikisayınıntoplamı(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
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

        private void RETURN_İFADESİNİ_YAZMA_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tanımlanan metodun bir değer döndürmesi isteniyorsa");
            listBox1.Items.Add("metot içinde bir return ifadesi yazılmalıdır.");
            listBox1.Items.Add("Hesaplanan ifadenin türü, metot tarafından belirtilen ");
            listBox1.Items.Add("dönüştürü ile aynı olmak zorundadır.Yani metot,int türünde ");
            listBox1.Items.Add("bir değer döndürüyorsa return ifadeside int türü döndürmelidir.");
            listBox1.Items.Add("Aksi takdirde program derlenmez.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("int ikisayınıntoplamı(int sayi1,int sayi2)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("return sayi1 + sayi2 ;");
            listBox1.Items.Add("}");
            listBox1.Items.Add("");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1,sayi2,sonuc;
            sayi1=int.Parse(textBox1.Text);
            sayi2=int.Parse(textBox2.Text);
            sonuc = ikisayınıntoplamı(sayi1, sayi2);
               textBox3.Text=(sonuc.ToString());
        }
    }
}
