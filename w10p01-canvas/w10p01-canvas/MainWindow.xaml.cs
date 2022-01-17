using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace w10p01_canvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.GetPosition(canvas);
            Canvas.SetLeft(kursor, p.X+10);
            Canvas.SetTop(kursor, p.Y+5);
            pozycja.Content = Math.Round(p.X) + " ; "+ Math.Round(p.Y);
        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(canvas);
            Ellipse e1 = new Ellipse();
            e1.Width = random.Next(50) + 10;
            e1.Height = random.Next(50) + 10;
            e1.Fill = new SolidColorBrush(Color.FromRgb((Byte)random.Next(255), (Byte)random.Next(255), (Byte)random.Next(255)));
            Canvas.SetLeft(e1, p.X);
            Canvas.SetTop(e1, p.Y);
            canvas.Children.Add(e1);
        }
    }
}
