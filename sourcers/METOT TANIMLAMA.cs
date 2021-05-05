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
    public partial class METOT_TANIMLAMA : Form
    {
        public METOT_TANIMLAMA()
        {
            InitializeComponent();
        }
        int alan(int kk,int uk)
        {
            int sonuc;
            sonuc=uk*kk;
            return sonuc;
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

        private void METOT_TANIMLAMA_Load(object sender, EventArgs e)
        {  
            listBox1.Items.Add("Metotlar,bir işlem yapmak üzere tasarlanmış kodlar topluluğudur.");
            listBox1.Items.Add("Program yazarken bellibir işlevi olan kod bloğunu birkaç kez kullanmak gerekebilir.");
            listBox1.Items.Add("Bu durumlarda aynı kodları program içerisinde sürekli yazmak yerine bu, bir metot olarak ");
            listBox1.Items.Add("hazırlanabilir ve ihtiyaç duyulduğunda kullanılabilir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Dönüş_türü,bir veri türü adıdır ve metodun yaptığı işlem sonucunda döndüreceği veri türünü ");
            listBox1.Items.Add("belirler.Herhangi bir sonuç döndürmeyen bir metot yazılıyorsa dönüş_türü yerine void anahtar ");
            listBox1.Items.Add("sözcüğü kullanılmalıdır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Metot_adı,metodu çağırmak için kullanılan addır.Metot adları belirlenirken değişken adları ");
            listBox1.Items.Add("tanımlanırken uygulanan kurallara uyulmalıdır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Parametre listesi:İsteğe bağlıdır,metoda dışarıdan gönderilecek veri adlarını vetürlerini ");
            listBox1.Items.Add("tanımlar.Parametreler önce tür adı,daha sonra parametre adı olacak şekilde parantez içerisinde");
            listBox1.Items.Add(" değişken tanımlanıyormuş gibi yazılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("ÖRNEK");
            listBox1.Items.Add("");
            listBox1.Items.Add("int alanhesaplama(int uzunkenar,int kısakenar)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("// kodla");
            listBox1.Items.Add("}");
            listBox1.Items.Add("");
            listBox1.Items.Add("Yukarıdaki metot tanımında alanhesaplama metodun adını, metot adının başındaki int ifadesi  ");
            listBox1.Items.Add("metodun döndüreceği veri türünü, parantez içerisinde tanımlanan değişkenler parametre listesini");
            listBox1.Items.Add(" göstermektedir.");
            listBox1.Items.Add("");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kk,uk,islem;
            kk=int.Parse(textBox1.Text);
            uk=int.Parse(textBox2.Text);
            islem=alan(kk,uk);
            textBox3.Text=(islem.ToString());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
