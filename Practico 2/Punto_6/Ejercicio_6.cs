/* 6. Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de la semana. 
 * La estructura es para registrar la temperatura diaria de una cabina de pago, 
 * estos oscilan entre los 7 y 38 grados. 
 * Deberá llenar la matriz de forma aleatoria para el mes de mayo donde 
 * el primer día inicia en lunes y el último (31) se ubica en el miércoles 
 * (la matriz puede ser inicializada con valores aleatorios desde el principio del programa,
 * no es necesario pedir los valores al usuario para cada posición). 
 * Se nos pide hacer lo siguiente: 
 * a. Obtener la temperatura más alta y baja de la semana y que día se produjo (lunes, martes, etc.)
 * b. Promedio de temperatura de la semana. 
 * c. Temperatura más alta del mes y su día. 
 */

using System;
using System.Collections.Generic;

namespace Punto_6;

public class Ejercicio_6
{
    public static void Main(/*string[] args*/)
    {
        int[,] temp = new int[5, 7];
        string[] dias = { "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb", "Dom" };
        Random rand = new();

        // Rellenar con valores entre 7 y 38
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
                temp[i, j] = rand.Next(7, 39);
        }

        int tempMaxMes = int.MinValue;
        string diaMaxMes = "";
        int semanaMaxMes = 0;

        // Procesar semanas
        for (int i = 0; i < 5; i++)
        {
            int suma = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            int diaMax = 0;
            int diaMin = 0;

            for (int j = 0; j < 7; j++)
            {
                int t = temp[i, j];
                suma += t;

                if (t > max) { max = t; diaMax = j; }
                if (t < min) { min = t; diaMin = j; }

                if (t > tempMaxMes)
                {
                    tempMaxMes = t;
                    diaMaxMes = dias[j];
                    semanaMaxMes = i + 1;
                }
            }

            double promedio = suma / 7.0;
            Console.WriteLine($"\nSemana {i + 1}:");
            Console.WriteLine($"-Máxima: {max}° ({dias[diaMax]})");
            Console.WriteLine($"-Mínima: {min}° ({dias[diaMin]})");
            Console.WriteLine($"-Promedio semanal: {promedio:F2}°");
        }

        Console.WriteLine($"\nTemperatura más alta del mes: {tempMaxMes}° en la semana " +
                                                                                $"{semanaMaxMes} ({diaMaxMes})");
    }
}