using Core;
using PersistanceXML;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CoreViewModel
{
    /// <summary>
    /// View Model de la classe Facade
    /// </summary>
    public class FacadeViewModel : BindableObject
    {
        /// <summary>
        /// Model
        /// </summary>
        private Facade FacadeModel { get; }

        /// <summary>
        /// ObservableCollection des champions favoris
        /// </summary>
        public ObservableCollection<ChampionViewModel> listFavori;

        /// <summary>
        /// ObservableCollection de ChampionViewModel
        /// </summary>
        public ObservableCollection<ChampionViewModel> listChampionViewModel;

        /// <summary>
        /// ObservableCollection des champions affichés
        /// </summary>
        private ObservableCollection<ChampionViewModel> listChampionAffiche;

        /// <summary>
        /// Attribut loadig permettant d'afficher le sablier
        /// </summary>
        private bool loading;

        /// <summary>
        /// Property Loading
        /// </summary>
        public bool Loading
        {
            get { return loading; }
            set { loading = value; OnPropertyChanged("Loading"); }
        }

        /// <summary>
        /// Property ListChampionAffiche
        /// </summary>
        public ObservableCollection<ChampionViewModel> ListChampionAffiche
        {
            get { return listChampionAffiche; }
            set { listChampionAffiche = value; OnPropertyChanged("ListChampionAffiche"); }
        }

        /// <summary>
        /// Property BoutonIntitule
        /// </summary>
        public string BoutonIntitule
        {
            get { return boutonIntitule; }
            set
            {
                boutonIntitule = value;
                OnPropertyChanged("BoutonIntitule");
            }
        }

        /// <summary>
        /// Attribut boutonIntitule permettant de passer de la liste des champions à la liste des favoris
        /// </summary>
        private string boutonIntitule;

        /// <summary>
        /// Property ICommand permettant de choisir quelle liste doit être affichée
        /// </summary>
        public ICommand ChoixListEvent { protected set; get; }

        /// <summary>
        /// Property ICommand permettant de recharger la liste de champion
        /// </summary>
        public ICommand GetListChampionCommand { protected set; get; }

        /// <summary>
        /// Property ICommand permettant de rechercher un champion par son nom
        /// </summary>
        public ICommand Search { protected set; get; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public FacadeViewModel() {
            ChoixListEvent = new Command(() => {
                Debug.WriteLine("Button");
                if (boutonIntitule.Equals("Champions"))
                {
                    BoutonIntitule = "Favori";
                    ListChampionAffiche = listChampionViewModel;
                }
                else
                {
                    if (boutonIntitule.Equals("Favori"))
                    {
                        ListChampionAffiche = listFavori;
                        BoutonIntitule = "Champions";
                    }
                }
            });
            GetListChampionCommand = new Command(() => { GetListChampion(); BoutonIntitule = "Favori"; });
            Search = new Command(text => { ListChampionAffiche = new ObservableCollection<ChampionViewModel>(ListChampionAffiche.Where(championVM => championVM.Nom.ToLower().Contains(((string)text).ToLower()))); });
            BoutonIntitule = "Favori";
            FacadeModel = new Facade(new ChargerChampionAPI(), new SauvegarderChampionXML());
            listFavori = new ObservableCollection<ChampionViewModel>();
            listChampionViewModel = new ObservableCollection<ChampionViewModel>();
        }

        /// <summary>
        /// Récupère la liste des champions à partir du Model
        /// </summary>
        /// <returns> Task liste de IChampion </returns>
        async public Task<ObservableCollection<ChampionViewModel>> GetListChampion()
        {
            Loading = true;
            listChampionViewModel = new ObservableCollection<ChampionViewModel>();
            listFavori.Clear();
            List<IChampion> listChampion = await FacadeModel.GetListChampion();
            foreach(IChampion champion in listChampion)
            {
                ChampionViewModel championVM = new ChampionViewModel(champion);
                listChampionViewModel.Add(championVM);
            }
            ListChampionAffiche = listChampionViewModel;
            Loading = false;
            return listChampionViewModel;
        }

        /// <summary>
        /// Ajoute un ChampionViewModel à la liste de champions favoris
        /// </summary>
        /// <param name="championVM"> ChampionViewModel à ajouter </param>
        public void addChampionFavori(ChampionViewModel championVM)
        {
            listFavori.Add(championVM);
        }

        /// <summary>
        /// Supprime un ChampionViewModel de la liste de champions favoris
        /// </summary>
        /// <param name="championVM"> ChampionViewModel à supprimer </param>
        public void deleteChampionFavori(ChampionViewModel championVM)
        {
            listFavori.Remove(championVM);
        }

    }
}
