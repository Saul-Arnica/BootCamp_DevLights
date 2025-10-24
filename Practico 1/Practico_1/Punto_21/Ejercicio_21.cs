/*
 * 21. Mini cajero automático 
 * Simular un cajero con un saldo inicial. Mostrar un menú con opciones: 
 * ● 1) Consultar saldo 
 * ● 2) Depositar 
 * ● 3) Retirar 
 * ● 4) Salir 
 * Validar que no se retire más de lo que hay y que los montos sean positivos.
 */

using System;

namespace Punto_21;

public class Ejercicio_21
{
    public static void Main(/*string[] args*/)
    {
        int opcion;
        Cajero cajero = new Cajero(1000, "Saul Arnica"); // saldo inicial y titular

        do
        {
            Console.WriteLine("\n=== MENÚ CAJERO AUTOMÁTICO ===");
            Console.WriteLine("1) Consultar saldo");
            Console.WriteLine("2) Depositar");
            Console.WriteLine("3) Retirar");
            Console.WriteLine("4) Salir");
            Console.Write("Seleccione una opción: ");

            string? ingreso = Console.ReadLine();
            if (!int.TryParse(ingreso, out opcion))
            {
                Console.WriteLine("Opción inválida. Intente de nuevo.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Saldo actual: ${cajero.ConsultarSaldo()}");
                    break;
                case 2:
                    Console.Write("Ingrese monto a depositar: ");
                    if (double.TryParse(Console.ReadLine(), out double montoDep))
                    {
                        cajero.Depositar(montoDep);
                    }
                    else
                    {
                        Console.WriteLine("Monto inválido.");
                    }
                        
                    break;
                case 3:
                    Console.Write("Ingrese monto a retirar: ");
                    if (double.TryParse(Console.ReadLine(), out double montoRet))
                    {
                        cajero.Retirar(montoRet);
                    }
                    else
                    {
                        Console.WriteLine("Monto inválido.");
                    }
                        
                    break;
                case 4:
                    Console.WriteLine("Saliendo del cajero...");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta. Intente nuevamente.");
                    break;
            }

        } while (opcion != 4);
    }
}