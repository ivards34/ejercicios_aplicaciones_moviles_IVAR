using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaApp.Models;

namespace TiendaApp.Services
{
    public class ProductoService : IProductoService
    {
        private readonly List<Producto> _productos = new()
        {
            new Producto { Id = 1, Nombre = "Camiseta", Descripcion = "Camiseta algodón", Precio = 19.99m, Imagen = "" },
            new Producto { Id = 2, Nombre = "Pantalón", Descripcion = "Pantalón jeans", Precio = 49.99m, Imagen = "" },
            new Producto { Id = 3, Nombre = "Gorra", Descripcion = "Gorra deportiva", Precio = 9.99m, Imagen = "" },
        };

        public Task AgregarAsync(Producto producto)
        {
            producto.Id = (_productos.LastOrDefault()?.Id ?? 0) + 1;
            _productos.Add(producto);
            return Task.CompletedTask;
        }

        public Task EliminarAsync(int id)
        {
            var p = _productos.FirstOrDefault(x => x.Id == id);
            if (p != null) _productos.Remove(p);
            return Task.CompletedTask;
        }

        public Task<Producto?> ObtenerPorIdAsync(int id)
        {
            var p = _productos.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(p);
        }

        public Task<IEnumerable<Producto>> ObtenerTodosAsync()
        {
            return Task.FromResult<IEnumerable<Producto>>(_productos);
        }
    }
}
