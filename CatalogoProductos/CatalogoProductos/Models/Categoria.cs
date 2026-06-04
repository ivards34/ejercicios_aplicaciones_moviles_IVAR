using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoProductos.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Icono { get; set; }
        public required string Color { get; set; }
    }
}