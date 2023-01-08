using System;
using CursoPOO.Models;

namespace CursoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();

            r1.DefinirMedidas(30, 15);
            r1.Area();

            Console.WriteLine($"Area igual a {r1.Area()} metros quadrados");


            //Abstração
            /*
            Pessoa p1 = new Pessoa();

            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Apresentar();
            */
        }
    }
}