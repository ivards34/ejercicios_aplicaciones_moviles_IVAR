using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LibroDigital : Libro
{
    public string Formato { get; set; } // PDF, EPUB, etc.
    public double TamañoMB { get; set; }
    public LibroDigital(int id, string titulo, string autor, int año,
    string isbn, string formato, double tamaño)
    : base(id, titulo, autor, año, isbn)
    {
        Formato = formato;
        TamañoMB = tamaño;
    }
    public void MostrarInfoDigital()
    {
        MostrarInfo();
        Console.WriteLine($"Formato: {Formato}");
        Console.WriteLine($"Tamaño: {TamañoMB} MB");
    }
}
class LibroFisico : Libro
{
    public int NumeroPaginas { get; set; }
    public string Editorial { get; set; }
    public LibroFisico(int id, string titulo, string autor, int año, string
    isbn, int paginas, string editorial)
    : base(id, titulo, autor, año, isbn)
    {
        NumeroPaginas = paginas;
        Editorial = editorial;
    }
    public void MostrarInfoFisico()
    {
        MostrarInfo();
        Console.WriteLine($"Páginas: {NumeroPaginas}");
        Console.WriteLine($"Editorial: {Editorial}");
    }
}