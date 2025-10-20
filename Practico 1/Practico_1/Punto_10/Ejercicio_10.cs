/*
 * 10. Dia de la semana con switch
 * Pedir un numero del 1 al 7 y mostrar el dia de la semana correspondiente.
 */

using System;

namespace Punto_10;

public class Ejercicio_10
{
    public static void Main(/*string[] args*/)
    {
        Console.Write("Ingrese un numero del 1 al 7 para elegir un dia de la semana:");
        string? ingreso = Console.ReadLine();

        if(!int.TryParse(ingreso, out int dia))
        {
            Console.WriteLine("No ingreso un numero...");

        }else if(dia >= 1 && dia <= 7)
        {
            switch (dia)
            {
                case 1: Console.WriteLine("Lunes");
                    break;
                case 2: Console.WriteLine("Martes");
                    break;
                case 3: Console.WriteLine("Miercoles");
                    break;
                case 4: Console.WriteLine("Jueves");
                    break;
                case 5: Console.WriteLine("Viernes");
                    break;
                case 6: Console.WriteLine("Sabado");
                    break;
                case 7: Console.WriteLine("Domingo");
                    break;
            }
        }
        else
        {
            Console.WriteLine("No ingreso un numero dentro del rango, intente de nuevo.");
        }
    }
}