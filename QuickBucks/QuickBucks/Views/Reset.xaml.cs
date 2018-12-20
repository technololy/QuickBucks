using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickBucks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reset : ContentPage
    {
        public Reset()
        {
            InitializeComponent();
            //ViewExtensions.CancelAnimations(myStack);
     
        }


        protected async override void OnAppearing()
        {
            await myBtn.ScaleTo(0, 0);

            await myStack.TranslateTo(-100, 0, 0, Easing.SinInOut);
            await myStack.TranslateTo(0, 0, 1000, Easing.SinInOut);
            await myBtn.ScaleTo(1, 500, Easing.BounceOut);
            //await  myStack.TranslateTo(0, -150,0);         

            // await myStack.TranslateTo(0, 0, 1000, Easing.SinInOut);
            base.OnAppearing(); 
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            myBtn.Text = "";
            await myBtn.ScaleTo(500, 5, Easing.SinIn);
            await Navigation.PushAsync(new NextPage());
            myBtn.Text = "Test Animation";
        }
    }
}