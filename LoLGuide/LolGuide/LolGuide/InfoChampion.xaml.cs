using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CoreViewModel;

namespace LolGuide
{
    public partial class InfoChampion : TabbedPage
    {
        private ChampionViewModel Champion;
        public FacadeViewModel Facade { get; private set; }
        private Switch FavoriSwitch { get { return favoriSwitch; } }

        public InfoChampion(ChampionViewModel champion, FacadeViewModel facade)
        {
            InitializeComponent();
            Facade = facade;
            this.Champion = champion;
            BindingContext = champion;
            FavoriSwitch.Toggled += ChangementFavori;
        }

        void ChangementFavori(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                Facade.addChampionFavori(Champion);
            }else
            {
                Facade.deleteChampionFavori(Champion);
            }
        }
    }
}
