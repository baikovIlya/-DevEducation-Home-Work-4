using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    public static class Cycles
    {
        //3.1
        public static double Exponentiate(double a, double b)
        {
            double tmp = 1;
            for (int i = 1; i <= Math.Abs(b); i++)
            {
                tmp *= a;
            }
            if (b < 0 && tmp != 0)
            {
                tmp = 1 / tmp;
            }
            return tmp;
        }

        //3.2
        public static int[] FindDivisibleNumbers(int a)
        {
            if (a==0)
            {
                throw new ArgumentException("A = 0 it has no divisors");
            }
            int amont_of_solution = 0;
            for (int i =Math.Abs(a); i<=1000; i+= Math.Abs(a))
            {
                amont_of_solution++;
            }
            int[] result = new int[amont_of_solution];
            result[0] = Math.Abs(a);
            for (int i =1; i<amont_of_solution; i++)
            {
                result[i] =result[i-1] + Math.Abs(a);
            }
            return result;
        }

        //3.3
        public static int GetSquears(int nomber)
        {
            int result = 0;
            for (int i =1; i<nomber;i++)
            {
                if (i*i < nomber)
                {
                    result++;
                }
            }
            return result;
        }

        //3.4
        public static int SearchLargestDivisor(int nomber)
        {
            int result = 1;
            if (nomber == 0)
            {
                throw new ArgumentException("Nomber = 0 it has no divisors");
            }
            for (int i = 2; i <= Math.Abs(nomber / 2); i++)
            {
                if (nomber % i == 0)
                {
                    result = i;
                }
            }
            return result;
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
            if (a<1)
            {
                throw new ArgumentException("Only positive nombers");
            }
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
            if(a == 0 || b == 0)
            {
                throw new ArgumentException("A or B = 0 it has no divisors");
            }
            a = Math.Abs(a);
            b = Math.Abs(b);
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
        public static double SearchThirdRoot(double nomber)
        {
            if (nomber == 0)
            {
                return 0;
            }
            else 
            {
                double leftSide = 0;
                double rightSide = Math.Abs(nomber);
                double newLimit = rightSide;
                while (
                      Math.Pow(leftSide, 3) != Math.Abs(nomber)
                   && Math.Pow(rightSide, 3) != Math.Abs(nomber))
                {
                    newLimit = (leftSide + rightSide) / 2;
                    if (Math.Pow(newLimit, 3) > Math.Abs(nomber))
                    {
                        rightSide = newLimit;
                    }
                    else
                    {
                        leftSide = newLimit;
                    }
                }
                if (nomber < 0)
                {
                    return -newLimit;
                }
                else
                {
                    return newLimit;
                }
            }
        }

        //3.9
        public static int SearchAmountOdd(int nomber)
        {
            int tmp;
            int result = 0;
            while (nomber != 0)
            {
                tmp = nomber % 10;
                if (tmp % 2 != 0)
                    result++;
                nomber /= 10;
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
            if (n<1)
            {
                throw new ArgumentException("Only positive nombers");
            }
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
            if (a == b)
            {
                flag = true;
            }
            if (a == 0)
            {
                for(int i = b; i != 0; i /= 10)
                {
                    if(i%10 == 0)
                    {
                        flag = true;
                    }
                }
            }
            if (b == 0)
            {
                for(int i = a; i != 0; i /= 10)
                {
                    if(i % 10 == 0)
                    {
                        flag = true;
                    }
                }
            }    
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
