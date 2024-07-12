namespace libre.Views;

public partial class LoadingPage : ContentPage
{
	public LoadingPage()
	{
		InitializeComponent();
	}

		 protected override async void OnAppearing()
	{
		base.OnAppearing();

		// Wait for 2 seconds
		await Task.Delay(2000);

		// Navigate to PointOfSalePage
		await Navigation.PushAsync(new PointofSale());
	}
}
