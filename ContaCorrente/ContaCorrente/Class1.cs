using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class ContaCorrente
    {
        public double Numero;
        public double Saldo;
        public string Titular;

        public ContaCorrente(double numero, double saldo, string titular, double deposito, double saque)
        {
            Numero = numero;
            Saldo = saldo;
            Titular = titular;
           
        }
        public double Deposito1()
        {
            return saldo + Deposito();
        }
        public double Saque()
        {
            return saldo - saque();
        }
    }
}
