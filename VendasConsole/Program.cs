using System;
using System.Collections.Generic;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            Produto p = new Produto();
            List<Cliente> clientes = new List<Cliente>();
            List<Vendedor> vendedores = new List<Vendedor>();
            List<Produto> produtos = new List<Produto>();


            do
            {
                Console.Clear();
                Console.WriteLine("" +
                    "\n ---- APLICAÇÃO DE VENDAS ----" +
                    "\n1 - Cadastrar Cliente" +
                    "\n2 - Listar Clientes" +
                    "\n3 - Cadastrar Vendedor" +
                    "\n4 - Listar Vendedores" +
                    "\n5 - Cadastrar Produto" +
                    "\n6 - Listar Produtos" +
                    "\n0 - Sair");

                Console.WriteLine("\nDigite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        c = new Cliente();
                        Console.WriteLine(" ---- Cadastrar Cliente ---- \n\n");

                        Console.WriteLine("Insira o nome do cliente: ");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("\nInsira o CPF do cliente: ");
                        c.Cpf = Console.ReadLine();

                        if (clientes.Count == 0)
                        {
                            clientes.Add(c);
                            Console.WriteLine("\n\n ---- Cliente cadastrado com sucesso! ----\n\n");

                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Cliente clienteCadastrado in clientes)
                            {
                                if (clienteCadastrado.Cpf == c.Cpf)
                                {
                                    encontrado = true;
                                }

                            }
                            if (!encontrado)
                            {
                                clientes.Add(c);
                                Console.WriteLine("\n\n ---- Cliente cadastrado com sucesso! ----\n\n");
                            }
                            else
                            {
                                Console.WriteLine("\n\nNão foi possível cadastrar!\n\n");
                            }

                        }

                        break;
                    case 2:
                        Console.WriteLine(" ---- Listar Clientes ---- \n\n");
                        foreach (Cliente clienteCadastrado in clientes)
                        {
                            Console.WriteLine(clienteCadastrado);
                        }
                        break;
                    case 3:
                        v = new Vendedor();
                        Console.WriteLine(" ---- Cadastrar Vendedor ---- \n\n");

                        Console.WriteLine("Insira o nome do vendedor: ");
                        v.Nome = Console.ReadLine();
                        Console.WriteLine("\nInsira o CPF do vendedor: ");
                        v.Cpf = Console.ReadLine();

                        if (vendedores.Count == 0)
                        {
                            vendedores.Add(v);
                            Console.WriteLine("\n\n ---- Vendedor cadastrado com sucesso! ----\n\n");

                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Vendedor vendedorCadastrado in vendedores)
                            {
                                if (vendedorCadastrado.Cpf == v.Cpf)
                                {
                                    encontrado = true;
                                }

                            }
                            if (!encontrado)
                            {
                                vendedores.Add(v);
                                Console.WriteLine("\n\n ---- Vendedor cadastrado com sucesso! ----\n\n");
                            }
                            else
                            {
                                Console.WriteLine("\n\nNão foi possível cadastrar!\n\n");
                            }

                        }

                        break;
                    case 4:
                        Console.WriteLine(" ---- Listar Vendedores ---- \n\n");
                        foreach (Vendedor vendedorCadastrado in vendedores)
                        {
                            Console.WriteLine(vendedorCadastrado);
                        }
                        break;
                    case 5:
                        p = new Produto();
                        Console.WriteLine(" ---- Cadastrar Produto ---- \n\n");

                        Console.WriteLine("Insira o nome do produto: ");
                        p.Nome = Console.ReadLine();
                        Console.WriteLine("\nInsira o preço do produto: ");
                        p.Preco = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInsira a quantidade do produto: ");
                        p.Quantidade = Convert.ToInt32(Console.ReadLine());

                        if (produtos.Count == 0)
                        {
                            produtos.Add(p);
                            Console.WriteLine("\n\n ---- Produto cadastrado com sucesso! ----\n\n");

                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Produto produtoCadastrado in produtos)
                            {
                                if (produtoCadastrado.Nome == p.Nome)
                                {
                                    encontrado = true;
                                }

                            }
                            if (!encontrado)
                            {
                                produtos.Add(p);
                                Console.WriteLine("\n\n ---- Produto cadastrado com sucesso! ----\n\n");
                            }
                            else
                            {
                                Console.WriteLine("\n\nNão foi possível cadastrar!\n\n");
                            }

                        }
                        break;
                    case 6:
                        Console.WriteLine(" ---- Listar Produtos ---- \n\n");
                        foreach (Produto produtoCadastrado in produtos)
                        {
                            Console.WriteLine(produtoCadastrado);
                        }
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
