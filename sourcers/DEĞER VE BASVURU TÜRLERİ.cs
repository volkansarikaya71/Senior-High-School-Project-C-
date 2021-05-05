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
    public partial class DEĞER_VE_BASVURU_TÜRLERİ : Form
    {
        public DEĞER_VE_BASVURU_TÜRLERİ()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void DEĞER_VE_BASVURU_TÜRLERİ_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        listBox1.Items.Add("Veri türü değişkenler,tanımlandığında derleyici tarafından yeterli bellek alanı ayrılan ve "); 
        listBox1.Items.Add("değişkenin saklayacağı değerin bu bellek alanında tutulduğu değişkenlerdir. Örneğin,byte türünde");
        listBox1.Items.Add("bir değişken tanımlanırsa derleyici bu değişkenin değerini saklamak için bize 1 bayt(8bit) bellek");
        listBox1.Items.Add(" alanı ayırır.Tanımlanan bu değişkene bir değer (örneğin,135) atandığın da, bu değer ayrılan 1");
        listBox1.Items.Add(" baytlık bellek alanına yazılır.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("VERİ TÜRÜ DEĞİŞKENLERİ SINIFLARI KOPYALAMA");
            listBox1.Items.Add("");
            listBox1.Items.Add("int a=15// a değişkeni 15");
            listBox1.Items.Add("int b=a // b değişkeni a ya eşitlenmis");
            listBox1.Items.Add("a++;// a değişkeni 1 artmıs b değişkeni artmaz");
            listBox1.Items.Add("");
            listBox1.Items.Add("sayı c=new sayı(12);// c değişkenini 12 esitlemis");
            listBox1.Items.Add("sayı d=c// d yi de 12 esitlemistir.");
            listBox1.Items.Add("");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("NULL DEĞERLERİ");
            listBox1.Items.Add("");
            listBox1.Items.Add("sayı c=new sayı();//değer girilmemis.   X");
            listBox1.Items.Add("sayı d=null// d değeri bostur yani değer yoktur.    X");
            listBox1.Items.Add("if (c==null)//derleme hatası verir. X");
            listBox1.Items.Add("{   X");
            listBox1.Items.Add("d=c;    X");
            listBox1.Items.Add("}  X");
            listBox1.Items.Add("");
            listBox1.Items.Add("int? b= null;");
            listBox1.Items.Add("if (!b.HasValue)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("b=15;");
            listBox1.Items.Add("}");
            listBox1.Items.Add("else");
            listBox1.Items.Add("{");
            listBox1.Items.Add("MessageBox.Show(b.Value);");
            listBox1.Items.Add("}");
            listBox1.Items.Add("");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("BASVURU PARAMETLERİ");
            listBox1.Items.Add("");
            listBox1.Items.Add("Daha önce yöntemlere parametre olarak bir değişken aktarıldığında parametrenin değişkenin ");
            listBox1.Items.Add("kopyasının oluşturulduğu biliniyor.Bu durum parametre değer türü (int gibi),boşolabilen ");
            listBox1.Items.Add("tür (int? gibi) ya da başvuru türü (Bisikletgibi) bile böyledir.Bu da yöntemiçerisinde ");
            listBox1.Items.Add("parametrenin değerinin değiştirilmesinin aktarılan değişkenin değerinietkilemeyeceği anlamına gelir.");
            listBox1.Items.Add("");
            listBox1.Items.Add("static void DegerArtir(int deger)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("deger++;");
            listBox1.Items.Add("}");
            listBox1.Items.Add("static void Main()");
            listBox1.Items.Add("{");
            listBox1.Items.Add("int a = 10;");
            listBox1.Items.Add("DegerArtir(a);");
            listBox1.Items.Add("MessageBox.Show(a);//10 yazar.");
            listBox1.Items.Add("}");
            listBox1.Items.Add("");
            listBox1.Items.Add("REF PAREMETLESİ");
            listBox1.Items.Add("");
            listBox1.Items.Add("bir parametrenin adının önüne ref yazılırsa değişkenin değeri değil,değişkenin yığındaki adresi");
            listBox1.Items.Add(" parametre olarak gönderilmiş olunur. ");
            listBox1.Items.Add("");
            listBox1.Items.Add("static void DegerArtir(ref int deger)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("deger++;");
            listBox1.Items.Add("}");
            listBox1.Items.Add("static void Main()");
            listBox1.Items.Add("{");
            listBox1.Items.Add("int a = 10;");
            listBox1.Items.Add("DegerArtir(ref a);");
            listBox1.Items.Add("MessageBox.Show(a);//11 yazar.");
            listBox1.Items.Add("");
            listBox1.Items.Add("OUT PAREMETLESİ");
            listBox1.Items.Add("");
            listBox1.Items.Add("out anahtar sözcüğünün değişkenlerin ilk değer verilmeden de parametre olarak aktarılmasını mümkün kılmasıdır. ");
            listBox1.Items.Add("");
            listBox1.Items.Add("static void DegerArtir(out int deger)");
            listBox1.Items.Add("{");
            listBox1.Items.Add("deger=10;");
            listBox1.Items.Add("deger++;");
            listBox1.Items.Add("}");
            listBox1.Items.Add("static void Main()");
            listBox1.Items.Add("{");
            listBox1.Items.Add("int a;");
            listBox1.Items.Add("DegerArtir(out a);");
            listBox1.Items.Add("MessageBox.Show(a);//11 yazar.");
            listBox1.Items.Add("");








        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" YIĞIN (STACK) VE ÖBEK (HEAP)");
            listBox1.Items.Add("");
            listBox1.Items.Add("İşletim sistemleri ve çalışma zamanları sık sık veriyi tutmak için kullanılan belleği herbiri ");
            listBox1.Items.Add("ayrı olarak yönetilen iki büyük parçaya ayırır. Belleğin iki büyük parçasına yığın (stack)ve");
            listBox1.Items.Add(" öbek(heap)adı verilir.Yığın ve öbek çok farklı amaçlara hizmet eder:");
            listBox1.Items.Add("");
            listBox1.Items.Add("new anahtar sözcüğünü kullanarak bir nesne (sınıförneği) yaratıldığında,nesneyi oluşturmak  ");
            listBox1.Items.Add("için gerekli bellek her zaman öbek üzerinde oluşturulur.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Tüm değer türleri yığın üzerinde yaratılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("Boş olabilen türler aslında başvuru türleridir ve öbek üzerinde yaratılır.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("KUTULAMA");
            listBox1.Items.Add("");
            listBox1.Items.Add("Object türündeki değişkenler bir değer türüne de başvurulabilir. Örneğin,aşağıdaki iki ifade,");
            listBox1.Items.Add("a değişkenine 15 başlangıç değerini atar ve daha sonra o değişkenine başlangıç değeri olarak a atar:");
            listBox1.Items.Add("int a = 15;");
            listBox1.Items.Add("object o = a;");
            listBox1.Items.Add("");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("KUTULAMA KALDIRMA");
            listBox1.Items.Add("");
            listBox1.Items.Add("Program içerisinde bazen kutulanmış değerlerin değer türünde değişkenlere aktarılması gerekir. Bu ");
            listBox1.Items.Add("durumda kutulamayı kaldırmak zorunlu olur. Örneğin, az önceki örnekte int değer türündeki a ");
            listBox1.Items.Add("değişkenine, içerisinde 15 tam sayı değerine başvuruyu barındıran object başvuru türündeki ");
            listBox1.Items.Add("o değişkeni atamaya çalışılırsa derleme hatasıyla karşılaşılır.");
            listBox1.Items.Add("");
            listBox1.Items.Add("sayi b = new sayi();");
            listBox1.Items.Add("int a = 10;");
            listBox1.Items.Add("object o;");
            listBox1.Items.Add("o = b;");
            listBox1.Items.Add("a = o;");
            listBox1.Items.Add("");
            listBox1.Items.Add("int i = 15;");
            listBox1.Items.Add("object o = i;// kutulama");
            listBox1.Items.Add("i = (int)o;//kutulamayı kaldırma");
            listBox1.Items.Add("");
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ÖRNEKLER_3 ÖRNEKLER_3 = new ÖRNEKLER_3();
            ÖRNEKLER_3.Show();
            this.Close();
        }
    }
}
