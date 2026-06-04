namespace CatalogoProductos.Views
{
    public partial class PerfilPage : ContentPage
    {
        public PerfilPage()
        {
            InitializeComponent();
        }
        async void OnEditarPerfilTapped(object? sender, EventArgs e)
        {
            await DisplayAlertAsync("Editar Perfil",
            "Funcionalidad de edición de perfil", "OK");
        }
        async void OnMisPedidosTapped(object? sender, EventArgs e)
        {
            await DisplayAlertAsync("Mis Pedidos", "Funcionalidad de pedidos",
            "OK");
        }
        async void OnConfiguracionTapped(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfiguracionPage());
        }
        async void OnCerrarSesionClicked(object? sender, EventArgs e)
        {
            bool respuesta = await DisplayAlertAsync(
            "Cerrar Sesión",
            "¿Estás seguro que deseas cerrar sesión?",
            "Sí",
            "No"
            );
            if (respuesta)
            {
                await Shell.Current.GoToAsync("//login");
            }
        }
    }
}