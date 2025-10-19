/*
 1. Numero positivo o negativo: Pedir un numero y mostrar si es positivo,
    negativo o cero.
 */

using System;

namespace Punto_1;
public class Ejercicio1
{
    public static void Main(/*string[] args*/)
    /*Acá no se usa el argumento, ya que no se pasan msgs :P
        Pero lo puse igual :V
    */
    {

        Console.WriteLine("Ingresa un numero:");
        string? input = Console.ReadLine();

        if(!int.TryParse(input, out int numero)) 
            {
            Console.WriteLine("Lo ingresado es de todo menos un numero!");
            return; 
        }
        else
        {
            if (numero > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Es 0");
            }
        }
    }
}