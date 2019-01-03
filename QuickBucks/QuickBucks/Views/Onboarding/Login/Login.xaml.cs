using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace QuickBucks.Views.Onboarding.Login
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //Navigation.PushAsync(new MainPage());
           //Application.Current.MainPage.Navigation.PushAsync(new MainPage());
          Application.Current.MainPage = (new MainPage());


        }
    }
}
