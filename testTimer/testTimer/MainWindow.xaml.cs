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
using System.Windows.Threading;

namespace testTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();

            dispatcherTimer.Tick += dispatcherTimer_Tick;

                
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(10);
            dispatcherTimer.Interval = TimeSpan.FromSeconds(10);
            dispatcherTimer.Interval = TimeSpan.FromMinutes(10);
            dispatcherTimer.Interval = TimeSpan.FromHours(10);
            dispatcherTimer.Interval = TimeSpan.FromDays(10);

            dispatcherTimer.Interval = TimeSpan.FromTicks(1);
            
            

            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);


            
            dispatcherTimer.Start();

            dispatcherTimer.Stop();
            
        }

        private void dispatcherTimer_Tick(object? sender, EventArgs e)
        {
            textBlock01.Text = (++i).ToString();
        }
    }
}
