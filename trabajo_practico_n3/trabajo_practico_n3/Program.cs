class Program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\n=== SISTEMA DE GESTIÓN - PRÁCTICO 3 POO ===");
            Console.WriteLine("1. Agenda de Contactos (Dictionary)");
            Console.WriteLine("2. Biblioteca (List<Libro> + Herencia)");
            Console.WriteLine("3. Estudiantes (LINQ)");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    TestAgenda.Ejecutar();
                    break;
                case "2":
                    EjecutarBiblioteca();
                    break;
                case "3":
                    TestEstudiantes.Ejecutar();
                    break;
                case "4":
                    continuar = false;
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }

    static void EjecutarBiblioteca()
    {
        Biblioteca miBiblioteca = new Biblioteca("Municipal");
        // Agregar libros de ejemplo
        miBiblioteca.AgregarLibro(new Libro(1, "Cien Años de Soledad", "Gabriel García Márquez", 1967, "978-0307474728"));
        miBiblioteca.AgregarLibro(new Libro(2, "El Principito", "Antoine de Saint - Exupéry", 1943, "978 - 0156012195"));
        miBiblioteca.AgregarLibro(new Libro(3, "1984", "George Orwell", 1949, "978-0451524935"));
        miBiblioteca.AgregarLibro(new Libro(4, "Don Quijote", "Miguel de Cervantes", 1605, "978 - 8420412146"));
        
        // Agregar libros digitales (herencia)
        miBiblioteca.AgregarLibro(new LibroDigital(5, "Clean Code", "Robert C. Martin", 2008, "978-0132350884", "PDF", 5.2));
        miBiblioteca.AgregarLibro(new LibroDigital(6, "Design Patterns", "Erich Gamma", 1994, "978-0201633610", "EPUB", 3.8));
        
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\n=== MENÚ BIBLIOTECA ===");
            Console.WriteLine("1. Ver todos los libros");
            Console.WriteLine("2. Buscar por autor");
            Console.WriteLine("3. Prestar libro");
            Console.WriteLine("4. Devolver libro");
            Console.WriteLine("5. Ver estadísticas");
            Console.WriteLine("6. Volver al menú principal");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    miBiblioteca.MostrarTodosLosLibros();
                    break;
                case "2":
                    Console.Write("Autor a buscar: ");
                    string autor = Console.ReadLine();
                    var resultados = miBiblioteca.BuscarPorAutor(autor);
                    Console.WriteLine($"Se encontraron {resultados.Count} libros: ");
                    foreach (var libro in resultados)
                        Console.WriteLine($" - {libro.Titulo}");
                    break;
                case "3":
                    Console.Write("ID del libro a prestar: ");
                    int idPrestar = int.Parse(Console.ReadLine());
                    miBiblioteca.PrestarLibro(idPrestar);
                    break;
                case "4":
                    Console.Write("ID del libro a devolver: ");
                    int idDevolver = int.Parse(Console.ReadLine());
                    miBiblioteca.DevolverLibro(idDevolver);
                    break;
                case "5":
                    miBiblioteca.MostrarEstadisticas();
                    break;
                case "6":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}