using CatalogoProductos.Models;
namespace CatalogoProductos.Views
{
    public partial class DetallePage : ContentPage
    {
        Producto producto;
        public DetallePage(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            MostrarDetalle();
        }
        void MostrarDetalle()
        {
            imgProducto.Source = producto.Imagen;
            lblNombre.Text = producto.Nombre;
            lblPrecio.Text = $"${producto.Precio:F2}";
            lblCalificacion.Text = producto.Calificacion.ToString("F1");
            lblCategoria.Text = producto.Categoria;
            lblStock.Text = $"Stock: {producto.Stock}";
            lblDescripcion.Text = producto.Descripcion;
        }
        async void OnAgregarCarritoClicked(object? sender, EventArgs e)
        {
            await DisplayAlertAsync("Carrito", $"{producto.Nombre} agregado al carrito", "OK");
        }
        async void OnComprarClicked(object? sender, EventArgs e)
        {
            bool respuesta = await DisplayAlertAsync("Comprar", $"¿Deseas comprar {producto.Nombre} por $ { producto.Precio:F2}?", "Sí", "No");
            if (respuesta)
            {

                await DisplayAlertAsync("Éxito", "Compra realizada con éxito", "OK");
            }
        }
    }
}