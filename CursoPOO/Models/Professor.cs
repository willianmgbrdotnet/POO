namespace CursoPOO.Models
{
    //Inheritance subclass Professor
    public class Professor : Pessoa
    {
        public double salario { get; set; }        

        //Polimorfismo override
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e atualmente recebo {salario} por mês");
        }

    }
}