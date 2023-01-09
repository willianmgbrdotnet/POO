using System;
using CursoPOO.Models;

namespace CursoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trying implement sealed method
            Diretor dr = new Diretor();
            dr.Nome = "Boss";
            dr.salario = 10000;

            /*error CS0239: "Diretor.Apresentar()": não é possível substituir o membro herdado "Professor
.Apresentar()" porque ele é sealed [C:\DIO\POO\CursoPOO\CursoPOO.csproj]
            dr.Apresentar();
            */
            dr.Apresentar();

            /*
            //implementando abstract class
            Corrente c = new Corrente();

            //setting Inherited members to object
            System.Console.WriteLine("Quanto de dinheiro você quer depositar");
            c.Depositar(double.Parse(Console.ReadLine()));

            c.ExibirSaldo();

            //User interactions
            System.Console.WriteLine("Quanto você gostaria de ter como limite da sua conta? Digite um valor");
            System.Console.ReadLine();
            System.Console.WriteLine("Procure o seu genente");
            */

            /*
            //Early binding Polimorfismo
            Calculadora calc = new Calculadora();
            System.Console.WriteLine($"Resultado da primeira soma é {calc.somar(20, 58)}");
            System.Console.WriteLine($"Resultado da primeira soma é {calc.somar(15, 10, 20)}");
            */

            //Polimorfismo Late binding
            /*
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
            */

            
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