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
    public partial class OnBoardingPage : ContentPage
    {
        public OnBoardingPage()
        {
            InitializeComponent();
        }

        private  async void Button_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new LandingPage());
        }

       
    }
}