using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] p1 = new Produto[2];
            p1[0] = new Produto();
            p1[0].Codigo = 1;
            p1[0].Nome = "Armario";
            p1[0].Preco = 199.99;
            p1[1] = new Produto();
            p1[1].Codigo = 2;
            p1[1].Nome = "Sofa";
            p1[1].Preco = 599.99;
            foreach (Produto prod in p1)
            {
                Console.WriteLine($"cod: {prod.getCodigo()}");
                Console.WriteLine($"nome: {prod.getNome()}");
                Console.WriteLine($"preco: {prod.getPreco()}");
                Console.WriteLine($"-------------------------");
            }
            
        }
    }
}
