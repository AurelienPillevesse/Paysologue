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
    public class Ville
    {
        public string Nom { get; set; }
        public int Habitant { get; set; }
        public int Superficie { get; set; }
        public int Densite { get; set; }
        

        public Ville()
        {
        }

        public Ville(string nom, int hab, int superficie, int dens)
        {
            Nom = nom;
            Habitant = hab;
            Superficie = superficie;
            Densite = dens;
        }
    }
}
