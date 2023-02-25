// 71. Показать натуральные числа от N до 1, N задано
void Loop(int N, int i)

 {
System.Console.Write($"{i,4}");
 if (i<N && i>=1) Loop(N,i+1);//рекурсия
}




Loop(10,1);

