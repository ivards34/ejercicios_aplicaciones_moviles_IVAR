using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TiendaApp.Models;
using TiendaApp.Services;

namespace TiendaApp.ViewModels
{
    public partial class ProductosViewModel : ObservableObject
    {
        private readonly IProductoService _productoService;

        public ObservableCollection<Producto> Productos { get; } = new();

        [ObservableProperty]
        private bool estaCargando;

        [ObservableProperty]
        private string terminoBusqueda = string.Empty;

        public ProductosViewModel(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [RelayCommand]
        private async Task Cargar()
        {
            EstaCargando = true;
            try
            {
                var productos = await _productoService.ObtenerTodosAsync();
                Productos.Clear();
                foreach (var p in productos)
                    Productos.Add(p);
            }
            finally
            {
                EstaCargando = false;
            }
        }

        [RelayCommand]
        private async Task Agregar()
        {
            await Shell.Current.GoToAsync("agregar");
        }

        [RelayCommand]
        private async Task Eliminar(Producto producto)
        {
            if (producto == null) return;

            bool confirmar = await Application.Current.MainPage.DisplayAlert(
                "Confirmar",
                $"¿Eliminar {producto.Nombre}?", "Sí", "No");

            if (!confirmar) return;

            await _productoService.EliminarAsync(producto.Id);
            Productos.Remove(producto);
        }

        [RelayCommand]
        private async Task Buscar()
        {
            // Simple filtering local
            var todos = await _productoService.ObtenerTodosAsync();
            Productos.Clear();
            foreach (var p in todos)
            {
                if (string.IsNullOrWhiteSpace(TerminoBusqueda) || p.Nombre.Contains(TerminoBusqueda, System.StringComparison.OrdinalIgnoreCase))
                    Productos.Add(p);
            }
        }

        [RelayCommand]
        private async Task IrADetalle(Producto producto)
        {
            if (producto == null) return;
            await Shell.Current.GoToAsync($"producto?id={producto.Id}");
        }
    }
}
