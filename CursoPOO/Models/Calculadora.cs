using CursoPOO.Interfaces;

namespace CursoPOO.Models
{
    public class Calculadora : ICalculadora
    {
        /*
        //Polimorfismo Early binding (dois metodos com mesmo nome)
        public int somar(int num1, int num2)
        {
            return num1 + num2;
        }
        
        //overload
        public int somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        */

        //implementing interface members
        public int dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}