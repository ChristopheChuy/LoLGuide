using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoreViewModel
{
    /// <summary>
    /// View Model de la classe Sort
    /// </summary>
    public class SortViewModel : BindableObject
    {

        /// <summary>
        /// Model
        /// </summary>
        private Sort model { get;}

        /// <summary>
        /// Property Nom du sort
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Property Description du sort
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Property Image du sort
        /// </summary>
        public string Image { get; private set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="sort"> Model </param>
        public SortViewModel(Sort sort)
        {
            model = sort;
            Nom = sort.Nom;
            Description = sort.Description;
            Image = sort.Image;
        }
    }
}
