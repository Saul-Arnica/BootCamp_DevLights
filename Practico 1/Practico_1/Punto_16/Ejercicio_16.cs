/*
 *  16. Promedio de notas
 *  Pedir 5 notas, calcular el promedio y mostrar si el estudiante aprueba (>=6) o no. 
 */

using System;

namespace Punto_16
{
    public class Ejercicio_16
    {
        public static void Main(/*string[] args*/)
        {
            double suma = 0;
            int cantidadNotas = 5;

            for (int i = 1; i <= cantidadNotas; i++)
            {
                bool notaValida = false;

                // Bucle para validar entrada
                while (!notaValida)
                {
                    Console.Write($"Ingrese la nota {i}: ");
                    string? entrada = Console.ReadLine();

                    if (double.TryParse(entrada, out double nota) && nota >= 0 && nota <= 10)
                    {
                        suma += nota;
                        notaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor numérico válido entre 0 y 10.");
                    }
                }
            }

            double promedio = suma / cantidadNotas;

            Console.WriteLine($"\nPromedio final: {promedio:F2}");

            if (promedio >= 6)
                Console.WriteLine("El estudiante aprueba.");
            else
                Console.WriteLine("El estudiante no aprueba.");
        }
    }
}



/*
 * Si quiere que se ingresen varios estudiantes y sacar cual aprobo o no:
 * 
 *  public static void Main()
        {
            bool continuar = true;

            while (continuar)
            {
                double suma = 0;
                int cantidadNotas = 5;

                for (int i = 1; i <= cantidadNotas; i++)
                {
                    double nota;
                    bool notaValida = false;

                    while (!notaValida)
                    {
                        Console.Write($"Ingrese la nota {i}: ");
                        string? entrada = Console.ReadLine();

                        if (double.TryParse(entrada, out nota) && nota >= 0 && nota <= 10)
                        {
                            suma += nota;
                            notaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Ingrese un valor válido entre 0 y 10.");
                        }
                    }
                }

                double promedio = suma / cantidadNotas;
                Console.WriteLine($"\nPromedio final: {promedio:F2}");
                Console.WriteLine(promedio >= 6 ? "✅ Aprobado" : "❌ No aprobado");

                Console.Write("\n¿Desea ingresar otro estudiante? (s/n): ");
                string? respuesta = Console.ReadLine();
                continuar = respuesta?.ToLower() == "s";
                Console.WriteLine();
            }
        }
*/



