namespace GestorPendientes;

public class Pendiente
{
    private static int siguienteIdentificador = 1;

    public int Identificador { get; }
    public string Descripcion { get; }
    public EstadoPendiente Estado { get; private set; }

    public Pendiente(string descripcion)
    {
        if (string.IsNullOrWhiteSpace(descripcion))
        {
            throw new ArgumentException("La descripción no puede estar vacía.", nameof(descripcion));
        }

        Identificador = siguienteIdentificador++;
        Descripcion = descripcion.Trim();
        Estado = EstadoPendiente.Pendiente;
    }

    public void Completar()
    {
        Estado = EstadoPendiente.Completado;
    }
}
