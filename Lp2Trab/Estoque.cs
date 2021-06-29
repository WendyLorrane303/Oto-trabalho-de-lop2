using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2Trab
{
  public class Estoque : Carrinho
    {
        private Dictionary<Produto, int> Obj;
        public Dictionary<Produto, int> Jbo
        {
            get
            {
                return this.Obj;
            }
        }
        public Estoque(Dictionary<Produto, int> Objetos)
        {
            this.Obj = Objetos;
        }
        public void Atz_Estoque(Compra compra)
        {
            int y = 0;
            foreach (KeyValuePair<Produto, int> PO in compra.Carrinho.Itens)
            {
                int quantidade = Obj[PO.Key];
                if (PO.Value > quantidade && y == 0)
                {
                    Console.WriteLine("A compra não pode ser finalizada", compra.Cliente.Nome);
                    y = y + 1;
                    break;
                }
            }
            if (y == 0)
            {
                foreach (Produto qualquercoisa in compra.Carrinho.Itens.Keys)
                {

                    if (Obj.ContainsKey(qualquercoisa))
                    {
                        this.Obj[qualquercoisa] = this.Obj[qualquercoisa] - compra.Carrinho.Itens[qualquercoisa];
                    }

                }
                Console.WriteLine("A compra do cliente {0} foi Realizada", compra.Cliente.Nome);
            }


        }
        public override void Imprimir()
        {
            Console.WriteLine("======== ESTOQUE ========");
            foreach (KeyValuePair<Produto, int> parOrdenado in this.Obj)
            {
                Console.WriteLine("Nome:\t{0}", parOrdenado.Key.Nome);
                Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);
                Console.WriteLine("==========================");
            }
        }
    }
}

