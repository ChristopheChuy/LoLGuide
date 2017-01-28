using Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoreViewModel
{
   public class ChampionViewModel : BindableObject
    {
        private IChampion model { get; }
        public string Nom { get; }

        public int Id { get; }

        public string Histoire { get; }
        public string Titre { get; }
        public string Image { get; }
        public ObservableCollection<SortViewModel> Sorts { get; }

        public ChampionViewModel(IChampion champion)
        {
            Sorts = new ObservableCollection<SortViewModel>();
            model = champion;
            Nom = champion.Nom;
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
