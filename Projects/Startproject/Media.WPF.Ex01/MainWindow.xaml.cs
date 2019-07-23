using Media.DataModel;
using Media.Player;
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
using System.Windows.Shapes;
using Media.DataModel.Exceptions;
using Media.Controller.Ex01;
using Media.WPF.Ex01.Properties;


namespace Media.WPF.Ex01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IDisposable cleanup;
        IPlayer player;
        IPlaylist playlist;
        MusicController _musicControler = 
        public MainWindow()
        {


            MusicController _musicControler = new MusicController(player, playlist);
            InitializeComponent();

            _musicControler.Player.IsStarted.IsStarted += player.Stop;
            _musicControler.Player.IsStarted.IsFinished += player.Stop;

        }

        private void PlayMusic(object sender, RoutedEventArgs e)
        {
            player.Play();
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            cleanup.Dispose();
        }

        private void Playbutton(object sender, RoutedEventArgs e)
        {
            player.Play();
        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (musicTabItem.IsSelected)
            {
                _activeController = _musicController;
            }
            else if (moviesTabItem.IsSelected)
            {
                _activeController = _movieController;
                Play.IsEnabled = false;
                Stop.IsEnabled = false;
                Pause.IsEnabled = false;
                Next.IsEnabled = false;
            }
        }
    }
}
