using Microsoft.Maui.ApplicationModel.DataTransfer;

namespace Practico_n10.Pages;

public partial class VibracionPage : ContentPage
{
	public VibracionPage()
	{
		InitializeComponent();
	}

	private void OnVibrarClicked(object sender, EventArgs e)
	{
		try
		{
			Vibration.Vibrate(TimeSpan.FromMilliseconds(500));
			lblEstado.Text = "📳 ¡Vibró!";
		}
		catch (Exception ex)
		{
			lblEstado.Text = $"Error: {ex.Message}";
		}
	}

	private async void OnCopiarClicked(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(txtCopiar.Text))
		{
			await DisplayAlert("Error", "Escribí algo para copiar", "OK");
			return;
		}
		await Clipboard.SetTextAsync(txtCopiar.Text);
		lblEstado.Text = "📋 ¡Copiado al portapapeles!";
	}
}
