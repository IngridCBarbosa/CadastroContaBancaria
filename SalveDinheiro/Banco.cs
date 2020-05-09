using System;
using System.Collections.Generic;
using System.Text;

namespace SalveDinheiro
{
    class Banco
    {
        List<ContaBancaria> contas;
        public Banco() {
            contas = new List<ContaBancaria>();
        }
        public void CadastrarConta()
        {
            string numeroConta;
            int numero;
            double saldo;

            Console.WriteLine("Digite o número da conta: ");
            numeroConta = Console.ReadLine();
            while (NumeroContaExistente(numeroConta))
            {
                Console.WriteLine("Número de conta já cadastrado. Digite novamente: ");
                numeroConta = Console.ReadLine();
            }
            Console.WriteLine("Digite o saldo");
            saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o numero de identificação");
            numero = Convert.ToInt32(Console.ReadLine());
            while (NumeroIdentificadorExistente(numero))
            {
                Console.Write("Numero identificador já existente. Digite novamente: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            ContaBancaria novaConta = new ContaBancaria(numeroConta, numero);
            novaConta.setSaldo(saldo);
            contas.Add(novaConta);
            Console.WriteLine("Conta cadastrada com sucesso!");
        }

        public void ExibirContas()
        {
            foreach(ContaBancaria c in contas)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public void ConsultarSaldoConta(int numeroId)
        {
            ContaBancaria conta = buscaConta(numeroId);
            if(conta != null)
            {
                Console.WriteLine("Saldo: "+conta.getSaldo());
            }
            else
            {
                Console.WriteLine("Conta não cadastrada!");
            }
        }

        public void RealizarSaque(int numeroId)
        {
            double saque;
            ContaBancaria conta = buscaConta(numeroId);
            if(conta != null)
            {
                Console.WriteLine("Digite o valor do saque: ");
                saque = Convert.ToDouble(Console.ReadLine());
                if(saque > conta.getSaldo())
                {
                    Console.WriteLine("Saque não pode ser efetuado");
                }
                else
                {
                    conta.setSaldo(conta.getSaldo() - saque);
                    Console.WriteLine("Saque realizado com sucesso!");
                }
            }
            else
            {
                Console.WriteLine("Conta não cadastrada!");
            }
        }

        public void RealizarDeposito(int numero)
        {
            double valorDeposito;
            ContaBancaria conta = buscaConta(numero);
            if(conta != null)
            {
                Console.WriteLine("Digite valor de depósito: ");
                valorDeposito = Convert.ToDouble(Console.ReadLine());
                conta.setSaldo(conta.getSaldo() + valorDeposito);
                Console.WriteLine("Valor depositado com sucesso");
            }
            else
            {
                Console.WriteLine("Conta não cadastrada!");
            }

        }

        public void removerConta(int numero)
        {
            ContaBancaria conta = buscaConta(numero);
            if(conta != null)
            {
                contas.Remove(conta);
                Console.WriteLine("Conta removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Conta não cadastrada!");
            }
        }

        private ContaBancaria buscaConta(int numero)
        {
            foreach(ContaBancaria c in contas)
            {
                if(c.getNumero() == numero)
                {
                    return c;
                }
            }
            return null;
        }

        private bool NumeroContaExistente(string numeroConta)
        {
            foreach(ContaBancaria conta in contas)
            {
                if(conta.getNumeroConta() == numeroConta)
                {
                    return true;
                }
            }
            return false;

        }

        private bool NumeroIdentificadorExistente(int numero)
        {
            foreach(ContaBancaria conta in contas)
            {
                if(conta.getNumero() == numero)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
