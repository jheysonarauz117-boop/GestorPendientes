// Autor: Jeremy Thorp
// Descripción: Pide un identificador y marca como completado solo ese pendiente,
// manejando entradas incorrectas, identificadores inexistentes y pendientes ya completados.

namespace GestorPendientes;

public static class CompletarPendiente
{
    public static void Ejecutar(List<Pendiente> pendientes)
    {
        // Completa el pendiente indicado.
        if (pendientes.Count == 0)
        {
            Console.WriteLine("No hay pendientes en la lista.");
            return;
        }

        Console.Write("Ingrese el identificador del pendiente a completar: ");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int identificador))
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
            return;
        }

        Pendiente? elegido = null;
        foreach (Pendiente p in pendientes)
        {
            if (p.Identificador == identificador)
            {
                elegido = p;
                break;
            }
        }

        if (elegido == null)
        {
            Console.WriteLine($"No existe un pendiente con el identificador {identificador}.");
            return;
        }

        if (elegido.Estado == EstadoPendiente.Completado)
        {
            Console.WriteLine($"El pendiente {identificador} ya estaba completado.");
            return;
        }

        elegido.Completar();
        Console.WriteLine($"Pendiente {identificador} completado: {elegido.Descripcion}");
    }
}