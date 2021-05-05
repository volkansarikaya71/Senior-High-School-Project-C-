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
    public partial class ÖRNEKLER_2 : Form
    {
        public ÖRNEKLER_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc;
            s1 = int.Parse(textBox1.Text);
            s2 = int.Parse(textBox2.Text);
            sonuc = ((s1 + 2) * s2);
            textBox3.Text = (sonuc.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s3, s4;
            s3 = int.Parse(textBox1.Text);
            s4 = int.Parse(textBox2.Text);
            s3 = s3 * s4;
            textBox3.Text = (s3.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = int.Parse(textBox1.Text);
            s2 = int.Parse(textBox2.Text);
            s1 = s1 / s2;
            textBox3.Text = (s1.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = ("Pı");
            textBox3.Text = (3.14159.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = ("ad girin");
            label3.Text = ("yas girin");
            textBox1.Text = ("volkan");
            textBox2.Text = ("17");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void ÖRNEKLER_2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SINIFLAR SINIFLAR = new SINIFLAR();
            SINIFLAR.Show();
            this.Close();
        }
    }
}
