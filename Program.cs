namespace GestorPendientes;

public class Program
{
    public static void Main(string[] args)
    {
        List<Pendiente> pendientes =
        [
            new Pendiente("Estudiar Git"),
            new Pendiente("Revisar el proyecto")
        ];

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine();
            Console.WriteLine("GESTOR DE PENDIENTE");
            Console.WriteLine("1. Agregar un pendiente");
            Console.WriteLine("2. Ver los pendientes");
            Console.WriteLine("3. Marcar un pendiente como completado");
            Console.WriteLine("4. Eliminar un pendiente");
            Console.WriteLine("0. Salir");
            Console.Write("Selecciona una opción: ");

            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarPendiente.Ejecutar(pendientes);
                    break;
                case "2":
                    ListarPendientes.Ejecutar(pendientes);
                    break;
                case "3":
                    CompletarPendiente.Ejecutar(pendientes);
                    break;
                case "4":
                    EliminarPendiente.Ejecutar(pendientes);
                    break;
                case "0":
                case null:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}
