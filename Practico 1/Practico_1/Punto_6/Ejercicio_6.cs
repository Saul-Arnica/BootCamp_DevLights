/*
 * 6. Clasificacion por edad
 * Pedir la edad  mostrar si la persona es niño, adolescente, adulto o adulto mayor("viejo").
 */

using System;

namespace Punto_6;

public class Ejercicio_6
{
    public static void Main(/*string[] args*/)
    {
        Console.Write("Ingrese su edad:");
        string? ingreso = Console.ReadLine();

        if (!int.TryParse(ingreso, out int edad))
        {
            Console.WriteLine("Lo ingresado no es un numero o caracter valido. Intente de nuevo.");
        }
        else
        {
            if(edad >= 0 && edad <= 12)
            {
                Console.WriteLine("\nEs niño");

            }else if(edad >= 13 && edad <= 17)
            {
                Console.WriteLine("\nEs adolescente");

            }else if(edad >= 18 && edad <= 60)
            {
                Console.WriteLine("\nEs adulto");

            }else if(edad > 60)
            {
                Console.WriteLine("\nTas mas cerca del cielo que de la tierra campeon!");
            }
        }
    }
}