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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Değişkenler Değişkenler = new Değişkenler();
            Değişkenler.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VERİ_TÜRLERİ VERİ_TÜRLERİ = new VERİ_TÜRLERİ();
            VERİ_TÜRLERİ.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OPARATÖRLER OPARATÖRLER = new OPARATÖRLER();
            OPARATÖRLER.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            METOTLAR METOTLAR = new METOTLAR();
            METOTLAR.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MANTIKSAL_OPERATORLER MANTIKSAL_OPERATORLER = new MANTIKSAL_OPERATORLER();
            MANTIKSAL_OPERATORLER.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ŞART_İFADELERİ ŞART_İFADELERİ = new ŞART_İFADELERİ();
            ŞART_İFADELERİ.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DÖNGÜ_YAPILARI DÖNGÜ_YAPILARI = new DÖNGÜ_YAPILARI();
            DÖNGÜ_YAPILARI.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HATA_AYIKLAMA HATA_AYIKLAMA = new HATA_AYIKLAMA();
            HATA_AYIKLAMA.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SINIFLAR SINIFLAR = new SINIFLAR();
            SINIFLAR.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DEĞER_VE_BASVURU_TÜRLERİ DEĞER_VE_BASVURU_TÜRLERİ = new DEĞER_VE_BASVURU_TÜRLERİ();
            DEĞER_VE_BASVURU_TÜRLERİ.Show();
            this.Close();
        }

    }
}
