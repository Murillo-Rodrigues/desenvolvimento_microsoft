using System;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views.Cadastrar
{
    class CadastrarVenda
    {
        public static void Renderizar()
        {
            Venda venda = new Venda();
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            Produto p = new Produto();
            Console.WriteLine(" ---- Cadastrar Venda ---- \n\n");

            //*********************************************
            //*********************************************
            Console.WriteLine("Insira o CPF do cliente: ");
            c.Cpf = Console.ReadLine();

            c = ClienteDAO.BuscarCliente(c.Cpf);
            if (c != null)
            {
                venda.Cliente = c;
            }
            else
            {
                Console.WriteLine("\nCliente não encontrado!");
            }

            //*********************************************
            //*********************************************
            Console.WriteLine("\nInsira o CPF do vendedor: ");
            v.Cpf = Console.ReadLine();

            v = VendedorDAO.BuscarVendedor(v.Cpf);
            if (v != null)
            {
                venda.Vendedor = v;
            }
            else
            {
                Console.WriteLine("\nVendedor não encontrado!");
            }

            //*********************************************
            //*********************************************
            Console.WriteLine("\nInsira o NOME do produto: ");
            p.Nome = Console.ReadLine();

            p = ProdutoDAO.BuscarProduto(p.Nome);
            if (p != null)
            {
                venda.Produto = p;
                Console.WriteLine("\nDigite a quantidade do produto: ");
                venda.Quantidade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\nVenda cadastrada com sucesso!\n\n\n");
                VendaDAO.Cadastrar(venda);
            }
            else
            {
                Console.WriteLine("\nProduto não encontrado!");
            }
        }
    }
}
