using System;

namespace SalveDinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            menuPrincipal();
        }
        public static void menuPrincipal()
        {
            Banco bancoSalveDinheiro = new Banco();
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
                        bancoSalveDinheiro.ConsultarSaldoConta(solicitaNumeroIdentificador());
                        break;
                    case 4:
                        bancoSalveDinheiro.RealizarSaque(solicitaNumeroIdentificador());
                        break;
                    case 5:
                        bancoSalveDinheiro.RealizarDeposito(solicitaNumeroIdentificador());
                        break;
                    case 6:
                        
                        bancoSalveDinheiro.removerConta(solicitaNumeroIdentificador());
                        break;
                    default:
                        break;
                }

            } while (opcao == 1 || opcao == 2 || opcao == 3 || opcao == 4 || opcao == 5 || opcao == 6);
        }
        public static int solicitaNumeroIdentificador()
        {
            int numero;
            Console.WriteLine("Digite o numero de identidicação: ");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }

    }
}
