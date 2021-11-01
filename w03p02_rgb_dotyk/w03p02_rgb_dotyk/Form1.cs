using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03p02_rgb_dotyk
{
    public partial class Form1 : Form
    {
        double dyR, dyG, dyB;

        public Form1()
        {
            InitializeComponent();
            skalujPanele();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(0, (int)Math.Round(e.X / dyG), 0);
            panel1.BackColor = mieszajKolory(panel2.BackColor, panel3.BackColor, panel4.BackColor);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(0, 0, (int)Math.Round(e.X / dyB));
            panel1.BackColor = mieszajKolory(panel2.BackColor, panel3.BackColor, panel4.BackColor);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
   
            panel2.BackColor = Color.FromArgb((int)Math.Round(e.X / dyR), 0, 0);
            panel1.BackColor = mieszajKolory(panel2.BackColor, panel3.BackColor, panel4.BackColor);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            skalujPanele();
        }

        void skalujPanele()
        {
            dyR = (double)panel1.Width / 255;
            dyG = (double)panel2.Width / 255;
            dyB = (double)panel3.Width / 255;
        }

        Color mieszajKolory(Color c1, Color c2, Color c3)
        {
            Color wynik = Color.FromArgb(c1.R, c2.G, c3.B);
            return wynik;
        }

    }
}
