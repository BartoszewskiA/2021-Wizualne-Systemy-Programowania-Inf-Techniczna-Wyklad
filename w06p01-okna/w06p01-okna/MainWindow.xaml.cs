using Microsoft.Win32;
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

namespace w06p01_okna
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki TXT (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            openFileDialog.Title = "Otwieranie pliku";
            if (openFileDialog.ShowDialog() == true)
                tb_01.Text = openFileDialog.FileName;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki TXT (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.Title = "Okno zapisu";
            saveFileDialog.DefaultExt = "doc";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (saveFileDialog.ShowDialog() == true) 
                tb_02.Text = saveFileDialog.FileName;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            okno01 noweOkno = new okno01();
            noweOkno.Title = "Nowe Okno";
            noweOkno.tekstBox01.Text = "tu coś wpisz";
            if (noweOkno.ShowDialog() == true)
                tb_03.Text = noweOkno.tekstBox01.Text + noweOkno.x;
            else
                tb_03.Text = "Cancel";
        }
    }
}
