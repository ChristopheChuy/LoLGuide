using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CustomViewApp
{
    public partial class SortCell : ViewCell
    {
        public SortCell()
        {
            InitializeComponent();
        }
        public static readonly BindableProperty DescriptionProperty =
    BindableProperty.Create("Description", typeof(string), typeof(SortCell), "");

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }
        public static readonly BindableProperty NomProperty =
                BindableProperty.Create("Nom", typeof(string), typeof(SortCell), "");

        public string Nom
        {
            get { return (string)GetValue(NomProperty); }
            set { SetValue(NomProperty, value); }
        }
        public static readonly BindableProperty ImageProperty =
              BindableProperty.Create("Image", typeof(string), typeof(SortCell), "");

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
    }
}
