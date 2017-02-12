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
        public string Nom
        {
            get { return model.Nom; }
            
        }

        /// <summary>
        /// Property Description du sort
        /// </summary>
        public string Description
        {
            get { return model.Description; }
           
        }

        /// <summary>
        /// Property Image du sort
        /// </summary>
        public string Image
        {
            get { return model.Image; }
          
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="sort"> Model </param>
        public SortViewModel(Sort sort)
        {
            model = sort;
        }
    }
}
