using Microsoft.Maui.Controls;
namespace Gestão
{
    

    
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();
            }
        private async void OnDashboardClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dashboard());
        }

        private async void OnStockClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private void OnLogoutClicked(object sender, EventArgs e)
            {
                DisplayAlert("Logout", "You have been logged out.", "OK");
            }
            private void OnCategoriaClicked(object sender, EventArgs e)
            {
                DisplayAlert("Categoria", "Categoria button clicked.", "OK");
            }

            private void OnDataClicked(object sender, EventArgs e)
            {
                DisplayAlert("Data", "Data button clicked.", "OK");
            }

            private void OnTipoClicked(object sender, EventArgs e)
            {
                DisplayAlert("Tipo", "Tipo button clicked.", "OK");
            }
            private void OnSearchCompleted(object sender, EventArgs e)
            {
                var searchEntry = sender as Entry;
                DisplayAlert("Search", $"Search for: {searchEntry.Text}", "OK");
            }
            private void OnTimeZoneClicked(object sender, EventArgs e)
            {
                DisplayAlert("Time Zone", "Time Zone button clicked.", "OK");
            }
            private void OnUserClicked(object sender, EventArgs e)
            {
                DisplayAlert("User", "User button clicked.", "OK");
            }
            private void OnPlusClicked(object sender, EventArgs e)
            {
                DisplayAlert("Add", "+ button clicked.", "OK");
            }
        }
    }

