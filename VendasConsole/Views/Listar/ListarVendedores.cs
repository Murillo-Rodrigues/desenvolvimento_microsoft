using System;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views.Listar
{
    class ListarVendedores
    {
        public static void Renderizar()
        {
            Console.WriteLine(" ---- Listar Vendedores ---- \n\n");
            foreach (Vendedor vendedorCadastrado in VendedorDAO.Listar())
            {
                Console.WriteLine(vendedorCadastrado);
            }
        }
    }
}
