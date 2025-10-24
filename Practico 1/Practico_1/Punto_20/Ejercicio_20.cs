/*
 * 20. Contar vocales
 * Pedir una palabra y contar cuantas vocales tiene
 */

using System;

namespace Punto_20;

public class Ejercicio_20
{
    public static void Main(/*string[] args*/)
    {
        Console.Write("Ingrese una palabra:");
        string? ingreso = Console.ReadLine();
        int contadorVocales = 0;
        if(ingreso != null)
        {
            foreach (char c in ingreso)
            {
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    contadorVocales++;
                }
                /*
                 * if("aeiouáéíóúÁÉÍÓÚ".Contains(c)) //Algo mas completo....
                 * {
                 *      contadorVocales++;
                 * }
                 */
            }
        }
        else
        {
            Console.WriteLine("Ingrese una palabra, no deje el campo vacio");
        }

        Console.WriteLine($"La cantidad de vocales en la palabra fueron de {contadorVocales} vocales.");
    }
}