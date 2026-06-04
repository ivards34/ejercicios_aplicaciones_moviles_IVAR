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
    }
}