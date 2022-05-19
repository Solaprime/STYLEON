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
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void ForgetPassWord_Tapped(object sender, EventArgs e)
        {

        }

        private async void SignIn_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new AppShell());
            //await this.Navigation.PushAsync(new HomePage());
            //await this.Navigation.PushAsync(new FirstPage());
          //  await this.Navigation.PushAsync(new FavouritePage());
        }
    }
}