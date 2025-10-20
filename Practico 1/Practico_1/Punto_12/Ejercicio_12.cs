/*
 * 12. Contador de pares.
 * Pedir un numero N y mostrar cujantos numeros pares hay entre 1 y N.
 */


using System;

namespace Punto_12;

public class Ejercicio_12
{
    public static void Main(/*string[] args*/)
    {
        Console.Write("Ingrese un numero cualquiera:");
        string? ingreso = Console.ReadLine();

        if(!int.TryParse(ingreso, out int numero))
        {
            Console.WriteLine("No ingreso un caracter valido. Intente de nuevo..");

        }
        else
        {
            int contador = 0;
            for(int i = 0; i < numero; i++)
            {
                if (i % 2 == 0)
                {
                    contador++;
                }
            }
            Console.WriteLine($"La cantidad de numeros pares que hay desde 1 hasta {numero} es: {contador}");
        }
    }
}