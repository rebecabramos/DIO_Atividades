using System;
using exemploPOO.Models;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();
            Retangulo r2 = new Retangulo();

            r1.DefinirMedidas(20, 30);
            System.Console.WriteLine($"Area: {r1.ObterArea()}");

            r2.DefinirMedidas(-20, 30);
            System.Console.WriteLine($"Area: {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Rebeca Raab";
            // p1.Idade = 22;

            // p1.Apresentar();
        }
    }
}
