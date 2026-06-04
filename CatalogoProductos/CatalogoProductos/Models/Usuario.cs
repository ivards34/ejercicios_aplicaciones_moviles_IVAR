using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoProductos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Email { get; set; }
        public required string Foto { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}