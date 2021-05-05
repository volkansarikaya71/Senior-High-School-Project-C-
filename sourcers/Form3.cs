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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("BİLGİ !!!");
            listBox1.Items.Add("-----------------------------------------------------------------------------");
            listBox1.Items.Add("Sifre girmek zorunda kaldıgınız icin özür dilerim.");
            listBox1.Items.Add("Program calınmasın diye sifrelemek zorunda kaldım.");
            listBox1.Items.Add("-----------------------------------------------------------------------------");
            listBox1.Items.Add("UYARI !!!");
            listBox1.Items.Add("-----------------------------------------------------------------------------");
            listBox1.Items.Add("Sifre Kısmına en fazla 11 karekter girire bilir.");
            listBox1.Items.Add("Sifreyi 1 kere yanlıs girince program kapanacaktır.");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i = 0;
            while (i < 1)
            {
                String Sifre;
                Sifre = (textBox2.Text);
                if (Sifre == "GALATASARAY")
                {
                    MessageBox.Show("MERHABA");
                    Form2 form2 = new Form2();
                    form2.Show();
                    Hide();
                    i = 1;

                }
                else
                {
                    textBox2.Clear();

                    Sifre = (textBox2.Text);
                    MessageBox.Show("SİFRE YANLIS");
                    i++;
                    if (i >= 1)
                    {
                        this.Close();
                        Application.Exit();
                    }
                }
            }

        }

    }
}
