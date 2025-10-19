/*
    2. Comparacion de tres números: Pedir tres números distintos y mostrar cuál es el mayor y menor.
 */
using System;
using System.Net.Http.Headers;

namespace Punto_2;

public class Ejercicio_2
{
    public static void Main(/*string[] args*/)

    {
        int numero1 = 0, numero2 = 0, numero3 = 0;
        bool seaValido = false;

        while (!seaValido)
        {
            Console.WriteLine("Ingrese 3 numeros distintos, para salir ingrese 0:");
            Console.WriteLine("Primer numero:");
            string? uno = Console.ReadLine();
            Console.WriteLine("Segundo numero:");
            string? dos = Console.ReadLine();
            Console.WriteLine("Tercer numero:");
            string? tres = Console.ReadLine();

            if (   !int.TryParse(uno, out numero1)
                || !int.TryParse(dos, out numero2)
                || !int.TryParse(tres, out numero3))
            {
                Console.WriteLine("Uno o mas valores no son numeros validos chamigo, media pila che!");
                continue;
            }

            if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
            {
                Console.WriteLine("Los numeros deben ser distintos. Ingresa de nuevo...\n");
                continue;
            }
            seaValido = true;
        }

        //Mostramos mayor y menor.
        //Como Math.Max y Min utiliza 2 parametros, hacemos que el primero se compare con el resultado del otro.
        int mayor = Math.Max(numero1, Math.Max(numero2, numero3));
        int menor = Math.Min(numero1, Math.Min(numero2, numero3));

        Console.WriteLine($"El numero mas grande ingresado es: {mayor}");
        Console.WriteLine($"El numero mas chico ingresado es:{menor}");
    }
}
