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
            MainPage = new AppShell();
            //MainPage = new NavigationPage(new OnBoardingPage());

            //MainPage = new TestPage();
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
