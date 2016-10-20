using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Sort
    {

        /// <summary>
        /// Nom du sort
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Description du sort
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Constructeur du sort
        /// </summary>
        /// <param name="Nom"></param>
        /// <param name="Description"></param>
        public Sort(string Nom, string Description)
        {
            this.Nom = Nom;
            this.Description = Description;
        }

        /// <summary>
        /// Réécriture de la méthode ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Nom : { Nom}  : Description : { Description} ";
        }

    }
}
