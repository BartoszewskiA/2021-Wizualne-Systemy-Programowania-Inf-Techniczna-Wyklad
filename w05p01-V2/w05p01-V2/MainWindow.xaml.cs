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

namespace w05p01_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void suwakR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelR.Content = Math.Round(e.NewValue).ToString();
            p1.Fill = new SolidColorBrush(Color.FromRgb((Byte)e.NewValue, 0, 0));
            zmienKolor();
        }


        private void suwakG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelG.Content = Math.Round(e.NewValue).ToString();
            p2.Fill = new SolidColorBrush(Color.FromRgb(0,(Byte)e.NewValue, 0));
            zmienKolor();
        }

        private void suwakB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelB.Content = Math.Round(e.NewValue).ToString();
            p3.Fill = new SolidColorBrush(Color.FromRgb(0,0,(Byte)e.NewValue));
            zmienKolor();
        }

        private void zmienKolor()
        {
            SolidColorBrush myBrush;
            if (suwakR != null && suwakG != null && suwakB != null)
            {
                if (czarno_bialy.IsChecked==true)
                    myBrush = new SolidColorBrush(Color.FromRgb((Byte)((suwakR.Value + suwakG.Value + suwakB.Value) / 3),
                                                                (Byte)((suwakR.Value + suwakG.Value + suwakB.Value) / 3),
                                                                (Byte)((suwakR.Value + suwakG.Value + suwakB.Value) / 3)));
                else
                    myBrush = new SolidColorBrush(Color.FromRgb((Byte)suwakR.Value,
                                                                (Byte)suwakG.Value,
                                                                (Byte)suwakB.Value));
                probnik.Fill = myBrush;
            }

        }

        private void czarno_bialy_Click(object sender, RoutedEventArgs e)
        {
            zmienKolor();
        }
    }
}
