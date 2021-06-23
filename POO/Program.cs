using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "Armario";
            p1.Preco = 199.99;
            Console.WriteLine($"cod: {p1.getCodigo()}");
            Console.WriteLine($"nome: {p1.getNome()}");
            Console.WriteLine($"preco: {p1.getPreco()}");
        }
    }
}
