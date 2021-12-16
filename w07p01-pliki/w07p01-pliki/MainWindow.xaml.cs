using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace w07p01_pliki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<String> list = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki tekstowe|*.txt|Wszystkie pliki|*.*";
            openFileDialog.Title = "Otwieranie pliku";
            if (openFileDialog.ShowDialog() == true)   
                textBox01.Text = File.ReadAllText(openFileDialog.FileName);
                label.Content = openFileDialog.FileName;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();   
            saveFileDialog.Filter = "Pliki tekstowe|*.txt|Wszystkie pliki|*.*";
            saveFileDialog.Title = "Zapisz plik";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox01.Text);
                label.Content = saveFileDialog.FileName;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String temp = "";
            list.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki tekstowe|*.txt|Wszystkie pliki|*.*";
            openFileDialog.Title = "Szyfrowanie pliku";
            if (openFileDialog.ShowDialog() == true)
            {
                list = new List<String>(File.ReadAllLines(openFileDialog.FileName));
                list.Reverse();
                for (int j=0; j<list.Count; j++)
                {
                    for (int i = list[j].Length - 1; i >= 0; i--)
                        temp += list[j][i];
                    list[j] = temp;
                    temp = "";
                }
                File.WriteAllLines(openFileDialog.FileName, list);
            }
               
                
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string temp = "";
            foreach(string s in list)
            {
                temp += s;
                temp += "\n";
            }
            textBox01.Text = temp;  
        }
    }
}
