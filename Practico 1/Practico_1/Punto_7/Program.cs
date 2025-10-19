/*
 * 7. Numero dentro de rango.
 * Pedir un numero y verificar si está dentro del rango 1-100 (inclusive)
 */

using System;

namespace Punto_7;

public class Ejercicio_7
{
    public static void Main(/*string[] args*/)
    {
        Console.Write("Ingrese un numero dentro del rango del 1 al 100:");
        string? ingreso = Console.ReadLine();

        if(!int.TryParse(ingreso, out int NumDeIngreso))
        {
            Console.WriteLine("\nColocaste cualquiera chamigo, pone un numero dentro del 1 al 100...");
        }
        else
        {
            if(NumDeIngreso > 0 && NumDeIngreso <= 100)
            {
                Console.WriteLine("\nEsta dentro del rago, bien ahi loco");
            }
            else if(NumDeIngreso > 100)
            {

                Console.WriteLine("\nComo te dicen? Mbapé? te fuiste re lejos que le pegaste al traba en la tribuna");

            }else if(NumDeIngreso < 0)
            {

                Console.WriteLine("\nJiaaa no sabe leer me parece che...");
            }
        }
    }
}