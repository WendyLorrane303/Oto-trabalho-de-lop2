using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2Trab
{
    public abstract class Produto : IImprimivel
    {
        protected string _nome;
        protected double _preco;
        Dictionary<Produto, int> estoque = new Dictionary<Produto, int>();  



        public double Preco
        {
            get { return this._preco; }
        }

        public string Nome
        {
            get { return this._nome; }
        }

        public abstract double CalculaValorTotal();
        public abstract void Imprimir();
        

   
    }
}
