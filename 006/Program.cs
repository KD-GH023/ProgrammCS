// 6. Написать программу вычисления значения функции y = sin(a). (Класс Math). 
double y;
double a;
System.Console.WriteLine ("Введите число a:");
a=Convert.ToDouble (Console.ReadLine());
y=Math.Sin(a);
Console.WriteLine (y);