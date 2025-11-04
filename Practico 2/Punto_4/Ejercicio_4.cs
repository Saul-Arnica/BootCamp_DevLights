/*
 * 4. Crear una variable para guardar los nombres de elementos para una “lista de supermercado”. 
 * Solicitar al usuario que ingrese el nombre de un elemento que va a comprar en el super y 
 * verificar que el elemento esté en la lista. 
 * Si no está, agregarlo e indicar que no estaba. 
 * Si está, quitarlo de la lista, y avisar que sí estaba. 
 * Al finalizar mostrar por pantalla los elementos que no compró y los que compró, pero no estaban en la lista. 
 * Si se quiere, mostrar también todos los elementos que el usuario compró. 
 * Para salir el usuario debe ingresar “fin”.
 */

using System;
using System.Collections.Generic;

namespace Punto_4;

public class Ejercicio_4
{
    public static void Main(/*string[] args*/)
    {
        List<string> listaSuper = new List<string>() { "leche", "pan", "huevos", "arroz", "azúcar" };
        List<string> compradosFuera = [];

        Console.WriteLine("Lista inicial de supermercado:");
        Console.WriteLine(string.Join(", ", listaSuper)); //Aca convierto todo a un solo texto separado por una ','
        Console.WriteLine("\nIngrese los productos que compra (escriba 'fin' para terminar):");

        while (true)
        {
            Console.Write("> ");
            string? input = Console.ReadLine();

            // Controlar null o cadenas vacías
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("La entrada esta vacía o no ingreso nada. Intente de nuevo.");
                continue; // vuelve al inicio del while
            }

            input = input.ToLower();

            if (input == "fin")
                break;

            if (listaSuper.Contains(input))
            {
                listaSuper.Remove(input);
                Console.WriteLine($"'{input}' estaba en la lista, fue quitado.");
            }
            else
            {
                compradosFuera.Add(input);
                Console.WriteLine($"'{input}' no estaba en la lista, fue agregado a 'comprados fuera'.");
            }

        }

        Console.WriteLine("\n- Resumen -");
        Console.WriteLine($"No compró: {string.Join(", ", listaSuper)}");
        Console.WriteLine($"Compró pero no estaban: {string.Join(", ", compradosFuera)}");
    }
}