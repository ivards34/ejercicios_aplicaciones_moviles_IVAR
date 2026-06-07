using Practico_n10.Models;
using Practico_n10.PageModels;

namespace Practico_n10.Pages
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