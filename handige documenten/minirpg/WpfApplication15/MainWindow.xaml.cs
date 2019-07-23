using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApplication15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hero ourHero;
        private Bird enemey;
        private DispatcherTimer timer = new DispatcherTimer();
        private int teller;

        public MainWindow()
        {
            InitializeComponent();
            ourHero = new Hero("HERO",900);
            MakeHero();
            Attackbutton.IsEnabled = false;
            heroattack.IsEnabled = false;
            heroheal.IsEnabled = false;
            heromaxhealth.IsEnabled = false;
            fireball.IsEnabled = false;

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

      

        private void timer_Tick(object sender, EventArgs e)
        {
            ourHero.healthregen();
            ourHero.manaregen();
            if (ourHero.MANA == 10 && enemey != null)
            {
                fireball.IsEnabled = true;
            }
        }



        private void MakeHero()
        {
            Rectangle rect = new Rectangle();
            rect.Height = ourHero.Health / 10;
            rect.Width = ourHero.Health / 10;
            rect.Margin = new Thickness(10, 10, 0, 0);
            rect.Stroke = new SolidColorBrush(Colors.Black);
            paper.Children.Add(rect);

        }

        private void MakeEnemy()
        {
            Ellipse e1 = new Ellipse();
            e1.Height = enemey.HP/5;
            e1.Width = enemey.HP/5;
            e1.Margin = new Thickness(200, 50, 0, 0);
            e1.Stroke = new SolidColorBrush(Colors.Black);
            paper.Children.Add(e1);
        }

        private void MakeNewEnemy(object sender, RoutedEventArgs e)
        {
            int healthmin = 50+(teller*5);
            int healthmax = 110+(teller*5);
            Random r = new Random();
            enemey = new Bird(r.Next(healthmin,healthmax));
            battleText.Content = "new bird appeared \n";
            MakeEnemy();
            if(Attackbutton.IsEnabled == false)
            {
                Attackbutton.IsEnabled = true;
            }
            if(enemey.HP != 0)
            {
                newenemy.IsEnabled = false;
            }
            ourHero.XpUp(1);
            enemey.Attackup(teller);
            teller++;
        }

        private void Attack(object sender, RoutedEventArgs e)
        {
           
                battleText.Content = "";
                ourHero.Attack(enemey);
                battleText.Content += "the hero hit the bird for " + ourHero.AttackPoints + " dmg \n";
                battleText.Content += "the bird has " + enemey.HP + " health left \n";
                if(enemey.HP <= 0)
                {
                     Attackbutton.IsEnabled = false;
                }
                 if (enemey.HP <= 0)
                   {
                newenemy.IsEnabled = true;
                   }
                battleText.Content += "the bird attacks \n";
                enemey.Attack(ourHero);  
                battleText.Content += "the bird deals  " + enemey.AttackPoints + " damage \n";
                battleText.Content += "the hero has " +Convert.ToInt32(ourHero.Health) + " health left \n";
                if(ourHero.Health == 0)
                {
                     battleText.Content += "the hero died try again";
                    Attackbutton.IsEnabled = false;
                     newenemy.IsEnabled = false;
            }
                paper.Children.Clear();
                MakeEnemy();
                MakeHero();
                ourHero.LevelUp(1);
                 if (ourHero.LEVEL == 1)
                  {
                       heroattack.IsEnabled = true;
                      heroheal.IsEnabled = true;
                     heromaxhealth.IsEnabled = true;
                
                     }
           ourHero.vamp();
            
        }
        

        private void HeroAttack(object sender, RoutedEventArgs e)
        {
            
            ourHero.damageplus(1);
            heroattack.IsEnabled = false;
            heroheal.IsEnabled = false;
            heromaxhealth.IsEnabled = false;
            ourHero.leveldown(1);
        }


        private void HeroHealth(object sender, RoutedEventArgs e)
        {
            ourHero.healthup(1);
            heroattack.IsEnabled = false;
            heroheal.IsEnabled = false;
            heromaxhealth.IsEnabled = false;
            ourHero.leveldown(1);
        }

        private void vemp(object sender, RoutedEventArgs e)
        {
            ourHero.vampup(1);
            heroattack.IsEnabled = false;
            heroheal.IsEnabled = false;
            heromaxhealth.IsEnabled = false;
            ourHero.leveldown(1);
        }

       

        private void FireBall(object sender, RoutedEventArgs e)
        {
            battleText.Content = "";
            battleText.Content += "Die Insect ! \n"; 
            battleText.Content += "the hero purged the bird for " + enemey.HP+" fire damage";
            ourHero.Fire(enemey);
            Attackbutton.IsEnabled = false;
            newenemy.IsEnabled = true;
            paper.Children.Clear();
            MakeEnemy();
            MakeHero();
            ourHero.cooldown();
            fireball.IsEnabled = false;
            ourHero.LevelUp(1);
            if (ourHero.LEVEL == 1)
            {
                heroattack.IsEnabled = true;
                heroheal.IsEnabled = true;
                heromaxhealth.IsEnabled = true;

            }
        }
    }
}
