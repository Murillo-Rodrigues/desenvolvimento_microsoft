using System;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views.Cadastrar
{
    class CadastrarProduto
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.WriteLine(" ---- Cadastrar Produto ---- \n\n");

            Console.WriteLine("Insira o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("\nInsira o preço do produto: ");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInsira a quantidade do produto: ");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());

            if (Validacao.ValidarNome(p.Nome))
            {
                if (ProdutoDAO.Cadastrar(p))
                {
                    Console.WriteLine("\n\nCliente cadastrado com sucesso!\n\n");
                }
                else
                {
                    Console.WriteLine("\n\nEste cliente já existe!\n\n");
                }

            }
            else
            {
                Console.WriteLine("\n\nNão foi possível cadastrar!\n\n");
            }
        }

    }


}
}
