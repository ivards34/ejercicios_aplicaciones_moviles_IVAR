using TiendaApp.ViewModels;

namespace TiendaApp.Pages
{
    public partial class ProductosPage : ContentPage
    {
        public ProductosPage(ProductosViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            Appearing += async (s, e) => { await vm.CargarCommand.ExecuteAsync(null); };
        }
    }
}
