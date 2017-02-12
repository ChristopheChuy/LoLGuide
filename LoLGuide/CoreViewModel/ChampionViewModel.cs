using Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoreViewModel
{
   /// <summary>
   /// View Model de la classe Champion
   /// </summary>
   public class ChampionViewModel : BindableObject
    {
        /// <summary>
        /// Model de type IChampion
        /// </summary>
        private IChampion model { get; }
        
        /// <summary>
        /// Property Nom
        /// </summary>
        public string Nom
        {
            get { return model.Nom; }
            set {
                model.Nom = value;
                OnPropertyChanged("Nom");
            }
        }

        /// <summary>
        /// Property Favori
        /// </summary>
        public bool Favoris
        {
            get { return model.Favoris; }
            set
            {
                model.Favoris = value;
                OnPropertyChanged("Favoris");
            }
        }

        /// <summary>
        /// ObservableCollection de Tags
        /// </summary>
        public ObservableCollection<string> Tags { get; }

        /// <summary>
        /// Property Id identifiant le champion
        /// </summary>
        public int Id
        {
            get { return model.Id; }
        }

        public ReadOnlyDictionary<BarreDeForce, Int32> BarresDeForce { get; }

        /// <summary>
        /// Property Histoire du champion
        /// </summary>
        public string Histoire
        {
            get { return model.Histoire; }
        }

        /// <summary>
        /// Property Titre du champion
        /// </summary>
        public string Titre
        {
            get { return model.Titre; }
        }

        /// <summary>
        /// Property Image du champion
        /// </summary>
        public string Image
        {
            get { return model.Image; }
        }

        /// <summary>
        /// ObservableCollection de Sorts du Champion
        /// </summary>
        public ObservableCollection<SortViewModel> Sorts { get; }

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="champion"></param>
        public ChampionViewModel(IChampion champion)
        {
            Sorts = new ObservableCollection<SortViewModel>();
            model = champion;
            Tags = new ObservableCollection<string>(champion.Tags);
            BarresDeForce = new ReadOnlyDictionary<BarreDeForce, Int32>(champion.BarresDeForce);
            foreach(Sort sort in champion.Sorts)
            {
                SortViewModel sortVM = new SortViewModel(sort);
                Sorts.Add(sortVM);
            }
           
        }
    }
}
