using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QuickBucks.Views;
using QuickBucks.Views.Dashboard;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace QuickBucks
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            //MainPage = new NavigationPage(new Views.Onboarding.Login.Login());
            MainPage = new NavigationPage(new Walkthrough.Views.WalkthroughView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
