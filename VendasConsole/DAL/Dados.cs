using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class Dados
    {
        public static void Inicializar()
        {
            Cliente cliente = new Cliente
            {
                Nome = "Murillo Rodrigues",
                Cpf = "11947013963"
            };

            ClienteDAO.Cadastrar(cliente);

            Vendedor vendedor = new Vendedor
            {
                Nome = "Pineapple Vendedor",
                Cpf = "11947013963"
            };

            VendedorDAO.Cadastrar(vendedor);

            Produto produto = new Produto
            {
                Nome = "Carne",
                Preco = 27.50,
                Quantidade = 150
            };

            ProdutoDAO.Cadastrar(produto);
        }
    }
}
