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

namespace w05p01_probnik_kolorow_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Color c = new Color();
        }

        private void suwakR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelR.Content = Math.Round(e.NewValue).ToString();
            p1.Fill = new SolidColorBrush(Color.FromRgb((Byte)e.NewValue, 0, 0));
            zmienKolor();
        }

        private void zmienKolor()
        {
            if (suwakR!=null && suwakG!=null && suwakB!=null)
                probnik.Fill = new SolidColorBrush(Color.FromRgb((Byte)suwakR.Value,
                                                                (Byte)suwakG.Value,
                                                                (Byte)suwakB.Value));        }
    }
}
