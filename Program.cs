using System;

namespace AdicionarProdutos
{
    class Program
    {
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
            Console.WriteLine($"Valor total do produto: {valorProduto.ToString("C2")}");
        }
    }
}
