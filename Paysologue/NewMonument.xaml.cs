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
    public partial class NewMonument : Window
    {
        public NewMonument(Monument m)
        {
            InitializeComponent();
            DataContext = new NewMonumentViewModel(m);
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            if ((DataContext as NewMonumentViewModel).NewMonu.Nom != null)
                DialogResult = true;
            else
                MessageBox.Show("Veuillez remplir le nom du nouveau monument");
        }

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void ParcourirMonu_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as NewMonumentViewModel).Parcourir();
        }
    }
}
