namespace CursoPOO.Models
{
    //base class or mother class
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Depositar(double dinheiro);

        public void ExibirSaldo()
        {
            System.Console.WriteLine("O saldo da Conta é: " + saldo);
        }
    }
}