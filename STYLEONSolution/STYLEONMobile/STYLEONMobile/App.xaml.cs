using STYLEONMobile.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STYLEONMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new HomePage();
            //MainPage = new AppShell();
            //MainPage = new Page1();
            MainPage = new NavigationPage(new OnBoardingPage());
            //MainPage = new Page1();
            //MainPage = new TestPage();
            //MainPage = new VerificationPage();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
