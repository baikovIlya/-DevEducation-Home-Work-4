using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    public static class ArrayControl
    {
        //4.1
        public static int SearchMin(int[] ar)
        {
            if (ar.Length == 0)
            {
                throw new ArgumentException("Empty archive has no min element");
            }
            int min = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < min)
                {
                    min = ar[i];
                }
            }
            return min;
        }

        //4.2
        public static int SearchMax(int[] ar)
        {
            if (ar.Length == 0)
            {
                throw new ArgumentException("Empty archive has no max element");
            }
            int max = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                {
                    max = ar[i];
                }
            }
            return max;
        }

        //4.3
        public static int GetIndexOfMin(int[]ar)
        {
            if (ar.Length == 0)
            {
                throw new ArgumentException("Empty archive has no min element");
            }
            int min = ar[0];
            int index_of_min = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < min)
                {
                    index_of_min = i;
                }
            }
            return index_of_min;
        }

        //4.4
        public static int GetIndexOfMax(int[] ar)
        {
            if (ar.Length == 0)
            {
                throw new ArgumentException("Empty archive has no max element");
            }
            int index_of_max = 0;
            int max = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                {
                    max = ar[i];
                    index_of_max = i;
                }
            }
            return index_of_max;
        }

        //4.5
        public static int GetSummOfOddIndex(int[] ar)
        {
            int result = 0;
            for (int i = 1; i < ar.Length; i +=2)
            {
                result +=ar[i];
            }
            return result;
        }

        //4.6
        public static int[] Reverse(int[] ar)
        {
            int[] result = Copy(ar);
            int leng = ar.Length - 1;
            int tmp;
            for (int i = 0; i <= leng/2; i++)
            {
                tmp = result[i];
                result[i] = result[leng - i];
                result[leng - i] = tmp;
            }
            return result;
        }

        //4.7
        public static int GetSummOfOdd(int[] ar)
        {
            int result = 0;
            for (int i = 0; i < ar.Length; i ++)
            {
                if (ar[i]%2 == 1)
                {
                    result++;
                }
            }
            return result;
        }

        //4.8
        public static int[] ReverseOfHalf(int[] ar)
        {
            int[] result = Copy(ar);
            int tmp;
            for (int i = 0; i < ar.Length / 2; i++)
            {
                tmp = result[ar.Length - i - 1];
                result[ar.Length - i - 1] = result[ar.Length/2 -i -1];
                result[ar.Length/2 - i - 1] = tmp;
                Write(result);
            }
            return result;
        }

        //4,9
        public static int[] SortAscending(int[] ar)
        {
            int[] result = Copy(ar);
            int tmp;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j =i+1; j<result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        tmp = result[i];
                        result[i] = result[j];
                        result[j] = tmp;
                    }
                }
            }
            return result;
        }

        //4.10
        public static int[] SortDescending(int[] ar)
        {
            int[] result = Copy(ar);
            for (int i = 1; i < result.Length; i++)
            {
                int current = result[i];
                int location = i-1;
                while (location >= 0 && result[location] < current)
                {
                    result[location+1] = result[location];
                    location--;
                }
                result[location+1] = current;
            }
            return result;
        }


        public static int[] Copy(int[] ar)
        {
            int[] newArray = new int[ar.Length];
            Array.Copy(ar, newArray, ar.Length);
            return newArray;
        }

        public static int[] GenerateRandom(int lenght, int min = -100, int max = 101)
        {
            if (lenght < 0)
            {
                throw new Exception("lenght >=0");
            }

            Random random = new Random();
            int[] ar = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                ar[i] = random.Next(min, max);
            }

            return ar;
        }

        public static void Write(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write($"{ar[i]} ");
            }
            Console.WriteLine();
        }
    }
}
