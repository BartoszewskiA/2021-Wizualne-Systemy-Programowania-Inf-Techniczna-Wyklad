using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w04p01
{
    public partial class Form1 : Form
    {
        private PrzeliczikWalut przeliczikWalut;
        public Form1()
        {
            InitializeComponent();
            przeliczikWalut = new PrzeliczikWalut();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
            dopasujInterface();
            przelicz();
        }

        private void dopasujInterface()
        {
            if (radioButton1.Checked)
                label3.Text = "PLN";
            else if (radioButton2.Checked)
                label3.Text = "EURO";
            else
                label3.Text = "USD";

            if (radioButton4.Checked)
                label4.Text = "PLN";
            else if (radioButton5.Checked)
                label4.Text = "EURO";
            else
                label4.Text = "USD";
        }

        private void przelicz()
        {
            if (radioButton1.Checked)
                przeliczikWalut.setPLN(hScrollBar1.Value);
            else if (radioButton2.Checked)
                przeliczikWalut.setEURO(hScrollBar1.Value);
            else
                przeliczikWalut.setUSD(hScrollBar1.Value);
            double wynik = 0;
            if (radioButton4.Checked)
                wynik = przeliczikWalut.getPLN();
            else if (radioButton5.Checked)
                wynik = przeliczikWalut.getEURO();
            else
                wynik = przeliczikWalut.getUSD();
            textBox2.Text = Math.Round(wynik,2).ToString();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            dopasujInterface();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            dopasujInterface();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            dopasujInterface();
            przelicz();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            dopasujInterface();
            przelicz();
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            dopasujInterface();
            przelicz();
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            dopasujInterface();
            przelicz();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void autorzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informatyka Techniczna 3 semestr", "Info", MessageBoxButtons.OK);
        }
    }
}
