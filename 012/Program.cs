// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
int a;
System.Console.WriteLine ("Введите число a:");
a=Convert.ToInt32 (Console.ReadLine());
int N = 0;
if (a<=99 && a>=10)
{
    N=a;

}
else
{
    Console.WriteLine ("Заднное число не входит в диапозон");
}
int d0,d1,max;
d0=N%10;
d1=N/10%10;
max=d0;
if (d0<d1)
{
    max=d1;
}
Console.WriteLine (max);