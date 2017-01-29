using Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LolGuide
{
    class ImageChampionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string key = (string)value;
            Uri uri = new Uri($"http://ddragon.leagueoflegends.com/cdn/7.2.1/img/champion/{key}.png");
            return ImageSource.FromUri(uri);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
