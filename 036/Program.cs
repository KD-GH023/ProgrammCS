// 36. Написать программу вычисления произведения чисел от 1 до N
int N=Convert.ToInt32 (Console.ReadLine ());

int P=1;
for(int i=1;i<=N;i++)
{
  P*=i;
}

System.Console.WriteLine(P);


