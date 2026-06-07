using System.Collections.Generic;
using System.Threading.Tasks;
using TiendaApp.Models;

namespace TiendaApp.Services
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> ObtenerTodosAsync();
        Task<Producto?> ObtenerPorIdAsync(int id);
        Task AgregarAsync(Producto producto);
        Task EliminarAsync(int id);
    }
}
