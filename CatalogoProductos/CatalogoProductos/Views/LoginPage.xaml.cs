namespace CatalogoProductos.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        async void OnLoginClicked(object? sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(entryEmail.Text))
            {

                await DisplayAlertAsync("Error", "Ingresa tu email", "OK");

                return;
            }
            if (string.IsNullOrWhiteSpace(entryPassword.Text))
            {

                await DisplayAlertAsync("Error", "Ingresa tu contraseña", "OK");

                return;
            }
            // Simular login

            await DisplayAlertAsync("Éxito", "Iniciando sesión...", "OK");
            await Shell.Current.GoToAsync("//home");
        }
        async void OnRegistroClicked(object? sender, EventArgs e)
        {
            await DisplayAlertAsync("Registro", "Funcionalidad de registro", "OK");
        }
        async void OnOlvidePasswordTapped(object? sender, EventArgs e)
        {
            await DisplayAlertAsync("Recuperar contraseña", "Funcionalidad de recuperación", "OK");
        }
    }
}