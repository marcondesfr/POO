using System;
using System.Globalization;

namespace POO7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email;
            int quarto;
            System.Console.Write("HOW MANY ROONS WILL BE RENTED? ");
            int N = int.Parse(Console.ReadLine());
            Aluno[] Student = new Aluno[10];

            for (int i = 0; i < N; i++ ) {
                
                System.Console.WriteLine();
                System.Console.WriteLine($"RENT{i + 1}");
                System.Console.Write("NOME: ");
                name = Console.ReadLine();
                System.Console.Write("E-MAIL: ");
                email = Console.ReadLine();
                System.Console.Write("NUMERO DO QUARTO: ");
                quarto = int.Parse(Console.ReadLine());
                System.Console.WriteLine();
                System.Console.WriteLine("NOME: " + name);
                System.Console.WriteLine("EMAIL: " + email);
                System.Console.WriteLine("QUARTO: " + quarto);
                System.Console.WriteLine();
                
                Student[quarto] = new Aluno(name, email);
            }
            
            for ( int j = 0 ; j < 10 ; j++ ) {
                if ( Student[j] != null ) {
                    System.Console.WriteLine("BUSY ROONS");
                    System.Console.WriteLine($"{j + 1}: {Student[j]}");

                }
            }
            


        }
    }
}
