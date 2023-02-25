// 78.С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1. Использовать рекурсию


int Fibonachi(int n)
{
 if (n == 0 || n == 1) return n;
     
 return Fibonachi(n - 1) + Fibonachi(n - 2);
 }
 
for( int i=1;i!=0 && i<10;i++)

 System.Console.WriteLine(Fibonachi(i));

