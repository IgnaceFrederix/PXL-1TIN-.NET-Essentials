using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource invoiceViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("invoiceViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // invoiceViewSource.Source = [generic data source]

            _db = new PayablesDataContext();

            //var verdors = from vendor in _db.Vendors select vendor;
            IEnumerable<Vendor> vendors = _db.Vendors.ToList();

            vendorIDTextBox.ItemsSource = vendors;
            vendorIDTextBox.DisplayMemberPath = "name";
            vendorIDTextBox.SelectedValuePath = "vendorID";
            System.Windows.Data.CollectionViewSource vendorViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vendorViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // vendorViewSource.Source = [generic data source]
        }
    }
}
