using System;

namespace VendasConsole.Models
{
    class Venda
    {
        public Venda()
        {
            CriadoEm = DateTime.Now;
            Cliente = new Cliente();
            Vendedor = new Vendedor();
            Produto = new Produto();
        }

        public DateTime CriadoEm { get; set; }

        public Cliente Cliente { get; set; }

        public Vendedor Vendedor { get; set; }

        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
    }
}
