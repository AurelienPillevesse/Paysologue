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
using System.Windows.Shapes;
using Métier;

namespace Paysologue
{
    public partial class NewPays : Window
    {
        public string nom;

        public NewPays(Pays p)
        {
            InitializeComponent();
            DataContext = new NewPaysViewModel(p);
        }

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            int a;
            if ((DataContext as NewPaysViewModel).NewPays.Nom != null && int.TryParse((DataContext as NewPaysViewModel).NewPays.PopulationTot.ToString(), out a) && (DataContext as NewPaysViewModel).NewPays.Capitale.Nom != null && int.TryParse((DataContext as NewPaysViewModel).NewPays.Capitale.Habitant.ToString(), out a) && (DataContext as NewPaysViewModel).NewPays.ChefEtat != null && (DataContext as NewPaysViewModel).NewPays.PopulationTot != 0 && (DataContext as NewPaysViewModel).NewPays.Capitale.Habitant != 0)
                DialogResult = true;
            else
                MessageBox.Show("Veuillez remplir tous les champs obligatoires");
        }

        private void Parcourir_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as NewPaysViewModel).Parcourir((sender as Button).Name);
        }
    }
}
