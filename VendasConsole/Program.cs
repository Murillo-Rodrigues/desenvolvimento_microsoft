﻿using System;
using System.Collections;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Cliente c = new Cliente();

            do
            {
                Console.Clear();
                Console.WriteLine("" +
                    "\n ---- APLICAÇÃO DE VENDAS ----" +
                    "\n1 - Cadastrar Cliente" +
                    "\n2 - Listar Clientes" +
                    "\n0 - Sair");

                Console.WriteLine("\nDigite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine(" ---- Cadastrar Cliente ---- \n\n");
                        
                        Console.WriteLine("Insira o nome do cliente: ");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Insira o CPF do cliente: ");
                        c.Cpf = Console.ReadLine();
                        Console.WriteLine($"Nome: {c.Nome} e CPF: {c.Cpf}");
                        break;
                    case 2:
                        Console.WriteLine(" ---- Listar Clientes ---- \n\n");
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

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
