
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using System.Drawing.Imaging;

using System.Windows.Threading;

using System.Collections;
using System.Threading;
using System.Timers;

namespace Card_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int cardnumber = 0;
        private int computerscore;
        private int playerscore;
        Random rand = new Random();
        int[] kaart = new int[4];
        private DispatcherTimer timer = new DispatcherTimer();
        int[,] arraytest = new int[4, 13];
        int[,] arraytest2 = new int[4, 13];//aanmaken lijst met kaarten die al gebruikt zijn
        int backtest = 0;


        string[,] cardImages = new string[4, 13];
        string[,] card_name = new string[4, 13]//aanmaken string lijst
        {
            { "deuce of hearts", "three of hearts", "four of hearts", "five of hearts", "six of hearts", "seven of hearts", "eight of hearts", "nine of hearts","ten of hearts", "jack of hearts","queen of hearts", "king of hearts", "ace of hearts" },
            { "deuce of spades", "three of spades", "four of spades", "five of spades", "six of spades", "seven of spades", "eight of spades", "nine of spades","ten of spades", "jack of spades","queen of spades", "king of spades", "ace of spades" },
            { "deuce of diamonds", "three of diamonds", "four of diamonds", "five of diamonds", "six of diamonds", "seven of diamonds", "eight of diamonds", "nine of diamonds","ten of diamonds", "jack of diamonds","queen of diamonds", "king of diamonds", "ace of diamonds" },
            { "deuce of clubs", "three of clubs", "four of clubs", "five of clubs", "six of clubs", "seven of clubs", "eight of clubs", "nine of clubs","ten of clubs", "jack of clubs","queen of clubs", "king of clubs", "ace of clubs" },
        };
        

        public MainWindow()
        {
            InitializeComponent();

            loadimages();
            dealcard.IsEnabled = false;
            
           

        }

        //images inladen
        public void loadimages()
        {
           
            cardImages[0, 0] = "pack://application:,,,/card_images/DeuceHearts.png";
            cardImages[0, 1] = "pack://application:,,,/card_images/ThreeHearts.png";
            cardImages[0, 2] = "pack://application:,,,/card_images/FourHearts.png";
            cardImages[0, 3] = "pack://application:,,,/card_images/FiveHearts.png";
            cardImages[0, 4] = "pack://application:,,,/card_images/SixHearts.png";
            cardImages[0, 5] = "pack://application:,,,/card_images/SevenHearts.png";
            cardImages[0, 6] = "pack://application:,,,/card_images/EightHearts.png";
            cardImages[0, 7] = "pack://application:,,,/card_images/NineHearts.png";
            cardImages[0, 8] = "pack://application:,,,/card_images/TenHearts.png";
            cardImages[0, 9] = "pack://application:,,,/card_images/JackHearts.png";
            cardImages[0, 10] = "pack://application:,,,/card_images/QueenHearts.png";
            cardImages[0, 11] = "pack://application:,,,/card_images/KingHearts.png";
            cardImages[0, 12] = "pack://application:,,,/card_images/AceHearts.png";

            cardImages[1, 0] = "pack://application:,,,/card_images/DeuceSpades.png";
            cardImages[1, 1] = "pack://application:,,,/card_images/ThreeSpades.png";
            cardImages[1, 2] = "pack://application:,,,/card_images/FourSpades.png";
            cardImages[1, 3] = "pack://application:,,,/card_images/FiveSpades.png";
            cardImages[1, 4] = "pack://application:,,,/card_images/SixSpades.png";
            cardImages[1, 5] = "pack://application:,,,/card_images/SevenSpades.png";
            cardImages[1, 6] = "pack://application:,,,/card_images/EightSpades.png";
            cardImages[1, 7] = "pack://application:,,,/card_images/NineSpades.png";
            cardImages[1, 8] = "pack://application:,,,/card_images/TenSpades.png";
            cardImages[1, 9] = "pack://application:,,,/card_images/JackSpades.png";
            cardImages[1, 10] = "pack://application:,,,/card_images/QueenSpades.png";
            cardImages[1, 11] = "pack://application:,,,/card_images/KingSpades.png";
            cardImages[1, 12] = "pack://application:,,,/card_images/AceSpades.png";

            cardImages[2, 0] = "pack://application:,,,/card_images/DeuceDiamonds.png";
            cardImages[2, 1] = "pack://application:,,,/card_images/ThreeDiamonds.png";
            cardImages[2, 2] = "pack://application:,,,/card_images/FourDiamonds.png";
            cardImages[2, 3] = "pack://application:,,,/card_images/FiveDiamonds.png";
            cardImages[2, 4] = "pack://application:,,,/card_images/SixDiamonds.png";
            cardImages[2, 5] = "pack://application:,,,/card_images/SevenDiamonds.png";
            cardImages[2, 6] = "pack://application:,,,/card_images/EightDiamonds.png";
            cardImages[2, 7] = "pack://application:,,,/card_images/NineDiamonds.png";
            cardImages[2, 8] = "pack://application:,,,/card_images/TenDiamonds.png";
            cardImages[2, 9] = "pack://application:,,,/card_images/JackDiamonds.png";
            cardImages[2, 10] = "pack://application:,,,/card_images/QueenDiamonds.png";
            cardImages[2, 11] = "pack://application:,,,/card_images/KingDiamonds.png";
            cardImages[2, 12] = "pack://application:,,,/card_images/AceDiamonds.png";

            cardImages[3, 0] = "pack://application:,,,/card_images/DeuceClubs.png";
            cardImages[3, 1] = "pack://application:,,,/card_images/ThreeClubs.png";
            cardImages[3, 2] = "pack://application:,,,/card_images/FourClubs.png";
            cardImages[3, 3] = "pack://application:,,,/card_images/FiveClubs.png";
            cardImages[3, 4] = "pack://application:,,,/card_images/SixClubs.png";
            cardImages[3, 5] = "pack://application:,,,/card_images/SevenClubs.png";
            cardImages[3, 6] = "pack://application:,,,/card_images/EightClubs.png";
            cardImages[3, 7] = "pack://application:,,,/card_images/NineClubs.png";
            cardImages[3, 8] = "pack://application:,,,/card_images/TenClubs.png";
            cardImages[3, 9] = "pack://application:,,,/card_images/JackClubs.png";
            cardImages[3, 10] = "pack://application:,,,/card_images/QueenClubs.png";
            cardImages[3, 11] = "pack://application:,,,/card_images/KingClubs.png";
            cardImages[3, 12] = "pack://application:,,,/card_images/AceClubs.png";

        }

        //cardback inladen
        private void cardback()
        {
            var uriback = new Uri("pack://application:,,,/card_images/cardback.png");
            var imageback = new BitmapImage(uriback);
            var brushImage = new ImageBrush();
            brushImage.ImageSource = imageback;
            paper1.Background = brushImage;
            paper4.Background = new ImageBrush(imageback);
        }

       

        private void playCard()
        {
         

            if (cardnumber > 52)//wat er moet gebeuren op het einde als de kaarten op zijn 
            {
                Thread.Sleep(2000);
                dealcard.IsEnabled = false;
                playerwins.Content = "";
                computerwins.Content = "";
                cardnumbercomputer.Content = "Click shuffle cards to continue";
                cardnumberplayer.Content = "Click shuffle cards to continue";
                cardnamecomputer.Content = "NO MORE CARDS TO DEAL";
                cardnameplayer.Content = "NO MORE CARDS TO DEAL";
                if (computerscore > playerscore)
                {
                    endgame.Text = "Sorry, you lost. The Computer won " + computerscore + " times, you won " + playerscore + " times.";
                }
                if (computerscore < playerscore)
                {
                    endgame.Text = "Congratulations !! You are the winner!! The Computer won " + computerscore + " times, you won " + playerscore + " times.";
                }
                if (computerscore == playerscore)
                {
                    endgame.Text = "No winner, you have the same result as the computer: you won " + playerscore + " times.";
                }
                dealcard.IsEnabled = false;//maakt alle canvasen leeg
                paper1.Background = new SolidColorBrush(Colors.Gray);
                paper2.Background = new SolidColorBrush(Colors.Gray);
                paper3.Background = new SolidColorBrush(Colors.Gray);
                paper4.Background = new SolidColorBrush(Colors.Gray);

            }
            else
            {
                //random getal genereren voor random kaart
                suffle.Content = "";

                int getal1 = rand.Next(0, 4);
                int getal2 = rand.Next(0, 13);
                int getal3 = rand.Next(0, 4);
                int getal4 = rand.Next(0, 13);
                while (arraytest[getal1, getal2] == 1)
                {

                    getal1 = (rand.Next(0, 4));
                    getal2 = (rand.Next(0, 13));

                }
                while (arraytest2[getal3, getal4] == 1)
                {

                    getal3 = (rand.Next(0, 4));
                    getal4 = (rand.Next(0, 13));

                }


                kaart[0] = getal2;
                kaart[1] = getal1;
                kaart[2] = getal4;
                kaart[3] = getal3;

                arraytest[getal1, getal2] = 1;//steekt gebruikte kaart in array voor te kijken of de volgende kaar al is gebruikt 
                arraytest2[getal3, getal4] = 1;
                if (cardnumber != 1)
                {
                    cardnumbercomputer.Content = "Card #" + (cardnumber);//afdrukken kaartnummer
                    cardnumberplayer.Content = "Card #" + (cardnumber);
                    var kaart1 = new Uri(cardImages[kaart[1], kaart[0]]);//afdrukkken random kaart image pc
                    var kaartImage = new BitmapImage(kaart1);
                    paper2.Background = new ImageBrush(kaartImage);

                    var kaart2 = new Uri(cardImages[kaart[3], kaart[2]]);//aftdrukken random kaart image gebruiker
                    var kaartImage2 = new BitmapImage(kaart2);
                    paper3.Background = new ImageBrush(kaartImage2);
                    cardnamecomputer.Content = card_name[kaart[1], kaart[0]];//afdrukken random kaart naam
                    cardnameplayer.Content = card_name[kaart[3], kaart[2]];
                }
                else//kaart 1 van de speler
                {
                    cardnameplayer.Content = card_name[kaart[3], kaart[2]];
                    var kaart2 = new Uri(cardImages[kaart[3], kaart[2]]);//aftdrukken random kaart image gebruiker
                    var kaartImage2 = new BitmapImage(kaart2);
                    paper3.Background = new ImageBrush(kaartImage2);
                    cardnumberplayer.Content = "Card #" + (cardnumber);



                }


                playerwins.Content = "";
                computerwins.Content = "";
              
                if (kaart[0] < kaart[2])//if structuur voor als je wint
                {
                    playerwins.Content = "you win";
                    playerscore++;
                }
                if (kaart[0] > kaart[2])//if stuctuur als pc wint 
                {
                    computerwins.Content = "computer wins";
                    computerscore++;
                }
                if (kaart[0] == kaart[2])//gelijk
                {
                    playerwins.Content = "equal";
                    computerwins.Content = "equal";

                }

              
            }
           
        }
      

   

    public void FirstCard()//automatische eerste computer kaart
        {
        
            int getal1 = rand.Next(0, 4);
            int getal2 = rand.Next(0, 13);
            int getal3 = rand.Next(0, 4);
            int getal4 = rand.Next(0, 13);
            while (arraytest[getal1, getal2] == 1)
            {

                getal1 = (rand.Next(0, 4));
                getal2 = (rand.Next(0, 13));

            }
            while (arraytest2[getal3, getal4] == 1)
            {

                getal3 = (rand.Next(0, 4));
                getal4 = (rand.Next(0, 13));

            }


            kaart[0] = getal2;
            kaart[1] = getal1;
            kaart[2] = getal4;
            kaart[3] = getal3;

            arraytest[getal1, getal2] = 1;//steekt gebruikte kaart in array voor te kijken of de volgende kaar al is gebruikt 
            arraytest2[getal3, getal4] = 1;
            cardnumbercomputer.Content = "Card #" + (cardnumber);
            var kaart1 = new Uri(cardImages[kaart[1], kaart[0]]);//afdrukkken random kaart image pc
            var kaartImage = new BitmapImage(kaart1);
            paper2.Background = new ImageBrush(kaartImage);
            cardnamecomputer.Content = card_name[kaart[1], kaart[0]];//afdrukken random kaart naam

        }
       
        private void DealCards(object sender, RoutedEventArgs e)//wat er gebeurd als je op deal card knap gebeurd
        {
            
            playCard();
           cardnumber++;
        }

       public void test()
        {
            backtest = 1;
            suffle.Content = "DECKS ARE SHUFFELD";
            dealcard.IsEnabled = true;
            cardnumber = 1;
            endgame.Text = "";
            cardnumbercomputer.Content = "";
            cardnumberplayer.Content = "";
            cardnamecomputer.Content = "";
            cardnameplayer.Content = "";
            playerwins.Content = "";
            computerwins.Content = "";
            cardback();
            paper2.Background = new SolidColorBrush(Colors.Gray);
            paper3.Background = new SolidColorBrush(Colors.Gray);
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 13; x++)
                {
                    arraytest[i, x] = 0;
                    arraytest2[i, x] = 0;
                }
            }
        }
        public void test2()
        {
            Thread.Sleep(2000); //eerste kaart afdrukken na 2 secondes
        }


        private void shuffleCards(object sender, RoutedEventArgs e)//shullfe button
        {

            test();
           
            test2();
            FirstCard();
           
        }



        private void ClickPlayCard(object sender, MouseButtonEventArgs e)//wat er moet gebeuren voor als je op de achterkand van jouw kaart klikt
        {
            if(backtest ==1 && cardnumber <53)
            {
                playCard();
                cardnumber++;
            }
            
           
        }
    }
}
