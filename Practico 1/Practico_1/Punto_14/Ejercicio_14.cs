/*
 * 14. Contador de letras:
 * Pedir una palabra y mostrar cuantas letras tiene.
 */

using System;
using System.ComponentModel.DataAnnotations;

namespace Punto_14;

public class Ejercicio_14
{
    public static void Main(/*string[] args*/)
    {
        Console.Write("Ingrese una palabra cualquiera:");
        string? ingreso = Console.ReadLine();
        int longitud = 0;
        if (ingreso != null)
        {
            longitud = ingreso.Length;
        }
        
        int contador1 = 0;
        for(int i = 0; i < longitud; i++)
        { 
            contador1++;
        }
        Console.WriteLine($"Tu palabra tiene {contador1} letras contando espacios vacios.");

        int contador2 = 0;
        if(!string.IsNullOrEmpty(ingreso))
        {
            foreach (char c in ingreso)
            {
                if (char.IsLetter(c))
                {
                    contador2++;
                }
            }
        }
        Console.WriteLine($"Tu palabra tiene {contador2} letras sin contar espacios vacios.");
    }
}