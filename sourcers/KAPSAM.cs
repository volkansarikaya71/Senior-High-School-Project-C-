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
    public partial class KAPSAM : Form
    {
        public KAPSAM()
        {
            InitializeComponent();
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

        private void KAPSAM_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Asagıdaki Konulardan Birini Seçin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Program içerisinde değişkenlerin nasıl tanımlandığı görüldü.");
            listBox1.Items.Add("Değişkenler tanımladıkları yerde oluşturulur ve daha sonra istenilen şekilde kullanılabilir.");
            listBox1.Items.Add(" Yani tanımlandıkları yer program gövdesi ya da herhangi bir metodun içerisi olabilir.");
            listBox1.Items.Add("Program yada metot sonlandığında ise değişken artık kullanılamaz.Bir değişken belirli bir yerde ");
            listBox1.Items.Add("kullanılabiliyorsa değişken o konumda kapsam (scope)içerisindedir.Farklı bir biçimde ifade etmek ");
            listBox1.Items.Add("gerekirse bir değişkenin kapsamı, değişkenin o program içerisinde kullanıldığı bölgedir.Bu kural ");
            listBox1.Items.Add("değişkenler için olduğu gibi tanımlanan metotlar içinde geçerlidir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Bir metodun gövdesini oluşturan,açılan ve kapatılan küme parantezleri, kapsamı tanımlar.");
            listBox1.Items.Add("Metodun gövdesi içinde tanımlanan bütün değişkenler,o metodun kapsamına eklenir");
            listBox1.Items.Add("Metot sona erdiğinde geçerliliklerini yitirir ve sadece tanımlandıkları metot üzerinden erişilebilir");
            listBox1.Items.Add("Bu tür değişkenler böyle oldugu için yerel(local) değişkenler olara adlandırılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("void bölme()");
            listBox1.Items.Add("{");
            listBox1.Items.Add("int a=Int16.Parse(textBox1.Text);");
            listBox1.Items.Add("int b=Int16.Parse(textBox2.Text);");
            listBox1.Items.Add("textBox3.Text=(a/b).ToString();");
            listBox1.Items.Add("}");
            listBox1.Items.Add("void carpma()");
            listBox1.Items.Add("a=Int16.Parse(textBox1.Text);   X");
            listBox1.Items.Add("b=Int16.Parse(textBox2.Text);   X");
            listBox1.Items.Add("textBox3.Text=(a/b).ToString(); X");
            listBox1.Items.Add("}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Bir sınıfın gövdesini oluşturmak için açılan ve kapatılan küme parantezleri de bir kapsam oluşturur.");
            listBox1.Items.Add("Sınıf gövdesi içinde tanımlanan değişkenler (metot içinde değil), o sınıfın kapsamındadır");
            listBox1.Items.Add("Sınıf içerisinde tanımlanmış değişkenler field(alan)olarak adlandırılır");
            listBox1.Items.Add("Yerel değişkenlerin aksine bu tür değişkenleri(alanları)");
            listBox1.Items.Add("metotlar arasında bilgi paylaşımı için kullanılabilir");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("public partial class Window1:Window");
            listBox1.Items.Add("{");
            listBox1.Items.Add("void bölme()");
            listBox1.Items.Add("{");
            listBox1.Items.Add(" a=Int16.Parse(textBox1.Text);");
            listBox1.Items.Add(" b=Int16.Parse(textBox2.Text);");
            listBox1.Items.Add("textBox3.Text=(a/b).ToString();");
            listBox1.Items.Add("}");
            listBox1.Items.Add("void carpma()");
            listBox1.Items.Add("a=Int16.Parse(textBox1.Text);   ");
            listBox1.Items.Add("b=Int16.Parse(textBox2.Text);   ");
            listBox1.Items.Add("textBox3.Text=(a/b).ToString(); ");
            listBox1.Items.Add("}");
            listBox1.Items.Add("int a;");
            listBox1.Items.Add("int b;");
            listBox1.Items.Add("");
            listBox1.Items.Add("public Window1()");
            listBox1.Items.Add("{");
            listBox1.Items.Add("InitializeComponent();");
            listBox1.Items.Add("}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("iki adet aynı isimde metod girilmesine aşırı yüklenmiş metot denir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("void CARPIM()");
            listBox1.Items.Add("{");
            listBox1.Items.Add("int sayı1, sayı2;");
            listBox1.Items.Add("int sonuc;");
            listBox1.Items.Add("sayı1 = int.Parse(textBox1.Text);");
            listBox1.Items.Add("sayı2 = int.Parse(textBox2.Text);");
            listBox1.Items.Add("sonuc = sayı1 * sayı2;");
            listBox1.Items.Add("textBox3.Text = (sonuc.ToString());");
            listBox1.Items.Add("}");
            listBox1.Items.Add("void CARPIM(int sayı1,int sayı2)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("int sonuc;");
            listBox1.Items.Add("sonuc = sayı1 * sayı2;");
            listBox1.Items.Add("textBox4.Text = (sonuc.ToString());");
            listBox1.Items.Add("}");
            listBox1.Items.Add("private void button1_Click(object sender, EventArgs e)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("int sayı1, sayı2;");
            listBox1.Items.Add("sayı1 = int.Parse(textBox1.Text);");
            listBox1.Items.Add("sayı2 = int.Parse(textBox2.Text);");
            listBox1.Items.Add("CARPIM(sayı1,sayı2);");
            listBox1.Items.Add("CARPIM();");
            listBox1.Items.Add("");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ÖRNEK ÖRNEK = new ÖRNEK();
            ÖRNEK.Show();
            this.Close();
        }
    }
}
