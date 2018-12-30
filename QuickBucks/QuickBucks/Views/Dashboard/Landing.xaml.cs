using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuickBucks.Views.Dashboard
{
    public partial class Landing : ContentPage
    {
        public bool isOtherloanElementVisible { get; set; } = false;
        public Landing()
        {
            InitializeComponent();
        }

       async void PayDayLoan_Tapped(object sender, System.EventArgs e)
        {
            if (LoanElement2.IsVisible && LoanElement1.IsVisible )
            {
                LoanElement2.IsVisible = false;
                LoanElement3.IsVisible = false;
                await LoanElement1.TranslateTo(150, 450, 300, Easing.Linear);

                //await LoanElement1.ScaleTo(2, 300, Easing.Linear);

            }
            else
            {
                await LoanElement1.TranslateTo(1,1, 300, Easing.Linear);

                LoanElement2.IsVisible = true;
                LoanElement3.IsVisible = true;
                //await LoanElement1.ScaleTo(1, 300, Easing.Linear);

                //await LoanElement1.ScaleTo(1, 500, Easing.SinIn);

            }

        }
    }
}
