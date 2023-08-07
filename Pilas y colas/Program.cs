using Logica;
using System;
using System.Collections.Generic;



try
{
    {
        PilaNombres pilaNombres = new PilaNombres();
        ColaNombres colaNombres = new ColaNombres();

        while (true)
        {
            Console.WriteLine("1. Agregar nombre");
            Console.WriteLine("2. Sacar nombre de la pila");
            Console.WriteLine("3. Sacar nombre de la cola");
            Console.Write("Selecciona una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa un nombre: ");
                    string? nombre = Console.ReadLine();
                    pilaNombres.AgregarNombre(nombre);
                    colaNombres.AgregarNombre(nombre);
                    break;

                case 2:
                    Console.WriteLine("Nombre sacado de la pila: " + pilaNombres.SacarNombre());
                    break;

                case 3:
                    Console.WriteLine("Nombre sacado de la cola: " + colaNombres.SacarNombre());
                    break;

                default:
                    Console.WriteLine("Opción inválida. Intenta de nuevo.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}