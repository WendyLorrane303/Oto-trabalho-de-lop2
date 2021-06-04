using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2Trab
{
    public class Licensa : Produto
    {

        protected string _chaveAtivacao;

        public string ChaveAtivacao
        {
            get { return this._chaveAtivacao; }
        }

        public Licensa(string nome, double preco, string chaveAtivacao)
        {
            this._nome = nome;
            this._preco = preco;
            this._chaveAtivacao = chaveAtivacao;
            
        }

        public override double CalculaValorTotal()
        {
            return this._preco;
        }
        public void PegarProduto(Produto produto)
        {
            this.Estoque.Add(produto);
        }

        public override void Imprimir()
        {
            Console.WriteLine("Software:\t{0}", this.Nome);
            Console.WriteLine("Valor:\t\tR$ {0:0.00}", this.CalculaValorTotal());
           
        }
    }
}
