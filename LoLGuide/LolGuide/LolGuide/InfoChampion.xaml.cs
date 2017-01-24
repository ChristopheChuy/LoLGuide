using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Xamarin.Forms;

namespace LolGuide
{
    public partial class InfoChampion : ContentPage
    {
        private IChampion Champion;

        public InfoChampion(IChampion champion)
        {
            InitializeComponent();
            this.Champion = champion;
            BindingContext = champion;
        }
    }
}
