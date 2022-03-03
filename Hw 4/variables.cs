using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    static class Variables
    {
        public static double Equation(int a,int b)
        {
            double result = (5 * a + b * b) / (b - a);
            return result;
        }

        //Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите в консоль решение
        //(значение X) линейного уравнения стандартного вида, где A*X+B=C.
        public static double SearchX(int a,int b,int c)
        {
            double x = (double)(c - b) / a;
            return x;
        }
    }
}
