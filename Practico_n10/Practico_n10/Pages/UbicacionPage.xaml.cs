using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices.Sensors;

namespace Practico_n10.Pages;

public partial class UbicacionPage : ContentPage
{
	public UbicacionPage()
	{
		InitializeComponent();
	}

	private async void OnObtenerUbicacionClicked(object sender, EventArgs e)
	{
		try
		{
			// Pedir permiso
			var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
			if (status != PermissionStatus.Granted)
				status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
			if (status != PermissionStatus.Granted)
			{
				lblEstado.Text = "Permiso denegado";
				return;
			}
			// Obtener ubicación
			lblEstado.Text = "Buscando ubicación...";
			var location = await Geolocation.GetLocationAsync(
				new GeolocationRequest(GeolocationAccuracy.Medium));
			if (location != null)
			{
				lblLatitud.Text = $"Latitud: {location.Latitude:F6}";
				lblLongitud.Text = $"Longitud: {location.Longitude:F6}";
				lblEstado.Text = "✅ Ubicación obtenida";
			}
		}
		catch (Exception ex)
		{
			lblEstado.Text = $"Error: {ex.Message}";
		}
	}
}
