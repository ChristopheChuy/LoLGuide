using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CoreViewModel;
using System.Collections.ObjectModel;

namespace LolGuide
{
    public partial class ChampionPage : ContentPage
    {
        public FacadeViewModel Facade { get; private set; }
       public Button ChoixList { get { return choixList; } }
        public ListView ListChampion { get { return listChampion; } }
        public ChampionPage()
        {
            InitializeComponent();
            Facade = new FacadeViewModel();
            ChargementDonnee();
            ListChampion.ItemSelected += OnItemSelected;
            ChoixList.Clicked += ChoixListEvent;
            SearchChampion.SearchCommand = new Command(() => { ListChampion.ItemsSource = Facade.listChampionViewModel.Where(championVM => championVM.Nom.ToLower().Contains(SearchChampion.Text.ToLower())); });

        }
        async void ChargementDonnee()
        {
            ObservableCollection<ChampionViewModel> listChampionCharge = await Facade.GetListChampion();
            ListChampion.ItemsSource = listChampionCharge;
        }
        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           await Navigation.PushAsync(new InfoChampion((ChampionViewModel)((ListView)sender).SelectedItem,Facade));
        }
        public void ChoixListEvent(object sender, EventArgs e)
        {
            if (ChoixList.Text.Equals("Liste des champions"))
            {
                ChoixList.Text = "Favori";
                ListChampion.ItemsSource = Facade.listChampionViewModel;

            }
            else
            {
                if(ChoixList.Text.Equals("Favori"))
                {
                    ListChampion.ItemsSource = Facade.listFavori;
                    ChoixList.Text = "Liste des champions";
                }
            }

        }
    }
}
