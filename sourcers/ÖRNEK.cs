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
    public partial class ÖRNEK : Form
    {
        public ÖRNEK()
        {
            InitializeComponent();
        }
        void CARPIM()
        {
            int sayı1, sayı2;
            int sonuc;
            sayı1 = int.Parse(textBox1.Text);
            sayı2 = int.Parse(textBox2.Text);
            sonuc = sayı1 * sayı2;
            textBox3.Text = (sonuc.ToString());
        }
        void BÖLÜM(int sayı1,int sayı2)
        {
            
            int sonuc;
            sonuc = sayı1 / sayı2;
            textBox4.Text = (sonuc.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
    int sayı1, sayı2;
    sayı1 = int.Parse(textBox1.Text);
    sayı2 = int.Parse(textBox2.Text);
    BÖLÜM(sayı1,sayı2);
    CARPIM();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KAPSAM KAPSAM = new KAPSAM();
            KAPSAM.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }
    }
}
