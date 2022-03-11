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
        public static void DivAndRes(int a, int b, out int rez1, out int rez2)
        {
            rez1 = a / b;
            rez2 = a % b;
        }
        
        //1.2
        public static double Equation(int a,int b)
        {
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
            double x = (double)(c - b) / a;
            return x;
        }

        //1.5
        public static string GetEquation(int x1,int y1, int x2,int y2)
        {
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;
            string result = $"Y={a}X+{b}";
            return result;
        }
    }
    
}