using Microsoft.Maui.Media;

namespace Practico_n10.Pages;

public partial class FotoPage : ContentPage
{
	public FotoPage()
	{
		InitializeComponent();
	}

	private async void OnSacarFotoClicked(object sender, EventArgs e)
	{
		try
		{
			if (!MediaPicker.IsCaptureSupported)
			{
				await DisplayAlert("Error", "Este dispositivo no tiene cámara", "OK");
				return;
			}
			var photo = await MediaPicker.CapturePhotoAsync();
			if (photo != null)
				imgFoto.Source = ImageSource.FromFile(photo.FullPath);
		}
		catch (Exception ex)
		{
			await DisplayAlert("Error", ex.Message, "OK");
		}
	}

	private async void OnElegirGaleriaClicked(object sender, EventArgs e)
	{
		try
		{
			var photo = await MediaPicker.PickPhotoAsync();
			if (photo != null)
				imgFoto.Source = ImageSource.FromFile(photo.FullPath);
		}
		catch (Exception ex)
		{
			await DisplayAlert("Error", ex.Message, "OK");
		}
	}
}
