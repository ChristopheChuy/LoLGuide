using Core;
using PersistanceXML;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreViewModel
{
   
    public class FacadeViewModel
    {
        private Facade FacadeModel { get; }
        public ObservableCollection<ChampionViewModel> listFavori;
        public  ObservableCollection<ChampionViewModel> listChampionViewModel;
        public FacadeViewModel() {
            FacadeModel = new Facade(new ChargerChampionAPI(), new SauvegarderChampionXML());
            listFavori = new ObservableCollection<ChampionViewModel>();
        }
        /// <summary>
        /// Récupère la liste des champions à partir de du Model
        /// </summary>
        /// <returns> Task liste de IChampion </returns>
        async public Task<ObservableCollection<ChampionViewModel>> GetListChampion()
        {
            listChampionViewModel = new ObservableCollection<ChampionViewModel>();
            List<IChampion> listChampion = await FacadeModel.GetListChampion();
            foreach(IChampion champion in listChampion)
            {
                ChampionViewModel championVM = new ChampionViewModel(champion);
                listChampionViewModel.Add(championVM);
            }
            Debug.WriteLine(listChampionViewModel);
            return listChampionViewModel;
        }
        public void addChampionFavori(ChampionViewModel championVM)
        {
            listFavori.Add(championVM);
            championVM.Favoris = true;
        }
        public void deleteChampionFavori(ChampionViewModel championVM)
        {
            championVM.Favoris = false;
            listFavori.Remove(championVM);
        }
    }
}
