using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wyświetl", "Okno dialogow", MessageBoxButtons.OKCancel) == DialogResult.OK)
                label1.Text = "OK";
            else
                label1.Text = "Cancel";
        }
    }
}
