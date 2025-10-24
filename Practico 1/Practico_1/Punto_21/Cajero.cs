using System;
using System.Text.RegularExpressions;

namespace Punto_21
{
    class Cajero
    {
        private double saldo;
        private string titular;

        public Cajero(double saldoInicial, string titular)
        {
            if (saldoInicial < 0)
            {
                Console.WriteLine("El saldo inicial no puede ser negativo. Se asignará 0.");
                saldoInicial = 0;
            }

            Saldo = saldoInicial;
            Titular = titular;
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string Titular
        {
            get { return titular; }
            set
            {
                if (string.IsNullOrEmpty(titular))
                {
                    Console.WriteLine("El nombre del titular no puede estar vacío.");
                }
                else
                {
                    titular = value;
                }
            }
        }

        public double ConsultarSaldo()
        {
            return saldo;
        }

        public void Depositar(double monto)
        {
            if(monto <= 0)
            {
                Console.WriteLine("El monto debe ser positivo.");
                return;
            }

            Saldo += monto;
            Console.WriteLine($"✅ Depósito exitoso de ${monto}. Saldo actual: ${Saldo}");
        }

        public void Retirar(double monto)
        {
            if(monto <= 0)
            {
                Console.WriteLine("El monto debe ser positivo.");
                return;
            }
            if(monto > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }

            saldo -= monto;
            Console.WriteLine($"Retiro exitoso. Saldo actual: ${saldo}");
        }
        
        public void MostrarInformacion()
        {
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo actual: ${Saldo}");
        }
    }
}
