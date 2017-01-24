using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LolGuide
{
    public partial class MainPage : MasterDetailPage
    {
        MasterPage main;
        public MainPage()
        {
            IsGestureEnabled = true;
            MasterBehavior = MasterBehavior.Popover;
            main = new MasterPage();
            Master = main;
            Detail = new NavigationPage(new ChampionPage());
            main.ListView.ItemSelected += OnItemSelected;
        }
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                main.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
