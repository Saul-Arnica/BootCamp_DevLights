/*
 * 2. Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla
 * cuántos son mayores de edad y cuántos no. 
 */

using System;
using System.Collections.Generic;

namespace Punto_2;

public class Ejercicio_2
{
    public static void Main(/*string[] args*/)
    {
        // Lista de edades de 20 personas (pueden ser fijas o aleatorias)
        List<int> edades = new List<int>();
        Random rand = new Random();

        for (int i = 0; i < 20; i++)
        {
            edades.Add(rand.Next(10, 60)); // edades entre 10 y 60
        }

        int mayores = 0;
        int menores = 0;

        Console.WriteLine("Edades registradas:\n");

        foreach (int edad in edades)
        {
            Console.Write(edad + " ");

            if (edad >= 18)
                mayores++;
            else
                menores++;
        }

        Console.WriteLine("\n---------------------------");
        Console.WriteLine($"Total de personas: {edades.Count}");
        Console.WriteLine($"Mayores de edad: {mayores}");
        Console.WriteLine($"Menores de edad: {menores}");
    }
}