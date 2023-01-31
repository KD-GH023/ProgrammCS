// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
int a,d;
Console.WriteLine ("Введите число a");
a = Convert.ToInt32 (Console.ReadLine());
d=a%10; 
Console.WriteLine(d);
