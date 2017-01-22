using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LolGuide
{
    public partial class ChampionPage : ContentPage
    {
        public ListView ListChampion { get { return listChampion; } }
        public ChampionPage()
        {
            InitializeComponent();
            List<string> list = new List<string> { "blaba", "ggg" };
            ListChampion.ItemsSource = list;
        }
    }
}
