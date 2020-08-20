using System;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views.Listar
{
    class ListarProdutos
    {
        public static void Renderizar()
        {
            Console.WriteLine(" ---- Listar Produtos ---- \n\n");
            foreach (Produto produtoCadastrado in ProdutoDAO.Listar())
            {
                Console.WriteLine(produtoCadastrado);
            }
        }
    }
}
