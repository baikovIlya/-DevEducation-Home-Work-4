using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    internal class TwoDimArrayCtrl
    {
        //5.1
        public static int SearchMin(int[,] ar)
        {
            int min = ar[0,0];
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    if (ar[i, j] < min)
                    {
                        min = ar[i, j];
                    }
                }
            }
            return min;
        }

        //5.2
        public static int SearchMax(int[,] ar)
        {
            int max = ar[0, 0];
            for (int i = 0; i < ar.GetLength(0); i++)
                for (int j = 0; j < ar.GetLength(1); j++)
                    if (ar[i, j] > max)
                    {
                        max = ar[i, j];
                    }
            return max;
        }

        //5.3
        public static int[] SearchIndexOfMin(int[,] ar)
        {
            int[] result = new int[2] {0,0};
            int min = ar[0,0];
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    if (ar[i, j] < min)
                    {
                        min = ar[i, j];
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }

        //5.4
        public static int[] SearchIndexOfMax(int[,] ar)
        {
            int[] result = new int[2] { 0, 0 };
            int max = ar[0, 0];
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    if (ar[i, j] > max)
                    {
                        max = ar[i, j];
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }

        //5.5
        public static int CountElemsHigherThanNaibor(int[,] ar)
        {
            int count = 0;
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    if(
                        (i == 0 || ar[i,j]> ar[i-1,j])
                        && (i == ar.GetLength(0) - 1 || ar[i,j]> ar[i+1,j])
                        && (j ==0 || ar[i,j]> ar[i,j-1])
                        && (j == ar.GetLength(1) - 1 || ar[i,j]> ar[i,j+1])
                        )
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        //5.6
        public static int[,] FlipDiagonally(int[,] ar)
        {
            int[,] result = Copy(ar);
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = i+1; j < ar.GetLength(1); j++)
                {
                    int tmp = result[i, j];
                    result[i, j] = result[j,i];
                    result[j,i] = tmp;
                }
            }
            return result;
        }

        public static int[,] Copy(int[,] ar)
        {
            int[,] newArray = new int[ar.GetLength(0),ar.GetLength(1)];
            Array.Copy(ar, newArray, ar.Length);
            return newArray;
        }

        public static void Write(int[,] ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.Write($"{ ar[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] GenerateRandom(int a, int b, int min = -100, int max = 101)
        {
            if (a < 0 || b < 0)
            {
                throw new Exception("lenght >=0");
            }

            Random random = new Random();
            int[,] result = new int[a,b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                { 
                result[i, j] = random.Next(min, max);
                }
            }

            return result;
        }
    }
}
