﻿using System;

namespace AdicionarProdutos
{
    class Program
    {
        public static int verificaPorcentagem(int quantidadeProduto)
        {
            if(quantidadeProduto<=10)
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
static void Main(string[] args)
        {
            string nomeProduto = string.Empty;
            double valorProduto;
            int quantidadeProduto;
            Console.WriteLine("Cadastro de produto.");
            Console.WriteLine("Digite o nome do produto.");
            nomeProduto = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto.");
            valorProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a quantidade que você deseja?");
            quantidadeProduto = int.Parse(Console.ReadLine());
            
        }
    }
}
