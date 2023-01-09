using System;

namespace CursoPOO.Models
{
    // base class
    public class Pessoa
    {
        public string Nome {get; set;}
           
        public int Idade {get; set;}

        //virtual to override method 
        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");

        }

    }
}