using DomainClasses;
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
using System.Windows.Threading;

namespace KoetjeMelken
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class KoetjeMelkenWindow : Window
    {
      //  private string[] faces;
     //   private string[] suits;

        //The deck of cards we'll use
        private DeckOfCards _computerDeck;
        private DeckOfCards _playerDeck;

        private bool _gameOver = false;
        private int _playerWins;
        private int _compWins;


        private DispatcherTimer _computerPlayTimer = new DispatcherTimer();
        private int _computerDelay = 2;

        public KoetjeMelkenWindow(string[] faces, string[] suits)
        {
            InitializeComponent();

            _playerDeck = new DeckOfCards(faces, suits);
            _computerDeck = new DeckOfCards(faces, suits);
            dealButton.IsEnabled = false;
            playerCardCanvas.IsEnabled = false;
            computerCardLabel.Content = "";
            playerCardLabel.Content = "";
            computerCardNumberLabel.Content = "";
            playerCardNumberLabel.Content = "";
            endLabel.Content = "";
            shuffledLabel.Content = "";
            computerCardCanvas.IsEnabled = false;
            playerActiveCardCanvas.IsEnabled = false;
            
            _computerPlayTimer.Interval = TimeSpan.FromSeconds(_computerDelay);
            _computerPlayTimer.Tick += ComputerAI;
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComputerAI(object sender, EventArgs e)
        {
            shuffledLabel.Content = "";
            computerResultLabel.Content = "";
            playerResultLabel.Content = "";
            Card card = _computerDeck.DealCard();
            if(card == null)
            {
                EndGame();
                computerActiveCardCanvas.Children.Clear();
            }
            else
            {
                string cardName = card.Face + card.Suit;
                try
                {
                    DrawCardOnCanvas(computerActiveCardCanvas, cardName);
                }
                catch (FileNotFoundException exc)
                {
                    MessageBox.Show(exc.Message, "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                computerCardLabel.Content = card.ToString();
                computerCardNumberLabel.Content = "Card #" + (_computerDeck.CurrentCard + 1);

                dealButton.IsEnabled = true;
                playerCardCanvas.IsEnabled = true;
                playerCardLabel.Content = "";
                playerCardNumberLabel.Content = "";
            }

            playerActiveCardCanvas.Children.Clear();
            _computerPlayTimer.Stop();
            
        }

        private void DealCard(object sender, EventArgs e)
        {
            Card card = _playerDeck.DealCard();

            string cardName = card.Face + card.Suit;
            try
            {
                DrawCardOnCanvas(playerActiveCardCanvas, cardName);
            }
            catch (FileNotFoundException exc)
            {
                MessageBox.Show(exc.Message, "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            playerCardLabel.Content = card.ToString();
            playerCardNumberLabel.Content = "Card #" + (_playerDeck.CurrentCard + 1);

            dealButton.IsEnabled = false;
            playerCardCanvas.IsEnabled = false;
            CheckWinner();

            if(!_gameOver)
            {
                _computerPlayTimer.Start();
            }
        }



        private void CheckWinner()
        {
            if (_playerDeck.CurrentValue < _computerDeck.CurrentValue)
            {
                computerResultLabel.Content = "Computer wins";
                playerResultLabel.Content = "";
                _compWins++;
            }
            else if (_playerDeck.CurrentValue > _computerDeck.CurrentValue)
            {
                computerResultLabel.Content = "";
                playerResultLabel.Content = "You win";
                _playerWins++;
            }
            else
            {
                computerResultLabel.Content = "Equal";
                playerResultLabel.Content = "Equal";
            }


            
        }

        private void EndGame()
        {
            _gameOver = true;

            playerCardCanvas.Children.Clear();
            computerCardCanvas.Children.Clear();

            playerCardLabel.Content = "NO MORE CARDS TO DEAL";
            computerCardLabel.Content = "NO MORE CARDS TO DEAL";
            playerCardNumberLabel.Content = "Click shuffle cards to continue";
            computerCardNumberLabel.Content = "Click shuffle cards to continue";

            if (_compWins > _playerWins)
            {
                endLabel.Content = "Sorry, you lost. The computer won " + _compWins + " times, you won " + _playerWins + " times";
            }
            else if (_playerWins > _compWins)
            {
                endLabel.Content = "Congratulations!! You are the winner !! The computer won " + _compWins + " times, you won " + _playerWins + " times";
            }
            else
            {
                endLabel.Content = "You have the same result as the computer: " + _compWins;
            }
        }

        private void ShuffleCards(object sender, RoutedEventArgs e)
        {
            int seed = DateTime.Now.Millisecond;
            _computerDeck.Shuffle(seed);
            seed = seed + new Random().Next(1, 1000);
            _playerDeck.Shuffle(seed);

            //Clear all the canvases
            playerActiveCardCanvas.Children.Clear();
            playerCardCanvas.Children.Clear();
            computerActiveCardCanvas.Children.Clear();
            computerCardCanvas.Children.Clear();

            //Clear the canvas and draw the back of a card
            try
            {
                DrawCardOnCanvas(computerCardCanvas, "cardback");
                DrawCardOnCanvas(playerCardCanvas, "cardback");
            }
            catch (FileNotFoundException exc)
            {
                MessageBox.Show(exc.Message, "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            dealButton.IsEnabled = false;
            computerCardCanvas.IsEnabled = false;
            playerCardCanvas.IsEnabled = false;
            
            shuffledLabel.Content = "DECKS ARE SHUFFLED";
            endLabel.Content = "";
            playerResultLabel.Content = "";
            computerResultLabel.Content = "";

            _gameOver = false;
            _compWins = 0;
            _playerWins = 0;
            _computerPlayTimer.Start();
        }
        

        private void DrawCardOnCanvas(Canvas canvas, string cardName)
        {
            //Clear the canvas first and then draw the card
            canvas.Children.Clear();
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"card_images\" + cardName + ".png", UriKind.Relative);
            bi.EndInit();
            if (bi.UriSource == null)
                throw new FileNotFoundException("Kan de afbeelding card_images\\" + cardName + "png niet tekenen");
            Image picture = new Image();
            picture.Source = bi;
            picture.Margin = new Thickness(0, 0, 0, 0);
            picture.Width = canvas.Width;
            picture.Height = canvas.Height;
            canvas.Children.Add(picture);
        }

        private void ExitApplication(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}

