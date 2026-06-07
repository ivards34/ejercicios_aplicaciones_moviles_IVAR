using Microsoft.Maui.Networking;

namespace Practico_n10.Pages;

public partial class ConectividadPage : ContentPage
{
	public ConectividadPage()
	{
		InitializeComponent();
		VerificarConectividad();
		// Escuchar cambios automáticamente
		Connectivity.ConnectivityChanged += (s, e) => VerificarConectividad();
	}

	private void VerificarConectividad()
	{
		if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
		{
			lblConectividad.Text = "✅ Conectado a internet";
			frameEstado.BackgroundColor = Color.FromArgb("#E8F5E9");
		}
		else
		{
			lblConectividad.Text = "❌ Sin conexión";
			frameEstado.BackgroundColor = Color.FromArgb("#FFEBEE");
		}
	}

	private void OnVerificarClicked(object sender, EventArgs e)
	{
		VerificarConectividad();
	}
}
