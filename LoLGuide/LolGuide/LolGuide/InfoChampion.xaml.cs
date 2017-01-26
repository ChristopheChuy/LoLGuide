using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Xamarin.Forms;
using CoreViewModel;

namespace LolGuide
{
    public partial class InfoChampion : ContentPage
    {
        private ChampionViewModel Champion;

        public InfoChampion(ChampionViewModel champion)
        {
            InitializeComponent();
            this.Champion = champion;
            BindingContext = champion;
        }
    }
}
