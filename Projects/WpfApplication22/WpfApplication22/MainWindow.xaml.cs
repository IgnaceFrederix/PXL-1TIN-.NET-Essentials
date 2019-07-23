using System;
using System.Collections;
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

namespace WpfApplication22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private IList list;
        private List<string> listOfStrings;

        public MainWindow()
        {
            InitializeComponent();
            listOfStrings = new List<string>();
            list = shoppingListBox.Items;

            string msg = String.Format("in de shopping list zitten {0} itemsen {1}", list.Count, "sam");
            MessageBox.Show(msg);
        }

        private void AddListItem(object sender, RoutedEventArgs e)
        {
            string itemtoAdd = inputText.Text;
            ListBoxItem item = new ListBoxItem();
            item.Content = itemtoAdd;
            list.Add(item);
        }

        private void Displaytest(object sender, RoutedEventArgs e)
        {
            int idx = Convert.ToInt32(inputText.Text);
            ListBoxItem item = (ListBoxItem) list[idx];
            displaylabel.Content = item.Content;
        }

        private void DeleteListItem(object sender, RoutedEventArgs e)
        {
            int idx = Convert.ToInt32(inputText.Text);
            list.RemoveAt(idx);
        }
    }
}
