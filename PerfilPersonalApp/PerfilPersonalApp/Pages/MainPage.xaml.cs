using PerfilPersonalApp.Models;
using PerfilPersonalApp.PageModels;

namespace PerfilPersonalApp.Pages
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