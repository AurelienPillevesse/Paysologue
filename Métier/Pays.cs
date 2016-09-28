using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Métier 
{
    public class Pays : INotifyPropertyChanged
    {
        public string Nom
        {
            get
            {
                return mNom;
            }
            set
            {
                mNom = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Nom"));
                }
            }
        }
        private string mNom;

        public string Devise { get; set; }

        public int PopulationTot { get; set; }

        public int SuperficieTot { get; set; }

        public int PIB { get; set; }

        public string ChefEtat { get; set; }

        public Ville Capitale { get; set; }

        public string ImageDrap { get; set; }

        public string Image { get; set; }

        public ObservableCollection<Monument> monuItems 
        {
            get;
            set;
        }

        public Pays()
        {
            monuItems = new ObservableCollection<Monument>();
        }
        
        public Pays(string nom, string devise, int pop, int superficie, int pib, string chef, Ville cap, string imgDrap, string img, params Monument[] monus)
        {
            monuItems = new ObservableCollection<Monument>();
            foreach(Monument m in monus)
                 monuItems.Add(m);
            Nom = nom;
            Devise = devise;
            PopulationTot = pop;
            SuperficieTot = superficie;
            PIB = pib;
            ChefEtat = chef;
            Capitale = cap;
            ImageDrap = imgDrap;
            Image = img;
        }

        public override string ToString()
        {
            return Nom + " " + "(Habs : " + PopulationTot + ")";
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}