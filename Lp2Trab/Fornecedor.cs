using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2Trab
{
   public class Fornecedor : IImprimivel
    {
        private string _nome;
        private string _cnpj;
        private List<Produto> _item;
        public string Nome
        {
            get
            {
                return this._nome;
            }
        }

        public string Cnpj
        {
            get
            {
                return this._cnpj;
            }
        }
       
        public Fornecedor(string nome, string tel, string cnpj, List<Produto> produtos)
        {
            this._nome = nome;
            this._cnpj = cnpj;
            this._item = produtos;
        }
        public void Imprimir()
        {
            Console.WriteLine("Nome:\t{0}", this.Nome);
            Console.WriteLine("CNPJ:\t{0}", this.Cnpj);
            foreach (var item in _item)
            {
                item.Imprimir();
                Console.WriteLine("---------------------------");
            }
        }
    }
}  

