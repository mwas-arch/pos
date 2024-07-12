namespace libre.Views;

public partial class PointofSale : ContentPage
{
	public PointofSale()
	{
		InitializeComponent();



		
	}
	private async void OnNavigateToMainPage(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());



	}
}