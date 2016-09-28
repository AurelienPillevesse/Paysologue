using Métier;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Paysologue
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private ObservableCollection<Pays> mListePays = new ObservableCollection<Pays>
        {
            new Pays("Allemagne", "Einigkeit und Recht und Freiheit", 80925000, 357340, 45888, "Joachim Gauck", 
                new Ville("Berlin", 3452911, 891, 3872), "Drapeau/Germany.png", "Carte/CarteGermany.png", 
                new Monument("Cathédrale de Cologne", "Monuments/CatedraleCologne.jpg")),
            new Pays("France", "Liberté, égalité, fraternité", 66917994, 675000, 40375, "François Hollande", 
                new Ville("Paris", 2240621, 105, 21258), "Drapeau/France.png", "Carte/France.png", 
                new Monument("Tour Eiffel", "Monuments/Tour Eiffel.jpg"), new Monument("Musée du Louvre", "Monuments/Louvre.jpg"),  new Monument("L'Arc de Triomphe", "Monuments/ArcDeTriomphe.jpg")),
            new Pays("Angleterre", "Aucune", 53012456, 130395, 50566, "Reine Élisabeth II", 
                new Ville("Londres", 8416535, 1572, 21258), "Drapeau/Angleterre.png", "Carte/CarteAngleterre.png", 
                new Monument("Big Ben", "Monuments/BigBen.jpg")),
            new Pays("Brésil", "Ordem e Progresso", 201032714, 8514876, 11208, "Dilma Rousseff",
                new Ville("Brasilia", 2562963, 5802, 442),"Drapeau/Bresil.png", "Carte/Bresil.png",
                new Monument("Christ Rédempteur","Monuments/Christ Rédempteur.jpg")),
            new Pays("Espagne", "Plus Ultra", 47265321, 505911, 32975, "Mariano Rajoy", 
                new Ville("Madrid", 3207247, 608, 5275), "Drapeau/Spain.png", "Carte/CarteSpain.png", 
                new Monument("Sagrada Familia", "Monuments/SagradaFamilia.jpg"))
        };

        public ICollectionView ListePays
        {
            get;
            set;
        }

        private Pays mCurrentPays;
        public Pays CurrentPays
        {
            get { return mCurrentPays; }
            set { mCurrentPays = value; OnPropertyChanged("CurrentPays"); }
        }

        private Monument mCurrentMonu;
        public Monument CurrentMonu
        {
            get { return mCurrentMonu; }
            set { mCurrentMonu = value; OnPropertyChanged("CurrentMonu"); }
        }

        private string mSearch;
        public string Search
        {
            get { return mSearch; }
            set { mSearch = value; OnPropertyChanged("Search"); Recherche(); }
        }

        public MainWindowViewModel()
        {
            mCurrentPays = mListePays[0];
            ListePays = CollectionViewSource.GetDefaultView(mListePays); 
        }

        public void AddPays()
        {
            Pays p = new Pays();
            Ville cap = new Ville();
            p.Capitale = cap;
            var window = new NewPays(p);
            window.ShowDialog();
            if (window.DialogResult == true)
            {
                mListePays.Add(p);
            }
        }

        public void RemovePays()
        {
            mListePays.Remove(mCurrentPays);
        }

        public void RemoveMonu()
        {
            mCurrentPays.monuItems.Remove(mCurrentMonu);
        }

        public void AddMonument()
        {
            Monument m = new Monument();
            var window = new NewMonument(m);
            window.ShowDialog();
            if (window.DialogResult == true)
            {
                mCurrentPays.monuItems.Add(m);
            }
        }

        public void Tri(object cbox)
        {
            string name = (cbox as ComboBoxItem).Name;
            string propertyName = "";
            System.ComponentModel.ListSortDirection sortDirection = System.ComponentModel.ListSortDirection.Ascending;

            if (name == "TriOrdreA")
            {
                propertyName = "Nom";
                sortDirection = System.ComponentModel.ListSortDirection.Ascending;
            }
            if (name == "TriOrdreZ")
            {
                propertyName = "Nom";
                sortDirection = System.ComponentModel.ListSortDirection.Descending;
            }
            if (name == "TriHabCroi")
            {
                propertyName = "PopulationTot";
                sortDirection = System.ComponentModel.ListSortDirection.Ascending;
            }
            if (name == "TriHabDecroi")
            {
                propertyName = "PopulationTot";
                sortDirection = System.ComponentModel.ListSortDirection.Descending;
            }
            ListePays.SortDescriptions.Clear();
            ListePays.SortDescriptions.Add(new System.ComponentModel.SortDescription(propertyName, sortDirection));
        }

        private bool UserFilter(object item)
        {
            if (string.IsNullOrEmpty(mSearch))
                return true;
            else
                return ((item as Pays).Nom.IndexOf(mSearch, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        public void Recherche()
        {
            ListePays.Filter = UserFilter;
            ListePays.Refresh();
        }
    }
}
