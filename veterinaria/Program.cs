public class Program
{
    static Mascota[] mascotas = new Mascota[10];
    static Servicio[] servicios = new Servicio[5];
    static Boleta[] boletas = new Boleta[10];

    public static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a la Veterinaria. Selecciona una opción:");
            Console.WriteLine("1. Crear Mascota");
            Console.WriteLine("2. Eliminar Mascota");
            Console.WriteLine("3. Listar Mascotas");
            Console.WriteLine("4. Crear Servicio");
            Console.WriteLine("5. Eliminar Servicio");
            Console.WriteLine("6. Listar Servicios");
            Console.WriteLine("7. Crear Boleta");
            Console.WriteLine("8. Listar Boletas");
            Console.WriteLine("9. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Mascota.CrearMascota(mascotas);
                    break;
                case 2:
                    Mascota.EliminarMascota(mascotas);
                    break;
                case 3:
                    Mascota.ListarMascotas(mascotas);
                    break;
                case 4:
                    Servicio.CrearServicio(servicios);
                    break;
                case 5:
                    Servicio.EliminarServicio(servicios);
                    break;
                case 6:
                    Servicio.ListarServicios(servicios);
                    break;
                case 7:
                    Boleta.CrearBoleta(boletas, mascotas, servicios);
                    break;
                case 8:
                    Boleta.ListarBoletas(boletas);
                    break;
                case 9:
                    Console.WriteLine("¡Hasta pronto!");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (opcion != 9);
    }
}
