using CatalogoProductos.Models;
using CatalogoProductos.PageModels;

namespace CatalogoProductos.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}