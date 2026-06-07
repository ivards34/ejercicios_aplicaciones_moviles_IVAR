using TiendaApp.Models;
using TiendaApp.PageModels;

namespace TiendaApp.Pages
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