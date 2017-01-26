using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PersistanceXML;
using CoreViewModel;
using System.Collections.ObjectModel;

namespace LolGuide
{
    public partial class ChampionPage : ContentPage
    {
        public FacadeViewModel Facade { get; private set; }
       
        public ListView ListChampion { get { return listChampion; } }
        public ChampionPage()
        {
            InitializeComponent();
            Facade = new FacadeViewModel();
            ChargementDonnee();
            ListChampion.ItemSelected += OnItemSelected;
        }
        async void ChargementDonnee()
        {
            ObservableCollection<ChampionViewModel> listChampionCharge = await Facade.GetListChampion();
            ListChampion.ItemsSource = listChampionCharge;
        }
        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           await Navigation.PushAsync(new InfoChampion((ChampionViewModel)((ListView)sender).SelectedItem));
        }
    }
}
