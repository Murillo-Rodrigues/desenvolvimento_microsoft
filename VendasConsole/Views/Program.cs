using System;
using VendasConsole.DAL;
using VendasConsole.Views.Cadastrar;
using VendasConsole.Views.Listar;

namespace VendasConsole.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados.Inicializar();
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("" +
                    "\n ---- APLICAÇÃO DE VENDAS ----" +
                    "\n1 - Cadastrar Cliente" +
                    "\n2 - Listar Clientes" +
                    "\n3 - Cadastrar Vendedor" +
                    "\n4 - Listar Vendedores" +
                    "\n5 - Cadastrar Produto" +
                    "\n6 - Listar Produtos" +
                    "\n7 - Cadastrar Venda" +
                    "\n8 - Listar Venda" +
                    "\n0 - Sair");

                Console.WriteLine("\nDigite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente.Renderizar();
                        break;
                    case 2:
                        ListarClientes.Renderizar();
                        break;
                    case 3:
                        CadastrarVendedor.Renderizar();
                        break;
                    case 4:
                        ListarVendedores.Renderizar();
                        break;
                    case 5:
                        CadastrarProduto.Renderizar();
                        break;
                    case 6:
                        ListarProdutos.Renderizar();
                        break;
                    case 7:
                        CadastrarVenda.Renderizar();
                        break;
                    case 8:
                        ListarVendas.Renderizar();
                        break;
                    case 9:

                        break;
                    case 0:
                        Console.WriteLine(" ---- Saindo ---- \n\n");
                        break;
                    default:
                        Console.WriteLine(" ---- OPÇÃO INVÁLIDA ---- \n\n");
                        break;
                }
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
