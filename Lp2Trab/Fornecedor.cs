using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2Trab
{
    class Fornecedor
    {
        private string nome;
        private string cnpj;

        public string Nome
        {
            get
            {
                return this.nome;
            }
        }

        public string CNPJ
        {
            get
            {
                return this.cnpj;
            }
        }

        public Fornecedor(string nome, string CNPJ)
        {
            this.nome = nome;
            this.cnpj = CNPJ;
        }
        public void Imprimir()
        {
            Console.WriteLine("Nome:\t{0}", this.Nome);
            Console.WriteLine("CNPJ:\t{0}", this.cnpj);
        }
    }
}  

