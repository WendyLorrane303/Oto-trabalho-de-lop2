using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2Trab
{
    class Compra : Carrinho
    {
       public List<Carrinho> carrinho;

        public void compra(Carrinho, Estoque)
        {
            foreach (var items in carrinho)
            {
                foreach (var produt in Estoque)
                {
                    if (produt._nome== items._nome)
                    {
                        int PreçoFinal = items._intens * produt.preco;

                        if (PreçoFinal <=  )
                        {

                        }
                }

            }





        }
    }
}
