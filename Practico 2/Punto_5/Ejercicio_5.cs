/*
 * 5. Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en lugares pares. 
 * Imprimir la matriz por pantalla 
 */


using System;
using System.Collections.Generic;

namespace Punto_5;

public class Ejercicio_5
{
    public static void Main(/*string[] args*/)
    {
        char[,] matriz = new char[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                int valor = i + j;
                matriz[i, j] = (valor % 2 == 0) ? 'P' : 'I';
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}