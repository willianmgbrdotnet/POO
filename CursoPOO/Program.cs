using System;
using CursoPOO.Models;

namespace CursoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polimorfismo Late binding
            Aluno a1 = new Aluno();
            a1.Idade = 19;
            a1.Nome = "Andre";
            a1.nota = 9;
            a1.Apresentar();

            Professor pr1 = new Professor();
            pr1.Nome = "Robert";
            pr1.Idade = 49;
            pr1.salario = 9900.00;
            pr1.Apresentar();

            
            //Encapsulamento
            /*
            Retangulo r1 = new Retangulo();
            r1.DefinirMedidas(30, 15);
            Console.WriteLine($"Area igual a {r1.Area()} metros quadrados");

            Retangulo r2 = new Retangulo();
            System.Console.WriteLine("Defina comprimento e largura");
            r2.DefinirMedidas(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine($"Area igual a {r2.Area()} metros quadrados");
            */


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