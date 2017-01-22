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
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contacts",
                IconSource = "",
                TargetType = typeof(ChampionPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "TodoList",
                IconSource = "images/",
                TargetType = typeof(RechercheInvocateur)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Reminders",
                IconSource = "list.jpg",
                TargetType = typeof(ChampionPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Reminders",
                IconSource = "",
                TargetType = typeof(InfoChampion)
            });


            ListView.ItemsSource = masterPageItems;
        }
    }
}

