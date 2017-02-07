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
        /// Attribut nom
        /// </summary>
        private string nom;

        /// <summary>
        /// Property Nom
        /// </summary>
        public string Nom
        {
            get { return nom; }
            set {
                model.Nom = value;
                nom = value;
                OnPropertyChanged("Nom");
            }
        }
        /// <summary>
        /// Attribut favori
        /// </summary>
        private bool favori;

        /// <summary>
        /// Property Favori
        /// </summary>
        public bool Favoris
        {
            get { return favori; }
            set
            {
                model.Favoris = value;
                favori = value;
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
        public int Id { get; }

        public ReadOnlyDictionary<BarreDeForce, Int32> BarresDeForce { get; }

        /// <summary>
        /// Property Histoire du champion
        /// </summary>
        public string Histoire { get; }

        /// <summary>
        /// Property Titre du champion
        /// </summary>
        public string Titre { get; }

        /// <summary>
        /// Property Image du champion
        /// </summary>
        public string Image { get; }

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
            Favoris = champion.Favoris;
            Nom = champion.Nom;
            BarresDeForce = new ReadOnlyDictionary<BarreDeForce, Int32>(champion.BarresDeForce);
            Id = champion.Id;
            Titre = champion.Titre;
            Image = champion.Image;
            Histoire = champion.Histoire;
            foreach(Sort sort in champion.Sorts)
            {
                SortViewModel sortVM = new SortViewModel(sort);
                Sorts.Add(sortVM);
            }
           
        }
    }
}
