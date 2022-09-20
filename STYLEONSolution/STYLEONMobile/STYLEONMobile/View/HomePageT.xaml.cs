using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STYLEONMobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageT : ContentPage
    {
        public HomePageT()
        {
            InitializeComponent();
        }

        private  async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //await this.Navigation.PushAsync(new DetailPage());

        }

        private async  void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //await this.Navigation.PushAsync(new SignInPage());
            Application.Current.MainPage = new SignInPage();
        }
    }
}