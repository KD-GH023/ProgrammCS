// 33.Возведите число А в натуральную степень B используя цикл.
int A=Convert.ToInt32 (Console.ReadLine ());
int B=Convert.ToInt32 (Console.ReadLine ());

for(int i=1;i<=B;i++)
{
    Math.Pow(A,B);
}
System.Console.WriteLine(Math.Pow(A,B));
