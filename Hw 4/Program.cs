using Hw_4;




//int[,] a = TwoDimArrayCtrl.GenerateRandom(4, 4, 10, 100);
//TwoDimArrayCtrl.Write(a);
//Console.WriteLine();
//int b = TwoDimArrayCtrl.CountElemsHigherThanNaibor(a);
//Console.Write(b);

int[] x = Cycles.FindDivisibleNumbers(0);
for (int i = 0; i < x.Length; i++)
{
    Console.WriteLine(x[i]);
}