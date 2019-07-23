using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace CommandLineDrawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindow mainwindow;
        public MainWindow()
        {
            InitializeComponent();
            commandTextBox.Focus();
        }

        private void commandTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return) // de gebruiker drukt op ENTER
            {
                ShapeFactory sh = new ShapeFactory;
                sh.testvorm();

                // doe hetgeen gevraagd is

            }
        }

        private void openFile(object sender, RoutedEventArgs e)
        {
            try
            {
                string destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                OpenFileDialog filedialog = new OpenFileDialog();
                filedialog.InitialDirectory = destination;
                filedialog.Filter = "Text files|*.txt|All files|*.*";
                if (filedialog.ShowDialog() == true)
                {
                    commandTextBox.Text = "";
                    StreamReader inputStream = File.OpenText(filedialog.FileName);
                    string line = inputStream.ReadLine();

                    while (line != null)
                    {

                        commandTextBox.AppendText(line + "\n");
                        line = inputStream.ReadLine();
                    }

                    inputStream.Close();
                }
            }
            catch (IllegalCommandException ex)
            {

                MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "bevat een fout: " + data[, 0] + "is een ongeldig commando");
            }
            catch (IllegalShapeException ex)
            {
                MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "bevat een fout: " + data[, 1] + "is een onbekende vorm");
            }
            catch (IllegalCommandException ex)
            {
                MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "bevat een fout: " + data[, 0] + "is een ongeldig commando");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Vormen.txt fout bij openen van bestand");
            }
        }
    
   
        private void saveFile(object sender, RoutedEventArgs e)
        {
            try
            {
                string destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                destination = System.IO.Path.Combine(destination, "Vormen.txt");



                StreamWriter outputStream = File.CreateText(destination);

                outputStream.WriteLine(commandTextBox.Text);
                outputStream.Close();
                
            }
            catch (SystemException ex)
            {
             
                MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Vormen.txt fout bij oplsaan/wegschrijven van bestand");
            }
        }
       

        

               private void sluitFile(object sender, RoutedEventArgs e)

        {

            mainwindow.Close();
        }
    }
}
