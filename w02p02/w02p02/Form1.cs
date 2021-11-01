using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            oblicz();
        }

        private void oblicz()
        {
            int a = 0, b = 0, c = 0;
            /*  a = int.Parse(textBox1.Text);
              b = int.Parse(textBox2.Text);
              c = int.Parse(textBox3.Text);*/

            int x = 0;

            if (int.TryParse(textBox1.Text, out x))
                a = x;
            else
            {
                a = 0;
                textBox1.Text = "0";
            }
            if (int.TryParse(textBox2.Text, out x))
                b = x;
            else
            {
                b = 0;
                textBox2.Text = "0";
            }
            if (int.TryParse(textBox3.Text, out x))
                c = x;
            else
            {
                c = 0;
                textBox3.Text = "0";
            }

            int delta = b * b - 4 * a * c;
            label4.Text = "Delta =" + delta.ToString() + "\n";


            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                string s = label4.Text;
                s += "x1 = ";
                s += x1.ToString();
                s += "\nx2 = ";
                s += x2.ToString();
                label4.Text = s;

            }
            else if (delta == 0)
            {
                double x0 = (double)-b / (2 * a);
                label4.Text = label4.Text + "x0 = " + x0.ToString();

            }
            else
            {
                label4.Text = label4.Text + "Brak rozwiązań";
            }
        }
    }
}
