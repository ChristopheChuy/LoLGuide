﻿using System;
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
            main = new MasterPage();
            Master = main;
            Detail = new ChampionPage();
        }
    }
}
