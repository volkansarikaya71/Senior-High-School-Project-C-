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
    public partial class METOTLAR : Form
    {
        public METOTLAR()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 SS = new Form2();
            SS.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            METOT_TANIMLAMA METOT_TANIMLAMA = new METOT_TANIMLAMA();
            METOT_TANIMLAMA.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RETURN_İFADESİNİ_YAZMA RETURN_İFADESİNİ_YAZMA = new RETURN_İFADESİNİ_YAZMA();
            RETURN_İFADESİNİ_YAZMA.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            METOT_CAGIRMA METOT_CAGIRMA = new METOT_CAGIRMA();
            METOT_CAGIRMA.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KAPSAM KAPSAM = new KAPSAM();
            KAPSAM.Show();
            this.Close();
        }
    }
}
