using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2Trab
{
    public class Cliente : IImprimivel
    {
        private string _nome;
        private string _cpf;
        public int _limiteCartao;
       

        public string Nome
        {
            get
            {
                return this._nome;
            }
        }

        public string Cpf
        {
            get
            {
                return this._cpf;
            }
        }
        public int limiteCartao
        {
            get
            {
                return this._limiteCartao;
            }
        }

        public Cliente(string nome, string cpf, int limiteCarta)
        {
            this._nome = nome;
            this._cpf = cpf;
            this._limiteCartao = limiteCarta;
        }
        public void Imprimir()
        {
            Console.WriteLine("Nome:\t\t\t{0}", this.Nome);
            Console.WriteLine("CPF:\t\t\t{0}", this.Cpf);
            Console.WriteLine("Limite do Cartão:\t{0}", this.limiteCartao);
        }
    }
}
