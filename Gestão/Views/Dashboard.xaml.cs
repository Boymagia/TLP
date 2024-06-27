namespace Gestão;

public partial class Dashboard: ContentPage
{
	public Dashboard()
	{
		InitializeComponent();
	}
    private async void OnStockClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}