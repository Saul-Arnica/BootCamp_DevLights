using System;

namespace Punto_4
{   
    class Producto
    {
        private string nombre;
        private double precio;
        private double precio_Descuento = 1000;

        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public string Nombre
        {
            get { return  nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return  precio; }
            set { precio = value; }

        }
        
        public void AplicarDescuento()
        {
            if (precio > precio_Descuento)
            {
                Console.WriteLine($"El producto {nombre} cuesta ${precio} se le aplicara 10% de descuento.");
                precio *= 0.9; //eto es -> precio = precio * 0.9 
            }
            else
            {
                Console.WriteLine($"El producto {nombre} cuesta ${precio} no tiene descuento.");
            }
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Producto: {nombre}  Precio: ${precio}");
        }
    }
}
