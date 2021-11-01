using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
            progressBar1.Value = hScrollBar1.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
/*            if (checkBox1.Checked)
                label1.Text = "Kliknięto opcję wyboru";
            else
                label1.Text = "odkliknieto opcję wyboru";*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                label1.Text = "Kliknięto opcję wyboru";
            else
                label1.Text = "odkliknieto opcję wyboru";
        }
    }
}
