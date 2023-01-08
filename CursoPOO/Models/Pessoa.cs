using System;

namespace CursoPOO.Models
{
    public class Pessoa
    {
        public string Nome {get; set;}
           
        public int Idade {get; set;}

        //change to override metod 
        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");

        }

    }
}