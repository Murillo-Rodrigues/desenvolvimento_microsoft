using System;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views.Listar
{
    class ListarVendas
    {
        public static void Renderizar()
        {
            double totalGeral = 0, totalVenda = 0, totalItem = 0;
            Console.WriteLine(" ---- Listar Vendas ---- \n\n");
            foreach (Venda vendaCadastrada in VendaDAO.Listar())
            {
                totalVenda = 0;
                Console.WriteLine("\n==================================================");
                Console.WriteLine("==================================================");
                Console.WriteLine($"Cliente: {vendaCadastrada.Cliente.Nome}");
                Console.WriteLine($"Vendedor: {vendaCadastrada.Vendedor.Nome}");
                Console.WriteLine("\n ---- ITENS DA VENDA ---- \n");
                Console.WriteLine($"\t{vendaCadastrada.Produto.Nome}");
                totalItem = vendaCadastrada.Produto.Preco * vendaCadastrada.Quantidade;
                Console.WriteLine($"\t{vendaCadastrada.Produto.Preco:C2} x {vendaCadastrada.Quantidade} = {totalItem:C2}");
                totalVenda += totalItem;
                Console.WriteLine($"\nTotal da venda: {totalVenda:C2}");
                totalGeral += totalVenda;
                Console.WriteLine();
            }
            Console.WriteLine($"Total geral: {totalGeral:C2}\n\n");
            Console.WriteLine("==================================================");
            Console.WriteLine("==================================================\n");
        }
    }
}
