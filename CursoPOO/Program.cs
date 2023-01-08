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
            Console.WriteLine($"Area igual a {r1.Area()} metros quadrados");

            Retangulo r2 = new Retangulo();
            System.Console.WriteLine("Defina comprimento e largura");
            r2.DefinirMedidas(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine($"Area igual a {r2.Area()} metros quadrados");


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