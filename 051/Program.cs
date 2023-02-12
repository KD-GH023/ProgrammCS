// 51.С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
int N=Convert.ToInt32(Console.ReadLine());
int[] a=new int[N];
PrintArray(a);
ActionResult(a);



void PrintArray (int[] a)
{

for (int i=0;i<a.Length;i++)
{
   Console.Write($"Введите элемент массива {i,10}:  ");
   a[i]=int.Parse (Console.ReadLine());
   }
}
void ActionResult(int[]a)
{
int k=0;
for (int i=0;i<N;i++)
{
if (a[i]>0) k++;
}

System.Console.WriteLine(k);
}
