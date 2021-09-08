using System;
using System.Globalization;

namespace estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre com os produtos");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quant = int.Parse(Console.ReadLine());

            Produto prod = new Produto(nome, preco, quant);

            Console.WriteLine("Dados do produto: " + prod);

            Console.Write("Digite o número a ser adicionado no estoque: ");
            int ad = int.Parse(Console.ReadLine());
            prod.adcionarProdutos(ad);

            Console.WriteLine("Dados atualizados: " + prod);



        }
    }
}
