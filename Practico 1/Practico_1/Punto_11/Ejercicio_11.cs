/*
 * 11. Menú con switch.
 * Crear un menú con opciones (1. Sumar, 2. Restar, 3. Multiplicar, 4. Dividir).
 * Pedir dos números y ejecutar la operación elegida. 
 */

using System;

namespace Punto_11;

public class Ejercicio_11
{
    public static void Main(/*string[] args*/)
    {
        
        Console.WriteLine("Ingrese una Opcion:");
        Console.Write("\n1-Sumar 2-Restar 3-Multiplicar 4-Dividir");
        
        string? ingreso = Console.ReadLine();

        if (!int.TryParse(ingreso, out int opcion))
        {
            Console.WriteLine("No ingreso un numero. Intente de nuevo...");

        }else if(opcion >= 1 && opcion <= 4)
        {
            Console.WriteLine("Ingrese dos numeros para sumar:");

            Console.Write("Numero 1:");
            string? ingresoNumero1 = Console.ReadLine();

            Console.Write("Numero 2:");
            string? ingresoNumero2 = Console.ReadLine();

            if (!int.TryParse(ingresoNumero1, out int numero1)
             || !int.TryParse(ingresoNumero2, out int numero2))
            {
                Console.WriteLine("Ingreso incorrecto, vuelva a intentar.");
            }
            else
            {
                double resultado;
                switch (opcion)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        Console.WriteLine($"La suma de los numeros ingresados es:{resultado}");
                        break;
                    case 2:
                            resultado = numero1 - numero2;
                            Console.WriteLine($"La resta de los numeros ingresados es:{resultado}");
                        break;
                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine($"La multiplicacion de los numeros ingresados es:{resultado}");
                        break;
                    case 4:
                        resultado = numero1 / numero2;
                        Console.WriteLine($"La division de los numeros ingresados es:{resultado}");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("No ingreso un numero del 1 al 4. Intente de nuevo...");
        }
    }
}