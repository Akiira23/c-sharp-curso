using System;
using Classes.Herança;
using Classes.Metodos;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(10, 20);
            Ponto3D p2 = new Ponto3D(10, 20, 30);
            Console.WriteLine($"Ponto p1: ({p1.x}, {p1.y})");
            Console.WriteLine($"Ponto p2: ({p2.x}, {p2.y}, {p2.z})");
            Ponto3D.Calcular();
            int x = 1, y = 3;
            Ref.Inverter(x, y);
            Out.Dividir();
        }
    }
}
