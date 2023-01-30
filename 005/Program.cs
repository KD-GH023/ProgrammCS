// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел.
int a,b,c, max;
System.Console.WriteLine ("Введите число a:");
a=Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine ("Введите число b:");
b=Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine ("Введите число c:");
c=Convert.ToInt32 (Console.ReadLine());

max=a;

if (b>a)
{
max=b;
}
if (c>a)
{
max=c;
}

System.Console.WriteLine ($"max={max}");