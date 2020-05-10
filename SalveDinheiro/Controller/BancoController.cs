using System;
using System.Collections.Generic;
using System.Text;

namespace SalveDinheiro.Controller
{
    class BancoController
    {
        private List<ContaBancaria> contas;

        public BancoController()
        {
            contas = new List<ContaBancaria>();
        }

        public string cadastrarContaController(ContaBancaria novaConta)
        {
            if(!numeroContaExistente(novaConta.getNumeroConta()) && !numeroIdentificadorExistente(novaConta.getNumero()))
            {
                contas.Add(novaConta);
                return ("Conta cadastrada com sucesso!");
            }
            else
            {
                return ("Conta já cadastrada. Cadastre outra conta");
            }

        }

        public void exibirContaController()
        {
            foreach (ContaBancaria c in contas)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public  string consultarSaldoController(int numeroId)
        {
            ContaBancaria conta = buscaConta(numeroId);
            if(conta != null)
            {
                return ("O saldo: "+conta.getSaldo());
            }
            else
            {
                return ("Conta não cadastrada");
            }

        }

        public string realizarSaqueController(int numeroId, double valorSaque) 
        {
            ContaBancaria conta = buscaConta(numeroId);
            if(conta != null)
            {
                if(valorSaque > conta.getSaldo())
                {
                    return ("Saque não pode ser efetuado, saldo inferior ");
                }
                else
                {
                    conta.setSaldo(conta.getSaldo() - valorSaque);
                    return ("Saque efetuado com sucesso");
                }
            }
            else
            {
                return ("Conta não cadastrada.");
            }
        }

        public string realizarDepositoController(int numeroId, double valorDeposito)
        {
            ContaBancaria conta = buscaConta(numeroId);
            if ( conta != null)
            {
                conta.setSaldo(conta.getSaldo() + valorDeposito);
                return ("Valor depositado com sucesso!");
            }
            else
            {
                return ("Conta não cadastrada");
            }
        }

        public string removerContaController(int numeroId)
        {
            ContaBancaria conta = buscaConta(numeroId);
            if (conta != null)
            {
                contas.Remove(conta);
                return("Conta removida com sucesso!");
            }
            else
            {
                return("Conta não cadastrada!");
            }

        }

        private bool numeroContaExistente(string numeroConta)
        {
            foreach (ContaBancaria conta in contas)
            {
                if (conta.getNumeroConta() == numeroConta)
                {
                    return true;
                }
            }
            return false;

        }

        private bool numeroIdentificadorExistente(int numeroId)
        {
            foreach (ContaBancaria conta in contas)
            {
                if (conta.getNumero() == numeroId)
                {
                    return true;
                }
            }
            return false;


        }

        private ContaBancaria buscaConta(int numeroId)
        {
            foreach (ContaBancaria c in contas)
            {
                if (c.getNumero() == numeroId)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
