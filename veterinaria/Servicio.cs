public class Servicio
{
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }

    // Constructor
    public Servicio(string descripcion, decimal precio)
    {
        Descripcion = descripcion;
        Precio = precio;
    }

    // Método para listar los servicios
    public static void ListarServicios(Servicio[] servicios)
    {
        Console.WriteLine("Servicios Disponibles:");
        for (int i = 0; i < servicios.Length; i++)
        {
            if (servicios[i] != null)
            {
                Console.WriteLine($"{i + 1}. Descripción: {servicios[i].Descripcion}, Precio: {servicios[i].Precio}");
            }
        }
    }

    // Método para crear un nuevo servicio
    public static void CrearServicio(Servicio[] servicios)
    {
        Console.Write("Ingrese la descripción del servicio: ");
        string descripcion = Console.ReadLine();
        Console.Write("Ingrese el precio del servicio: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        Servicio nuevoServicio = new Servicio(descripcion, precio);

        for (int i = 0; i < servicios.Length; i++)
        {
            if (servicios[i] == null)
            {
                servicios[i] = nuevoServicio;
                Console.WriteLine("Servicio creado exitosamente.");
                return;
            }
        }

        Console.WriteLine("No hay espacio para más servicios.");
    }

    // Método para eliminar un servicio
    public static void EliminarServicio(Servicio[] servicios)
    {
        Console.WriteLine("Ingrese el índice del servicio a eliminar (1-5): ");
        ListarServicios(servicios);
        int indice = int.Parse(Console.ReadLine()) - 1;

        if (indice >= 0 && indice < servicios.Length && servicios[indice] != null)
        {
            servicios[indice] = null;
            Console.WriteLine("Servicio eliminado.");
        }
        else
        {
            Console.WriteLine("Servicio no encontrado.");
        }
    }
}
