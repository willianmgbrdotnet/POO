namespace CursoPOO.Models
{
    public class Calculadora
    {
        //Polimorfismo Early binding (dois metodos com mesmo nome)
        public int somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

    }
}