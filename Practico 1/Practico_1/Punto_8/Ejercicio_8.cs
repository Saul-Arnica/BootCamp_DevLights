/*
 * 8.Operador ternario:
 * Pedir un numero y mostrar "Par" o "Impar" usando el operador ternario
 */

using System;

namespace Punto_8;

public class Ejercicio_8
{
    public static void Main(/*string[] args*/)
    {
        Console.Write("Ingrese un numero:");
        string? ingreso = Console.ReadLine();

        if(!int.TryParse(ingreso, out int numero))
        {
            Console.WriteLine("Lo que ingreso no es un numero.");
        }
        else
        {
            var num = (numero % 2) == 0 ? "ES PAR" : "NO ES PAR. ES IMPAR";
            Console.WriteLine(num);
        }
    }
}