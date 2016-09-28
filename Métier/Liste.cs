using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier
{
    public class Liste : System.Collections.ObjectModel.ObservableCollection<Pays> // ?
    {
        public static List<Pays> listePays = new List<Pays>();

        public Liste()
            : base ()
        {
            Pays p1 = new Pays("France", "Liberté, égalité, fraternité", 58000000, 15848424, 154545, "Flamby", new Ville("Paris", 150, 150, 150), @"D:\Documents\IUT\C#\TP\Projet\Projet\Projet\Drapeaux\France.png", @"D:\Documents\IUT\C#\TP\Projet\Projet\Projet\Carte\France.png");
            Pays p2 = new Pays("Brésil", "Nique bien ta mère Jules", 1, 1, 1, "Aurélien le meilleur", new Ville("Aurélien's City", 1, 1, 999999999), @"D:\Documents\IUT\C#\TP\Projet\Projet\Projet\Drapeaux\Bresil.png", @"D:\Documents\IUT\C#\TP\Projet\Projet\Projet\Carte\Bresil.png");
            Pays p = new Pays("bonjour");
            Pays pa = new Pays("love");
            listePays.Add(p1);
            listePays.Add(p2);
            listePays.Add(p);
            listePays.Add(pa);
        }

    }
}
