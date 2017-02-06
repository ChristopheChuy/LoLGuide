using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CoreViewModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace LolGuide
{
    public partial class ChampionPage : ContentPage
    {
        public FacadeViewModel Facade { get; private set; }
        public ChampionPage()
        {
            InitializeComponent();
            Facade = new FacadeViewModel();
            
            listChampion.IsPullToRefreshEnabled = true;
            listChampion.RefreshCommand = new Command(() => { ChargementDonnee();  });
            listChampion.BeginRefresh(); 
            listChampion.ItemSelected += OnItemSelected;
            choixList.Clicked += ChoixListEvent;
            SearchChampion.SearchCommand = new Command(() => { listChampion.ItemsSource = Facade.listChampionViewModel.Where(championVM => championVM.Nom.ToLower().Contains(SearchChampion.Text.ToLower())); });

        }

      
        async void ChargementDonnee()
        {
            listChampion.ItemsSource = await Facade.GetListChampion();
            listChampion.EndRefresh();
        }
        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           await Navigation.PushAsync(new InfoChampion((ChampionViewModel)((ListView)sender).SelectedItem,Facade));
        }
        public void ChoixListEvent(object sender, EventArgs e)
        {
            if (choixList.Text.Equals("Liste des champions"))
            {
                choixList.Text = "Favori";
                listChampion.ItemsSource = Facade.listChampionViewModel;

            }
            else
            {
                if(choixList.Text.Equals("Favori"))
                {
                    listChampion.ItemsSource = Facade.listFavori;
                    choixList.Text = "Liste des champions";
                }
            }

        }
    }
}
