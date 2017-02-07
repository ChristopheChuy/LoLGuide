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
            BindingContext = Facade;
            ChargementDonnee();
        }
      
        async void ChargementDonnee()
        {
            await Facade.GetListChampion();
        }
        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           await Navigation.PushAsync(new InfoChampion((ChampionViewModel)((ListView)sender).SelectedItem,Facade));
        }
    }
}
