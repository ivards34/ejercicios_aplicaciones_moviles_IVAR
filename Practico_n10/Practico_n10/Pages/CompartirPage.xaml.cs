using Microsoft.Maui.ApplicationModel.DataTransfer;

namespace Practico_n10.Pages;

public partial class CompartirPage : ContentPage
{
	public CompartirPage()
	{
		InitializeComponent();
	}

	private async void OnCompartirClicked(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(txtMensaje.Text))
		{
			await DisplayAlert("Error", "Escribí algo para compartir", "OK");
			return;
		}
		await Share.RequestAsync(new ShareTextRequest
		{
			Text = txtMensaje.Text,
			Title = "Compartir mensaje"
		});
	}
}
