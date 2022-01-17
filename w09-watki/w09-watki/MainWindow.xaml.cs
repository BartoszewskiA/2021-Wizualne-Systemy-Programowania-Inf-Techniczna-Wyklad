using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace w09_watki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker worker;
        public MainWindow()
        {
            InitializeComponent();
            worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            worker.DoWork += worker_doWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.ProgressChanged += worker_ProgressChanged;
        }

        private void worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            progressBar01.Value = e.ProgressPercentage;

        }

        private void worker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                textBox01.Text = "Proces przerwano";
            }
            else if (e.Error != null)
            {
                textBox01.Text = "Błąd obliczeń";
            }
            else
            {
                progressBar01.Value = 0;
                textBox01.Text = e.Result.ToString();
            }

        }

        private void worker_doWork(object? sender, DoWorkEventArgs e)
        {
            Random random = new Random();
            DateTime dateTime = DateTime.Now; //pobieramy czas systemowy
            int czas_start = dateTime.Hour * 3600 + dateTime.Minute * 60 + dateTime.Second;
            // czas startowy - liczba sekund, która upłyneła od początku doby
            int ile = 0, x;
            long licznik = 0;
            bool powt;
            if (e.Argument != null) ile = (int)e.Argument;
            // sprawdzany, czy metoda wywołana została z argumentem (zakres)
            List<int> list = new List<int>(); //tworzymy pustą listę

            for (int i = 0; i < ile; i++)
            {
                if (worker.CancellationPending)
                // reakcja na polecenie przerwania wątku
                {
                    e.Cancel = true;
                    return;
                }
                //Thread.Sleep(1); 
                // aby lepiej prześledzić działanie aplikacji 
                // można obliczenia sztucznie spowolnić	
                if (i % 100 == 0) worker.ReportProgress((int)Math.Round(((double)list.Count / ile) * 100));
                // raportujemy postęp - co 100 iteracji, żeby niepotrzebnie nie 	// spowalniać programu
                do // losujemy liczbę bez powtórzeń i dodajemy do listy
                {
                    powt = false;
                    x = random.Next(ile + 1);
                    foreach (int element in list)
                        if (element == x) powt = true;
                    licznik++;
                    if (!powt) list.Add(x);
                } while (powt);
            }
                string wynik = "";
                foreach (int i in list)
                    wynik += i.ToString() + " ";
                // na podstawie listy generujemy łańcuch przygotowany do wyświetlenia
                dateTime = DateTime.Now;
                // ponownie pobieramy czas systemowy
                int czas = dateTime.Hour * 3600 + dateTime.Minute * 60 + dateTime.Second - czas_start;
                // liczymy ile sekund upłyneło od czas_start
                e.Result = licznik.ToString() + " " + czas.ToString() + "\n" + wynik;
                // wygenerowany łańcuch wstawiamy do obiektu e
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int ile = 1000;
            textBox01.Text = "";
            if (int.TryParse(textBox02.Text, out ile)) ;
            worker.RunWorkerAsync(ile);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            worker.CancelAsync();
        }
    }
}
