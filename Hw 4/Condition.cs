using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    public static class Condition
    {
        //2.1
        public static int ChooseOperation(int a, int b)
        {
            if (a > b)
            {
                a += b;
            }
            else if (a == b)
            {
                a *= b;
            }
            else
            {
                a -= b;
            }
            return a;
        }

        //2.2
        public static string DefineQuart(int x, int y)
        {
            string result;
            if (x == 0 || y == 0)
            {
                result = "Точка лежит на оси";
            }
            else if (x > 0 && y > 0)
            {
                result = "I четверть";
            }
            else if (x < 0 && y > 0)
            {
                result = "II четверть";
            }
            else if (x < 0 && y < 0)
            {
                result = "III четверть";
            }
            else result = "IV четверть";
            return result;
        }

        //2.3
        public static int[] Sort(int a, int b, int c)
        {
            int[] result = new int[3];
            if (a > b && a > c)
            {
                if (b > c)
                {
                    result[0] = c;
                    result[1] = b;
                    result[2] = a;
                }
                else
                {
                    result[0] = b;
                    result[1] = c;
                    result[2] = a;
                }

            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    result[0] = c;
                    result[1] = a;
                    result[2] = b;
                }
                else
                {
                    result[0] = a;
                    result[1] = c;
                    result[2] = b;
                }
            }
            else if (a > b)
            {
                result[0] = b;
                result[1] = a;
                result[2] = c;
            }
            else
            {
                result[0] = a;
                result[1] = b;
                result[2] = c;
            }
            return result;
        }

        //2.4
        public static double[] SolveQuadEquation(double a, double b, double c)
        {
            if (a ==0)
            {
                throw new ArgumentException("If A = 0 then this is not a quadratic equation");
            }
            double d = (b * b) - (4 * a * c);
            if (d > 0)
            {
                double[] result = new double[2];
                result[0] = (-b + Math.Sqrt(d)) / (2 * a);
                result[1] = (-b - Math.Sqrt(d)) / (2 * a);
                return result;
            }
            else if (d == 0)
            {
                double[] result = new double[1];
                result[0] = (-b + Math.Sqrt(d)) / (2 * a);
                return result;
            }
            else 
            {
                double[] result = new double[0];
                return result;
            }
        }

        //2.5
        public static string ConvertToInscription(int nomber)
        {
            if (nomber < 10 || nomber >= 100)
            {
                throw new ArgumentException("Only 10-99 nombers");
            }
            string result = "";
            if (nomber < 20)
            {
                if (nomber == 10)
                    result = "Десять";
                else if (nomber == 11)
                    result = "Одиннадцать";
                else if (nomber == 12)
                    result = "Двенадцть";
                else if (nomber == 13)
                    result = "Тринадцть";
                else if (nomber == 14)
                    result = "Четырнацать";
                else if (nomber == 15)
                    result = "Пятнадцть";
                else if (nomber == 16)
                    result = "Шестнадать";
                else if (nomber == 17)
                    result = "Семнадцть";
                else if (nomber == 18)
                    result = "Восемнацать";
                else if (nomber == 19)
                    result = "Девятнацать";
            }
            else
            {
                if (nomber >= 20 && nomber < 30)
                    result = "Двадцать";
                else if (nomber >= 30 && nomber < 40)
                    result = "Тридцать";
                else if (nomber >= 40 && nomber < 50)
                    result = "Сорок";
                else if (nomber >= 50 && nomber < 60)
                    result = "Пятьдесят";
                else if (nomber >= 60 && nomber < 70)
                    result = "Шестьдесят";
                else if (nomber >= 70 && nomber < 80)
                    result = "Семдесят";
                else if (nomber >= 80 && nomber < 90)
                    result = "Восемдесят";
                else if (nomber >= 90)
                    result = "Девяносто";
                if (nomber % 10 == 1)
                    result += " один";
                else if (nomber % 10 == 2)
                    result += " два";
                else if (nomber % 10 == 3)
                    result += " три";
                else if (nomber % 10 == 4)
                    result += " четыре";
                else if (nomber % 10 == 5)
                    result += " пять";
                else if (nomber % 10 == 6)
                    result += " шесть";
                else if (nomber % 10 == 7)
                    result += " семь";
                else if (nomber % 10 == 8)
                    result += " восемь";
                else if (nomber % 10 == 9)
                    result += " девять";
            }
            return result;
        }

    }     
}