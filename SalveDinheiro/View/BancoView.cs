using SalveDinheiro.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalveDinheiro
{
    class BancoView
    {
        private BancoController controller ;

        public BancoView() {
            controller = new BancoController();
        }

        public string CadastrarConta()
        {
            string numeroConta;
            int numero;
            double saldo;

            Console.WriteLine("Digite o número da conta: ");
            numeroConta = Console.ReadLine();
            Console.WriteLine("Digite o saldo");
            saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o numero de identificação");
            numero = Convert.ToInt32(Console.ReadLine());
            ContaBancaria novaConta = new ContaBancaria(numeroConta, numero);
            novaConta.setSaldo(saldo);
            return controller.cadastrarContaController(novaConta);
           
        }

        public void ExibirContas()
        {
            controller.exibirContaController();
        }

        public string consultarSaldoConta(int numeroId)
        {
            return controller.consultarSaldoController(numeroId);
        }

        public string realizarSaque(int numeroId)
        {
            double saque;
            Console.WriteLine("Digite o valor do saque: ");
            saque = Convert.ToDouble(Console.ReadLine());
            return controller.realizarSaqueController(numeroId, saque); 
        }

        public string realizarDeposito(int numero)
        {

            double valorDeposito;
            Console.WriteLine("Digite valor de depósito: ");
            valorDeposito = Convert.ToDouble(Console.ReadLine());
            return controller.realizarDepositoController(numero, valorDeposito);

        }

        public string removerConta(int numero)
        {
            return controller.removerContaController(numero);
        }

    }
}
