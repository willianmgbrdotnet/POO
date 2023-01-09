namespace CursoPOO.Models
{
    //Inheritance subclass Aluno
    public class Aluno : Pessoa
    {
        public int nota { get; set; }

        //Polimorfismo override
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e minha média é {nota}");
        }


    }
}