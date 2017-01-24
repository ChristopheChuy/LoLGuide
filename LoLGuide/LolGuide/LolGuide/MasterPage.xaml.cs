using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LolGuide
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }
        

        public MasterPage()
        {
            InitializeComponent();

            List<MasterPageItem> masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem{
                Title = "Liste des champions",
                TargetType = typeof(ChampionPage)
            });
            ListView.ItemsSource = masterPageItems;
        }
    }
}

