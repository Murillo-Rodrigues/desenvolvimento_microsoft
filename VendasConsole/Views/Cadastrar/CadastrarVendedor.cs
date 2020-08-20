using System;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views.Cadastrar
{
    class CadastrarVendedor
    {
        public static void Renderizar()
        {
            Vendedor v = new Vendedor();
            Console.WriteLine(" ---- Cadastrar Vendedor ---- \n\n");

            Console.WriteLine("Insira o nome do vendedor: ");
            v.Nome = Console.ReadLine();
            Console.WriteLine("\nInsira o CPF do vendedor: ");
            v.Cpf = Console.ReadLine();

            if (Validacao.ValidarCpf(v.Cpf))
            {
                if (VendedorDAO.Cadastrar(v))
                {
                    Console.WriteLine("\n\nVendedor cadastrado com sucesso!\n\n");
                }
                else
                {
                    Console.WriteLine("\n\nEste vendedor já existe!\n\n");
                }

            }
            else
            {
                Console.WriteLine("\n\nNão foi possível cadastrar!\n\n");
            }

        }
    }
}
