using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    internal class ArrayController
    {
        //4.1
        public static int SearchMin(int[] ar)
        {
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
