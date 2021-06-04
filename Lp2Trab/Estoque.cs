using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2Trab
{
    class Estoque 
    {
        private Dictionary<Produto, int> _items;

        public Dictionary<Produto, int> Items
        {
            get { return this._items; }
        }

        

        public Estoque()
        {
            this._items = new Dictionary<Produto, int>();
        }

        public void AdicionarEstoque(Produto items, int quantidade)
        {
            this._items = items;
            this._quantidade = quantidade;
            Estoque.Add (items, quantidade);
        }

        public void AdicionarEstoque(Produto items)
        {
            this.AdicionarEstoque(items, 1);
        }

        public double Total2
        {
            get
            {
                int quantidadeVendida; 
                int novaQuantidade = this.estoque[Produto].Value - quantidadeVendida;
                this.estoque[Produto] = novaQuantidade;
                return novaQuantidade;
            }
        }

        public void Adicionar(List<Produto> items)
        {
            foreach (var item in items)
            {
                this.Adicionar(items);
            }
        }

        public void AdicionarEstoque(Dictionary<Produto, int> itens)
        {
            foreach (KeyValuePair<Produto, int> PO in itens)
            {
                this.AdicionarEstoque(PO.Key, PO.Value);
            }
        }

        public void ImprimirEstoque()
        {
            Console.WriteLine("======== ESTOQUE==");
            foreach (KeyValuePair<Produto, int> parOrdenado in this._items)
            {
                parOrdenado.Key.Imprimir();
                Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);
                Console.WriteLine("==========================");
            }
            Console.WriteLine("Total De Itens No Estoque:/{0}", this.Total2);
            Console.WriteLine("==========================");
        }
    }

}

