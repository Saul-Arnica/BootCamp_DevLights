/*
 * 13. Suma de números impares
 * Calcular la suma de los números impares del 1 al 100.
 */


using System;

namespace Punto_13;

public class Ejercicio_13
{
    public static void Main(/*string[] args*/)
    {
        int valor = 100;
        int acumulador = 0;

        for (int i = 0; i <= valor; i++)
        {
            if(i % 2 != 0)
            {
                acumulador += i; // es lo mismo hacer acumulador = acumulador + i;
            }
        }

        Console.WriteLine($"La suma de los numeros impares del 1 al {valor} es:{acumulador}");
    }
}