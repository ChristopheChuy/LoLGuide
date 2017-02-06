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
   public class ChampionViewModel : BindableObject
    {
        private IChampion model { get; }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set {
                model.Nom = value;
                nom = value;
                OnPropertyChanged("Nom");
            }
        }
        private bool favori;
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
        public  List<string> Tags { get; }
        public int Id { get; }
        public ReadOnlyDictionary<BarreDeForce, Int32> BarresDeForce { get; }
        public string Histoire { get; }
        public string Titre { get; }
        public string Image { get; }
        public ObservableCollection<SortViewModel> Sorts { get; }

        public ChampionViewModel(IChampion champion)
        {
            Sorts = new ObservableCollection<SortViewModel>();
            model = champion;
            Tags = champion.Tags;
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
