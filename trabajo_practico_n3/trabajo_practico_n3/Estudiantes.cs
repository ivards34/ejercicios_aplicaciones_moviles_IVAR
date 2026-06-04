using System;
using System.Collections.Generic;
using System.Linq;
class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Promedio { get; set; }
    public string Carrera { get; set; }
}
class TestEstudiantes
{
    public static void Ejecutar()
    {
        List<Estudiante> estudiantes = new List<Estudiante>
            {
            new Estudiante { Nombre = "Ana", Edad = 20, Promedio = 8.5, Carrera = "Sistemas" },
            new Estudiante { Nombre = "Carlos", Edad = 22, Promedio = 7.2, Carrera = "Sistemas" },
            new Estudiante { Nombre = "María", Edad = 19, Promedio = 9.1, Carrera = "Diseño" },
            new Estudiante { Nombre = "Pedro", Edad = 21, Promedio = 6.8, Carrera = "Sistemas" },
            new Estudiante { Nombre = "Laura", Edad = 23, Promedio = 8.9, Carrera = "Diseño" },
            new Estudiante { Nombre = "Juan", Edad = 20, Promedio = 5.5, Carrera = "Sistemas" },
            new Estudiante { Nombre = "Sofía", Edad = 22, Promedio = 9.5, Carrera = "Diseño" }
            };
            // 1. Estudiantes aprobados (promedio >= 6)
            var aprobados = estudiantes.Where(e => e.Promedio >= 6).ToList();
            Console.WriteLine($"Aprobados: {aprobados.Count}");
            // 2. Ordenar por promedio (mayor a menor)
            var ordenados = estudiantes.OrderByDescending(e =>
            e.Promedio).ToList();
            Console.WriteLine("\nRanking:");
            foreach (var e in ordenados)
                Console.WriteLine($" {e.Nombre}: {e.Promedio}");
            // 3. Promedio general
            double promedioGeneral = estudiantes.Average(e => e.Promedio);
            Console.WriteLine($"\nPromedio general: {promedioGeneral:F2}");
            // 4. Estudiantes de Sistemas con promedio > 7
            var sistemasBuenos = estudiantes
            .Where(e => e.Carrera == "Sistemas" && e.Promedio > 7)
            .ToList();

            Console.WriteLine($"\nSistemas con promedio > 7:  { sistemasBuenos.Count}");
    // 5. El mejor estudiante
            var mejor = estudiantes.OrderByDescending(e => e.Promedio).First();
                    Console.WriteLine($"\nMejor estudiante: {mejor.Nombre} ({ mejor.Promedio})");
    }
}