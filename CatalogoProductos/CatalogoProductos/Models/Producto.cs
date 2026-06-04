using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoProductos.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public required string Imagen { get; set; }
        public required string Categoria { get; set; }
        public int Stock { get; set; }
        public double Calificacion { get; set; }
    }
}