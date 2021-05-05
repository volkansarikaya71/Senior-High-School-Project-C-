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
    public partial class Değişkenler : Form
    {
        public Değişkenler()
        {
            InitializeComponent();
        }

        private void Değişkenler_Load(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("Değişken adlarında (büyük ve küçük), rakam ve alt çizgi( _ )karakteri kullanılabilir, boşluk içermez.");
            listBox1.Items.Add("Türkçe karakterler kullanılabilir ama önerilmez (ç,ğ,ş,ö,ü,ı,i vb.).");
            listBox1.Items.Add("Değişken adı, bir harf ile (Altçizgi harf olarak kabul edilir.) başlamak zorundadır, rakamlarla başlayamaz.");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("Örnek");
            listBox1.Items.Add("1. int sayı; ");
            listBox1.Items.Add("1. string soy_ad ;");
            listBox1.Items.Add("");
            listBox1.Items.Add("2. ınt sayı ;           X");
            listBox1.Items.Add("2. string soy ad ;          X");
            listBox1.Items.Add("");
            listBox1.Items.Add("1.ci örnekler dogru 2.ci örnekler yanlıstır");
        }

        private void button1_Click(object sender, EventArgs e)
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
