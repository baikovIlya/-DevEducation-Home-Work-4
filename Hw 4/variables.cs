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
    
    static class Condition
    {
        public static int ChooseOperation(int a,int b)
        {
            if (a > b)
            {
                a = a + b;
            }
            else if (a == b)
            {
                a = a * b;
            }
            else 
            {
                a = a - b;
            }
            return a;
        }
        public static string DefineQuart(int x, int y)
        {
            string result;
            if (x == 0 || y == 0)
            {
                result = "Точка лежит на оси";
            }
            else if (x > 0 && y > 0)
            {
                result = "I четверь";
            }
            else if (x < 0 && y > 0)
            {
                result = "II четверь";
            }
            else if (x < 0 && y < 0)
            {
                result = "III четверть";
            }
            else result = "IV четверть";
            return result;
        }
        public static string ConvertToInscription(int nomber)
        {
            string result = "";
            if (nomber < 20)
            {
                if (nomber == 10)
                    result = "Десять";
                else if (nomber == 11)
                    result = "Одиннадать";
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
                    result = "Тридцацать";
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
                    result += " Один";
                else if (nomber % 10 == 2)
                    result += " Два";
                else if (nomber % 10 == 3)
                    result += " Три";
                else if (nomber % 10 == 4)
                    result += " Четыре";
                else if (nomber % 10 == 5)
                    result += " Пять";
                else if (nomber % 10 == 6)
                    result += " Шесть";
                else if (nomber % 10 == 7)
                    result += " Семь";
                else if (nomber % 10 == 8)
                    result += " Восемь";
                else if (nomber % 10 == 9)
                    result += " Девять";
            }
            return result;
        }
    }
}