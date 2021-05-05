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
    public partial class ÖRNEKLER_3 : Form
    {
        public ÖRNEKLER_3()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DEĞER_VE_BASVURU_TÜRLERİ DEĞER_VE_BASVURU_TÜRLERİ = new DEĞER_VE_BASVURU_TÜRLERİ();
            DEĞER_VE_BASVURU_TÜRLERİ.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1;
            s1 = int.Parse(textBox1.Text);
            textBox2.Text = (s1.ToString());
            label2.Text = ("SONUC");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = ("Null");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1;
            s1 = int.Parse(textBox1.Text);
            s1++;
            textBox2.Text = ("ref" +  s1.ToString());
            label2.Text = ("out" +  s1.ToString());
        }
    }
}
