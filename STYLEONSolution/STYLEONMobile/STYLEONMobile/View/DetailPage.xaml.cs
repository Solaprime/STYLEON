using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STYLEONMobile.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STYLEONMobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public Clothe SelectedClothe { get; set; }
        public DetailPage( Clothe clothe)
        {
            InitializeComponent();
            SelectedClothe = clothe;
        }
    }
}