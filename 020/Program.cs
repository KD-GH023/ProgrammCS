// 20. Дано число. Проверить кратно ли оно 7 и 23.
int a;
a=Convert.ToInt32 (Console.ReadLine());
if (a%7==0 && a%23==0)  Console.WriteLine ($"Число {a} кратно 7 и 23");
else Console.WriteLine($"Число {a} некратно 7 и 23");
