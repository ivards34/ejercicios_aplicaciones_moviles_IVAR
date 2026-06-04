using BibliotecaApp.Models;
using BibliotecaApp.PageModels;

namespace BibliotecaApp.Pages
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