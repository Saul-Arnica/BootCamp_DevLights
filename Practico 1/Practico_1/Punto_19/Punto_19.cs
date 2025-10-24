/*
 *  19. Contador de dígitos
 *  Pedir un número entero y decir cuántos dígitos tiene.
 */

using System;

namespace Punto_19;

public class Ejercicio_19
{
    public static void Main(/*string[] args*/)
    {
        Console.Write("Ingrese un numero entero:");
        string? ingreso = Console.ReadLine();
        if (ingreso != null)
        {
            if (ingreso.StartsWith("-"))
            {
                ingreso = ingreso.Substring(1); //Esto hace que si se ingresa un numero negativo, ignoremos ese "-"
            }

            bool esValido = true;
            foreach(char c in ingreso)
            {
                if(!char.IsDigit(c))
                {
                    esValido = false;
                    break;
                }
            }

            if (esValido)
            {
                Console.WriteLine($"El número tiene {ingreso.Length} dígitos.");
            }
            else
            {
                Console.WriteLine("Ingrese solo numeros enteros validos por favor..");
            }
        }
    }
}