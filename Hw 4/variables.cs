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

        //Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек
        //на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B,
        //проходящей через эти точки.
        public static string TwoPoints(int x1,int y1, int x2,int y2)
        {
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;
            string result = $"Y={a}X+{b}";
            return result;
        }
    }
}