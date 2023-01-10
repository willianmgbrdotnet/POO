using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoPOO.Interfaces
{
    public interface ICalculadora
    {
        int somar(int num1, int num2);
        int subtrair(int num1, int num2);
        int multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        int dividir(int num1, int num2);

    }
}