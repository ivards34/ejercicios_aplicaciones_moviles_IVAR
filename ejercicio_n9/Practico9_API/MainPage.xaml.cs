using Practico9_API.Models;
using Practico9_API.Services;

namespace Practico9_API;

public partial class MainPage : TabbedPage
{
	private readonly ApiService _apiService = new ApiService();

	public MainPage()
	{
		InitializeComponent();
	}

	// Ejercicio 1: Cargar Posts
	private async void OnCargarPostsClicked(object? sender, EventArgs e)
	{
		try
		{
			var posts = await _apiService.ObtenerPostsAsync();
			listaPosts.ItemsSource = posts;
		}
		catch (Exception ex)
		{
			await DisplayAlertAsync("Error", $"No se pudieron cargar los posts: {ex.Message}", "OK");
		}
	}

	// Ejercicio 2: Cargar Usuarios
	private async void OnCargarUsuariosClicked(object? sender, EventArgs e)
	{
		try
		{
			var usuarios = await _apiService.ObtenerUsuariosAsync();
			listaUsuarios.ItemsSource = usuarios;
		}
		catch (Exception ex)
		{
			await DisplayAlertAsync("Error", $"No se pudieron cargar los usuarios: {ex.Message}", "OK");
		}
	}

	// Ejercicio 3: Buscar Post por ID
	private async void OnBuscarClicked(object? sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(txtId.Text))
		{
			await DisplayAlertAsync("Error", "Ingresá un ID", "OK");
			return;
		}

		if (!int.TryParse(txtId.Text, out int id))
		{
			await DisplayAlertAsync("Error", "El ID debe ser un número", "OK");
			return;
		}

		try
		{
			var post = await _apiService.ObtenerPostPorIdAsync(id);
			if (post != null)
			{
				lblTitulo.Text = post.Title;
				lblCuerpo.Text = post.Body;
				resultado.IsVisible = true;
			}
			else
			{
				await DisplayAlertAsync("Error", "Post no encontrado", "OK");
				resultado.IsVisible = false;
			}
		}
		catch (Exception ex)
		{
			await DisplayAlertAsync("Error", $"No se pudo buscar el post: {ex.Message}", "OK");
		}
	}

	// Ejercicio 4: Manejo de Errores (sin internet)
	private async void OnCargarConErroresClicked(object? sender, EventArgs e)
	{
		// Verificar internet
		if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
		{
			await DisplayAlertAsync("Sin conexión",
				"Necesitás internet para cargar los datos", "OK");
			return;
		}

		// Si hay internet, hacer la petición
		try
		{
			var posts = await _apiService.ObtenerPostsAsync();
			listaPostsErrores.ItemsSource = posts;
		}
		catch (HttpRequestException)
		{
			await DisplayAlertAsync("Error", "No se pudo conectar con el servidor", "OK");
		}
		catch (TaskCanceledException)
		{
			await DisplayAlertAsync("Timeout", "La petición tardó demasiado", "OK");
		}
		catch (Exception ex)
		{
			await DisplayAlertAsync("Error", $"Ocurrió un error: {ex.Message}", "OK");
		}
	}
}
