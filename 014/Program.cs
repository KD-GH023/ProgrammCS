// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
int a,b;
a=Convert.ToInt32 (Console.ReadLine());
b=Convert.ToInt32 (Console.ReadLine());
int N;
N=a%b;

if (N<1) Console.WriteLine($"{a} кратно {b}");
else Console.WriteLine($"{a} некратно {b}, остаток от деления {N}");
