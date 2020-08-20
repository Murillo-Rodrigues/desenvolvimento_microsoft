using System;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views.Cadastrar
{
    class CadastrarCliente
    {
        public static void Renderizar()
        {
            Cliente c = new Cliente();
            Console.WriteLine(" ---- Cadastrar Cliente ---- \n\n");

            Console.WriteLine("Insira o nome do cliente: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("\nInsira o CPF do cliente: ");
            c.Cpf = Console.ReadLine();

            if (Validacao.ValidarCpf(c.Cpf))
            {
                if (ClienteDAO.Cadastrar(c))
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
