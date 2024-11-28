public class Boleta
{
    public string Codigo { get; set; }
    public Mascota Mascota { get; set; }
    public Servicio Servicio1 { get; set; }
    public Servicio Servicio2 { get; set; }
    public decimal Total { get; set; }

    // Constructor
    public Boleta(string codigo, Mascota mascota, Servicio servicio1, Servicio servicio2)
    {
        Codigo = codigo;
        Mascota = mascota;
        Servicio1 = servicio1;
        Servicio2 = servicio2;
        Total = servicio1.Precio + servicio2.Precio;
    }

    // Método para listar las boletas
    public static void ListarBoletas(Boleta[] boletas)
    {
        Console.WriteLine("Boletas Registradas:");
        for (int i = 0; i < boletas.Length; i++)
        {
            if (boletas[i] != null)
            {
                Console.WriteLine($"Código: {boletas[i].Codigo}, Mascota: {boletas[i].Mascota.Nombre}, " +
                                  $"Servicios: {boletas[i].Servicio1.Descripcion} y {boletas[i].Servicio2.Descripcion}, Total: {boletas[i].Total}");
            }
        }
    }

    // Método para crear una nueva boleta
    public static void CrearBoleta(Boleta[] boletas, Mascota[] mascotas, Servicio[] servicios)
    {
        // Seleccionar la mascota
        Console.WriteLine("Seleccione la mascota para la boleta:");
        Mascota.ListarMascotas(mascotas);
        int mascotaIndex = int.Parse(Console.ReadLine()) - 1;

        // Seleccionar el primer servicio
        Console.WriteLine("Seleccione el primer servicio:");
        Servicio.ListarServicios(servicios);
        int servicio1Index = int.Parse(Console.ReadLine()) - 1;

        // Seleccionar el segundo servicio
        Console.WriteLine("Seleccione el segundo servicio:");
        Servicio.ListarServicios(servicios);
        int servicio2Index = int.Parse(Console.ReadLine()) - 1;

        // Generar un código único para la boleta
        string codigoBoleta = Guid.NewGuid().ToString();

        // Crear la nueva boleta con la mascota y los dos servicios seleccionados
        Boleta nuevaBoleta = new Boleta(codigoBoleta, mascotas[mascotaIndex], servicios[servicio1Index], servicios[servicio2Index]);

        // Guardar la boleta en el arreglo de boletas
        for (int i = 0; i < boletas.Length; i++)
        {
            if (boletas[i] == null)
            {
                boletas[i] = nuevaBoleta;
                Console.WriteLine($"Boleta creada con código: {codigoBoleta}");
                return;
            }
        }

        Console.WriteLine("No hay espacio para más boletas.");
    }
}
