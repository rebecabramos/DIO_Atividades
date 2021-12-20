using System;
using exemploPOO.Models;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Rebeca Raab";
            p1.Idade = 22;

            p1.Apresentar();
        }
    }
}
