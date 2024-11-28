public class Mascota
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Especie { get; set; }

    // Constructor
    public Mascota(string nombre, int edad, string especie)
    {
        Nombre = nombre;
        Edad = edad;
        Especie = especie;
    }

    // Método para listar las mascotas
    public static void ListarMascotas(Mascota[] mascotas)
    {
        Console.WriteLine("Mascotas Registradas:");
        for (int i = 0; i < mascotas.Length; i++)
        {
            if (mascotas[i] != null)
            {
                Console.WriteLine($"{i + 1}. Nombre: {mascotas[i].Nombre}, Edad: {mascotas[i].Edad}, Especie: {mascotas[i].Especie}");
            }
        }
    }

    // Método para crear una nueva mascota
    public static void CrearMascota(Mascota[] mascotas)
    {
        Console.Write("Ingrese el nombre de la mascota: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la edad de la mascota: ");
        int edad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la especie de la mascota: ");
        string especie = Console.ReadLine();

        Mascota nuevaMascota = new Mascota(nombre, edad, especie);

        for (int i = 0; i < mascotas.Length; i++)
        {
            if (mascotas[i] == null)
            {
                mascotas[i] = nuevaMascota;
                Console.WriteLine("Mascota creada exitosamente.");
                return;
            }
        }

        Console.WriteLine("No hay espacio para más mascotas.");
    }

    // Método para eliminar una mascota
    public static void EliminarMascota(Mascota[] mascotas)
    {
        Console.WriteLine("Ingrese el índice de la mascota a eliminar (1-10): ");
        ListarMascotas(mascotas);
        int indice = int.Parse(Console.ReadLine()) - 1;

        if (indice >= 0 && indice < mascotas.Length && mascotas[indice] != null)
        {
            mascotas[indice] = null;
            Console.WriteLine("Mascota eliminada.");
        }
        else
        {
            Console.WriteLine("Mascota no encontrada.");
        }
    }
}