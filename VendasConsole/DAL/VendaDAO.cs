﻿using System.Collections.Generic;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class VendaDAO
    {

        private static List<Venda> vendas = new List<Venda>();

        public static List<Venda> Listar() => vendas;

        public static void Cadastrar(Venda venda) => vendas.Add(venda);

    }
}
