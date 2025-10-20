/*
 * 9. Calculo de impuestos:
 * Pedir un ingreso anual y calcular el impuesto
 * < 10,000 = 0%
 * 10,000 y 50,000 = 10%
 * > 50,000 = 20%
 * 
 * Mostrar el monto de impuesto a pagar.
 */

using System;

namespace Punto_9;

public class Ejercicio_9
{
    public static void Main(/*string[] args*/)
    {
        Console.Write("Ingrese su sueldo anual para calcular sus impuestos:$");
        string? ingreso = Console.ReadLine();

        if(!double.TryParse(ingreso, out double ingresoAnual))
        {
            Console.WriteLine("No ingreso un numero o los caracteres ingresados son incorrectos. Intente de nuevo.");
        }else
        {
            if(ingresoAnual < 10000)
            {
                Console.WriteLine("No se le aplican impuestos por sus ingresos. debe pagar $0.00");

            }else if(ingresoAnual >= 10000 && ingresoAnual <= 50000)
            {
                double impuesto_A_Pagar = ingresoAnual * 0.10;
                Console.WriteLine($"Se le aplica un 10%. debe pagar ${impuesto_A_Pagar:F2}.");
            }else if(ingresoAnual > 50000)
            {
                double impuesto_A_Pagar = ingresoAnual * 0.20;
                Console.WriteLine($"Se le aplica un 20%. debe pagar ${impuesto_A_Pagar:F2}.");
            }
        }
    }
}