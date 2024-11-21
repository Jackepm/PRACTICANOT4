/*
cree una aplicativo de veterinaria
clases con propiedades: 
    Mascota: nombre, edad, especie
    Servicio: descripcion, precio
    Boleta: codigo, mascota, servicio1, servicio2, total

Use arreglos estáticos de las clases
Debe tener un menu con estas opciones:
- crear, eliminar, listar Servicios
- crear, eliminar, listar Mascotas
- crear, listar Boletas

Para crear boletas debe seleccionar la Mascota y el Servicio de 
sus respectivos arreglos

Divida entre sus integrantes, el lider consolida y los integrantes uno hace lo de servicios y el otro el de mascotas
Debe tener una rama por integrante, el lider debe tener por lo menos 2 ramas: main y dev. debe trabajar y consolidar en dev
*/
using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("1. Crear Servicio");
            Console.WriteLine("2. Eliminar Servicio");
            Console.WriteLine("3. Listar Servicios");
            Console.WriteLine("4. Crear Mascota");
            Console.WriteLine("5. Eliminar Mascota");
            Console.WriteLine("6. Listar Mascotas");
            Console.WriteLine("7. Crear Boleta");
            Console.WriteLine("8. Listar Boletas");
            Console.WriteLine("0. Salir");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "0":
                    return;
            }
        }
    }
}
