using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Lib
{
    public partial class SortViewCell : ViewCell
    {
        public SortViewCell()
        {
            InitializeComponent();
        }
    
    public static readonly BindableProperty DescriptionProperty =
        BindableProperty.Create("Description", typeof(string), typeof(SortViewCell), "Description");

    public string Description
    {
        get { return (string)GetValue(DescriptionProperty); }
        set { SetValue(DescriptionProperty, value); }
    }
    public static readonly BindableProperty BobProperty =
            BindableProperty.Create("Bob", typeof(string), typeof(SortViewCell), "Nom");

        public string Bob
        {
            get { return (string)GetValue(BobProperty); }
            set { SetValue(BobProperty, value);  }
        }
        //public static readonly BindableProperty ImageProperty =
        //    BindableProperty.Create("Image", typeof(string), typeof(SortViewCell), "Image");

        //public string Image
        //{
        //    get { return (string)GetValue(ImageProperty); }
        //    set { SetValue(ImageProperty, value); }
        //}
    }
}
