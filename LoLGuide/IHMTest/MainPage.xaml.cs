using Core;
using PersistanceXML;
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
        public List<IChampion> ListChampion { get; private set; }
        public MainPage()
        {
            this.InitializeComponent();
            Facade = new Facade(new ChargerChampionAPI(),new SauvegarderChampionXML());
        }

        /// <summary>
        /// Evenement lors du clic sur le boutton "clic"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            List<IChampion> listChampions = await Facade.GetListChampion();
            ListChampion = listChampions;
            Debug.WriteLine(listChampions);
            tb.Text = listChampions.Select(c => c.Nom).Aggregate(String.Empty, (chaine, s) => chaine + $"{s} ");
        }

        /// <summary>
        /// Evenement lors du clic sur le boutton "suavegarde"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSauvegarde(object sender, RoutedEventArgs e)
        {
            Facade.SauvergarderChampion(ListChampion);
        }
    }
}
