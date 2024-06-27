using Gestão.Controllers;

namespace Gestão;

public partial class Dashboard: ContentPage
{
	public Dashboard()
	{
		InitializeComponent();
        CarregarMovimentos(false);
	}
    private async void CarregarMovimentos(bool cond)
    {
        if(!cond)
        {
          listaMovimentos.ItemsSource = await MovimentoController.todosMovimentos();
        }
        else
        {
          listaMovimentos.ItemsSource = await MovimentoController.todosMovimentos();
        }
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