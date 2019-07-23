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

namespace H6_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;

            timer.Start();


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            updateSeconds();
        }

        public void updateSeconds()
        {
            if (seconds.Width <= 600) { seconds.Width += 10; }
            else
            {
                seconds.Width = 0;
                updateMinutes();
            }
        }
        public void updateMinutes()
        {
            if (minutes.Width <= 600) { minutes.Width += 10; }
            else { minutes.Width = 0; }
        }
    }
}

