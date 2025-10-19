/*
 * Conversion de tipo: Pedir un numero decimal y convertirlo a entero (usando conversion explícita).
 * Mostrar ambos valores y comentar la diferencia.
 */

using System;

namespace Punto_5;

public class Ejercicio_5
{
    public static void Main(/*string[] args*/)
    {
        double salida = 0.0;
        Console.Write("Ingrese un numero decimal:");
        string? ingreso = Console.ReadLine();

        if (!double.TryParse(ingreso, out salida))
        {
            Console.WriteLine("Lo que ingreso no es un numero decimal. Pruebe de nuevo en otra ocación");
        }
        else
        {
            //En este caso, solicito un numero double(decimal) de ingreso, lo obtengo como tipo string
            //Luego lo intento convertir de string a double y de double a int(entero).
            Console.WriteLine($"Aca lo ingresado esta en tipo string:  \"{ingreso}\" ");
            Console.WriteLine($"Aca lo ingresado esta como double(decimal) {salida}");
            int CasteoSalida = (int)salida;
            Console.WriteLine($"Y aca esta el valor casteado o pasado de decimal a entero(int): {CasteoSalida}");

        }
    }
}