using CommunityToolkit.Maui.Alerts;

namespace BibliotecaApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // Registrar rutas

            Routing.RegisterRoute("detalle", typeof(Views.DetallePage));
        }

        public static async Task DisplayToastAsync(string message)
        {
            var toast = Toast.Make(message, CommunityToolkit.Maui.Core.ToastDuration.Short);
            await toast.Show();
        }
    }
}