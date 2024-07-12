using libre.Views;

namespace libre
{
	public partial class MainPage : ContentPage
	{
		

		public MainPage()
		{
			InitializeComponent();

		}

		private async void OnNavigateToLoadingPageClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new LoadingPage());

			
		}


	}

}
