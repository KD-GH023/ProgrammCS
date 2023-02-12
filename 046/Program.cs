// 46.В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] a;
a=new int[123];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next();

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");//для наглядности массива
    System.Console.WriteLine();

int counter=0;
for(int i=10; i<=99; i++)
           counter++;
       
        System.Console.WriteLine(counter);

       