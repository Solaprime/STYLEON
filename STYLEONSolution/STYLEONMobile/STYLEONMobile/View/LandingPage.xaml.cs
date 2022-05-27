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
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private async void SignInButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AppShell();
            //await this.Navigation.PopToRootAsync(true);
            //await this.Navigation.PopToRootAsync();
            //await this.Navigation.PushAsync(new Page1());
            //await this.Navigation.PushAsync(new TestPage());
            //await this.Navigation.PushAsync(new FirstPage());
            //  await this.Navigation.PushAsync(new FavouritePage());
        }

        private  async void SignUP_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new CreateAccountPage());
        }

        private void FaceBookButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}