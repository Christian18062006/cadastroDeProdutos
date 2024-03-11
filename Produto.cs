using System;
using System.Collections.Generic;
using System.Text;

namespace AdicionarProdutos
{
    class Produto
    {
        public string nomeProduto = string.Empty;
        public double valorProduto;
        public int quantidadeProduto;
        public int verificaPorcentagem()
        {
            if (quantidadeProduto<=10)
            {
                return (0);
            }
            else if(quantidadeProduto>=11 && quantidadeProduto<=20)
            {
                return (10);
            }
            else if(quantidadeProduto>=21 && quantidadeProduto<=50)
            {
                return (20);
            }
            else
            {
                return (25);
            }
        }
    }
}
