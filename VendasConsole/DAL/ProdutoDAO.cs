using System.Collections.Generic;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class ProdutoDAO
    {
        private static List<Produto> produtos = new List<Produto>();

        public static List<Produto> Listar() => produtos;

        public static bool Cadastrar(Produto p)
        {
            if (BuscarProduto(p.Nome) == null)
            {
                produtos.Add(p);
                return true;
            }
            return false;
        }

        public static Produto BuscarProduto(string nome)
        {
            foreach (Produto produtoCadastrado in produtos)
            {
                if (produtoCadastrado.Nome == nome)
                {
                    return produtoCadastrado;
                }
            }
            return null;
        }
    }
}
