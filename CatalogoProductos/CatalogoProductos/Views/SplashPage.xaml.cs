namespace CatalogoProductos.Views
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            IniciarApp();
        }
        async void IniciarApp()
        {
            await Task.Delay(3000);
            await Shell.Current.GoToAsync("//login");
        }
    }
}