// 22. По двум заданным числам проверять является ли одно квадратом другого.
int a,b;
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
if (b==a*a || a==b*b) Console.WriteLine("Число является квадратом другого числа");
else Console.WriteLine("Ни одно из чисел не является квадратом другого числа");
