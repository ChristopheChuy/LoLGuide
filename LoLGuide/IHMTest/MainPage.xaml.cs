using Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IHMTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Facade  Facade { get; private set; }

        public MainPage()
        {
            this.InitializeComponent();
            
        }

        async private void Button_Click(object sender, RoutedEventArgs e)
        {
            Facade = new Facade(new ChargerChampionAPI());
            List<IChampion> listChampions = await Facade.GetListChampion();

            Debug.WriteLine(listChampions);
            tb.Text = listChampions.Select(c => c.Nom).Aggregate(String.Empty, (chaine, s) => chaine + $"{s} ");
        }
    }
}
