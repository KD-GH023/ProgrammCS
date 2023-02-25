// 74.Найти сумму цифр числа

int SumDigits (int N, int s = 0)
{
 if (N == 0) return s;
 return SumDigits(N/10, s + N%10);
}

Console.WriteLine(SumDigits(555));
