using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2Trab
{
    public class Compra : IImprimivel
    {
        private Cliente cliente;
        private Carrinho carrinho;
        public DateTime data;
        public Cliente Cliente
        {
            get
            {
                return this.cliente;
            }
        }

        public Carrinho Carrinho
        {
            get
            {
                return this.carrinho;
            }
        }
        public DateTime Data
        {
            get
            {
                return this.Data;
            }
        }
        public Compra(Cliente cliente, Carrinho carrinho)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.data = DateTime.Today;
        }
        public void Imprimir()
        {
            this.Cliente.Imprimir();
            Console.WriteLine(this.data.ToString("g"));
            Console.WriteLine("Total do carrinho:\tR$ {0:0.00}", this.Carrinho.Total);
        }
    }
}
