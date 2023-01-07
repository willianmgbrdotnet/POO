using System;

namespace CursoPOO.Models
{
    public class Pessoa
    {
        public string Nome {get; set;}
           
        public int Idade {get; set;}

        public void Apresentar()
        {
            System.Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");

        }

    }
}