namespace CursoPOO.Models
{
    public class Professor : Pessoa
    {
        public double salario { get; set; }        

        //Polimorfismo override
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e atualmente recebo {salario} por mês");
        }

    }
}