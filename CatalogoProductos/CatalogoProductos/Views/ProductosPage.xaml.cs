using CatalogoProductos.Models;
using CatalogoProductos.Services;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
namespace CatalogoProductos.Views
{
    public partial class ProductosPage : ContentPage
    {
        ProductoService productoService = new();
        List<Producto> todosLosProductos = new();
        string categoriaFiltro = string.Empty;
        public ProductosPage(string? filtro = null)
        {
            InitializeComponent();

            productoService = new ProductoService();
            categoriaFiltro = filtro ?? string.Empty;
            CargarProductos();
            if (!string.IsNullOrWhiteSpace(filtro))
            {

                searchBar.Text = filtro;

            }
        }

        void CargarProductos()
        {
            if (string.IsNullOrWhiteSpace(categoriaFiltro))
            {

                todosLosProductos =
                productoService.ObtenerTodosLosProductos();
            }
            else
            {

                todosLosProductos =
                productoService.ObtenerProductosPorCategoria(categoriaFiltro);
            }

            collectionViewProductos.ItemsSource = todosLosProductos;
        }
        void OnSearchTextChanged(object? sender, TextChangedEventArgs e)
        {
            string termino = e.NewTextValue;
            if (string.IsNullOrWhiteSpace(termino))
            {

                collectionViewProductos.ItemsSource = todosLosProductos;

            }
            else
            {
                var productosFiltrados = todosLosProductos
                .Where(p =>

                p.Nombre.ToLower().Contains(termino.ToLower()) ||
                p.Descripcion.ToLower().Contains(termino.ToLower()))

                .ToList();

                collectionViewProductos.ItemsSource = productosFiltrados;

            }
        }
        async void OnProductoSelected(object? sender,
        SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {

                Producto producto = (Producto)e.CurrentSelection[0];
                await Navigation.PushAsync(new DetallePage(producto));
                collectionViewProductos.SelectedItem = null;

            }
        }
        async void OnRefreshing(object? sender, EventArgs e)
        {
            await Task.Delay(1000);
            CargarProductos();

            refreshView.IsRefreshing = false;
        }
    }
}