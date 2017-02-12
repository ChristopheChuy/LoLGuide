using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lib
{
    public class ImageSortConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imageSort = (string)value;
            Uri uri = new Uri($"http://ddragon.leagueoflegends.com/cdn/7.2.1/img/spell/{imageSort}");
            return ImageSource.FromUri(uri);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
