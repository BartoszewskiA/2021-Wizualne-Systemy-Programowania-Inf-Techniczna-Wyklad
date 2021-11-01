using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Activation\n";
            richTextBox1.ForeColor = Color.Black;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Deactivation\n";
            richTextBox1.ForeColor = Color.LightGray;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Napewno???", "Komunikat", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Shown\n";
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "ResizeEnd\n";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Text = this.Width.ToString() + " " + this.Height.ToString();
        }
    }
}
