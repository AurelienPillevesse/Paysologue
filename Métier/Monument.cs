using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier
{
    public class Monument
    {
        public string Nom { get; set; }
        public string Image { get; set; }

        public Monument()
        {
        }

        public Monument(string nom, string img)
        {
            Nom = nom;
            Image = img;
        }
    }
}
