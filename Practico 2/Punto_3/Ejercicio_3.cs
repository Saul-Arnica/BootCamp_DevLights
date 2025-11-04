/*
 * 3. Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y el que 
 * tenga menos letras de todos. 
 */

using System;
using System.Collections.Generic;

namespace Punto_3;

public class Ejercicio_3
{
    public static void Main(/*string[] args*/)
    {
        List<string> nombres = new List<string>()
            {
                "Saul", "Sergio", "Amancay", "Maxi", "Luana", "Fernando", "Maximiliano"
            };
        //Aca inicializo las variables.
        string nombreMasLargo = nombres[0];
        string nombreMasCorto = nombres[0];
        //Buscamos el nombre mas largo y corto.
        foreach (string nombre in nombres)
        {
            if (nombre.Length > nombreMasLargo.Length)
                nombreMasLargo = nombre;

            if (nombre.Length < nombreMasCorto.Length)
                nombreMasCorto = nombre;
        }
        //Mostramos los nombres :P
        Console.WriteLine("Nombres ingresados:");
        foreach (string n in nombres)
            Console.WriteLine(n);
        //Y aca lo mismo pero con el mas largo y el mas corto.
        Console.WriteLine($"\nNombre con más letras: {nombreMasLargo} ({nombreMasLargo.Length})");
        Console.WriteLine($"Nombre con menos letras: {nombreMasCorto} ({nombreMasCorto.Length})");
    }
}