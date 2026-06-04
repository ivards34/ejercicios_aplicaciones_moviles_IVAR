using System;
using System.Collections.Generic;
using System.Linq;
class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
}
class AgendaContactos
{
    private Dictionary<string, Contacto> contactos = new Dictionary<string,
    Contacto>();
    public void Agregar(Contacto contacto)
    {
        contactos[contacto.Nombre.ToLower()] = contacto;
        Console.WriteLine($"Contacto '{contacto.Nombre}' agregado");
    }
    public Contacto Buscar(string nombre)
    {
        if (contactos.ContainsKey(nombre.ToLower()))
            return contactos[nombre.ToLower()];
        return null;
    }
    public void Eliminar(string nombre)
    {
        if (contactos.Remove(nombre.ToLower()))
            Console.WriteLine($"Contacto '{nombre}' eliminado");
        else
            Console.WriteLine("Contacto no encontrado");
    }
    public void MostrarTodos()
    {
        Console.WriteLine($"\n=== AGENDA ({contactos.Count} contactos)=== ");
    foreach (var c in contactos.Values.OrderBy(c => c.Nombre))
            Console.WriteLine($" {c.Nombre} | {c.Telefono} | {c.Email}");
    }
}
class TestAgenda
{
    public static void Ejecutar()
    {
        var agenda = new AgendaContactos();
        agenda.Agregar(new Contacto
        {
            Nombre = "Juan",
            Telefono =
        "11-2345-6789",
            Email = "juan@email.com"
        });
        agenda.Agregar(new Contacto
        {
            Nombre = "María",
            Telefono =
        "11-9876-5432",
            Email = "maria@email.com"
        });
        agenda.Agregar(new Contacto
        {
            Nombre = "Pedro",
            Telefono =
        "11-5555-1234",
            Email = "pedro@email.com"
        });
        agenda.MostrarTodos();
        var encontrado = agenda.Buscar("María");
        if (encontrado != null)
            Console.WriteLine($"\nEncontrado: {encontrado.Nombre} - { encontrado.Telefono}");
        agenda.Eliminar("Pedro");
        agenda.MostrarTodos();
    }
}