/*  
 *  3. Múltiplos de un número: Pedir dos números e indicar si el primero es múltiplo del segundo.
 */

using System;

namespace Punto_3;

public class Ejercicio_3
{
    public static void Main(/*String[] args*/)
    {
        bool esValido = false;

        while (!esValido)
        {
            Console.WriteLine("Ingrese dos numeros para indicar si alguno es multiplo del otro:");
            Console.WriteLine("Numero 1:");
            string? ingreso1 = Console.ReadLine();
            Console.WriteLine("Numero 2:");
            string? ingreso2 = Console.ReadLine();

            if (!int.TryParse(ingreso1, out int numero1) || !int.TryParse(ingreso2, out int numero2))
            {
                Console.WriteLine("Algun numero de los que ingreso es cualquier cosa menos un numero, " +
                                    "ingrese de nuevo. Grax");
                continue;
            }
            else
            {
                if((numero1 % numero2) == 0)
                { 
                    Console.WriteLine($"El numero: {numero1} es multiplo de {numero2}");
                }
                else
                {
                    Console.WriteLine($"El numero: {numero1} no es multiplo de {numero2}");
                }
                esValido = true;
            }
        }
    }
}