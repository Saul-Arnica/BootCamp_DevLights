/*
 *  1. Dado que se tiene almacenado en una lista, los resultados de los últimos 10 
 *  exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10 notas de
 *  los exámenes y el promedio resultante
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Punto_1;

public class Ejercicio_1
{
    public static void Main(/*string[] args*/)
    {
        double promedio = 0;
        int contador = 1;
        List<int> notas =
        //Agregamos las notas.
        [
            6,
            7,
            7,
            8,
            7,
            7,
            7,
            6,
            8,
            9,
        ]; 
        //Tambien puede ser "var notas = new List<int>();" y luego notas.Add(x);
        
        Console.WriteLine("Las notas del alumno fueron:");
        foreach (int i in notas)
        {
            
            promedio += i;
            Console.WriteLine($"Nota {contador}:{i}");
            contador++;
        }

        promedio /= notas.Count; //esto es lo mismo que promedio = promedio / notas.Count;
        Console.WriteLine($"El promedio del alumno es: {promedio:F2}");
    }
}