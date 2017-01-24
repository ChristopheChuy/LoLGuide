using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Xamarin.Forms;
using PersistanceXML;

namespace LolGuide
{
    public partial class ChampionPage : ContentPage
    {
        public Facade Facade { get; private set; }
       
        public ListView ListChampion { get { return listChampion; } }
        public ChampionPage()
        {
            InitializeComponent();
            Facade = new Facade(new ChargerChampionAPI(), new SauvegarderChampionXML());
            ChargementDonnee();
            List<string> list = new List<string> { "blaba", "ggg" };
           
            ListChampion.ItemSelected += OnItemSelected;
        }
        async void ChargementDonnee()
        {
            List<IChampion> listChampionCharge = await Facade.GetListChampion();
            ListChampion.ItemsSource = listChampionCharge;
        }
        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           await Navigation.PushAsync(new InfoChampion((String)((ListView)sender).SelectedItem));
        }
    }
}
