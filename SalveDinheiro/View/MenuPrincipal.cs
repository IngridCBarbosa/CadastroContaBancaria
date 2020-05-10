using System;
using System.Collections.Generic;
using System.Text;

namespace SalveDinheiro.View
{
    class MenuPrincipal
    {
        public void menuPrincipal()
        {
            BancoView bancoSalveDinheiro = new BancoView();
            int opcao;
            do
            {
                Console.WriteLine("1-Cadastrar Conta");
                Console.WriteLine("2-Exibir Contas Cadastradas");
                Console.WriteLine("3-Consultar Saldo");
                Console.WriteLine("4-Realizar Saque");
                Console.WriteLine("5-Realizar Depósito");
                Console.WriteLine("6-Remover Conta");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        bancoSalveDinheiro.CadastrarConta();
                        break;
                    case 2:
                        bancoSalveDinheiro.ExibirContas();
                        break;
                    case 3:
                        Console.WriteLine(bancoSalveDinheiro.consultarSaldoConta(solicitaNumeroIdentificador()));
                        break;
                    case 4:
                        Console.WriteLine(bancoSalveDinheiro.realizarSaque(solicitaNumeroIdentificador()));
                        break;
                    case 5:
                        Console.WriteLine(bancoSalveDinheiro.realizarDeposito(solicitaNumeroIdentificador()));
                        break;
                    case 6:
                        Console.WriteLine(bancoSalveDinheiro.removerConta(solicitaNumeroIdentificador()));
                        break;
                    default:
                        break;
                }

            } while (opcao == 1 || opcao == 2 || opcao == 3 || opcao == 4 || opcao == 5 || opcao == 6);
        }
        public  int solicitaNumeroIdentificador()
        {
            int numero;
            Console.WriteLine("Digite o numero de identidicação: ");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}
