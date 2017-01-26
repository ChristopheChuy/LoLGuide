using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoreViewModel
{
    public class SortViewModel : BindableObject
    {
        private Sort model { get;}
        /// <summary>
        /// Nom du sort
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Description du sort
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Image du sort
        /// </summary>
        public string Image { get; private set; }
        public SortViewModel(Sort sort)
        {
            model = sort;
            Nom = sort.Nom;
            Description = sort.Description;
            Image = sort.Image;
        }
    }
}
