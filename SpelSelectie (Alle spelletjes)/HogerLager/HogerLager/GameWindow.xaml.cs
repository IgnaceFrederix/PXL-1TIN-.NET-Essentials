
using DomainClasses;
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

namespace HogerLager
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private int numberOfCards;
        private Card currentCard;
        private int currentIdx;

        private List<Card> cardList;
        private List<Canvas> canvasList;

        private List<Card> deck; // bevat initieel alle kaarten;

        private string[] faces;
        private string[] suits;

        public GameWindow(int number, Card card, string[] faces, string[] suits)
        {
            InitializeComponent();
            currentCard = card;
            numberOfCards = number;

            this.faces = faces;
            this.suits = suits;
            deck = InitDeck();
            cardList = ChooseCards(number, card);
            canvasList = LayoutCards();
        }

        private List<Card> InitDeck()
        {
            List<Card> d = new List<Card>();

            for (int s = 0; s < suits.Length; s++)
            {
                for (int r = 0; r < faces.Length; r++)
                {
                    if ((currentCard.Face != faces[r])
                        || (currentCard.Suit != suits[s]))
                    {
                        d.Add(new Card(suits[s],
                                                    faces[r], r));
                    }
                }
            }
            return d;
        }

        private List<Card> ChooseCards(int number, Card start)
        {
            Random random = new Random();

            List<Card> list = new List<Card>();
            list.Add(start);

            for (int i = 1; i < number; i++)
            {
                // haal willekeurig kaart uit deck en stop in list
                int p = random.Next(0, deck.Count);
                list.Add(deck[p]);
                deck.RemoveAt(p);
            }

            return list;
        }

        private List<Canvas> LayoutCards()
        {
            List<Canvas> canvases = new List<Canvas>();
            canvases.Add(startingCardCanvas);

            try
            {

                Util.DrawCardOnCanvas(startingCardCanvas, currentCard.Face + currentCard.Suit);
            }
            catch (FileNotFoundException exc)
            {
                MessageBox.Show(exc.Message, "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            int gap = Convert.ToInt32(
                                ((double)(this.Width - startingCardCanvas.Margin.Left -
                                       startingCardCanvas.Width * numberOfCards)) / numberOfCards);
            int x = (int)(startingCardCanvas.Margin.Left + startingCardCanvas.Width + gap);
            for (int i = 1; i < numberOfCards; i++)
            {
                Canvas canvas = new Canvas();
                canvas.Width = startingCardCanvas.Width;
                canvas.Height = startingCardCanvas.Height;
                canvas.Margin = new Thickness(x, startingCardCanvas.Margin.Top,
                    0, 0);
                canvas.VerticalAlignment = VerticalAlignment.Top;
                canvas.HorizontalAlignment = HorizontalAlignment.Left;
                grid.Children.Add(canvas);
                canvases.Add(canvas);
                try
                { 
                    Util.DrawCardOnCanvas(canvas, "cardback");
                }
                catch (FileNotFoundException exc)
                {
                    MessageBox.Show(exc.Message, "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                x += (int)(gap + startingCardCanvas.Width);
            }

            return canvases;
        }

        private void GuessHigher(object sender, RoutedEventArgs e)
        {
            Card nextCard = cardList[currentIdx + 1];
            if (nextCard.Value >= currentCard.Value)
            {
                GoodGuess(nextCard);
            }
            else
            {
                Lost();
            }
        }

        private void GuessLower(object sender, RoutedEventArgs e)
        {
            Card nextCard = cardList[currentIdx + 1];
            if (nextCard.Value <= currentCard.Value)
            {
                GoodGuess(nextCard);
            }
            else
            {
                Lost();
            }
        }

        private void GoodGuess(Card nextCard)
        {
            currentCard = nextCard;
            currentIdx++;

            //Show the card
            try
            {
                Util.DrawCardOnCanvas(canvasList[currentIdx], currentCard.Face + currentCard.Suit);
            }
            catch(FileNotFoundException exc)
            {
                MessageBox.Show(exc.Message, "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            //Did we win?
            if (currentIdx == numberOfCards - 1)
            {
                MessageBox.Show("Proficiat, u heeft gewonnen", "Hoger-Lager", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                this.Close();
            }
        }

        private void Lost()
        {
            MessageBox.Show("Jammer, volgende keer beter", "Hoger-Lager", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            this.Close();
        }
    }
}
