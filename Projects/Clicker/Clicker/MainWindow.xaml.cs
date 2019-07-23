using System;
using System.Collections.Generic;
using System.IO;
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

namespace Clicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private long moneyInt;
        private DispatcherTimer timer = new DispatcherTimer();
        private DispatcherTimer timer2 = new DispatcherTimer();
        private DispatcherTimer timer3 = new DispatcherTimer();
        private DispatcherTimer timer4 = new DispatcherTimer();
        private DispatcherTimer timer5 = new DispatcherTimer();
        private DispatcherTimer timer6 = new DispatcherTimer();
        private DispatcherTimer timer7 = new DispatcherTimer();
        private DispatcherTimer checkTimer = new DispatcherTimer();
        private DispatcherTimer checkTimer2 = new DispatcherTimer();



        private int teller1;
        private int teller2;
        private int teller3;
        private int teller4;
        private int teller5;
        private int teller6;
        private int teller7;

        private long kost1;
        private long kost2;
        private long kost3;
        private long kost4;
        private long kost5;
        private long kost6;
        private long kost7;

        private int aclicker1;
        private int aclicker2;
        private int aclicker3;
        private int aclicker4;
        private int aclicker5;
        private int aclicker6;
        private int aclicker7;

       


        //aanmaken extra windows
        private Window2 upspeed = new Window2();
        private Window3 upprofit = new Window3();

     

        public MainWindow()
        {
            
            InitializeComponent();

       
            //locatie van savefile
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            destination = System.IO.Path.Combine(destination, "clicker.txt");

            //als bestand niet bestaat
            if (!File.Exists(destination))
            {
             

                teller1 = 1;
                teller2 = 0;
                teller3 = 0;
                teller4 = 0;
                teller5 = 0;
                teller6 = 0;
                teller7 = 0;

                kost1 = 20;
                kost2 = 200;
                kost3 = 2000;
                kost4 = 20000;
                kost5 = 200000;
                kost6 = 2000000;
                kost7 = 20000000;

                aclicker1 = 0;
                aclicker2 = 0;
                aclicker3 = 0;
                aclicker4 = 0;
                aclicker5 = 0;
                aclicker6 = 0;
                aclicker7 = 0;

                upspeed.speed1 = 1;
                upspeed.speed2 = 1;
                upspeed.speed3 = 1;
                upspeed.speed4 = 1;
                upspeed.speed5 = 1;
                upspeed.speed6 = 1;
                upspeed.speed7 = 1;
                upspeed.speedAll = 1;

                upprofit.profit1 = 1;
                upprofit.profit2 = 1;
                upprofit.profit3 = 1;
                upprofit.profit4 = 1;
                upprofit.profit5 = 1;
                upprofit.profit6 = 1;
                upprofit.profit7 = 1;
                upprofit.profitAll = 1;


            }
            else
            {
                //lees een save file begin
                //construeer een pad



                
                //open een conecite naar het bestand
                StreamReader inputStream = File.OpenText(destination);
                //lees alle data
                string moneyline = inputStream.ReadLine();

                string tellerline1 = inputStream.ReadLine();
                string tellerline2 = inputStream.ReadLine();
                string tellerline3 = inputStream.ReadLine();
                string tellerline4 = inputStream.ReadLine();
                string tellerline5 = inputStream.ReadLine();
                string tellerline6 = inputStream.ReadLine();
                string tellerline7 = inputStream.ReadLine();

                string upgradeline1 = inputStream.ReadLine();
                string upgradeline2 = inputStream.ReadLine();
                string upgradeline3 = inputStream.ReadLine();
                string upgradeline4 = inputStream.ReadLine();
                string upgradeline5 = inputStream.ReadLine();
                string upgradeline6 = inputStream.ReadLine();
                string upgradeline7 = inputStream.ReadLine();

                string autoline1 = inputStream.ReadLine();
                string autoline2 = inputStream.ReadLine();
                string autoline3 = inputStream.ReadLine();
                string autoline4 = inputStream.ReadLine();
                string autoline5 = inputStream.ReadLine();
                string autoline6 = inputStream.ReadLine();
                string autoline7 = inputStream.ReadLine();

                string speedline1 = inputStream.ReadLine();
                string speedline2 = inputStream.ReadLine();
                string speedline3 = inputStream.ReadLine();
                string speedline4 = inputStream.ReadLine();
                string speedline5 = inputStream.ReadLine();
                string speedline6 = inputStream.ReadLine();
                string speedline7 = inputStream.ReadLine();
                string speedlineAll = inputStream.ReadLine();

                string profitline1 = inputStream.ReadLine();
                string profitline2 = inputStream.ReadLine();
                string profitline3 = inputStream.ReadLine();
                string profitline4 = inputStream.ReadLine();
                string profitline5 = inputStream.ReadLine();
                string profitline6 = inputStream.ReadLine();
                string profitline7 = inputStream.ReadLine();
                string profitlineAll = inputStream.ReadLine();



                inputStream.Close();







                moneyInt = Convert.ToInt64(moneyline);


                teller1 = Convert.ToInt32(tellerline1);
                teller2 = Convert.ToInt32(tellerline2);
                teller3 = Convert.ToInt32(tellerline3);
                teller4 = Convert.ToInt32(tellerline4);
                teller5 = Convert.ToInt32(tellerline5);
                teller6 = Convert.ToInt32(tellerline6);
                teller7 = Convert.ToInt32(tellerline7);

                kost1 = Convert.ToInt64(upgradeline1);
                kost2 = Convert.ToInt64(upgradeline2);
                kost3 = Convert.ToInt64(upgradeline3);
                kost4 = Convert.ToInt64(upgradeline4);
                kost5 = Convert.ToInt64(upgradeline5);
                kost6 = Convert.ToInt64(upgradeline6);
                kost7 = Convert.ToInt64(upgradeline7);

                aclicker1 = Convert.ToInt32(autoline1);
                aclicker2 = Convert.ToInt32(autoline2);
                aclicker3 = Convert.ToInt32(autoline3);
                aclicker4 = Convert.ToInt32(autoline4);
                aclicker5 = Convert.ToInt32(autoline5);
                aclicker6 = Convert.ToInt32(autoline6);
                aclicker7 = Convert.ToInt32(autoline7);

                upspeed.speed1 = Convert.ToDouble(speedline1);
                upspeed.speed2 = Convert.ToDouble(speedline2);
                upspeed.speed3 = Convert.ToDouble(speedline3);
                upspeed.speed4 = Convert.ToDouble(speedline4);
                upspeed.speed5 = Convert.ToDouble(speedline5);
                upspeed.speed6 = Convert.ToDouble(speedline6);
                upspeed.speed7 = Convert.ToDouble(speedline7);
                upspeed.speedAll = Convert.ToDouble(speedlineAll);

                upprofit.profit1 = Convert.ToInt32(profitline1);
                upprofit.profit2 = Convert.ToInt32(profitline2);
                upprofit.profit3 = Convert.ToInt32(profitline3);
                upprofit.profit4 = Convert.ToInt32(profitline4);
                upprofit.profit5 = Convert.ToInt32(profitline5);
                upprofit.profit6 = Convert.ToInt32(profitline6);
                upprofit.profit7 = Convert.ToInt32(profitline7);
                upprofit.profitAll = Convert.ToInt32(profitlineAll);
                //einde lees een save file
            }



            checkTimer.Interval = TimeSpan.FromMilliseconds(1);
            checkTimer.Tick += timer_TickCheck;

          
            checkTimer.Start();
            if (teller2 == 0)
            {
                b2.IsEnabled = false;
            }
            if (teller3 == 0)
            {
                b3.IsEnabled = false;
            }
            if (teller4 == 0)
            {
                b4.IsEnabled = false;
            }
            if (teller5 == 0)
            {
                b5.IsEnabled = false;
            }
            if (teller6 == 0)
            {
                b6.IsEnabled = false;
            }
            if (teller7 == 0)
            {
                b7.IsEnabled = false;
            }

            b2.Content = teller2;
            b3.Content = teller3;
            b4.Content = teller4;
            b5.Content = teller5;
            b6.Content = teller6;
            b7.Content = teller7;

            money.Content = moneyInt;
            b1.Content = teller1;

            u1.Content = kost1 + " $";
            u2.Content = kost2 + " $";
            u3.Content = kost3 + " $";
            u4.Content = kost4 + " $";
            u5.Content = kost5 + " $";
            u6.Content = kost6 + " $";
            u7.Content = kost7 + " $";


            checkTimer2.Interval = TimeSpan.FromMilliseconds(1);
            checkTimer2.Tick += timer_TickCheck2;
            checkTimer2.Start();

            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += timer_Tick;
           
            timer2.Tick += timer_Tick2;           
            timer3.Tick += timer_Tick3;         
            timer4.Tick += timer_Tick4;        
            timer5.Tick += timer_Tick5;          
            timer6.Tick += timer_Tick6;
            timer7.Tick += timer_Tick7;
        }

        //elke second check
        private void timer_TickCheck2(object sender, EventArgs e)
        {
            
            if (upspeed.button1WasClicked == true)
            {
                moneyInt = moneyInt - 2000;
                upspeed.button1WasClicked =false;
                
            }
            if(upspeed.speed1 == 0.5)
            {
                upspeed.speedbutton1.Content = "Bought";
            }

            if (upspeed.button2WasClicked == true)
            {
                moneyInt = moneyInt - 20000;
                upspeed.button2WasClicked = false;
               
            }
            if (upspeed.speed2 == 0.5)
            {
                upspeed.speedbutton2.Content = "Bought";
            }

            if (upspeed.button3WasClicked == true)
            {
                moneyInt = moneyInt - 200000;
                upspeed.button3WasClicked = false;
                
            }
            if (upspeed.speed3 == 0.5)
            {
                upspeed.speedbutton3.Content = "Bought";
            }

            if (upspeed.button4WasClicked == true)
            {
                moneyInt = moneyInt - 2000000;
                upspeed.button4WasClicked = false;
                
            }
            if (upspeed.speed4 == 0.5)
            {
                upspeed.speedbutton4.Content = "Bought";
            }

            if (upspeed.button5WasClicked == true)
            {
                moneyInt = moneyInt - 20000000;
                upspeed.button5WasClicked = false;
              
            }
            if (upspeed.speed5 == 0.5)
            {
                upspeed.speedbutton5.Content = "Bought";
            }
            if (upspeed.button6WasClicked == true)
            {
                moneyInt = moneyInt - 200000000;
                upspeed.button6WasClicked = false;
               
            }
            if (upspeed.speed6 == 0.5)
            {
                upspeed.speedbutton6.Content = "Bought";
            }

            if (upspeed.button7WasClicked == true)
            {
                moneyInt = moneyInt - 2000000000;
                upspeed.button7WasClicked = false;
                
            }
            if (upspeed.speed7 == 0.5)
            {
                upspeed.speedbutton7.Content = "Bought";
            }

            if (upspeed.buttonAllWasClicked == true)
            {
                moneyInt = moneyInt - 20000000000;
                upspeed.buttonAllWasClicked = false;
               
            }
            if (upspeed.speedAll == 0.5)
            {
                upspeed.speedbuttonAll.Content = "Bought";
            }

            if (upprofit.button1profitWasClicked == true)
            {
                moneyInt = moneyInt - 2000;
                upprofit.button1profitWasClicked = false;
               
            }
            if (upprofit.profit1 == 2)
            {
               upprofit.profitbutton1.Content = "Bought";
            }

            if (upprofit.button2profitWasClicked == true)
            {
                moneyInt = moneyInt - 20000;
                upprofit.button2profitWasClicked = false;
              
            }
            if (upprofit.profit2 == 2)
            {
                upprofit.profitbutton2.Content = "Bought";
            }

            if (upprofit.button3profitWasClicked == true)
            {
                moneyInt = moneyInt - 200000;
                upprofit.button3profitWasClicked = false;
               
            }
            if (upprofit.profit3 == 2)
            {
                upprofit.profitbutton3.Content = "Bought";
            }

            if (upprofit.button4profitWasClicked == true)
            {
                moneyInt = moneyInt - 2000000;
                upprofit.button4profitWasClicked = false;
               
            }
            if (upprofit.profit4 == 2)
            {
                upprofit.profitbutton4.Content = "Bought";
            }

            if (upprofit.button5profitWasClicked == true)
            {
                moneyInt = moneyInt - 20000000;
                upprofit.button5profitWasClicked = false;
               
            }
            if (upprofit.profit5 == 2)
            {
                upprofit.profitbutton5.Content = "Bought";
            }

            if (upprofit.button6profitWasClicked == true)
            {
                moneyInt = moneyInt - 200000000;
                upprofit.button6profitWasClicked = false;
              
            }
            if (upprofit.profit6 == 2)
            {
                upprofit.profitbutton6.Content = "Bought";
            }
            if (upprofit.button7profitWasClicked == true)
            {
                moneyInt = moneyInt - 20000000000;
                upprofit.button7profitWasClicked = false;
               
            }
            if (upprofit.profit7 == 2)
            {
                upprofit.profitbutton7.Content = "Bought";
            }

            if (upprofit.buttonAllprofitWasClicked == true)
            {
                moneyInt = moneyInt - 200000000000;
                upprofit.buttonAllprofitWasClicked = false;
              
            }
            if (upprofit.profitAll == 2)
            {
                upprofit.profitbuttonAll.Content = "Bought";
            }

            money.Content = moneyInt+" $";
        }





        private void timer_TickCheck(object sender, EventArgs e)
        {
        
               if(moneyInt < 2000 || upspeed.speed1 ==0.5)
            {
               
                upspeed.speedbutton1.IsEnabled = false ;
            }
            else
            {
                upspeed.speedbutton1.IsEnabled = true;
            }


            if (moneyInt < 20000 || upspeed.speed2 == 0.5)
            {

                upspeed.speedbutton2.IsEnabled = false;
            }
            else
            {
                upspeed.speedbutton2.IsEnabled = true;
            }

            if (moneyInt < 200000 || upspeed.speed3 == 0.5)
            {

                upspeed.speedbutton3.IsEnabled = false;
            }
            else
            {
                upspeed.speedbutton3.IsEnabled = true;
            }


            if (moneyInt < 2000000 || upspeed.speed4 == 0.5)
            {

                upspeed.speedbutton4.IsEnabled = false;
            }
            else
            {
                upspeed.speedbutton4.IsEnabled = true;
            }

            if (moneyInt < 20000000 || upspeed.speed5 == 0.5)
            {

                upspeed.speedbutton5.IsEnabled = false;
            }
            else
            {
                upspeed.speedbutton5.IsEnabled = true;
            }


            if (moneyInt < 200000000 || upspeed.speed6 == 0.5)
            {

                upspeed.speedbutton6.IsEnabled = false;
            }
            else
            {
                upspeed.speedbutton6.IsEnabled = true;
            }


            if (moneyInt < 2000000000 || upspeed.speed7 == 0.5)
            {

                upspeed.speedbutton7.IsEnabled = false;
            }
            else
            {
                upspeed.speedbutton7.IsEnabled = true;
            }

            if (moneyInt < 20000000000 || upspeed.speedAll == 0.5)
            {

                upspeed.speedbuttonAll.IsEnabled = false;
            }
            else
            {
                upspeed.speedbuttonAll.IsEnabled = true;
            }




            if (moneyInt < 2000 || upprofit.profit1 == 2)
            {

                upprofit.profitbutton1.IsEnabled = false;
            }
            else
            {
                upprofit.profitbutton1.IsEnabled = true;
            }

            if (moneyInt < 20000 || upprofit.profit2 == 2)
            {

                upprofit.profitbutton2.IsEnabled = false;
            }
            else
            {
                upprofit.profitbutton2.IsEnabled = true;
            }

            if (moneyInt < 200000 || upprofit.profit3 == 2)
            {

                upprofit.profitbutton3.IsEnabled = false;
            }
            else
            {
                upprofit.profitbutton3.IsEnabled = true;
            }

            if (moneyInt < 200000 || upprofit.profit4 == 2)
            {

                upprofit.profitbutton4.IsEnabled = false;
            }
            else
            {
                upprofit.profitbutton4.IsEnabled = true;
            }

            if (moneyInt < 2000000 || upprofit.profit5 == 2)
            {

                upprofit.profitbutton5.IsEnabled = false;
            }
            else
            {
                upprofit.profitbutton5.IsEnabled = true;
            }

            if (moneyInt < 20000000 || upprofit.profit6 == 2)
            {

                upprofit.profitbutton6.IsEnabled = false;
            }
            else
            {
                upprofit.profitbutton6.IsEnabled = true;
            }

            if (moneyInt < 200000000 || upprofit.profit7 == 2)
            {

                upprofit.profitbutton7.IsEnabled = false;
            }
            else
            {
                upprofit.profitbutton7.IsEnabled = true;
            }

            if (moneyInt < 2000000000 || upprofit.profitAll == 2)
            {

                upprofit.profitbuttonAll.IsEnabled = false;
            }
            else
            {
                upprofit.profitbuttonAll.IsEnabled = true;
            }





            if (kost1 > moneyInt)
            {
                u1.IsEnabled = false;
            }
            else
            {
                u1.IsEnabled = true;
            }

            if (kost2 > moneyInt)
            {
                u2.IsEnabled = false;
            }
            else
            {
                u2.IsEnabled = true;
            }

            if (kost3 > moneyInt)
            {
                u3.IsEnabled = false;
            }
            else
            {
                u3.IsEnabled = true;
            }

            if (kost4 > moneyInt)
            {
                u4.IsEnabled = false;
            }
            else
            {
                u4.IsEnabled = true;
            }

            if (kost5 > moneyInt)
            {
                u5.IsEnabled = false;
            }
            else
            {
                u5.IsEnabled = true;
            }

            if (kost6 > moneyInt)
            {
                u6.IsEnabled = false;
            }
            else
            {
                u6.IsEnabled = true;
            }

            if (kost7 > moneyInt)
            {
                u7.IsEnabled = false;
            }
            else
            {
                u7.IsEnabled = true;
            }

            if (moneyInt < 2000 || aclicker1 == 1 || teller1 == 0)
            {

                auto1.IsEnabled = false;


            }
            else
            {
                auto1.IsEnabled = true;
            }

            if (moneyInt < 20000 || aclicker2 == 1 || teller2 == 0)
            {
                auto2.IsEnabled = false;
            }
            else
            {
                auto2.IsEnabled = true;
            }

            if (moneyInt < 200000 || aclicker3 == 1 || teller3 == 0)
            {
                auto3.IsEnabled = false;
            }
            else
            {
                auto3.IsEnabled = true;
            }

            if (moneyInt < 2000000 || aclicker4 == 1 || teller4 == 0)
            {
                auto4.IsEnabled = false;
            }
            else
            {
                auto4.IsEnabled = true;
            }

            if (moneyInt < 20000000 || aclicker5 == 1 || teller5 == 0)
            {
                auto5.IsEnabled = false;
            }
            else
            {
                auto5.IsEnabled = true;
            }

            if (moneyInt < 20000000 || aclicker6 == 1 || teller6 == 0)
            {
                auto6.IsEnabled = false;
            }
            else
            {
                auto6.IsEnabled = true;
            }

            if (moneyInt < 200000000 || aclicker7 == 1 || teller7 == 0)
            {
                auto7.IsEnabled = false;
            }
            else
            {
                auto7.IsEnabled = true;
            }
            if (aclicker1 == 1)
            {
                auto1.Content = "";
                auto1.Content = " Bought in the fight against ISIS";
            }
            if (aclicker2 == 1)
            {
                auto2.Content = "";
                auto2.Content = " Bought in the fight against ISIS";
            }
            if (aclicker3 == 1)
            {
                auto3.Content = "";
                auto3.Content = " Bought in the fight against ISIS";
            }
            if (aclicker4 == 1)
            {
                auto4.Content = "";
                auto4.Content = " Bought in the fight against ISIS";
            }
            if (aclicker5 == 1)
            {
                auto5.Content = "";
                auto5.Content = " Bought in the fight against ISIS";
            }
            if (aclicker6 == 1)
            {
                auto6.Content = "";
                auto6.Content = " Bought in the fight against ISIS";
            }
            if (aclicker7 == 1)
            {
                auto7.Content = "";
                auto7.Content = " Bought in the fight against ISIS";
            }

            //schrijf een save file begin
            //construeer een pad
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


            destination = System.IO.Path.Combine(destination, "clicker.txt");


            // maak connecite met een bestand
            StreamWriter outputStream = File.CreateText(destination);
            //schrijf data weg naar het bestna
            outputStream.WriteLine(moneyInt);

            outputStream.WriteLine(teller1);
            outputStream.WriteLine(teller2);
            outputStream.WriteLine(teller3);
            outputStream.WriteLine(teller4);
            outputStream.WriteLine(teller5);
            outputStream.WriteLine(teller6);
            outputStream.WriteLine(teller7);

            outputStream.WriteLine(kost1);
            outputStream.WriteLine(kost2);
            outputStream.WriteLine(kost3);
            outputStream.WriteLine(kost4);
            outputStream.WriteLine(kost5);
            outputStream.WriteLine(kost6);
            outputStream.WriteLine(kost7);

            outputStream.WriteLine(aclicker1);
            outputStream.WriteLine(aclicker2);
            outputStream.WriteLine(aclicker3);
            outputStream.WriteLine(aclicker4);
            outputStream.WriteLine(aclicker5);
            outputStream.WriteLine(aclicker6);
            outputStream.WriteLine(aclicker7);

            outputStream.WriteLine(upspeed.speed1);
            outputStream.WriteLine(upspeed.speed2);
            outputStream.WriteLine(upspeed.speed3);
            outputStream.WriteLine(upspeed.speed4);
            outputStream.WriteLine(upspeed.speed5);
            outputStream.WriteLine(upspeed.speed6);
            outputStream.WriteLine(upspeed.speed7);
            outputStream.WriteLine(upspeed.speedAll);

            outputStream.WriteLine(upprofit.profit1);
            outputStream.WriteLine(upprofit.profit2);
            outputStream.WriteLine(upprofit.profit3);
            outputStream.WriteLine(upprofit.profit4);
            outputStream.WriteLine(upprofit.profit5);
            outputStream.WriteLine(upprofit.profit6);
            outputStream.WriteLine(upprofit.profit7);
            outputStream.WriteLine(upprofit.profitAll);

            // MessageBox.Show(aclicker1+"");


            //sluit de connnectie
            outputStream.Close();
            //einde schrijf een save file
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            check1();
        }

        private void timer_Tick2(object sender, EventArgs e)
        {
            check2();
        }
        private void timer_Tick3(object sender, EventArgs e)
        {
            check3();
        }
        private void timer_Tick4(object sender, EventArgs e)
        {
            check4();
        }
        private void timer_Tick5(object sender, EventArgs e)
        {
            check5();
        }
        private void timer_Tick6(object sender, EventArgs e)
        {
            check6();
        }
        private void timer_Tick7(object sender, EventArgs e)
        {
            check7();
        }

        private void check1()
        {
            
            p1.Value = p1.Value + 1;
            int earn = (teller1 * 1)*upprofit.profit1*upprofit.profitAll;
            if (p1.Value >= 100)
            {
                p1.Value = 0;

                moneyInt = moneyInt + (teller1 * 1)*upprofit.profit1 * upprofit.profitAll;
                money.Content = moneyInt + " $";
                b1.IsEnabled = true;
                if (aclicker1 == 0)
                {
                    timer.Stop();
                }

            }
            if (p1.Value > 0)
            {
                b1.IsEnabled = false;
            }
            if (p1.Value > 0)
            {
               
                earn1.Content = earn + " $              " +p1.Value +" %";
            }
            else
            {
                earn1.Content = "";
            }
        }

        private void check2()
        {
            p2.Value = p2.Value + 1;
            int earn = (10 + (teller2 * 10)) * upprofit.profit2 * upprofit.profitAll;
            if (p2.Value >= 100)
            {
                p2.Value = 0;
                moneyInt = moneyInt + (10 + (teller2 * 10))*upprofit.profit2 * upprofit.profitAll;
                money.Content = moneyInt + " $";
                b2.IsEnabled = true;
                if (aclicker2 == 0)
                {
                    timer2.Stop();
                }
            }
            if (p2.Value > 0)
            {
                b2.IsEnabled = false;
            }
            if (p2.Value > 0)
            {
               
                earn2.Content = earn + " $              " + p2.Value +" %" ;
            }
            else
            {
                earn2.Content = "";
            }

        }

        private void check3()
        {
            p3.Value = p3.Value + 1;
            int earn = (100 + (teller3 * 100)) * upprofit.profit3 * upprofit.profitAll;
            if (p3.Value >= 100)
            {
                p3.Value = 0;
                moneyInt = moneyInt + (100 + (teller3 * 100)) * upprofit.profit3 * upprofit.profitAll;
                money.Content = moneyInt + " $";
                b3.IsEnabled = true;
                if (aclicker3 == 0)
                {
                    timer3.Stop();
                }
            }
            if (p3.Value > 0)
            {
                b3.IsEnabled = false;
            }
            if (p3.Value > 0)
            {
              
                earn3.Content = earn + " $            " + p3.Value +" %" ;
            }
            else
            {
                earn3.Content = "";
            }
        }

        private void check4()
        {
            p4.Value = p4.Value + 1;
            int earn = (1000 + (teller4 * 1000)) * upprofit.profit4 * upprofit.profitAll;
            if (p4.Value >= 100)
            {
                p4.Value = 0;
                moneyInt = moneyInt + (1000 + (teller4 * 1000)) * upprofit.profit4 * upprofit.profitAll;
                money.Content = moneyInt + " $";
                b4.IsEnabled = true;
                if (aclicker4 == 0)
                {
                    timer4.Stop();
                }


            }
            if (p4.Value > 0)
            {
                b4.IsEnabled = false;
            }
            if (p4.Value > 0)
            {
               
                earn4.Content = earn + " $          " + p4.Value +" %";
            }
            else
            {
                earn4.Content = "";
            }
        }

        private void check5()
        {
            p5.Value = p5.Value + 1;
            int earn = (10000 + (teller5 * 10000)) * upprofit.profit5 * upprofit.profitAll;
            if (p5.Value >= 100)
            {
                p5.Value = 0;
                moneyInt = moneyInt + (10000 + (teller5 * 10000)) * upprofit.profit5 * upprofit.profitAll;
                money.Content = moneyInt + " $";
                b5.IsEnabled = true;
                if (aclicker5 == 0)
                {
                    timer5.Stop();
                }
            }
            if (p5.Value > 0)
            {
                b5.IsEnabled = false;
            }
            if (p5.Value > 0)
            {

             
                earn5.Content = earn + " $         " + p5.Value +" %";
            }
            else
            {
                earn5.Content = "";
            }
        }

        private void check6()
        {
            p6.Value = p6.Value + 1;
            int earn = (100000 + (teller6 * 100000)) * upprofit.profit6 * upprofit.profitAll;
            if (p6.Value >= 100)
            {
                p6.Value = 0;
                moneyInt = moneyInt + (100000 + (teller6 * 100000)) * upprofit.profit6 * upprofit.profitAll;
                money.Content = moneyInt + " $";
                b6.IsEnabled = true;
                if (aclicker6 == 0)
                {
                    timer6.Stop();
                }
            }
            if (p6.Value > 0)
            {
                b6.IsEnabled = false;
            }
            if (p6.Value > 0)
            {
                
                earn6.Content = earn + " $       " + p6.Value +" %" ;
            }
            else
            {
                earn6.Content = "";
            }
        }

        private void check7()
        {
            p7.Value = p7.Value + 1;
            int earn = (1000000 + (teller7 * 1000000)) * upprofit.profit7 * upprofit.profitAll;
            if (p7.Value >= 100)
            {
                p7.Value = 0;
                moneyInt = moneyInt + (1000000 + (teller7 * 1000000)) * upprofit.profit7* upprofit.profitAll;
                money.Content = moneyInt + " $";
                b7.IsEnabled = true;
                if (aclicker7 == 0)
                {
                    timer7.Stop();
                }
            }
            if (p7.Value > 0)
            {
                b7.IsEnabled = false;
            }
            if (p7.Value > 0)
            {
                

                earn7.Content = earn + " $    " + p7.Value+ " % " ;
            }
            else
            {
                earn7.Content = "";
            }
        }



        private void startprogress1(object sender, RoutedEventArgs e)
        {
         
            timer.Start();
          
           timer.Interval = TimeSpan.FromMilliseconds(5 * upspeed.speed1 * upspeed.speedAll);

        }


        private void startprogress2(object sender, RoutedEventArgs e)
        {
            timer2.Start();
            timer2.Interval = TimeSpan.FromMilliseconds(30 * upspeed.speed2 * upspeed.speedAll);
        }

        private void startprogress3(object sender, RoutedEventArgs e)
        {
            timer3.Start();
            timer3.Interval = TimeSpan.FromMilliseconds(80 * upspeed.speed3 * upspeed.speedAll);
        }

        private void startprogress4(object sender, RoutedEventArgs e)
        {
            timer4.Start();
            timer4.Interval = TimeSpan.FromMilliseconds(200 * upspeed.speed4 * upspeed.speedAll);

        }

        private void startprogress5(object sender, RoutedEventArgs e)
        {
            timer5.Start();
            timer5.Interval = TimeSpan.FromMilliseconds(500 * upspeed.speed5 * upspeed.speedAll);
        }

        private void startprogress6(object sender, RoutedEventArgs e)
        {
            timer6.Start();
            timer6.Interval = TimeSpan.FromMilliseconds(1200 * upspeed.speed6 * upspeed.speedAll);
        }

        private void startprogress7(object sender, RoutedEventArgs e)
        {
            timer7.Start();
            timer7.Interval = TimeSpan.FromMilliseconds(2500 * upspeed.speed7 * upspeed.speedAll);
        }

        private void upgrade1(object sender, RoutedEventArgs e)
        {
            moneyInt = moneyInt - kost1;
            teller1++;
            b1.Content = teller1;

            kost1 = kost1 * 2;
            u1.Content = kost1 + " $";
            money.Content = moneyInt + " $";
        }

        private void upgrade2(object sender, RoutedEventArgs e)
        {
            teller2++;
            b2.Content = teller2;
            b2.IsEnabled = true;
            moneyInt = moneyInt - kost2;
            kost2 = kost2 * 2;
            u2.Content = kost2 + " $";
            money.Content = moneyInt + " $";
        }

        private void upgrade3(object sender, RoutedEventArgs e)
        {
            teller3++;
            b3.Content = teller3;
            b3.IsEnabled = true;
            moneyInt = moneyInt - kost3;
            kost3 = kost3 * 2;
            u3.Content = kost3 + " $";
            money.Content = moneyInt + " $";
        }

        private void upgrade4(object sender, RoutedEventArgs e)
        {
            teller4++;
            b4.Content = teller4;
            b4.IsEnabled = true;
            moneyInt = moneyInt - kost4;
            kost4 = kost4 * 2;
            u4.Content = kost4 + " $";
            money.Content = moneyInt + " $";
        }

        private void upgrade5(object sender, RoutedEventArgs e)
        {
            teller5++;
            b5.Content = teller5;
            b5.IsEnabled = true;
            moneyInt = moneyInt - kost5;
            kost5 = kost5 * 2;
            u5.Content = kost5 + " $";
            money.Content = moneyInt + " $";
        }

        private void upgrade6(object sender, RoutedEventArgs e)
        {
            teller6++;
            b6.Content = teller6;
            b6.IsEnabled = true;
            moneyInt = moneyInt - kost6;
            kost6 = kost6 * 2;
            u6.Content = kost6 + " $";
            money.Content = moneyInt + " $";
        }

        private void upgrade7(object sender, RoutedEventArgs e)
        {
            teller7++;
            b7.Content = teller7;
            b7.IsEnabled = true;
            moneyInt = moneyInt - kost7;
            kost7 = kost7 * 2;
            u7.Content = kost7 + " $";
            money.Content = moneyInt + " $";

        }

        private void setAuto1(object sender, RoutedEventArgs e)
        {
            aclicker1 = 1;
            auto1.IsEnabled = false;
            moneyInt = moneyInt - 2000;
            money.Content = moneyInt + " $";

        }

        private void setAuto2(object sender, RoutedEventArgs e)
        {
            aclicker2 = 1;
            auto2.IsEnabled = false;
            moneyInt = moneyInt - 20000;
            money.Content = moneyInt + " $";
        }

        private void setAuto3(object sender, RoutedEventArgs e)
        {
            aclicker3 = 1;
            auto3.IsEnabled = false;
            moneyInt = moneyInt - 200000;
            money.Content = moneyInt + " $";
        }

        private void setAuto4(object sender, RoutedEventArgs e)
        {
            aclicker4 = 1;
            auto4.IsEnabled = false;
            moneyInt = moneyInt - 2000000;
            money.Content = moneyInt + " $";
        }

        private void setAuto5(object sender, RoutedEventArgs e)
        {
            aclicker5 = 1;
            auto5.IsEnabled = false;
            moneyInt = moneyInt - 20000000;
            money.Content = moneyInt + " $";
        }

        private void setAuto6(object sender, RoutedEventArgs e)
        {
            aclicker6 = 1;
            auto6.IsEnabled = false;
            moneyInt = moneyInt - 200000000;
            money.Content = moneyInt + " $";
        }

        private void setAuto7(object sender, RoutedEventArgs e)
        {
            aclicker7 = 1;
            auto7.IsEnabled = false;
            moneyInt = moneyInt - 2000000000;
            money.Content = moneyInt + " $";
        }

        private void closeButton(object sender, RoutedEventArgs e)
        {
            Window1 close = new Window1();
            close.ShowDialog();
            //close.quittext.Content = "test qutee";
            if (close.test == 1)
            {
                upspeed.Close();
                upprofit.Close();
                this.Close();
            }
            else
            {
                close.test = 1;
            }

        }
        private void upgradebuttonspeed(object sender, RoutedEventArgs e)
        {
           
           
        upspeed.ShowDialog();
           // Window2 upspeed = new Window2();
        }

        private void upgradebuttonprofit(object sender, RoutedEventArgs e)
        {
           // Window3 upprofit = new Window3();

            upprofit.ShowDialog();
        }
      
    }
    
}
