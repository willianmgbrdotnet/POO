namespace CursoPOO.Models
{
    public class Corrente : Conta
    {
        public override void Depositar(double dinheiro)
        {
            base.saldo = dinheiro;
        }

    }
}