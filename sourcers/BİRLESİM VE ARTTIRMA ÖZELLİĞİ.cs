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
    public partial class BİRLESİM_VE_ARTTIRMA_ÖZELLİĞİ : Form
    {
        public BİRLESİM_VE_ARTTIRMA_ÖZELLİĞİ()
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

        private void BİRLESİM_VE_ARTTIRMA_ÖZELLİĞİ_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Programlama dilinde eşittir işareti( = ) birişleçtir.");
            listBox1.Items.Add(" Tüm işleçler, işlenenlerine bağlı olarak bir değer döndürür.");
            listBox1.Items.Add(" Atama işleci (= )’de farklı değildir.İki işlenen alır,sağ tarafındaki işlenen değerlendirilir ve daha sonra");
            listBox1.Items.Add(" sol taraftaki işlenende depolanır.");
            listBox1.Items.Add(" Atama işlecinin değeri, sol işlenene atanmış olan değerdir.");
            listBox1.Items.Add("Atama işleci bir değer döndürdüğünden, atama ifadesinin başka bir oluşumunda da aynı değer kullanılabilir:");
            listBox1.Items.Add("int sayi1;");
            listBox1.Items.Add("int sayi2;");
            listBox1.Items.Add("int sayi3;");
            listBox1.Items.Add("int sayi4;");
            listBox1.Items.Add("sayi1=sayi2=sayi3=sayi4=20;");
            listBox1.Items.Add("sayi1,sayi2,sayi3,sayi4 değerleri 20 olur.");

        
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, sayi4;
            sayi1 = int.Parse(textBox1.Text);
            sayi4= sayi2 = sayi3 = sayi1;
            textBox2.Text = (sayi2.ToString());
            textBox3.Text = (sayi3.ToString());
            textBox4.Text = (sayi4.ToString());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
