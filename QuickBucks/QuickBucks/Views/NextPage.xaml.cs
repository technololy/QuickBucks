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
    public partial class NextPage : ContentPage
    {
        public NextPage()
        {
            InitializeComponent();
            //mtStack.TranslateTo(0, 0);

            myBtn2.IsVisible = false;
            myBtn3.IsVisible = false;
            Balance.IsVisible = false;
             mtStack.TranslateTo(0, 50, 1000, Easing.SinInOut);
        }

        private void MyBtn1_Clicked(object sender, EventArgs e)
        {
            myBtn2.Opacity = 0;
            myBtn2.IsVisible = true;
            myBtn2.FadeTo(1, 500, Easing.SinIn);
        }

        private void MyBtn2_Clicked(object sender, EventArgs e)
        {

        }

        private void MyBtn3_Clicked(object sender, EventArgs e)
        {

        }

        private void Checkbox_IsCheckedChanged(object sender, TappedEventArgs e)
        {
            if (savingsChkBox.IsChecked)
            {
                myBtn2.Opacity = 0;

                Balance.IsVisible = true;

              
                Balance.FadeTo(1, 500, Easing.SinIn);
            }
            else
            {
                Balance.IsVisible = false;

            }
     
        }
    }
}