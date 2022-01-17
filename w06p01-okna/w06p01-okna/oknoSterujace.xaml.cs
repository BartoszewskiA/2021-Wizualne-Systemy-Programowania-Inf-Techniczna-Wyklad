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
using System.Windows.Shapes;

namespace w06p01_okna
{
    /// <summary>
    /// Logika interakcji dla klasy oknoSterujace.xaml
    /// </summary>
    public partial class oknoSterujace : Window
    {
        
        MainWindow mainWindow;
        public oknoSterujace(MainWindow rodzic)
        {
            InitializeComponent();
           mainWindow = rodzic;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mainWindow.tb_07.Text = e.NewValue.ToString();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.okno = null;
        }
    }
}
