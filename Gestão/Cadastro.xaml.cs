namespace Gestão;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();


	}
    private async void OnDashboardClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Dashboard());
    }
}