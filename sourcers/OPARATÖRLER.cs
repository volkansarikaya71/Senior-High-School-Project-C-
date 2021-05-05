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
    public partial class OPARATÖRLER : Form
    {
        public OPARATÖRLER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ARİTMETİKSEL_OPARATÖRLER ARİTMETİKSEL_OPARATÖRLER = new ARİTMETİKSEL_OPARATÖRLER();
            ARİTMETİKSEL_OPARATÖRLER.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            İSLECLER_VE_TÜRLERİ İSLECLER_VE_TÜRLERİ = new İSLECLER_VE_TÜRLERİ();
            İSLECLER_VE_TÜRLERİ.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            İSLEM_ÖNCELİĞİ İSLEM_ÖNCELİĞİ = new İSLEM_ÖNCELİĞİ();
            İSLEM_ÖNCELİĞİ.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BİRLEŞİM_ÖZELLİĞİ BİRLEŞİM_ÖZELLİĞİ = new BİRLEŞİM_ÖZELLİĞİ();
            BİRLEŞİM_ÖZELLİĞİ.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BİRLESİM_VE_ARTTIRMA_ÖZELLİĞİ BİRLESİM_VE_ARTTIRMA_ÖZELLİĞİ = new BİRLESİM_VE_ARTTIRMA_ÖZELLİĞİ();
            BİRLESİM_VE_ARTTIRMA_ÖZELLİĞİ.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ARTTIRMA_VE_AZALTMA_OPARATÖRÜ ARTTIRMA_VE_AZALTMA_OPARATÖRÜ = new ARTTIRMA_VE_AZALTMA_OPARATÖRÜ();
           ARTTIRMA_VE_AZALTMA_OPARATÖRÜ.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VAR_DEĞİŞKEN_TÜRÜ VAR_DEĞİŞKEN_TÜRÜ = new VAR_DEĞİŞKEN_TÜRÜ();
            VAR_DEĞİŞKEN_TÜRÜ.Show();
            this.Close();
        }
    }
}
