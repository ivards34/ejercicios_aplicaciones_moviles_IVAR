using System;
using System.Collections.Generic;
using System.Text;

using CatalogoProductos.Models;
namespace CatalogoProductos.Services
{
    public class ProductoService
    {
        private static List<Producto> productos = new();
        private static List<Categoria> categorias = new();
        public ProductoService()
        {
            InicializarDatos();
        }
        void InicializarDatos()
        {
            if (productos == null)
            {

                productos = new List<Producto>


                {
                new Producto
                {
                Id = 1,
                Nombre = "Laptop HP",
                Descripcion = "Laptop HP 15.6 pulgadas, Intel Core i5, 8GB RAM, 256GB SSD",
                Precio = 899.99m,
                Imagen = "laptop.png",
                Categoria = "Electrónica",
                Stock = 15,
                Calificacion = 4.5

                },
                new Producto
                {
                Id = 2,
                Nombre = "Mouse Logitech",
                Descripcion = "Mouse inalámbrico Logitech M185, ergonómico",
                Precio = 19.99m,
                Imagen = "mouse.png",
                Categoria = "Electrónica",
                Stock = 50,
                Calificacion = 4.2

                },
                new Producto
                {
                Id = 3,
                Nombre = "Teclado Mecánico",
                Descripcion = "Teclado mecánico RGB, switches azules",
                Precio = 79.99m,
                Imagen = "teclado.png",
                Categoria = "Electrónica",
                Stock = 30,
                Calificacion = 4.7

                },
                new Producto
                {
                Id = 4,
                Nombre = "Monitor Samsung",
                Descripcion = "Monitor Samsung 24 pulgadas Full HD",
                Precio = 199.99m,
                Imagen = "monitor.png",
                Categoria = "Electrónica",
                Stock = 20,
                Calificacion = 4.6

                },
                new Producto
                {
                Id = 5,
                Nombre = "Auriculares Sony",
                Descripcion = "Auriculares Sony con cancelación de ruido",
                Precio = 149.99m,
                Imagen = "auriculares.png",
                Categoria = "Audio",
                Stock = 25,
                Calificacion = 4.8

                },
                new Producto
                {
                Id = 6,
                Nombre = "Webcam Logitech",
                Descripcion = "Webcam Logitech C920 Full HD 1080p",
                Precio = 69.99m,
                Imagen = "webcam.png",
                Categoria = "Electrónica",
                Stock = 40,
                Calificacion = 4.4

                }
                };
            }
            if (categorias == null)
            {

                categorias = new List<Categoria>

                {
                new Categoria { Id = 1, Nombre = "Electrónica", Icono =

                " ", Color = "#2196F3" },

                new Categoria { Id = 2, Nombre = "Audio", Icono = " ",

                Color = "#4CAF50" },

                new Categoria { Id = 3, Nombre = "Accesorios", Icono =

                " ", Color = "#FF9800" },

                new Categoria { Id = 4, Nombre = "Gaming", Icono =

                " ", Color = "#9C27B0" }
                };
                            }
            }
        public List<Producto> ObtenerTodosLosProductos()
        {
            return productos;
        }
        public List<Producto> BuscarProductos(string termino)
        {
            if (string.IsNullOrWhiteSpace(termino))
                return productos;
            return productos
            .Where(p => p.Nombre.ToLower().Contains(termino.ToLower())
            ||
            p.Descripcion.ToLower().Contains(termino.ToLower()))
            .ToList();
        }
        public List<Producto> ObtenerProductosPorCategoria(string categoria)
        {
            return productos.Where(p => p.Categoria == categoria).ToList();
        }
        public Producto? ObtenerProductoPorId(int id)
        {
            return productos.FirstOrDefault(p => p.Id == id);
        }
        public List<Categoria> ObtenerCategorias()
        {
            return categorias;
        }
    }
}