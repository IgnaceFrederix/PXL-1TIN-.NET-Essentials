using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace vooorbeeldexamenadv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            name = "test";
        }

        private void testFunctie(object sender, RoutedEventArgs e)
        {
            Connection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
            List<State> stateList = new List<State>();
            While(reader.Read()) {
            State state = new State();
            state.StateCode = reader[“StateCode”].ToString();
            state.StateName = reader[‘StateName”].ToString(); stateList.add(state);
            }
            reader.close();
        }
    }
}
