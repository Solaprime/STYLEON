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
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private  async void OnLabel_Tapped(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new SignInPage());
        }

        private async void SignUpButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new VerificationPage());
        }
    }
}