using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    static class Cycles
    {
        //3.1
        public static double Exponentiate(double a, double b)
        {
            double tmp = 1;
            for (int i = 1; i <= Math.Abs(b); i++)
            {
                tmp *= a;
            }
            if (b < 0)
            {
                tmp = 1 / tmp;
            }
            return tmp;
        }

        //3.2
        public static int[] FindDivisibleNumbers(int a)
        {
            int amont_of_solution = 0;
            for (int i =a; i<1000; i+=a)
            {
                amont_of_solution++;
            }
            int[] result = new int[amont_of_solution];
            result[0] = a;
            for (int i =1; i<amont_of_solution; i++)
            {
                result[i] =result[i-1] + a;
            }
            return result;
        }

        //3.3
        public static int GetSquears(int a)
        {
            int result = Convert.ToInt32(Math.Truncate(Math.Sqrt(a)));
            return result;
        }

        //3.4
        public static int SearchLargestDivisor(int a)
        {
            int tmp = 1;
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                    tmp = i;
            }
            return tmp;
        }

        //3.5
        public static int GetSevens(int a, int b)
        {
            int result = 0;
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                        result += i;
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                        result += i;
                }
            }
            return result;
        }

        //3.6
        public static int SearchFibonacci(int a)
        {
            int fib1 = 1;
            int fib2 = 1;
            int result = 1;
            for (int i = 3; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    result = fib1 + fib2;
                    fib1 = result;
                }
                else
                {
                    result = fib1 + fib2;
                    fib2 = result;
                }
            }
            return result;
        }

        //3.7
        public static int SearchGCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            return (a + b);
        }

        //3.8
        public static int SearchThirdRoot(int a)
        {
            int leftSide = 0;
            int rightSide = a;
            int newLimit = 0;
            while (leftSide * leftSide * leftSide != a && rightSide * rightSide * rightSide != a)
            {
                newLimit = (leftSide + rightSide) / 2;
                if (newLimit * newLimit * newLimit > a)
                {
                    rightSide = newLimit;
                }
                else
                {
                    leftSide = newLimit;
                }
            }
            return newLimit;
        }

        //3.9
        public static int SearchAmountOdd(int a)
        {
            int tmp;
            int result = 0;
            while (a != 0)
            {
                tmp = a % 10;
                if (tmp % 2 != 0)
                    result++;
                a /= 10;
            }
            return result;
        }

        //3.10
        public static int MirrorNumber(int a)
        {
            int tmp1 = 0;
            while (a != 0)
            {
                tmp1 = tmp1 * 10 + a % 10;
                a /= 10;
            }
            return tmp1;
        }

        //3.11
        public static int[] SearchEvenNumbers(int n)
        {
            int amount_of_solution = 0;
            int even = 0; //чет
            int odd = 0;  //нечет
            int tmp;
            for (int i = 0; i <= n; i++)
            {
                int r = i;
                while (r != 0)
                {
                    tmp = r % 10;
                    if (tmp % 2 == 0)
                    {
                        even += tmp;
                    }
                    else
                    {
                        odd += tmp;
                    }
                    r /= 10;
                }
                if (even > odd)
                {
                    amount_of_solution++;
                }
                even = 0;
                odd = 0;
            }
            int[] result = new int[amount_of_solution];
            tmp = 0;
            int tmp_nomber = 0;
            for (int i = 0; i <= n; i++)
            {
                int r = i;
                while (r != 0)
                {
                    tmp = r % 10;
                    if (tmp % 2 == 0)
                    {
                        even += tmp;
                    }
                    else
                    {
                        odd += tmp;
                    }
                    r /= 10;
                }
                if (even > odd)
                {
                    result[tmp_nomber] = i;
                    tmp_nomber++;
                }
                even = 0;
                odd = 0;
            }
            return result;
        }

        //3.12
        public static bool SearchSameNombers(int a, int b)
        {
            bool flag = false;
            while (a != 0)
            {
                int tmp = a % 10;
                for (int i = b; i != 0; i /= 10)
                {
                    if (tmp == i % 10)
                    {
                        flag = true;
                    }
                }
                a /= 10;
            }
            return flag;
        }
    }
}
