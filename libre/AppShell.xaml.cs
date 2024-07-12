using libre.Views;

namespace libre
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			// Register the LoadingPage route
			Routing.RegisterRoute(nameof(Views.LoadingPage), typeof(Views.LoadingPage));
			Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
			//Routing.RegisterRoute(nameof(), typeof());
		}
	}
}
