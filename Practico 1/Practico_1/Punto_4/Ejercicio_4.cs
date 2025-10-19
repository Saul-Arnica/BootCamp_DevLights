/*
 * 4. Descuento en Tienda:
 *  Pedir el precio de un producto y aplicar un descuento del 10% si el precio es > a $1000.
 */

//Para este ejercicio aplique conceptos de POO.

using System;

namespace Punto_4;

public class Ejercicio_4
{
    public static void Main(/*string[] args*/)
    {
        Producto producto1 = new Producto("Collar", 500);
        Producto producto2 = new Producto("Termo", 5000);

        producto1.AplicarDescuento();
        producto2.AplicarDescuento();

        producto1.MostrarInfo();
        producto2.MostrarInfo();
    }    
}