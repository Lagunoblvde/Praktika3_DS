using System;
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
using Praktika3_DS.Prsktika3_DSDataSetTableAdapters;

namespace Praktika3_DS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientsTableAdapter Clients = new ClientsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            Full_Tablica.ItemsSource = Clients.GetData();
        }
    }
}
