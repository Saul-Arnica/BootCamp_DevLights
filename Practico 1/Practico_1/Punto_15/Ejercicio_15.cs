/*
 * 15. Tabla de multiplicar
 * Pedir un número y mostrar su tabla de multiplicar del 1 al 10.
 */

using System;

namespace Punto_15;

public class Ejercicio_15
{
    public static void Main(/*string[] args*/)
    {
        Console.Write("Ingrese un numero para saber su tabla de multiplicar del 1 al 10:");
        string? ingreso = Console.ReadLine();

        if(!int.TryParse(ingreso, out int numeroDeIngreso))
        {
            Console.WriteLine("Lo que ingreso no es un numero. Intente de nuevo");
        }
        else
        {
            for(int i = 1;i <= 10; i++)
            {
                int resultado = i* numeroDeIngreso;
                Console.WriteLine($"{numeroDeIngreso} * {i} = {resultado}");
            }
        }
    }
}