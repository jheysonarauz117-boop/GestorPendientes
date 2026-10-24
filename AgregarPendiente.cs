namespace GestorPendientes;

public static class AgregarPendiente
{
    public static void Ejecutar(List<Pendiente> pendientes)
    {
        // 1 y 2. Solicitar la descripción; volver a pedirla si está vacía
        string? descripcion;
        do
        {
            Console.Write("Descripción del pendiente: ");
            descripcion = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(descripcion))
                Console.WriteLine("La descripción no puede estar vacía. Intenta de nuevo.");

        } while (string.IsNullOrWhiteSpace(descripcion));

        // 3. Agregar un objeto válido (el constructor valida y asigna el identificador)
        var pendiente = new Pendiente(descripcion);
        pendientes.Add(pendiente);

        // 4. Informar su identificador
        Console.WriteLine($"Pendiente agregado con ID: {pendiente.Identificador}");
    }
}