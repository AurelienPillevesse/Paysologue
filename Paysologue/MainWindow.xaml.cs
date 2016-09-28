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
using Métier;

namespace Paysologue
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowViewModel();
            InitializeComponent();
        }

        private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            (DataContext as MainWindowViewModel).Recherche();
        }

        private void AddMonu_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).AddMonument();
        }

        private void AddPays_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).AddPays();
        }

        private void RemovePays_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).RemovePays();
        }

        private void TriOrdre_Selected(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).Tri(sender);
        }

        private void RemoveMonu_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).RemoveMonu();
        }
    }
}
