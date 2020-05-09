using System;
using System.Collections.Generic;
using System.Text;

namespace SalveDinheiro
{
    class ContaBancaria
    {
        private string numeroConta;
        private double saldo;
        public int numero;

        public ContaBancaria (string numeroConta, int numero)
        {
            this.numeroConta = numeroConta;
            this.numero = numero;
        }

        public string getNumeroConta()
        {
            return numeroConta;
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public double getSaldo()
        {
            return saldo;
        }

        public int getNumero()
        {
            return numero;
        }

        override
        public string ToString()
        {
            return (
                "Número conta: "+numeroConta+"\nNúmero identificador: "+numero+"\nSaldo: "+saldo
            );
        }
    }
}
