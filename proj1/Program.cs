using System;
using System.Globalization;

namespace proj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            System.Console.WriteLine("Entre com os dados do protudo:");
            System.Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            System.Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine($"Dados do produto {p}");
            System.Console.WriteLine();
            System.Console.Write("Digite o numero de produtos a serem adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            System.Console.WriteLine();
            System.Console.WriteLine($"Dados atualizados: {p}");
            System.Console.WriteLine();
            System.Console.Write($"Digite o numero de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            System.Console.WriteLine();
            System.Console.WriteLine($"Dados atualizados: {p}"); 
        }
    }
}
