using System;
using System.Collections.Generic;

namespace GestorPendientes;

public static class ListarPendientes
{
    public static void Ejecutar(List<Pendiente> pendientes)
    {
        Console.Clear();
        Console.WriteLine("=== LISTA DE PENDIENTES ===");

        if (pendientes == null || pendientes.Count == 0)
        {
            Console.WriteLine("No hay pendientes registrados en este momento.");
        }
        else
        {
            foreach (var p in pendientes)
            {
                // Muestra el identificador, la descripción y el estado sin modificar la lista
                Console.WriteLine($"ID: {p.Identificador} | Descripción: {p.Descripcion} | Estado: {p.Estado}");
            }
        }

        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
        Console.ReadKey();
    }
}