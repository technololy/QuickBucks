using Walkthrough.Views.Walkthrough;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Walkthrough.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WalkthroughView : ContentPage
	{
		private View[] _views;

		public WalkthroughView()
		{
			InitializeComponent();

			_views = new View[]
			{
                new BikingCoolView(),


                new BikingHardView(),
				new AcrobaticsView(),
				new SoExcitedView()
			};

			Carousel.ItemsSource = _views;
		}


		private void OnCarouselPositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
		{
			var currentView = _views[e.NewValue];

			if (currentView is IAnimatedView animatedView)
			{
				animatedView.StartAnimation();
			}
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new QuickBucks.Views.Onboarding.Login.Login());
        }
    }
}