using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    public static class Variables
    {
        //1.1
        public static void DivAndRes(int a, int b, out int div, out int res)
        {
            if (b == 0)
            {
                throw new ArgumentException("B = 0 Doesn't work like that");
            }
            div = a / b;
            res = a % b;
        }
        
        //1.2
        public static double SolveTheEquation(int a,int b)
        {
            if (a == b)
            {
                throw new Exception("a = b doesn't work like that");
            }
            double result = (5 * a + b * b) / (b - a);
            return result;
        }
        
        //1.3
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //1.4
        public static double SearchX(int a,int b,int c)
        {
            if (a == 0)
            {
                throw new Exception("A = 0 doesn't work like that");
            }
            double x = (double)(c - b) / a;
            return x;
        }

        //1.5
        public static string GetEquation(double x1,double y1, double x2,double y2)
        {
            if (x1 == x2)
            {
                throw new ArgumentException("X1 = X2 Doesn't work like that");
            }
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;
            string result = $"Y={a}X+{b}";
            return result;
        }
    }
    
}