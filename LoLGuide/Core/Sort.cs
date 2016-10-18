using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Sort
    {

        public string Nom { get; private set; }

        public string Description { get; private set; }

        public Sort(string Nom, string Description)
        {
            this.Nom = Nom;
            this.Description = Description;
        }
        public override string ToString()
        {
            return $"Nom : { Nom}  : Description : { Description} ";
        }

    }
}
