/*
 * Contador hasta que sea cero: Pedir números enteros hasta que el usuario ingrese 0. 
 * Mostrar la cantidad de números introducidos.
 */

using System;

namespace Punto_17;

public class Ejercicio_17
{
    public static void Main(/*string[] args*/)
    {
        Console.WriteLine("Ingrese numeros enteros cualesquiera sean, si desea terminar ingrese 0:");
        int contador = 0;
        bool continuar = true;
        while (continuar)
        {
            Console.Write($"Numero {contador + 1}:");
            string? ingreso = Console.ReadLine();
            if(!int.TryParse(ingreso, out int numero))
            {
                Console.WriteLine("Incorrecto, ingrese numeros enteros, intente de nuevo...");
                continue;
            }
            else
            {
                contador++;

                if (numero == 0)
                {
                    continuar = false;
                }
            }
                
        }

        Console.WriteLine($"\nSe ingresaron {contador} números en total (sin contar el 0).");
    }
}