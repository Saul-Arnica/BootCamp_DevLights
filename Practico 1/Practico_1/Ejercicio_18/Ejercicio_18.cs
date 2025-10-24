/*
 * Suma acumulada con condición: Pedir números y sumar hasta que la suma supere 
 * 100. Mostrar cuántos números se ingresaron.
 */

using System;

namespace Punto_18;

public class Ejercicio_18
{
    public static void Main(/*string[] args*/)
    {
        Console.WriteLine("Ingrese numeros variados hasta que el conjunto de numeros sume mas de 100:");
        bool continua = true;
        int contador = 0;
        int acumulador = 0;

        while (continua)
        {
            string? ingreso = Console.ReadLine();
            if (!int.TryParse(ingreso, out int numero))
            {
                Console.WriteLine("Ingrese un numero por favor, intente de nuevo...");
                continue;
            }
            else
            {
                contador++;
                acumulador += numero;
                if(acumulador > 100)
                {
                    continua = false;
                }
            }

        }

        Console.WriteLine($"Se ingresaron {contador} cantidad de numeros");
    }
}